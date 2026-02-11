using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2303. 騎手見習コード
/// </summary>
public enum JockeyApprenticeCode
{
    /// <summary>
    ///
    /// </summary>
    [Description("")]
    None,

    /// <summary>
    /// ☆ 1Kg減
    /// </summary>
    [Description("☆")]
    Star,

    /// <summary>
    /// △ 2Kg減
    /// </summary>
    [Description("△")]
    Triangle,

    /// <summary>
    /// ▲ 3Kg減
    /// </summary>
    [Description("▲")]
    FilledTriangle,

    /// <summary>
    /// ★ 4Kg減
    /// </summary>
    [Description("★")]
    FilledStar,

    /// <summary>
    /// ◇ 2Kg減
    /// </summary>
    [Description("◇")]
    Diamond,

}

/// <summary>
/// 騎手見習コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Symbol">略名</param>
/// <param name="Reduction">減量値</param>
/// <param name="Description">説明</param>
public record JockeyApprenticeInfo(
    string Code,
    string Symbol,
    string Reduction,
    string Description
);

/// <summary>
/// 騎手見習コード拡張メソッド
/// </summary>
public static class JockeyApprenticeCodeExtensions
{
    /// <summary>
    /// 騎手見習コード情報を取得します
    /// </summary>
    public static JockeyApprenticeInfo GetInfo(this JockeyApprenticeCode code)
    {
        return code switch
        {
            JockeyApprenticeCode.None => new JockeyApprenticeInfo(
                "0",
                "",
                "",
                "下記以外　または未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)"),
            JockeyApprenticeCode.Star => new JockeyApprenticeInfo(
                "1",
                "☆",
                "1Kg減",
                "男性騎手：通算免許期間が5年未満で平地競走勝利数が51回以上100回以下(2023年1月から) 　　　　　通算免許期間が5年未満で障害競走勝利数が16回以上20回以下 (2023年1月から) 男性騎手：通算免許期間が5年未満で勝利数が51回以上100回以下(2019年3月から) 通算免許期間が5年未満の騎手で勝利数が51回以上100回以下(2016年から) 通算免許期間が3年未満の騎手で勝利数が51回以上100回以下(2004年から) 通算免許期間が3年未満の騎手で勝利数が31回以上100回以下(2003年まで)"),
            JockeyApprenticeCode.Triangle => new JockeyApprenticeInfo(
                "2",
                "△",
                "2Kg減",
                "男性騎手：通算免許期間が5年未満で平地競走勝利数が31回以上50回以下(2023年1月から) 　　　　　通算免許期間が5年未満で障害競走勝利数が11回以上15回以下(2023年1月から) 男性騎手：通算免許期間が5年未満で勝利数が31回以上50回以下(2019年3月から) 通算免許期間が5年未満の騎手で勝利数が31回以上50回以下(2016年から) 通算免許期間が3年未満の騎手で勝利数が31回以上50回以下(2004年から) 通算免許期間が3年未満の騎手で勝利数が21回以上30回以下(2003年まで)"),
            JockeyApprenticeCode.FilledTriangle => new JockeyApprenticeInfo(
                "3",
                "▲",
                "3Kg減",
                "男性騎手：通算免許期間が5年未満で平地競走勝利数が30回以下　　　　 (2023年1月から) 　　　　　通算免許期間が5年未満で障害競走勝利数が10回以下　　　　 (2023年1月から) 女性騎手：通算免許期間が5年未満で平地競走勝利数が51回以上100回以下(2023年1月から) 　　　　　通算免許期間が5年未満で障害競走勝利数が16回以上20回以下 (2023年1月から) 男性騎手：通算免許期間が5年未満で勝利数が30回以下　　　　　 (2019年3月から) 女性騎手：通算免許期間が5年未満で勝利度数が51回以上100回以下(2019年3月から) 通算免許期間が5年未満の騎手で勝利数が30回以下(2016年から) 通算免許期間が3年未満の騎手で勝利数が30回以下(2004年から) 通算免許期間が3年未満の騎手で勝利数が20回以下(2003年まで)"),
            JockeyApprenticeCode.FilledStar => new JockeyApprenticeInfo(
                "4",
                "★",
                "4Kg減",
                "女性騎手：通算免許期間が5年未満で平地競走勝利数が50回以下(2023年1月から) 　　　　　通算免許期間が5年未満で障害競走勝利数が15回以下(2023年1月から) 女性騎手：通算免許期間が5年未満で勝利度数が50回以下　(2019年3月から)"),
            JockeyApprenticeCode.Diamond => new JockeyApprenticeInfo(
                "9",
                "◇",
                "2Kg減",
                "女性騎手：通算免許期間が5年未満で勝利度数が101回以上、または5年以上(2019年3月から)"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
