using JVDTLabLib;
using System;
using System.Linq;

namespace JRA_VAN.Logic;

public class JraVanClient : IDisposable
{
    private readonly JVLink _jvLink;
    private readonly byte[] _buffer;
    private bool _disposed;

    public JraVanClient()
    {
        _jvLink = new JVLink();
        _buffer = new byte[102400]; // バッファサイズ固定 (制約遵守)

        // 初期化
        // 戻り値が0以外はエラー
        if (_jvLink.JVInit("UNKNOWN") != 0)
        {
            throw new Exception("JVInit failed (JRA-VAN SDK Initialization Error).");
        }
    }

    /// <summary>
    /// JRA-VANデータの読み込みを開始します (JVOpenラッパー)
    /// </summary>
    public void Open(string dataSpec, string fromTime, int option, out int readCount, out int downloadCount, out string lastTimestamp)
    {
        // refパラメータの初期化
        readCount = 0;
        downloadCount = 0;
        lastTimestamp = "";

        int result = _jvLink.JVOpen(dataSpec, fromTime, option, ref readCount, ref downloadCount, out lastTimestamp);
        if (result != 0)
        {
            throw new Exception($"JVOpen failed. Return Code: {result}");
        }
    }

    /// <summary>
    /// データを1件読み込みます (JVGetsラッパー)
    /// </summary>
    /// <returns>読み込んだデータのバイト配列。読み込み完了はnull。エラーは例外。</returns>
    public byte[]? Read()
    {
        while (true)
        {
            // バッファをクリア (メモリ破損防止のため推奨)
            Array.Clear(_buffer, 0, _buffer.Length);

            // JVGetsの制約: ref object 型で渡す必要がある
            object buffObj = _buffer;
            string fName = "";

            // resultには読み込まれたバイト数が入る (0=EOF, -1=ファイル切替, -2=NoData, -3=InsufficientBuffer)
            int result = _jvLink.JVGets(ref buffObj, _buffer.Length, out fName);

            if (result == 0)
            {
                return null; // EOF
            }

            if (result == -1)
            {
                // ファイル切り替え: 次のデータを読むためにループ継続
                continue;
            }

            if (result < 0)
            {
                // エラー時
                // -2: データなし, -3: バッファ不足 (102400あるので通常起きないが)
                throw new Exception($"JVGets failed with error code: {result}");
            }

            // 成功した場合、buffObjにデータが入っている (キャストして返す)
            var rawData = (byte[])buffObj;

            // 読み込んだサイズ分だけ切り出して返す (指定されたため維持)
            return rawData.Take(result).ToArray();
        }
    }

    /// <summary>
    /// 接続を閉じます (JVCloseラッパー)
    /// </summary>
    public void Close()
    {
        if (!_disposed)
        {
            _jvLink.JVClose();
            _disposed = true;
        }
    }

    public void Dispose()
    {
        Close();
        GC.SuppressFinalize(this);
    }
}
