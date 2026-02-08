using JVDTLabLib;
using System.Text;

// 文字化け対策
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

Console.WriteLine("データ取得と解読を開始します...");

try
{
    JVLink jv = new JVLink();

    // 1. 初期化
    if (jv.JVInit("UNKNOWN") != 0)
    {
        Console.WriteLine("初期化エラー");
        return;
    }

    // 2. データの読み出し開始
    int readCount = 0;
    int downloadCount = 0;
    string lastTimestamp = "";

    // オプション1 (通常読み込み)
    // ※ JG1データ（除外・発走除外・競走中止などの馬情報）を取得します
    int openResult = jv.JVOpen("RACE", "20260101000000", 1, ref readCount, ref downloadCount, out lastTimestamp);

    if (openResult == 0)
    {
        Console.WriteLine($"読み込み準備完了！ 対象件数: {readCount}件");
        Console.WriteLine("--------------------------------------------------");

        // バイト配列を用意（メモリ破損防止のため必須）
        byte[] byteBuffer = new byte[102400];
        int buffSize = byteBuffer.Length;
        string fName = "";

        // Shift-JISエンコーディングの準備
        Encoding sjis = Encoding.GetEncoding("Shift_JIS");

        while (true)
        {
            // JVGetsには object型 として渡す
            object buffObj = byteBuffer;

            // データの読み込み
            int readResult = jv.JVGets(ref buffObj, buffSize, out fName);

            if (readResult == 0) break; // 完了
            if (readResult == -1) break; // エラー

            // object型に入っているバイト配列を取り出す
            byte[] rawBytes = (byte[])buffObj;

            // --- ここから解読処理 (JG1レコードの仕様に合わせて切り抜く) ---

            // 1. 開催日 (11バイト目から8文字)
            string raceDate = sjis.GetString(rawBytes, 11, 8);

            // 2. レース番号 (25バイト目から2文字) 
            // ※仕様書上の位置は25バイト目
            string raceNum = sjis.GetString(rawBytes, 25, 2);

            // 3. 馬名 (37バイト目から36文字分)
            string horseName = sjis.GetString(rawBytes, 37, 36).Trim();

            // 画面にきれいに表示
            Console.WriteLine($"開催日: {raceDate} | {raceNum}R | 馬名: {horseName}");

            // --- 解読ここまで ---

            // 次のループのために配列をクリア
            Array.Clear(byteBuffer, 0, byteBuffer.Length);
        }

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("【完了】正常に終了しました。");
        jv.JVClose();
    }
    else
    {
        Console.WriteLine($"JVOpenエラー: {openResult}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"例外エラー: {ex.Message}");
}