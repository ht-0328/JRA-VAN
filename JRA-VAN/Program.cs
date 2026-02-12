using System.Text;
using JRA_VAN.Dtos;
using JRA_VAN.Logic;
using JRA_VAN.Models;

// 文字化け対策
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

Console.WriteLine("データ取得と解読を開始します...");

try
{
    using (var client = new JraVanClient())
    {
        // 1. データ読み出し準備 (JVOpen)
        int readCount;
        int downloadCount;
        string lastTimestamp;

        // オプション1 (通常読み込み)
        // ※ JG1データ（除外・発走除外・競走中止などの馬情報）を取得します
        client.Open("RACE", "20260101000000", 1, out readCount, out downloadCount, out lastTimestamp);

        Console.WriteLine($"読み込み準備完了！ 対象件数: {readCount}件（ファイル数）");
        Console.WriteLine("--------------------------------------------------");

        var sjis = Encoding.GetEncoding("Shift_JIS");

        for (int i = 0; i < readCount; i++)
        {
            // 2. データの読み込み (JVRead)
            byte[]? fileData = client.ReadFile();

            if (fileData == null) continue;

            // 3. データを文字列化して行単位で処理
            string content = sjis.GetString(fileData);
            // 改行で分割 (CRLF, LF対応)
            string[] lines = content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                // RAレコードのみ対象
                if (line.StartsWith("RA"))
                {
                    // パース処理のためにバイト配列に戻す
                    // ※JraVanRecordParserはバイト配列を期待するため
                    byte[] lineBytes = sjis.GetBytes(line);

                    try
                    {
                        // 4. パース処理
                        RaDto dto = JraVanRecordParser.Parse<RaDto>(lineBytes);

                        // 画面にきれいに表示
                        Console.WriteLine($"開催日: {dto.DataCreationDate} | {dto.RaceNum}R | レース名: {dto.RaceName}");
                        if (dto.PrizeMoney.Count > 0)
                        {
                            Console.WriteLine($"  1着賞金: {dto.PrizeMoney[0]}百円");
                        }
                    }
                    catch (Exception)
                    {
                        // パースエラーはスキップ（不正なデータや短い行など）
                    }
                }
            }
        }

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("【完了】正常に終了しました。");
        // usingブロックを抜ける際にDisposeが呼ばれ、JVCloseが実行されます
    }
}
catch (Exception ex)
{
    Console.WriteLine($"例外エラー: {ex.Message}");
}
