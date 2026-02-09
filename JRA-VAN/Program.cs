using System.Text;
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

        // "RACE" データスペックを指定して取得
        // 2026年1月1日以降のレース情報を取得
        client.Open("RACE", "20260101000000", 1, out readCount, out downloadCount, out lastTimestamp);

        Console.WriteLine($"読み込み準備完了！ 対象件数: {readCount}件");
        Console.WriteLine("--------------------------------------------------");

        var races = new Dictionary<string, Race>();
        var sjis = Encoding.GetEncoding("Shift_JIS");

        while (true)
        {
            // 2. データの読み込み (JVGets)
            byte[]? data = client.Read();

            if (data == null) break; // 読み込み終了

            // レコード種別の判別 (先頭2バイト)
            string recordSpec = sjis.GetString(data, 0, 2);

            if (recordSpec == "RA")
            {
                try
                {
                    Race race = RaParser.Parse(data);
                    // キー: Date + Place + Kai + Nichi + Num (RaceIdプロパティと同じ)
                    if (!races.ContainsKey(race.RaceId))
                    {
                        races[race.RaceId] = race;
                        // Console.WriteLine($"RAレコード解析: {race.RaceName}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"RAパースエラー: {ex.Message}");
                }
            }
            else if (recordSpec == "SE")
            {
                try
                {
                    string raceId = SeParser.GetRaceId(data);

                    if (races.TryGetValue(raceId, out var race))
                    {
                        RaceHorse horse = SeParser.Parse(data);
                        race.Horses.Add(horse);
                        // Console.WriteLine($"  -> SEレコード結合: {horse.HorseName}");
                    }
                    else
                    {
                        // RAレコードが見つからない場合はスキップ (通常はRAが先に来る)
                        // Console.WriteLine($"警告: 対応するRAレコードが見つかりません (ID: {raceId})");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"SEパースエラー: {ex.Message}");
                }
            }
            // その他のレコード(H1など)は今回は無視
        }

        // 3. 結果の表示
        Console.WriteLine($"\n【解析結果】 {races.Count} レース分のデータを結合しました。\n");

        foreach (var race in races.Values)
        {
            Console.WriteLine(race.ToString());
            foreach (var horse in race.Horses)
            {
                Console.WriteLine($"  - {horse}");
            }
            Console.WriteLine(new string('-', 50));
        }

        Console.WriteLine("【完了】正常に終了しました。");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"例外エラー: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}
