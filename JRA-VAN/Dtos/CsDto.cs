namespace JRA_VAN.Dtos;

/// <summary>
/// ２７．コース情報 (CS)
/// レコード長 6829 バイト
/// </summary>
public class CsDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "CS"をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:新規登録 2:更新 0:該当レコード削除(提供ミスなどの理由による)
    /// </summary>
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// 競馬場コード (12, 2)
    /// &lt;コード表 2001.競馬場コード&gt;参照
    /// </summary>
    public string RacetrackCode { get; set; } = string.Empty;

    /// <summary>
    /// 距離 (14, 4)
    /// 単位：メートル
    /// </summary>
    public int Distance { get; set; }

    /// <summary>
    /// トラックコード (18, 2)
    /// &lt;コード表 2009.トラックコード&gt;参照
    /// </summary>
    public string TrackCode { get; set; } = string.Empty;

    /// <summary>
    /// コース改修年月日 (20, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式　(コース改修後、最初に行われた開催日）
    /// </summary>
    public string CourseModificationDate { get; set; } = string.Empty;

    /// <summary>
    /// コース説明 (28, 6800)
    /// テキスト文
    /// </summary>
    public string CourseDescription { get; set; } = string.Empty;
}
