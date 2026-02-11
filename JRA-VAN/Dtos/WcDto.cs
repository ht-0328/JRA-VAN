namespace JRA_VAN.Dtos;

/// <summary>
/// ３２．ウッドチップ調教 (WC)
/// レコード長 105 バイト
/// </summary>
public class WcDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "WC" をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:初期値　0:該当レコード削除(提供ミスなどの理由による)
    /// </summary>
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// トレセン区分 (12, 1)
    /// 0:美浦　1:栗東
    /// </summary>
    public string TrainingCenterCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教年月日 (13, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string TrainingDate { get; set; } = string.Empty;

    /// <summary>
    /// 調教時刻 (21, 4)
    /// 時分各2桁
    /// </summary>
    public string TrainingTime { get; set; } = string.Empty;

    /// <summary>
    /// 血統登録番号 (25, 10)
    /// 生年(西暦)4桁＋品種1桁＋数字5桁
    /// </summary>
    public string BloodlineNum { get; set; } = string.Empty;

    /// <summary>
    /// コース (35, 1)
    /// 0：A、1：B、2：C、3：D、4：E
    /// </summary>
    public string CourseCode { get; set; } = string.Empty;

    /// <summary>
    /// 馬場周り (36, 1)
    /// 0：右、1：左
    /// </summary>
    public string TrackDirection { get; set; } = string.Empty;

    /// <summary>
    /// 予備 (37, 1)
    /// </summary>
    public string Reserve1 { get; set; } = string.Empty;

    /// <summary>
    /// 10ハロンタイム合計(2000M～0M) (38, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime10 { get; set; }

    /// <summary>
    /// ラップタイム(2000M～1800M) (42, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime10 { get; set; }

    /// <summary>
    /// 9ハロンタイム合計(1800M～0M) (45, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime9 { get; set; }

    /// <summary>
    /// ラップタイム(1800M～1600M) (49, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime9 { get; set; }

    /// <summary>
    /// 8ハロンタイム合計(1600M～0M) (52, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime8 { get; set; }

    /// <summary>
    /// ラップタイム(1600M～1400M) (56, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime8 { get; set; }

    /// <summary>
    /// 7ハロンタイム合計(1400M～0M) (59, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime7 { get; set; }

    /// <summary>
    /// ラップタイム(1400M～1200M) (63, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime7 { get; set; }

    /// <summary>
    /// 6ハロンタイム合計(1200M～0M) (66, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime6 { get; set; }

    /// <summary>
    /// ラップタイム(1200M～1000M) (70, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime6 { get; set; }

    /// <summary>
    /// 5ハロンタイム合計(1000M～0M) (73, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime5 { get; set; }

    /// <summary>
    /// ラップタイム(1000M～800M) (77, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime5 { get; set; }

    /// <summary>
    /// 4ハロンタイム合計(800M～0M) (80, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime4 { get; set; }

    /// <summary>
    /// ラップタイム(800M～600M) (84, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime4 { get; set; }

    /// <summary>
    /// 3ハロンタイム合計(600M～0M) (87, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime3 { get; set; }

    /// <summary>
    /// ラップタイム(600M～400M) (91, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime3 { get; set; }

    /// <summary>
    /// 2ハロンタイム合計(400M～0M) (94, 4)
    /// 単位:0.1秒　測定不良時は 0000 999.9秒以上は 9999 をセット
    /// </summary>
    public int FurlongTime2 { get; set; }

    /// <summary>
    /// ラップタイム(400M～200M) (98, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime2 { get; set; }

    /// <summary>
    /// ラップタイム(200M～0M) (101, 3)
    /// 単位:0.1秒　測定不良時は 000 99.9秒以上は 999 をセット
    /// </summary>
    public int LapTime1 { get; set; }
}
