using System.ComponentModel;

namespace JRA_VAN.Shared.Domain.Enums;

/// <summary>
/// 2005.競走種別コード
/// </summary>
public enum RaceTypeCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// サラブレッド系2歳
    /// </summary>
    [Description("サラブレッド系2歳")]
    TwoYearOlds,

    /// <summary>
    /// サラブレッド系3歳
    /// </summary>
    [Description("サラブレッド系3歳")]
    ThreeYearOlds,

    /// <summary>
    /// サラブレッド系3歳以上
    /// </summary>
    [Description("サラブレッド系3歳以上")]
    ThreeYearOldsAndUp,

    /// <summary>
    /// サラブレッド系4歳以上
    /// </summary>
    [Description("サラブレッド系4歳以上")]
    FourYearOldsAndUp,

    /// <summary>
    /// サラブレッド系障害3歳以上
    /// </summary>
    [Description("サラブレッド系障害3歳以上")]
    ThreeYearOldsAndUpSteepleChase,

    /// <summary>
    /// サラブレッド系障害4歳以上
    /// </summary>
    [Description("サラブレッド系障害4歳以上")]
    FourYearOldsAndUpSteepleChase,

    /// <summary>
    /// アラブ系2歳
    /// </summary>
    [Description("アラブ系2歳")]
    TwoYearOldsAngloArabs,

    /// <summary>
    /// アラブ系3歳
    /// </summary>
    [Description("アラブ系3歳")]
    ThreeYearOldsAngloArabs,

    /// <summary>
    /// アラブ系3歳以上
    /// </summary>
    [Description("アラブ系3歳以上")]
    ThreeYearOldsAndUpAngloArabs,

    /// <summary>
    /// アラブ系4歳以上
    /// </summary>
    [Description("アラブ系4歳以上")]
    FourYearOldsAndUpAngloArabs,

}

/// <summary>
/// 競走種別コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="Abbr4">略名(4文字)</param>
/// <param name="Abbr6">略名(6文字)</param>
/// <param name="Abbr8">略名(8文字)</param>
/// <param name="EnglishName">欧字名</param>
public record RaceTypeInfo(
    string Code,
    string Name,
    string Abbr4,
    string Abbr6,
    string Abbr8,
    string EnglishName
);

/// <summary>
/// 競走種別コード拡張メソッド
/// </summary>
public static class RaceTypeCodeExtensions
{
    /// <summary>
    /// 競走種別コード情報を取得します
    /// </summary>
    public static RaceTypeInfo GetInfo(this RaceTypeCode code)
    {
        return code switch
        {
            RaceTypeCode.None => new RaceTypeInfo(
                "00",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                "",
                "",
                ""),
            RaceTypeCode.TwoYearOlds => new RaceTypeInfo(
                "11",
                "サラブレッド系2歳",
                "サラ２才",
                "サラ系２歳",
                "サラ系２歳",
                "TWO-YEAR-OLDS"),
            RaceTypeCode.ThreeYearOlds => new RaceTypeInfo(
                "12",
                "サラブレッド系3歳",
                "サラ３才",
                "サラ系３歳",
                "サラ系３歳",
                "THREE-YEAR-OLDS"),
            RaceTypeCode.ThreeYearOldsAndUp => new RaceTypeInfo(
                "13",
                "サラブレッド系3歳以上",
                "サラ３上",
                "サラ系３歳上",
                "サラ系３歳以上",
                "THREE-YEAR-OLDS & UP"),
            RaceTypeCode.FourYearOldsAndUp => new RaceTypeInfo(
                "14",
                "サラブレッド系4歳以上",
                "サラ４上",
                "サラ系４歳上",
                "サラ系４歳以上",
                "FOUR-YEAR-OLDS & UP"),
            RaceTypeCode.ThreeYearOldsAndUpSteepleChase => new RaceTypeInfo(
                "18",
                "サラブレッド系障害3歳以上",
                "障害３上",
                "障害３歳上",
                "サラ障害３歳以上",
                "THREE-YEAR-OLDS & UP STEEPLE-CHASE"),
            RaceTypeCode.FourYearOldsAndUpSteepleChase => new RaceTypeInfo(
                "19",
                "サラブレッド系障害4歳以上",
                "障害４上",
                "障害４歳上",
                "サラ障害４歳以上",
                "FOUR-YEAR-OLDS & UP STEEPLE-CHASE"),
            RaceTypeCode.TwoYearOldsAngloArabs => new RaceTypeInfo(
                "21",
                "アラブ系2歳",
                "アラ２才",
                "アラ系２歳",
                "アラブ系２歳",
                "TWO-YEAR-OLDS ANGLO-ARABS"),
            RaceTypeCode.ThreeYearOldsAngloArabs => new RaceTypeInfo(
                "22",
                "アラブ系3歳",
                "アラ３才",
                "アラ系３歳",
                "アラブ系３歳",
                "THREE-YEAR-OLDS ANGLO-ARABS"),
            RaceTypeCode.ThreeYearOldsAndUpAngloArabs => new RaceTypeInfo(
                "23",
                "アラブ系3歳以上",
                "アラ３上",
                "アラ系３歳上",
                "アラブ系３歳以上",
                "THREE-YEAR-OLDS & UP ANGLO-ARABS"),
            RaceTypeCode.FourYearOldsAndUpAngloArabs => new RaceTypeInfo(
                "24",
                "アラブ系4歳以上",
                "アラ４上",
                "アラ系４歳上",
                "アラブ系４歳以上",
                "FOUR-YEAR-OLDS & UP ANGLO-ARABS"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
