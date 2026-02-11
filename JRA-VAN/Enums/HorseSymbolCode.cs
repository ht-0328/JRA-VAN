using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2204.馬記号コード
/// </summary>
public enum HorseSymbolCode
{
    /// <summary>
    /// 下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// (抽)
    /// </summary>
    [Description("(抽)")]
    Lottery,

    /// <summary>
    /// [抽]
    /// </summary>
    [Description("[抽]")]
    ArabLottery,

    /// <summary>
    /// (父)
    /// </summary>
    [Description("(父)")]
    Sire,

    /// <summary>
    /// (市)
    /// </summary>
    [Description("(市)")]
    Market,

    /// <summary>
    /// (地)
    /// </summary>
    [Description("(地)")]
    RegionalFormer,

    /// <summary>
    /// (外)
    /// </summary>
    [Description("(外)")]
    ForeignBred,

    /// <summary>
    /// (父)(抽)
    /// </summary>
    [Description("(父)(抽)")]
    SireLottery,

    /// <summary>
    /// (父)(市)
    /// </summary>
    [Description("(父)(市)")]
    SireMarket,

    /// <summary>
    /// (父)(地)
    /// </summary>
    [Description("(父)(地)")]
    SireRegionalFormer,

    /// <summary>
    /// (市)(地)
    /// </summary>
    [Description("(市)(地)")]
    MarketRegionalFormer,

    /// <summary>
    /// (外)(地)
    /// </summary>
    [Description("(外)(地)")]
    ForeignBredRegionalFormer,

    /// <summary>
    /// (父)(市)(地)
    /// </summary>
    [Description("(父)(市)(地)")]
    SireMarketRegionalFormer,

    /// <summary>
    /// (招)
    /// </summary>
    [Description("(招)")]
    Invited,

    /// <summary>
    /// (招)(外)
    /// </summary>
    [Description("(招)(外)")]
    InvitedForeignBred,

    /// <summary>
    /// (招)(父)
    /// </summary>
    [Description("(招)(父)")]
    InvitedSire,

    /// <summary>
    /// (招)(市)
    /// </summary>
    [Description("(招)(市)")]
    InvitedMarket,

    /// <summary>
    /// (招)(父)(市)
    /// </summary>
    [Description("(招)(父)(市)")]
    InvitedSireMarket,

    /// <summary>
    /// (父)(外)
    /// </summary>
    [Description("(父)(外)")]
    SireForeignBred,

    /// <summary>
    /// [地]
    /// </summary>
    [Description("[地]")]
    RegionalBelong,

    /// <summary>
    /// (外)[地]
    /// </summary>
    [Description("(外)[地]")]
    ForeignBredRegionalBelong,

    /// <summary>
    /// (父)[地]
    /// </summary>
    [Description("(父)[地]")]
    SireRegionalBelong,

    /// <summary>
    /// (市)[地]
    /// </summary>
    [Description("(市)[地]")]
    MarketRegionalBelong,

    /// <summary>
    /// (父)(市)[地]
    /// </summary>
    [Description("(父)(市)[地]")]
    SireMarketRegionalBelong,

    /// <summary>
    /// [外]
    /// </summary>
    [Description("[外]")]
    ForeignRan,

    /// <summary>
    /// (父)[外]
    /// </summary>
    [Description("(父)[外]")]
    SireForeignRan,

    /// <summary>
    /// (持)
    /// </summary>
    [Description("(持)")]
    ImportedInUtero,

    /// <summary>
    /// (父)(外)(地)
    /// </summary>
    [Description("(父)(外)(地)")]
    SireForeignBredRegionalFormer,

    /// <summary>
    /// (父)(外)[地]
    /// </summary>
    [Description("(父)(外)[地]")]
    SireForeignBredRegionalBelong,

}

/// <summary>
/// 馬記号コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="Description">説明</param>
public record HorseSymbolInfo(
    string Code,
    string Name,
    string EnglishName,
    string Description
);

