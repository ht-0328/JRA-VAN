using System.ComponentModel;

namespace JRA_VAN.Shared.Domain.Enums;

/// <summary>
/// 2009.トラックコード
/// </summary>
public enum TrackCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 平地　芝　　　直線
    /// </summary>
    [Description("平地　芝　　　直線")]
    TurfStraight,

    /// <summary>
    /// 平地　芝　　　左回り
    /// </summary>
    [Description("平地　芝　　　左回り")]
    TurfLeft,

    /// <summary>
    /// 平地　芝　　　左回り　外回り
    /// </summary>
    [Description("平地　芝　　　左回り　外回り")]
    TurfLeftOuter,

    /// <summary>
    /// 平地　芝　　　左回り　内－外回り
    /// </summary>
    [Description("平地　芝　　　左回り　内－外回り")]
    TurfLeftInnerToOuter,

    /// <summary>
    /// 平地　芝　　　左回り　外－内回り
    /// </summary>
    [Description("平地　芝　　　左回り　外－内回り")]
    TurfLeftOuterToInner,

    /// <summary>
    /// 平地　芝　　　左回り　内２周
    /// </summary>
    [Description("平地　芝　　　左回り　内２周")]
    TurfLeftInnerTwoLaps,

    /// <summary>
    /// 平地　芝　　　左回り　外２周
    /// </summary>
    [Description("平地　芝　　　左回り　外２周")]
    TurfLeftOuterTwoLaps,

    /// <summary>
    /// 平地　芝　　　右回り
    /// </summary>
    [Description("平地　芝　　　右回り")]
    TurfRight,

    /// <summary>
    /// 平地　芝　　　右回り　外回り
    /// </summary>
    [Description("平地　芝　　　右回り　外回り")]
    TurfRightOuter,

    /// <summary>
    /// 平地　芝　　　右回り　内－外回り
    /// </summary>
    [Description("平地　芝　　　右回り　内－外回り")]
    TurfRightInnerToOuter,

    /// <summary>
    /// 平地　芝　　　右回り　外－内回り
    /// </summary>
    [Description("平地　芝　　　右回り　外－内回り")]
    TurfRightOuterToInner,

    /// <summary>
    /// 平地　芝　　　右回り　内２周
    /// </summary>
    [Description("平地　芝　　　右回り　内２周")]
    TurfRightInnerTwoLaps,

    /// <summary>
    /// 平地　芝　　　右回り　外２周
    /// </summary>
    [Description("平地　芝　　　右回り　外２周")]
    TurfRightOuterTwoLaps,

    /// <summary>
    /// 平地　ダート　左回り
    /// </summary>
    [Description("平地　ダート　左回り")]
    DirtLeft,

    /// <summary>
    /// 平地　ダート　右回り
    /// </summary>
    [Description("平地　ダート　右回り")]
    DirtRight,

    /// <summary>
    /// 平地　ダート　左回り　内回り
    /// </summary>
    [Description("平地　ダート　左回り　内回り")]
    DirtLeftInner,

    /// <summary>
    /// 平地　ダート　右回り　外回り
    /// </summary>
    [Description("平地　ダート　右回り　外回り")]
    DirtRightOuter,

    /// <summary>
    /// 平地　サンド　左回り
    /// </summary>
    [Description("平地　サンド　左回り")]
    SandLeft,

    /// <summary>
    /// 平地　サンド　右回り
    /// </summary>
    [Description("平地　サンド　右回り")]
    SandRight,

    /// <summary>
    /// 平地　ダート　直線
    /// </summary>
    [Description("平地　ダート　直線")]
    DirtStraight,

    /// <summary>
    /// 障害　芝　襷
    /// </summary>
    [Description("障害　芝　襷")]
    JumpTurfTasuki,

    /// <summary>
    /// 障害　芝　ダート
    /// </summary>
    [Description("障害　芝　ダート")]
    JumpTurfDirtToDirt,

    /// <summary>
    /// 障害　芝・左
    /// </summary>
    [Description("障害　芝・左")]
    JumpTurfLeft,

    /// <summary>
    /// 障害　芝
    /// </summary>
    [Description("障害　芝")]
    JumpTurf,

    /// <summary>
    /// 障害　芝　外回り
    /// </summary>
    [Description("障害　芝　外回り")]
    JumpTurfOuter,

    /// <summary>
    /// 障害　芝　外－内回り
    /// </summary>
    [Description("障害　芝　外－内回り")]
    JumpTurfOuterToInner,

    /// <summary>
    /// 障害　芝　内－外回り
    /// </summary>
    [Description("障害　芝　内－外回り")]
    JumpTurfInnerToOuter,

    /// <summary>
    /// 障害　芝　内２周以上
    /// </summary>
    [Description("障害　芝　内２周以上")]
    JumpTurfInnerTwoLaps,

    /// <summary>
    /// 障害　芝　外２周以上
    /// </summary>
    [Description("障害　芝　外２周以上")]
    JumpTurfOuterTwoLaps,

}

/// <summary>
/// トラックコード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="Abbr6">略名(6文字)</param>
/// <param name="EnglishName">欧字名</param>
public record TrackInfo(
    string Code,
    string Name,
    string Abbr6,
    string EnglishName
);

