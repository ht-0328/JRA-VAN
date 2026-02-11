namespace JRA_VAN.Dtos;

/// <summary>
/// １０２．天候馬場状態 (WE)
/// レコード長 42 バイト
/// </summary>
public class WeDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "WE" をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:初期値
    /// </summary>
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// 開催年 (12, 4)
    /// 該当レース施行年 西暦4桁 yyyy形式
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 開催月日 (16, 4)
    /// 該当レース施行月日 各2桁 mmdd形式
    /// </summary>
    public string MonthDay { get; set; } = string.Empty;

    /// <summary>
    /// 競馬場コード (20, 2)
    /// 該当レース施行競馬場 &lt;コード表 2001.競馬場コード&gt;参照
    /// </summary>
    public string RacetrackCode { get; set; } = string.Empty;

    /// <summary>
    /// 開催回[第N回] (22, 2)
    /// 該当レース施行回 その競馬場でその年の何回目の開催かを示す
    /// </summary>
    public int MeetingNum { get; set; }

    /// <summary>
    /// 開催日目[N日目] (24, 2)
    /// 該当レース施行日目 そのレース施行回で何日目の開催かを示す
    /// </summary>
    public int DayNum { get; set; }

    /// <summary>
    /// 発表月日時分 (26, 8)
    /// 月日時分各2桁
    /// </summary>
    public string AnnouncementTime { get; set; } = string.Empty;

    /// <summary>
    /// 変更識別 (34, 1)
    /// 1:天候馬場初期状態　2:天候変更　3:馬場状態変更
    /// </summary>
    public string ChangeIdentifier { get; set; } = string.Empty;

    /// <summary>
    /// 現在・天候状態 (35, 1)
    /// &lt;コード表 2011.天候コード&gt;参照
    /// </summary>
    public string CurrentWeatherCode { get; set; } = string.Empty;

    /// <summary>
    /// 現在・馬場状態・芝 (36, 1)
    /// &lt;コード表 2010.馬場状態コード&gt;参照
    /// </summary>
    public string CurrentTurfConditionCode { get; set; } = string.Empty;

    /// <summary>
    /// 現在・馬場状態・ダート (37, 1)
    /// &lt;コード表 2010.馬場状態コード&gt;参照
    /// </summary>
    public string CurrentDirtConditionCode { get; set; } = string.Empty;

    /// <summary>
    /// 変更前・天候状態 (38, 1)
    /// &lt;コード表 2011.天候コード&gt;参照
    /// </summary>
    public string OldWeatherCode { get; set; } = string.Empty;

    /// <summary>
    /// 変更前・馬場状態・芝 (39, 1)
    /// &lt;コード表 2010.馬場状態コード&gt;参照
    /// </summary>
    public string OldTurfConditionCode { get; set; } = string.Empty;

    /// <summary>
    /// 変更前・馬場状態・ダート (40, 1)
    /// &lt;コード表 2010.馬場状態コード&gt;参照
    /// </summary>
    public string OldDirtConditionCode { get; set; } = string.Empty;
}
