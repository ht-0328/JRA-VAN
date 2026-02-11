using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2201.品種コード
/// </summary>
public enum BreedCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// サラブレッド
    /// </summary>
    [Description("サラブレッド")]
    Thoroughbred,

    /// <summary>
    /// サラブレッド系種
    /// </summary>
    [Description("サラブレッド系種")]
    ThoroughbredStrain,

    /// <summary>
    /// 準サラブレッド
    /// </summary>
    [Description("準サラブレッド")]
    SemiThoroughbred,

    /// <summary>
    /// 軽半血種
    /// </summary>
    [Description("軽半血種")]
    LightHalfBred,

    /// <summary>
    /// アングロアラブ
    /// </summary>
    [Description("アングロアラブ")]
    AngloArab,

    /// <summary>
    /// アラブ系種
    /// </summary>
    [Description("アラブ系種")]
    ArabStrain,

    /// <summary>
    /// アラブ
    /// </summary>
    [Description("アラブ")]
    Arab,

    /// <summary>
    /// 中半血種
    /// </summary>
    [Description("中半血種")]
    MiddleHalfBred,

}

/// <summary>
/// 品種コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="ShortName">略名</param>
/// <param name="Description">説明</param>
public record BreedInfo(
    string Code,
    string Name,
    string ShortName,
    string Description
);

/// <summary>
/// 品種コード拡張メソッド
/// </summary>
public static class BreedCodeExtensions
{
    /// <summary>
    /// 品種コード情報を取得します
    /// </summary>
    public static BreedInfo GetInfo(this BreedCode code)
    {
        return code switch
        {
            BreedCode.None => new BreedInfo(
                "0",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            BreedCode.Thoroughbred => new BreedInfo(
                "1",
                "サラブレッド",
                "サラ",
                "サラブレッドとして登録したもの。"),
            BreedCode.ThoroughbredStrain => new BreedInfo(
                "2",
                "サラブレッド系種",
                "サラ系",
                "アラブの血量が２５％未満"),
            BreedCode.SemiThoroughbred => new BreedInfo(
                "3",
                "準サラブレッド",
                "準サラ",
                "昭和49年6月1日の登録規定改定により「準サラ」は「サラ系」となり、「準サラ」の品種は廃止された。"),
            BreedCode.LightHalfBred => new BreedInfo(
                "4",
                "軽半血種",
                "軽半",
                "アングロノルマン、アングロノルマン系種または中半血種と連続2代以上にあたり、軽種を交配したもの。軽半血種相互の交配によって生まれたもの。"),
            BreedCode.AngloArab => new BreedInfo(
                "5",
                "アングロアラブ",
                "アア",
                "アラブの血量が２５％以上（父母の組み合わせにより「アラ系」と異なる。）"),
            BreedCode.ArabStrain => new BreedInfo(
                "6",
                "アラブ系種",
                "アラ系",
                "アラブの血量が２５％以上（父母の組み合わせにより「アア」と異なる。）"),
            BreedCode.Arab => new BreedInfo(
                "7",
                "アラブ",
                "アラブ",
                "純血のアラブ"),
            BreedCode.MiddleHalfBred => new BreedInfo(
                "8",
                "中半血種",
                "中半",
                "異種の中間相互、中半血種の中間相互、の交配で生まれたもの。中半血種と軽種、アングロノルマンとサラブレッドを除く軽種、重半血種と軽種を交配して生まれたもの。"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
