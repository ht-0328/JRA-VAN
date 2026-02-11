using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2203.毛色コード
/// </summary>
public enum HorseColorCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 栗毛
    /// </summary>
    [Description("栗毛")]
    Chestnut,

    /// <summary>
    /// 栃栗毛
    /// </summary>
    [Description("栃栗毛")]
    DarkChestnut,

    /// <summary>
    /// 鹿毛
    /// </summary>
    [Description("鹿毛")]
    Bay,

    /// <summary>
    /// 黒鹿毛
    /// </summary>
    [Description("黒鹿毛")]
    DarkBay,

    /// <summary>
    /// 青鹿毛
    /// </summary>
    [Description("青鹿毛")]
    Brown,

    /// <summary>
    /// 青毛
    /// </summary>
    [Description("青毛")]
    Black,

    /// <summary>
    /// 芦毛
    /// </summary>
    [Description("芦毛")]
    Grey,

    /// <summary>
    /// 栗粕毛
    /// </summary>
    [Description("栗粕毛")]
    Code08,

    /// <summary>
    /// 鹿粕毛
    /// </summary>
    [Description("鹿粕毛")]
    Code09,

    /// <summary>
    /// 青粕毛
    /// </summary>
    [Description("青粕毛")]
    Code10,

    /// <summary>
    /// 白毛
    /// </summary>
    [Description("白毛")]
    White,

}

/// <summary>
/// 毛色コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="EnglishAbbr">欧字略名</param>
public record HorseColorInfo(
    string Code,
    string Name,
    string EnglishName,
    string EnglishAbbr
);

/// <summary>
/// 毛色コード拡張メソッド
/// </summary>
public static class HorseColorCodeExtensions
{
    /// <summary>
    /// 毛色コード情報を取得します
    /// </summary>
    public static HorseColorInfo GetInfo(this HorseColorCode code)
    {
        return code switch
        {
            HorseColorCode.None => new HorseColorInfo(
                "00",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            HorseColorCode.Chestnut => new HorseColorInfo(
                "01",
                "栗毛",
                "chestnut",
                "ch."),
            HorseColorCode.DarkChestnut => new HorseColorInfo(
                "02",
                "栃栗毛",
                "dark chestnut",
                "d. ch."),
            HorseColorCode.Bay => new HorseColorInfo(
                "03",
                "鹿毛",
                "bay",
                "b."),
            HorseColorCode.DarkBay => new HorseColorInfo(
                "04",
                "黒鹿毛",
                "dark bay",
                "d. b."),
            HorseColorCode.Brown => new HorseColorInfo(
                "05",
                "青鹿毛",
                "brown",
                "br."),
            HorseColorCode.Black => new HorseColorInfo(
                "06",
                "青毛",
                "black",
                "bl."),
            HorseColorCode.Grey => new HorseColorInfo(
                "07",
                "芦毛",
                "grey",
                "g."),
            HorseColorCode.Code08 => new HorseColorInfo(
                "08",
                "栗粕毛",
                "",
                ""),
            HorseColorCode.Code09 => new HorseColorInfo(
                "09",
                "鹿粕毛",
                "",
                ""),
            HorseColorCode.Code10 => new HorseColorInfo(
                "10",
                "青粕毛",
                "",
                ""),
            HorseColorCode.White => new HorseColorInfo(
                "11",
                "白毛",
                "white",
                "w."),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