/// <summary>
/// 馬記号コード拡張メソッド
/// </summary>
public static class HorseSymbolCodeExtensions
{
    /// <summary>
    /// 馬記号コード情報を取得します
    /// </summary>
    public static HorseSymbolInfo GetInfo(this HorseSymbolCode code)
    {
        return code switch
        {
            HorseSymbolCode.None => new HorseSymbolInfo(
                "00",
                "下記以外　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)",
                "",
                ""),
            HorseSymbolCode.Lottery => new HorseSymbolInfo(
                "01",
                "(抽)",
                "(S)",
                "ＪＲＡが市場で購買し、抽せんによって希望する馬主へ売却、配布したサラブレッド系の内国産馬"),
            HorseSymbolCode.ArabLottery => new HorseSymbolInfo(
                "02",
                "[抽]",
                "",
                "ＪＲＡが市場で購買し、抽せんによって希望する馬主へ売却、配布したアラブ系の内国産馬"),
            HorseSymbolCode.Sire => new HorseSymbolInfo(
                "03",
                "(父)",
                "(D)",
                "父がサラブレッド系の内国産馬であるサラブレッド系の馬"),
            HorseSymbolCode.Market => new HorseSymbolInfo(
                "04",
                "(市)",
                "(A)",
                "公認せり市場において売買された (抽) 以外のサラブレッド系の馬"),
            HorseSymbolCode.RegionalFormer => new HorseSymbolInfo(
                "05",
                "(地)",
                "(R)",
                "ＪＲＡの馬名登録のとき、すでに地方競馬に出走したことのある馬であって [抽] 以外の馬"),
            HorseSymbolCode.ForeignBred => new HorseSymbolInfo(
                "06",
                "(外)",
                "(F)",
                "外国産馬であって [外] 以外の馬"),
            HorseSymbolCode.SireLottery => new HorseSymbolInfo(
                "07",
                "(父)(抽)",
                "(D)(S)",
                ""),
            HorseSymbolCode.SireMarket => new HorseSymbolInfo(
                "08",
                "(父)(市)",
                "(D)(A)",
                ""),
            HorseSymbolCode.SireRegionalFormer => new HorseSymbolInfo(
                "09",
                "(父)(地)",
                "(D)(R)",
                ""),
            HorseSymbolCode.MarketRegionalFormer => new HorseSymbolInfo(
                "10",
                "(市)(地)",
                "(A)(R)",
                ""),
            HorseSymbolCode.ForeignBredRegionalFormer => new HorseSymbolInfo(
                "11",
                "(外)(地)",
                "(F)(R)",
                ""),
            HorseSymbolCode.SireMarketRegionalFormer => new HorseSymbolInfo(
                "12",
                "(父)(市)(地)",
                "(D)(A)(R)",
                ""),
            HorseSymbolCode.Invited => new HorseSymbolInfo(
                "15",
                "(招)",
                "(I)",
                "ＪＲＡの国際招待競走または地方競馬招待競走に出走する地方競馬または外国からの招待馬"),
            HorseSymbolCode.InvitedForeignBred => new HorseSymbolInfo(
                "16",
                "(招)(外)",
                "(I)(F)",
                ""),
            HorseSymbolCode.InvitedSire => new HorseSymbolInfo(
                "17",
                "(招)(父)",
                "(I)(D)",
                ""),
            HorseSymbolCode.InvitedMarket => new HorseSymbolInfo(
                "18",
                "(招)(市)",
                "(I)(A)",
                ""),
            HorseSymbolCode.InvitedSireMarket => new HorseSymbolInfo(
                "19",
                "(招)(父)(市)",
                "(I)(D)(A)",
                ""),
            HorseSymbolCode.SireForeignBred => new HorseSymbolInfo(
                "20",
                "(父)(外)",
                "(D)(F)",
                ""),
            HorseSymbolCode.RegionalBelong => new HorseSymbolInfo(
                "21",
                "[地]",
                "[R]",
                "中央競馬に出走する地方競馬所属の馬"),
            HorseSymbolCode.ForeignBredRegionalBelong => new HorseSymbolInfo(
                "22",
                "(外)[地]",
                "(F)[R]",
                ""),
            HorseSymbolCode.SireRegionalBelong => new HorseSymbolInfo(
                "23",
                "(父)[地]",
                "(D)[R]",
                ""),
            HorseSymbolCode.MarketRegionalBelong => new HorseSymbolInfo(
                "24",
                "(市)[地]",
                "(A)[R]",
                ""),
            HorseSymbolCode.SireMarketRegionalBelong => new HorseSymbolInfo(
                "25",
                "(父)(市)[地]",
                "(D)(A)[R]",
                ""),
            HorseSymbolCode.ForeignRan => new HorseSymbolInfo(
                "26",
                "[外]",
                "[F]",
                "中央競馬に出走する以前に外国の競馬に出走したことのある外国産馬"),
            HorseSymbolCode.SireForeignRan => new HorseSymbolInfo(
                "27",
                "(父)[外]",
                "(D)[F]",
                ""),
            HorseSymbolCode.ImportedInUtero => new HorseSymbolInfo(
                "31",
                "(持)",
                "",
                "活馬の輸入事由化の実施日以降に輸入される妊娠馬による持込馬(S59年1/1から削除)"),
            HorseSymbolCode.SireForeignBredRegionalFormer => new HorseSymbolInfo(
                "40",
                "(父)(外)(地)",
                "(D)(F)(R)",
                ""),
            HorseSymbolCode.SireForeignBredRegionalBelong => new HorseSymbolInfo(
                "41",
                "(父)(外)[地]",
                "(D)(F)[R]",
                ""),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
