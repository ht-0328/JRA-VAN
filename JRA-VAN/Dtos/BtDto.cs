namespace JRA_VAN.Dtos;

/// <summary>
/// ２６．系統情報 (BT)
/// レコード長 6889 バイト
/// </summary>
public class BtDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "BT"をセットレコードフォーマットを特定する
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
    /// 繁殖登録番号 (12, 10)
    /// </summary>
    public string BreedingRegNum { get; set; } = string.Empty;

    /// <summary>
    /// 系統ID (22, 30)
    /// 2桁ごとに系譜を表現するID。詳しくは特記事項を参照
    /// </summary>
    public string LineageId { get; set; } = string.Empty;

    /// <summary>
    /// 系統名 (52, 36)
    /// "サンデーサイレンス"系など、その系統の名称
    /// </summary>
    public string LineageName { get; set; } = string.Empty;

    /// <summary>
    /// 系統説明 (88, 6800)
    /// テキスト文
    /// </summary>
    public string LineageDescription { get; set; } = string.Empty;
}
