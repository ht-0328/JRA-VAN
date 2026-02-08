using JVDTLabLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JRA_VAN.Infrastructure
{
    /// <summary>
    /// JV-Linkコンポーネントの操作をカプセル化するクライアントクラス。
    /// </summary>
    public class JraVanClient : IDisposable
    {
        // JV-Link仕様に基づくバッファサイズ (100KB)
        private const int BufferSize = 102400;

        private readonly JVLink _jvLink;
        private readonly JvRecordMapper _mapper;
        private bool _disposed;

        public JraVanClient()
        {
            _jvLink = new JVLink();
            _mapper = new JvRecordMapper();
        }

        /// <summary>
        /// JV-Linkコンポーネントを初期化します。
        /// </summary>
        /// <param name="sid">サービスID (通常は "UNKNOWN" または特定のID)</param>
        public void Initialize(string sid)
        {
            int result = _jvLink.JVInit(sid);
            if (result != 0)
            {
                throw new JraVanException($"JVInit failed with return code: {result}");
            }
        }

        /// <summary>
        /// 指定された条件に一致するレコードを取得します。
        /// JVOpen, JVGets, JVClose の呼び出しフローを自動化します。
        /// T型に JvRecordSpecAttribute が付与されている場合、対応するレコードIDでフィルタリングします。
        /// </summary>
        /// <typeparam name="T">マッピング対象のレコード型</typeparam>
        /// <param name="dataSpec">データ種別 (例: "RACE")</param>
        /// <param name="key">データ取得キー (例: "20260101000000")</param>
        /// <param name="option">オプション値 (例: 1)</param>
        /// <returns>マッピングされたレコードの列挙子</returns>
        public IEnumerable<T> GetRecords<T>(string dataSpec, string key, int option) where T : new()
        {
            int readCount = 0;
            int downloadCount = 0;
            string lastTimestamp = "";

            int openResult = _jvLink.JVOpen(dataSpec, key, option, ref readCount, ref downloadCount, out lastTimestamp);
            if (openResult != 0)
            {
                throw new JraVanException($"JVOpen failed with return code: {openResult}");
            }

            // マッピング対象のレコードIDを取得
            string? targetRecordId = null;
            var recordSpecAttr = typeof(T).GetCustomAttribute<JvRecordSpecAttribute>();
            if (recordSpecAttr != null)
            {
                targetRecordId = recordSpecAttr.RecordId;
            }

            // try-finallyブロックで確実にJVCloseが呼ばれるようにする
            try
            {
                // 仕様に従い、十分なバッファサイズを確保する
                byte[] buffer = new byte[BufferSize];
                int buffSize = BufferSize;
                string filename = "";

                // レコードIDチェック用のエンコーディング (ASCII/Shift-JIS共通の範囲)
                var encoding = Encoding.GetEncoding("Shift_JIS");

                while (true)
                {
                    object buffObj = buffer;
                    int readResult = _jvLink.JVGets(ref buffObj, buffSize, out filename);

                    if (readResult == 0) break; // 読み込み完了
                    if (readResult < 0)
                    {
                         // 負の値はエラーとして扱う
                         throw new JraVanException($"JVGets failed with return code: {readResult}");
                    }

                    // readResult は読み込まれたバイト数
                    // 有効なデータ範囲を切り出す
                    byte[] recordBytes = new byte[readResult];
                    Array.Copy((byte[])buffObj, recordBytes, readResult);

                    // レコードIDによるフィルタリング
                    if (!string.IsNullOrEmpty(targetRecordId))
                    {
                        // 通常、レコードIDは先頭2バイト
                        if (recordBytes.Length >= 2)
                        {
                            string recordId = encoding.GetString(recordBytes, 0, 2);
                            if (recordId != targetRecordId)
                            {
                                // 対象外のレコードなのでスキップ
                                Array.Clear(buffer, 0, buffer.Length);
                                continue;
                            }
                        }
                    }

                    yield return _mapper.Map<T>(recordBytes);

                    // 次の読み込みのためにバッファをクリア
                    Array.Clear(buffer, 0, buffer.Length);
                }
            }
            finally
            {
                _jvLink.JVClose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // JVCloseを呼び出す必要があるか確認
                    try
                    {
                        _jvLink.JVClose();
                    }
                    catch
                    {
                        // 破棄時のエラーは無視
                    }
                }
                _disposed = true;
            }
        }
    }

    /// <summary>
    /// JRA-VAN操作に関連するカスタム例外クラス
    /// </summary>
    public class JraVanException : Exception
    {
        public JraVanException(string message) : base(message) { }
    }
}
