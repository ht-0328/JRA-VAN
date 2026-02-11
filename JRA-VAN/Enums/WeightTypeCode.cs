using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2008.重量種別コード
/// </summary>
public enum WeightTypeCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// ハンデ
    /// </summary>
    [Description("ハンデ")]
    Handicap,

    /// <summary>
    /// 別定
    /// </summary>
    [Description("別定")]
    SpecialWeight,

    /// <summary>
    /// 馬齢
    /// </summary>
    [Description("馬齢")]
    WeightForAge,

    /// <summary>
    /// 定量
    /// </summary>
    [Description("定量")]
    FixedWeight,

}

/// <summary>
/// 重量種別コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="Description">説明</param>
public record WeightTypeInfo(
    string Code,
    string Name,
    string EnglishName,
    string Description
);

/// <summary>
/// 重量種別コード拡張メソッド
/// </summary>
public static class WeightTypeCodeExtensions
{
    /// <summary>
    /// 重量種別コード情報を取得します
    /// </summary>
    public static WeightTypeInfo GetInfo(this WeightTypeCode code)
    {
        return code switch
        {
            WeightTypeCode.None => new WeightTypeInfo(
                "0",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            WeightTypeCode.Handicap => new WeightTypeInfo(
                "1",
                "ハンデ",
                "HANDICAP",
                "出走馬の実績等を考慮し、ハンデキャッパーが負担重量を決定するレース"),
            WeightTypeCode.SpecialWeight => new WeightTypeInfo(
                "2",
                "別定",
                "SPECIAL WEIGHT",
                "レースごとに負担重量を決定する基準が設けられているレース"),
            WeightTypeCode.WeightForAge => new WeightTypeInfo(
                "3",
                "馬齢",
                "WEIGHT FOR AGE",
                "馬の年齢や性別によって負担重量を決定するレース"),
            WeightTypeCode.FixedWeight => new WeightTypeInfo(
                "4",
                "定量",
                "SPECIAL WEIGHT",
                "別定レースであって、馬の年齢や性別によって負担重量を決定するレース"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