/// <summary>
/// トラックコード拡張メソッド
/// </summary>
public static class TrackCodeExtensions
{
    /// <summary>
    /// トラックコード情報を取得します
    /// </summary>
    public static TrackInfo GetInfo(this TrackCode code)
    {
        return code switch
        {
            TrackCode.None => new TrackInfo(
                "00",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            TrackCode.TurfStraight => new TrackInfo(
                "10",
                "平地　芝　　　直線",
                "芝・直",
                "Turf Str."),
            TrackCode.TurfLeft => new TrackInfo(
                "11",
                "平地　芝　　　左回り",
                "芝・左",
                "Turf"),
            TrackCode.TurfLeftOuter => new TrackInfo(
                "12",
                "平地　芝　　　左回り　外回り",
                "芝・左外",
                "Turf"),
            TrackCode.TurfLeftInnerToOuter => new TrackInfo(
                "13",
                "平地　芝　　　左回り　内－外回り",
                "芝・左内→外",
                "Turf"),
            TrackCode.TurfLeftOuterToInner => new TrackInfo(
                "14",
                "平地　芝　　　左回り　外－内回り",
                "芝・左外→内",
                "Turf"),
            TrackCode.TurfLeftInnerTwoLaps => new TrackInfo(
                "15",
                "平地　芝　　　左回り　内２周",
                "芝・左内２周",
                "Turf"),
            TrackCode.TurfLeftOuterTwoLaps => new TrackInfo(
                "16",
                "平地　芝　　　左回り　外２周",
                "芝・左外２周",
                "Turf"),
            TrackCode.TurfRight => new TrackInfo(
                "17",
                "平地　芝　　　右回り",
                "芝・右",
                "Turf"),
            TrackCode.TurfRightOuter => new TrackInfo(
                "18",
                "平地　芝　　　右回り　外回り",
                "芝・右外",
                "Turf"),
            TrackCode.TurfRightInnerToOuter => new TrackInfo(
                "19",
                "平地　芝　　　右回り　内－外回り",
                "芝・右内→外",
                "Turf"),
            TrackCode.TurfRightOuterToInner => new TrackInfo(
                "20",
                "平地　芝　　　右回り　外－内回り",
                "芝・右外→内",
                "Turf"),
            TrackCode.TurfRightInnerTwoLaps => new TrackInfo(
                "21",
                "平地　芝　　　右回り　内２周",
                "芝・右内２周",
                "Turf"),
            TrackCode.TurfRightOuterTwoLaps => new TrackInfo(
                "22",
                "平地　芝　　　右回り　外２周",
                "芝・右外２周",
                "Turf"),
            TrackCode.DirtLeft => new TrackInfo(
                "23",
                "平地　ダート　左回り",
                "ダート・左",
                "Dirt"),
            TrackCode.DirtRight => new TrackInfo(
                "24",
                "平地　ダート　右回り",
                "ダート・右",
                "Dirt"),
            TrackCode.DirtLeftInner => new TrackInfo(
                "25",
                "平地　ダート　左回り　内回り",
                "ダート・左内",
                "Dirt"),
            TrackCode.DirtRightOuter => new TrackInfo(
                "26",
                "平地　ダート　右回り　外回り",
                "ダート・右外",
                "Dirt"),
            TrackCode.SandLeft => new TrackInfo(
                "27",
                "平地　サンド　左回り",
                "サンド・左",
                "Sand"),
            TrackCode.SandRight => new TrackInfo(
                "28",
                "平地　サンド　右回り",
                "サンド・右",
                "Sand"),
            TrackCode.DirtStraight => new TrackInfo(
                "29",
                "平地　ダート　直線",
                "ダート・直",
                "Dirt Str."),
            TrackCode.JumpTurfTasuki => new TrackInfo(
                "51",
                "障害　芝　襷",
                "芝・襷",
                "Turf"),
            TrackCode.JumpTurfDirtToDirt => new TrackInfo(
                "52",
                "障害　芝　ダート",
                "芝→ダート",
                "Turf→Dirt"),
            TrackCode.JumpTurfLeft => new TrackInfo(
                "53",
                "障害　芝・左",
                "芝・左",
                "Turf"),
            TrackCode.JumpTurf => new TrackInfo(
                "54",
                "障害　芝",
                "芝",
                "Turf"),
            TrackCode.JumpTurfOuter => new TrackInfo(
                "55",
                "障害　芝　外回り",
                "芝・外",
                "Turf"),
            TrackCode.JumpTurfOuterToInner => new TrackInfo(
                "56",
                "障害　芝　外－内回り",
                "芝・外→内",
                "Turf"),
            TrackCode.JumpTurfInnerToOuter => new TrackInfo(
                "57",
                "障害　芝　内－外回り",
                "芝・内→外",
                "Turf"),
            TrackCode.JumpTurfInnerTwoLaps => new TrackInfo(
                "58",
                "障害　芝　内２周以上",
                "芝・内２周",
                "Turf"),
            TrackCode.JumpTurfOuterTwoLaps => new TrackInfo(
                "59",
                "障害　芝　外２周以上",
                "芝・外２周",
                "Turf"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
