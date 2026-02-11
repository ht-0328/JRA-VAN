using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2102.着差コード
/// </summary>
public enum MarginCode
{
    /// <summary>
    /// 未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 1/2馬身
    /// </summary>
    [Description("1/2馬身")]
    HalfLength,

    /// <summary>
    /// 3/4馬身
    /// </summary>
    [Description("3/4馬身")]
    ThreeQuartersLength,

    /// <summary>
    /// 1馬身
    /// </summary>
    [Description("1馬身")]
    OneLength,

    /// <summary>
    /// 1 1/2馬身
    /// </summary>
    [Description("1 1/2馬身")]
    OneAndHalfLengths,

    /// <summary>
    /// 1 1/4馬身
    /// </summary>
    [Description("1 1/4馬身")]
    OneAndQuarterLengths,

    /// <summary>
    /// 1 3/4馬身
    /// </summary>
    [Description("1 3/4馬身")]
    OneAndThreeQuartersLengths,

    /// <summary>
    /// 2馬身
    /// </summary>
    [Description("2馬身")]
    TwoLengths,

    /// <summary>
    /// 2 1/2馬身
    /// </summary>
    [Description("2 1/2馬身")]
    TwoAndHalfLengths,

    /// <summary>
    /// 3馬身
    /// </summary>
    [Description("3馬身")]
    ThreeLengths,

    /// <summary>
    /// 3 1/2馬身
    /// </summary>
    [Description("3 1/2馬身")]
    ThreeAndHalfLengths,

    /// <summary>
    /// 4馬身
    /// </summary>
    [Description("4馬身")]
    FourLengths,

    /// <summary>
    /// 5馬身
    /// </summary>
    [Description("5馬身")]
    FiveLengths,

    /// <summary>
    /// 6馬身
    /// </summary>
    [Description("6馬身")]
    SixLengths,

    /// <summary>
    /// 7馬身
    /// </summary>
    [Description("7馬身")]
    SevenLengths,

    /// <summary>
    /// 8馬身
    /// </summary>
    [Description("8馬身")]
    EightLengths,

    /// <summary>
    /// 9馬身
    /// </summary>
    [Description("9馬身")]
    NineLengths,

    /// <summary>
    /// アタマ
    /// </summary>
    [Description("アタマ")]
    Head,

    /// <summary>
    /// 同着
    /// </summary>
    [Description("同着")]
    DeadHeat,

    /// <summary>
    /// ハナ
    /// </summary>
    [Description("ハナ")]
    Nose,

    /// <summary>
    /// クビ
    /// </summary>
    [Description("クビ")]
    Neck,

    /// <summary>
    /// 大差
    /// </summary>
    [Description("大差")]
    Distance,

    /// <summary>
    /// １０馬身
    /// </summary>
    [Description("１０馬身")]
    TenLengths,

    /// <summary>
    /// 1/4馬身
    /// </summary>
    [Description("1/4馬身")]
    QuarterLength,

    /// <summary>
    /// 2 1/4馬身
    /// </summary>
    [Description("2 1/4馬身")]
    TwoAndQuarterLengths,

    /// <summary>
    /// 7 3/4馬身
    /// </summary>
    [Description("7 3/4馬身")]
    SevenAndThreeQuartersLengths,

}

/// <summary>
/// 着差コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="Abbr3">略名(3文字)</param>
/// <param name="EnglishName">欧字名</param>
public record MarginInfo(
    string Code,
    string Name,
    string Abbr3,
    string EnglishName
);

/// <summary>
/// 着差コード拡張メソッド
/// </summary>
public static class MarginCodeExtensions
{
    /// <summary>
    /// 着差コード情報を取得します
    /// </summary>
    public static MarginInfo GetInfo(this MarginCode code)
    {
        return code switch
        {
            MarginCode.None => new MarginInfo(
                "   ",
                "未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            MarginCode.HalfLength => new MarginInfo(
                " 12",
                "1/2馬身",
                "1/2",
                "1/2"),
            MarginCode.ThreeQuartersLength => new MarginInfo(
                " 34",
                "3/4馬身",
                "3/4",
                "3/4"),
            MarginCode.OneLength => new MarginInfo(
                "1  ",
                "1馬身",
                "1",
                "1"),
            MarginCode.OneAndHalfLengths => new MarginInfo(
                "112",
                "1 1/2馬身",
                "1 1/2",
                "1 1/2"),
            MarginCode.OneAndQuarterLengths => new MarginInfo(
                "114",
                "1 1/4馬身",
                "1 1/4",
                "1 1/4"),
            MarginCode.OneAndThreeQuartersLengths => new MarginInfo(
                "134",
                "1 3/4馬身",
                "1 3/4",
                "1 3/4"),
            MarginCode.TwoLengths => new MarginInfo(
                "2  ",
                "2馬身",
                "2",
                "2"),
            MarginCode.TwoAndHalfLengths => new MarginInfo(
                "212",
                "2 1/2馬身",
                "2 1/2",
                "2 1/2"),
            MarginCode.ThreeLengths => new MarginInfo(
                "3  ",
                "3馬身",
                "3",
                "3"),
            MarginCode.ThreeAndHalfLengths => new MarginInfo(
                "312",
                "3 1/2馬身",
                "3 1/2",
                "3 1/2"),
            MarginCode.FourLengths => new MarginInfo(
                "4  ",
                "4馬身",
                "4",
                "4"),
            MarginCode.FiveLengths => new MarginInfo(
                "5  ",
                "5馬身",
                "5",
                "5"),
            MarginCode.SixLengths => new MarginInfo(
                "6  ",
                "6馬身",
                "6",
                "6"),
            MarginCode.SevenLengths => new MarginInfo(
                "7  ",
                "7馬身",
                "7",
                "7"),
            MarginCode.EightLengths => new MarginInfo(
                "8  ",
                "8馬身",
                "8",
                "8"),
            MarginCode.NineLengths => new MarginInfo(
                "9  ",
                "9馬身",
                "9",
                "9"),
            MarginCode.Head => new MarginInfo(
                "A  ",
                "アタマ",
                "アタマ",
                "HD"),
            MarginCode.DeadHeat => new MarginInfo(
                "D  ",
                "同着",
                "同着",
                "DH"),
            MarginCode.Nose => new MarginInfo(
                "H  ",
                "ハナ",
                "ハナ",
                "NS"),
            MarginCode.Neck => new MarginInfo(
                "K  ",
                "クビ",
                "クビ",
                "NK"),
            MarginCode.Distance => new MarginInfo(
                "T  ",
                "大差",
                "大差",
                "DS"),
            MarginCode.TenLengths => new MarginInfo(
                "Z  ",
                "１０馬身",
                "１０",
                "1 0"),
            MarginCode.QuarterLength => new MarginInfo(
                " 14",
                "1/4馬身",
                "1/4",
                "1/4"),
            MarginCode.TwoAndQuarterLengths => new MarginInfo(
                "214",
                "2 1/4馬身",
                "2 1/4",
                "2 1/4"),
            MarginCode.SevenAndThreeQuartersLengths => new MarginInfo(
                "734",
                "7 3/4馬身",
                "7 3/4",
                "7 3/4"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
