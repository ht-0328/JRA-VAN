using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2003.グレードコード
/// </summary>
public enum GradeCode
{
    /// <summary>
    /// G1（平地競走）
    /// </summary>
    [Description("G1（平地競走）")]
    G1,

    /// <summary>
    /// G2（平地競走）
    /// </summary>
    [Description("G2（平地競走）")]
    G2,

    /// <summary>
    /// G3（平地競走）
    /// </summary>
    [Description("G3（平地競走）")]
    G3,

    /// <summary>
    /// グレードのない重賞
    /// </summary>
    [Description("グレードのない重賞")]
    NonGradedGroupRace,

    /// <summary>
    /// 重賞以外の特別競走
    /// </summary>
    [Description("重賞以外の特別競走")]
    SpecialRace,

    /// <summary>
    /// J･G1（障害競走）
    /// </summary>
    [Description("J･G1（障害競走）")]
    JG1,

    /// <summary>
    /// J･G2（障害競走）
    /// </summary>
    [Description("J･G2（障害競走）")]
    JG2,

    /// <summary>
    /// J･G3（障害競走）
    /// </summary>
    [Description("J･G3（障害競走）")]
    JG3,

    /// <summary>
    /// L（リステッド）
    /// </summary>
    [Description("L（リステッド）")]
    Listed,

    /// <summary>
    /// 一般競走　または未設定・未整備時の初期値（主に地方競馬・海外国際レースに関するデータ）
    /// </summary>
    [Description("一般競走　または未設定・未整備時の初期値（主に地方競馬・海外国際レースに関するデータ）")]
    GeneralOrUnset,

}

/// <summary>
/// グレードコード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">内容</param>
public record GradeInfo(
    string Code,
    string Name
);

/// <summary>
/// グレードコード拡張メソッド
/// </summary>
public static class GradeCodeExtensions
{
    /// <summary>
    /// グレードコード情報を取得します
    /// </summary>
    public static GradeInfo GetInfo(this GradeCode code)
    {
        return code switch
        {
            GradeCode.G1 => new GradeInfo(
                "A",
                "G1（平地競走）"),
            GradeCode.G2 => new GradeInfo(
                "B",
                "G2（平地競走）"),
            GradeCode.G3 => new GradeInfo(
                "C",
                "G3（平地競走）"),
            GradeCode.NonGradedGroupRace => new GradeInfo(
                "D",
                "グレードのない重賞"),
            GradeCode.SpecialRace => new GradeInfo(
                "E",
                "重賞以外の特別競走"),
            GradeCode.JG1 => new GradeInfo(
                "F",
                "J･G1（障害競走）"),
            GradeCode.JG2 => new GradeInfo(
                "G",
                "J･G2（障害競走）"),
            GradeCode.JG3 => new GradeInfo(
                "H",
                "J･G3（障害競走）"),
            GradeCode.Listed => new GradeInfo(
                "L",
                "L（リステッド）"),
            GradeCode.GeneralOrUnset => new GradeInfo(
                "_",
                "一般競走　または未設定・未整備時の初期値（主に地方競馬・海外国際レースに関するデータ）"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
