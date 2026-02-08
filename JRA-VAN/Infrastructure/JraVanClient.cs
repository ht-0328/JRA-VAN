using JVDTLabLib;
using System;
using System.Collections.Generic;

namespace JRA_VAN.Infrastructure
{
    /// <summary>
    /// JV-Linkコンポーネントの操作をカプセル化するクライアントクラス。
    /// </summary>
    public class JraVanClient : IDisposable
    {
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

            // try-finallyブロックで確実にJVCloseが呼ばれるようにする
            try
            {
                byte[] buffer = new byte[102400]; // 標準的なバッファサイズ
                int buffSize = buffer.Length;
                string filename = "";

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
                    // 通常、JVLinkの仕様ではJVCloseはデータ読み出しセッションを閉じるもの。
                    // JVInit後のセッション終了処理はデストラクタ等に任せるか、明示的なCloseが必要か仕様による。
                    // ここでは念のため例外を無視してCloseを試みる。
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
