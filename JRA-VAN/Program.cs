using JRA_VAN.Infrastructure;
using JRA_VAN.Models;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Shift-JISエンコーディングを利用可能にする
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        // COMコンポーネントなしでロジックをテストするための検証モード
        if (args.Length > 0 && args[0] == "verify")
        {
            VerifyMapper();
            return;
        }

        Console.WriteLine("データ取得と解析を開始します...");

        try
        {
            // 注意: JVDTLabLib COMが登録されていない環境（例: Linux CI）では例外が発生します
            using (var client = new JraVanClient())
            {
                // 1. 初期化
                client.Initialize("UNKNOWN");

                // 2. データ取得
                // 注意: JVOpenの第一引数はデータ種別（"RACE"）を指定する必要があります。
                // "RA" などのレコードIDを直接指定するとエラー (-111) になります。
                string dataSpec = "RACE"; // データ種別: レース情報 (RA, SE, UM などが含まれる)
                string key = "20240101000000";
                int option = 1; // 通常読み込み

                Console.WriteLine($"{key} 以降の {dataSpec} データから SE レコード（馬毎レース情報）を取得中...");

                // JraVanClient内部で SeRecord の [JvRecordSpec("SE")] 属性を見てフィルタリングします
                var records = client.GetRecords<SeRecord>(dataSpec, key, option);
                int count = 0;

                foreach (var record in records)
                {
                    Console.WriteLine(record.ToString());
                    count++;
                }

                Console.WriteLine($"--------------------------------------------------");
                Console.WriteLine($"処理済みレコード総数: {count}");
            }
        }
        catch (JraVanException ex)
        {
            Console.WriteLine($"[JRA-VAN エラー] {ex.Message}");
        }
        catch (TypeInitializationException ex)
        {
            Console.WriteLine($"[COM エラー] COMコンポーネントを初期化できませんでした。Windows環境かつJV-Linkがインストールされている必要があります。");
            Console.WriteLine($"詳細: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[エラー] {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }

        Console.WriteLine("終了するには何かキーを押してください...");
        // Console.ReadKey(); // 非対話環境のためにコメントアウト
    }

    /// <summary>
    /// COMコンポーネントを使用せずにマッピングロジックを検証します。
    /// </summary>
    static void VerifyMapper()
    {
        Console.WriteLine("マッパー検証を実行中...");

        try
        {
            // レコードを模したダミーのバイト配列を作成
            // 最大オフセット+長さ (37+36=73) を収容できるサイズ
            byte[] data = new byte[100];
            Encoding sjis = Encoding.GetEncoding("Shift_JIS");

            // 指定したオフセットに文字列を書き込むヘルパー関数
            void Write(int offset, string value)
            {
                byte[] b = sjis.GetBytes(value);
                Array.Copy(b, 0, data, offset, b.Length);
            }

            // RecordID (先頭2バイト) をセット (SE: 馬毎レース情報)
            Write(0, "SE");

            // SeRecordの仕様に従ってデータを埋める
            // 開催年月日: 11, 8
            Write(11, "20240526");
            // レース番号: 25, 2
            Write(25, "11"); // 11R
            // 馬名: 37, 36
            Write(37, "ダノンデサイル"); // 日本ダービー馬

            // マッピングのテスト
            var mapper = new JvRecordMapper();
            var record = mapper.Map<SeRecord>(data);

            Console.WriteLine($"マップ結果: {record}");

            // 検証 (アサーション)
            if (record.RaceDate != "20240526") throw new Exception($"開催年月日の不一致: {record.RaceDate}");
            if (record.RaceNumber != "11") throw new Exception($"レース番号の不一致: {record.RaceNumber}");
            if (record.HorseName != "ダノンデサイル") throw new Exception($"馬名の不一致: {record.HorseName}");

            Console.WriteLine("検証成功！");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"検証失敗: {ex.Message}");
            Environment.Exit(1);
        }
    }
}
