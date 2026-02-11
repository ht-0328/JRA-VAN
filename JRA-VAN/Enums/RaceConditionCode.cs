using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2007.競走条件コード
/// </summary>
public enum RaceConditionCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// １００万円以下
    /// </summary>
    [Description("１００万円以下")]
    OneMillionAndLess,

    /// <summary>
    /// ２００万円以下
    /// </summary>
    [Description("２００万円以下")]
    TwoMillionAndLess,

    /// <summary>
    /// ３００万円以下
    /// </summary>
    [Description("３００万円以下")]
    ThreeMillionAndLess,

    /// <summary>
    /// ５００万円以下 １勝クラス
    /// </summary>
    [Description("５００万円以下 １勝クラス")]
    FiveMillionAndLessorOneWinClass,

    /// <summary>
    /// １０００万円以下 ２勝クラス
    /// </summary>
    [Description("１０００万円以下 ２勝クラス")]
    TenMillionAndLessorTwoWinsClass,

    /// <summary>
    /// １６００万円以下 ３勝クラス
    /// </summary>
    [Description("１６００万円以下 ３勝クラス")]
    SixteenMillionAndLessorThreeWinsClass,

    /// <summary>
    /// ９９００万円以下
    /// </summary>
    [Description("９９００万円以下")]
    NinetyNineMillionAndLess,

    /// <summary>
    /// １億円以下
    /// </summary>
    [Description("１億円以下")]
    OneHundredMillionAndLess,

    /// <summary>
    /// 新馬
    /// </summary>
    [Description("新馬")]
    Newcomer,

    /// <summary>
    /// 未出走
    /// </summary>
    [Description("未出走")]
    Unraced,

    /// <summary>
    /// 未勝利
    /// </summary>
    [Description("未勝利")]
    Maiden,

    /// <summary>
    /// オープン
    /// </summary>
    [Description("オープン")]
    Open,

}

/// <summary>
/// 競走条件コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="Description">説明</param>
public record RaceConditionInfo(
    string Code,
    string Name,
    string EnglishName,
    string Description
);

/// <summary>
/// 競走条件コード拡張メソッド
/// </summary>
public static class RaceConditionCodeExtensions
{
    /// <summary>
    /// 競走条件コード情報を取得します
    /// </summary>
    public static RaceConditionInfo GetInfo(this RaceConditionCode code)
    {
        return code switch
        {
            RaceConditionCode.None => new RaceConditionInfo(
                "000",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            RaceConditionCode.OneMillionAndLess => new RaceConditionInfo(
                "001",
                "１００万円以下",
                "1,000,000 & LESS",
                "収得賞金が100万円以下の馬が出走できる。"),
            RaceConditionCode.TwoMillionAndLess => new RaceConditionInfo(
                "002",
                "２００万円以下",
                "2,000,000 & LESS",
                "収得賞金が200万円以下の馬が出走できる。"),
            RaceConditionCode.ThreeMillionAndLess => new RaceConditionInfo(
                "003",
                "３００万円以下",
                "3,000,000 & LESS",
                "収得賞金が300万円以下の馬が出走できる。"),
            RaceConditionCode.FiveMillionAndLessorOneWinClass => new RaceConditionInfo(
                "005",
                "５００万円以下 １勝クラス",
                "5,000,000 & LESS 1 Win Class",
                "収得賞金が500万円以下の馬が出走できる。 1勝した馬が出走できる。　　　　　　　　※呼称は特記事項を参照"),
            RaceConditionCode.TenMillionAndLessorTwoWinsClass => new RaceConditionInfo(
                "010",
                "１０００万円以下 ２勝クラス",
                "10,000,000 & LESS 2 Wins Class",
                "収得賞金が1000万円以下の馬が出走できる。 2勝した馬が出走できる。　　　　　　　　※呼称は特記事項を参照"),
            RaceConditionCode.SixteenMillionAndLessorThreeWinsClass => new RaceConditionInfo(
                "016",
                "１６００万円以下 ３勝クラス",
                "16,000,000 & LESS 3 Wins Class",
                "収得賞金が1600万円以下の馬が出走できる。 3勝した馬が出走できる。　　　　　　　　※呼称は特記事項を参照"),
            RaceConditionCode.NinetyNineMillionAndLess => new RaceConditionInfo(
                "099",
                "９９００万円以下",
                "99,000,000 & LESS",
                "収得賞金が9900万円以下の馬が出走できる。"),
            RaceConditionCode.OneHundredMillionAndLess => new RaceConditionInfo(
                "100",
                "１億円以下",
                "100,000,000 & LESS",
                "収得賞金が1億円以下の馬が出走できる。"),
            RaceConditionCode.Newcomer => new RaceConditionInfo(
                "701",
                "新馬",
                "NEWCOMER",
                "サラブレッド系の未出走馬が出走できる。"),
            RaceConditionCode.Unraced => new RaceConditionInfo(
                "702",
                "未出走",
                "UNRACED",
                "当該競馬以外の競馬 (地方競馬または外国の競馬を含む) において、出走したことがなく、当該競馬において、第1着または重賞競走の第2着になったことのない馬が出走できる。"),
            RaceConditionCode.Maiden => new RaceConditionInfo(
                "703",
                "未勝利",
                "MAIDEN",
                "当該競馬以外の競馬 (地方競馬または外国の競馬を含む) において出走し、収得賞金がない馬が出走できる。また未出走馬も出走できる。"),
            RaceConditionCode.Open => new RaceConditionInfo(
                "999",
                "オープン",
                "OPEN",
                "特に記載のない限り、すべての馬が出走できる競走"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
