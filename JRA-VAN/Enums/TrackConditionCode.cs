using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2010.馬場状態コード
/// </summary>
public enum TrackConditionCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 良
    /// </summary>
    [Description("良")]
    Good,

    /// <summary>
    /// 稍重
    /// </summary>
    [Description("稍重")]
    SlightlyHeavy,

    /// <summary>
    /// 重
    /// </summary>
    [Description("重")]
    Heavy,

    /// <summary>
    /// 不良
    /// </summary>
    [Description("不良")]
    Bad,

}

/// <summary>
/// 馬場状態コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishNameTurf">欧字名（芝）</param>
/// <param name="EnglishNameDirt">欧字名（ダート）</param>
public record TrackConditionInfo(
    string Code,
    string Name,
    string EnglishNameTurf,
    string EnglishNameDirt
);

/// <summary>
/// 馬場状態コード拡張メソッド
/// </summary>
public static class TrackConditionCodeExtensions
{
    /// <summary>
    /// 馬場状態コード情報を取得します
    /// </summary>
    public static TrackConditionInfo GetInfo(this TrackConditionCode code)
    {
        return code switch
        {
            TrackConditionCode.None => new TrackConditionInfo(
                "0",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            TrackConditionCode.Good => new TrackConditionInfo(
                "1",
                "良",
                "Good to Firm",
                "Standard"),
            TrackConditionCode.SlightlyHeavy => new TrackConditionInfo(
                "2",
                "稍重",
                "Good",
                "Good"),
            TrackConditionCode.Heavy => new TrackConditionInfo(
                "3",
                "重",
                "Yielding",
                "Muddy"),
            TrackConditionCode.Bad => new TrackConditionInfo(
                "4",
                "不良",
                "Soft",
                "Sloppy"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
