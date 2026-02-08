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
                // 例: 特定の開始時点から速報レース情報 (RA) を取得
                string targetSpec = "RA";
                string key = "20240101000000";
                int option = 1; // 通常読み込み

                Console.WriteLine($"{key} 以降の {targetSpec} レコードを取得中...");

                var records = client.GetRecords<RaRecord>(targetSpec, key, option);
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
            // 最大オフセット+長さ (33+60=93) を収容できるサイズ
            byte[] data = new byte[100];
            Encoding sjis = Encoding.GetEncoding("Shift_JIS");

            // 指定したオフセットに文字列を書き込むヘルパー関数
            void Write(int offset, string value)
            {
                byte[] b = sjis.GetBytes(value);
                Array.Copy(b, 0, data, offset, b.Length);
            }

            // RaRecordの仕様に従ってデータを埋める
            // 年: 11, 4
            Write(11, "2024");
            // 月日: 15, 4
            Write(15, "0526"); // 5月26日
            // 競馬場コード: 19, 2
            Write(19, "05"); // 東京?
            // レース番号: 25, 2
            Write(25, "11"); // 11R
            // レース名: 33, 60
            Write(33, "日本ダービー (G1)");

            // マッピングのテスト
            var mapper = new JvRecordMapper();
            var record = mapper.Map<RaRecord>(data);

            Console.WriteLine($"マップ結果: {record}");

            // 検証 (アサーション)
            if (record.Year != "2024") throw new Exception($"年の不一致: {record.Year}");
            if (record.MonthDay != "0526") throw new Exception($"月日の不一致: {record.MonthDay}");
            if (record.CourseCode != "05") throw new Exception($"競馬場コードの不一致: {record.CourseCode}");
            if (record.RaceNumber != "11") throw new Exception($"レース番号の不一致: {record.RaceNumber}");
            // Shift-JISの日本語文字列が正しく扱えるかもチェック
            if (record.RaceName != "日本ダービー (G1)") throw new Exception($"レース名の不一致: {record.RaceName}");

            Console.WriteLine("検証成功！");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"検証失敗: {ex.Message}");
            Environment.Exit(1);
        }
    }
}
