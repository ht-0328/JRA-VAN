using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2202.性別コード
/// </summary>
public enum HorseGenderCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 牡馬
    /// </summary>
    [Description("牡馬")]
    Male,

    /// <summary>
    /// 牝馬
    /// </summary>
    [Description("牝馬")]
    Female,

    /// <summary>
    /// セン馬
    /// </summary>
    [Description("セン馬")]
    Gelding,

}

/// <summary>
/// 性別コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="Description">説明</param>
public record HorseGenderInfo(
    string Code,
    string Name,
    string EnglishName,
    string Description
);

/// <summary>
/// 性別コード拡張メソッド
/// </summary>
public static class HorseGenderCodeExtensions
{
    /// <summary>
    /// 性別コード情報を取得します
    /// </summary>
    public static HorseGenderInfo GetInfo(this HorseGenderCode code)
    {
        return code switch
        {
            HorseGenderCode.None => new HorseGenderInfo(
                "0",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            HorseGenderCode.Male => new HorseGenderInfo(
                "1",
                "牡馬",
                "満年齢0～4歳　C 満年齢5歳～ 　H",
                "オス馬"),
            HorseGenderCode.Female => new HorseGenderInfo(
                "2",
                "牝馬",
                "満年齢0～4歳　F 満年齢5歳～ 　M",
                "メス馬"),
            HorseGenderCode.Gelding => new HorseGenderInfo(
                "3",
                "セン馬",
                "満年齢0～4歳　G 満年齢5歳～ 　G",
                "去勢したオス馬"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
