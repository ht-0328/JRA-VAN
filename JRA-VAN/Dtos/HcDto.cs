namespace JRA_VAN.Dtos;

/// <summary>
/// ２２．坂路調教 (HC)
/// レコード長 60 バイト
/// </summary>
public class HcDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "HC" をセットレコードフォーマットを特定する
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
    /// 4ハロンタイム合計(800M～0M) (35, 4)
    /// 単位:0.1秒　測定不良時は 0000 をセット
    /// </summary>
    public int FurlongTime4 { get; set; }

    /// <summary>
    /// ラップタイム(800M～600M) (39, 3)
    /// 単位:0.1秒　測定不良時は 000 をセット
    /// </summary>
    public int LapTime4 { get; set; }

    /// <summary>
    /// 3ハロンタイム合計(600M～0M) (42, 4)
    /// 単位:0.1秒　測定不良時は 0000 をセット
    /// </summary>
    public int FurlongTime3 { get; set; }

    /// <summary>
    /// ラップタイム(600M～400M) (46, 3)
    /// 単位:0.1秒　測定不良時は 000 をセット
    /// </summary>
    public int LapTime3 { get; set; }

    /// <summary>
    /// 2ハロンタイム合計(400M～0M) (49, 4)
    /// 単位:0.1秒　測定不良時は 0000 をセット
    /// </summary>
    public int FurlongTime2 { get; set; }

    /// <summary>
    /// ラップタイム(400M～200M) (53, 3)
    /// 単位:0.1秒　測定不良時は 000 をセット
    /// </summary>
    public int LapTime2 { get; set; }

    /// <summary>
    /// ラップタイム(200M～0M) (56, 3)
    /// 単位:0.1秒　測定不良時は 000 をセット
    /// </summary>
    public int LapTime1 { get; set; }
}
