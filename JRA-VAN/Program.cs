using System;
using System.Text;
using JRA_VAN.Dtos;
using JRA_VAN.Logic;

namespace JRA_VAN;

public static class Program
{
    public static void Main(string[] args)
    {
        // 文字化け対策
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var sjis = Encoding.GetEncoding("Shift_JIS");

        Console.WriteLine("データ取得と解読を開始します...");

        try
        {
            using (var client = new JraVanClient())
            {
                // 1. データ読み出し準備 (JVOpen)
                // JVOpenの第1引数は "RACE" のようなデータカテゴリを指定する
                // 第2引数は取得開始日時 (YYYYMMDDhhmmss)
                // 第3引数はオプション (通常1)
                // JRA-VAN JV-Link の仕様に従い、適切なパラメータで呼び出す
                // 戻り値として読み込み件数などが得られる

                int readCount;
                int downloadCount;
                string lastTimestamp;

                // JVOpen: データ種別ID="RACE", 開始日時="20230101000000", オプション=1 (通常読み込み)
                // ※ユーザーの要望により実際のAPI呼び出しを行う形にする
                client.Open("RACE", "20230101000000", 1, out readCount, out downloadCount, out lastTimestamp);

                Console.WriteLine($"JVOpen 成功: 読み込み予定件数={readCount}, ダウンロード={downloadCount}, Timestamp={lastTimestamp}");
                Console.WriteLine("--------------------------------------------------");

                while (true)
                {
                    // 2. データの読み込み (JVGets)
                    // バイト配列として取得される (nullなら終了)
                    byte[]? rawData = client.Read();
                    if (rawData == null)
                    {
                        break;
                    }

                    // バイト配列をShift_JIS文字列に変換
                    // TrimEndして末尾のゴミを除くことも考慮できるが、固定長パースは位置指定なのでそのまま渡すのが安全
                    string line = sjis.GetString(rawData);

                    // レコード種別 (先頭2文字) を確認
                    if (line.StartsWith("RA"))
                    {
                        // 3. パース処理 (RAレコードの場合)
                        try
                        {
                            RaDto dto = JraVanRecordParser.ParseRa(line);

                            // 結果を表示 (例: レース名などを出力)
                            Console.WriteLine($"[RA] {dto.Year}年{dto.MonthDay} {dto.RacetrackCode} {dto.RaceNum}R: {dto.RaceName.Trim()}");
                        }
                        catch (Exception parseEx)
                        {
                            Console.WriteLine($"Parse Error (RA): {parseEx.Message}");
                        }
                    }
                    else
                    {
                        // RA以外はスキップするか、必要に応じて処理
                        // Console.WriteLine($"Skipping record: {line.Substring(0, Math.Min(2, line.Length))}");
                    }
                }

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("【完了】正常に終了しました。");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"例外エラー: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }
    }
}
