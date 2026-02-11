using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2302.騎乗資格コード
/// </summary>
public enum JockeyQualificationCode
{
    /// <summary>
    /// 資格なし　または未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("資格なし　または未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 平・障
    /// </summary>
    [Description("平・障")]
    FlatAndJump,

    /// <summary>
    /// 平地
    /// </summary>
    [Description("平地")]
    Flat,

    /// <summary>
    /// 障害
    /// </summary>
    [Description("障害")]
    Jump,

}

/// <summary>
/// 騎乗資格コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Content">内容</param>
public record JockeyQualificationInfo(
    string Code,
    string Content
);

/// <summary>
/// 騎乗資格コード拡張メソッド
/// </summary>
public static class JockeyQualificationCodeExtensions
{
    /// <summary>
    /// 騎乗資格コード情報を取得します
    /// </summary>
    public static JockeyQualificationInfo GetInfo(this JockeyQualificationCode code)
    {
        return code switch
        {
            JockeyQualificationCode.None => new JockeyQualificationInfo(
                "0",
                "資格なし　または未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)"),
            JockeyQualificationCode.FlatAndJump => new JockeyQualificationInfo(
                "1",
                "平・障"),
            JockeyQualificationCode.Flat => new JockeyQualificationInfo(
                "2",
                "平地"),
            JockeyQualificationCode.Jump => new JockeyQualificationInfo(
                "3",
                "障害"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
