using JVDTLabLib;

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
    /// <returns>読み込んだデータのバイト配列。読み込み完了またはエラーの場合はnull。</returns>
    public byte[]? Read()
    {
        // バッファをクリア (メモリ破損防止のため推奨)
        Array.Clear(_buffer, 0, _buffer.Length);

        // JVGetsの制約: ref object 型で渡す必要がある
        object buffObj = _buffer;
        string fName = "";

        int result = _jvLink.JVGets(ref buffObj, _buffer.Length, out fName);

        // 0: 完了(EOF), -1: エラー -> どちらも読み込み終了とみなす
        if (result == 0 || result == -1)
        {
            return null;
        }

        // 成功した場合、buffObjにデータが入っている (キャストして返す)
        return (byte[])buffObj;
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
