using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2301.東西所属コード
/// </summary>
public enum AffiliationCode
{
    /// <summary>
    /// 下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ) ()
    /// </summary>
    [Description("下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 関東 (美浦)
    /// </summary>
    [Description("関東")]
    Miho,

    /// <summary>
    /// 関西 (栗東)
    /// </summary>
    [Description("関西")]
    Ritto,

    /// <summary>
    /// 地方招待 (招待)
    /// </summary>
    [Description("地方招待")]
    RegionalInvited,

    /// <summary>
    /// 外国招待 (招待)
    /// </summary>
    [Description("外国招待")]
    ForeignInvited,

}

/// <summary>
/// 東西所属コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name1">名称１</param>
/// <param name="Name2">名称２</param>
/// <param name="Description">説明</param>
public record AffiliationInfo(
    string Code,
    string Name1,
    string Name2,
    string Description
);

/// <summary>
/// 東西所属コード拡張メソッド
/// </summary>
public static class AffiliationCodeExtensions
{
    /// <summary>
    /// 東西所属コード情報を取得します
    /// </summary>
    public static AffiliationInfo GetInfo(this AffiliationCode code)
    {
        return code switch
        {
            AffiliationCode.None => new AffiliationInfo(
                "0",
                "下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            AffiliationCode.Miho => new AffiliationInfo(
                "1",
                "関東",
                "美浦",
                "美浦トレーニングセンターに所属する。"),
            AffiliationCode.Ritto => new AffiliationInfo(
                "2",
                "関西",
                "栗東",
                "栗東トレーニングセンターに所属する。"),
            AffiliationCode.RegionalInvited => new AffiliationInfo(
                "3",
                "地方招待",
                "招待",
                "地方からの招待"),
            AffiliationCode.ForeignInvited => new AffiliationInfo(
                "4",
                "外国招待",
                "招待",
                "外国からの招待"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
