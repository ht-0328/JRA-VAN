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

        Console.WriteLine($"読み込み準備完了！ 対象件数: {readCount}件");
        Console.WriteLine("--------------------------------------------------");

        while (true)
        {
            // 2. データの読み込み (JVGets)
            byte[]? data = client.Read();

            if (data == null) break; // 読み込み終了またはエラー

            // 3. パース処理 (分離されたロジック) - ジェネリックパーサーを利用
            RaDto dto = JraVanRecordParser.Parse<RaDto>(data);

            // 画面にきれいに表示
            Console.WriteLine($"開催日: {dto.DataCreationDate} | {dto.RaceNum}R | レース名: {dto.RaceName}");
            if (dto.PrizeMoney.Count > 0)
            {
                Console.WriteLine($"  1着賞金: {dto.PrizeMoney[0]}百円");
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
