using System.ComponentModel;

namespace JRA_VAN.Shared.Domain.Enums;

/// <summary>
/// 2101.異常区分コード
/// </summary>
public enum AbnormalResultCode
{
    /// <summary>
    /// 下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 出走取消
    /// </summary>
    [Description("出走取消")]
    Scratched,

    /// <summary>
    /// 発走除外
    /// </summary>
    [Description("発走除外")]
    ExcludedByStarters,

    /// <summary>
    /// 競走除外
    /// </summary>
    [Description("競走除外")]
    ExcludedByStewards,

    /// <summary>
    /// 競走中止
    /// </summary>
    [Description("競走中止")]
    FallToFinish,

    /// <summary>
    /// 失格
    /// </summary>
    [Description("失格")]
    Disqualified,

    /// <summary>
    /// 落馬再騎乗
    /// </summary>
    [Description("落馬再騎乗")]
    RemountAfterACropper,

    /// <summary>
    /// 降着
    /// </summary>
    [Description("降着")]
    DisqualifiedAndPlaced,

}

/// <summary>
/// 異常区分コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="Abbr2">略名(2文字)</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="EnglishAbbr">欧字略名</param>
public record AbnormalResultInfo(
    string Code,
    string Name,
    string Abbr2,
    string EnglishName,
    string EnglishAbbr
);

/// <summary>
/// 異常区分コード拡張メソッド
/// </summary>
public static class AbnormalResultCodeExtensions
{
    /// <summary>
    /// 異常区分コード情報を取得します
    /// </summary>
    public static AbnormalResultInfo GetInfo(this AbnormalResultCode code)
    {
        return code switch
        {
            AbnormalResultCode.None => new AbnormalResultInfo(
                "0",
                "下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)",
                "",
                "",
                ""),
            AbnormalResultCode.Scratched => new AbnormalResultInfo(
                "1",
                "出走取消",
                "取消",
                "SCRATCHED",
                "S"),
            AbnormalResultCode.ExcludedByStarters => new AbnormalResultInfo(
                "2",
                "発走除外",
                "発除",
                "EXCLUDED BY STARTERS",
                "ES"),
            AbnormalResultCode.ExcludedByStewards => new AbnormalResultInfo(
                "3",
                "競走除外",
                "競除",
                "EXCLUDED BY STEWARDS",
                "ER"),
            AbnormalResultCode.FallToFinish => new AbnormalResultInfo(
                "4",
                "競走中止",
                "中止",
                "FALL TO FINISH",
                "FF"),
            AbnormalResultCode.Disqualified => new AbnormalResultInfo(
                "5",
                "失格",
                "失格",
                "DISQUALIFIED",
                "DQ"),
            AbnormalResultCode.RemountAfterACropper => new AbnormalResultInfo(
                "6",
                "落馬再騎乗",
                "再騎",
                "REMOUNT AFTER A CROPPER",
                "RM"),
            AbnormalResultCode.DisqualifiedAndPlaced => new AbnormalResultInfo(
                "7",
                "降着",
                "降着",
                "DISQUALIFIED AND PLACED",
                "DQ&P"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
