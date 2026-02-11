using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2006.競走記号コード
/// </summary>
public enum RaceSymbolCode
{
    /// <summary>
    /// 記号なし　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("記号なし　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// (指定)
    /// </summary>
    [Description("(指定)")]
    Dsn,

    /// <summary>
    /// 見習騎手 (2003年までの表記) 若手騎手 (2004年からの表記)
    /// </summary>
    [Description("見習騎手 (2003年までの表記) 若手騎手 (2004年からの表記)")]
    ApprenticeOrYoungJockey,

    /// <summary>
    /// [指定]
    /// </summary>
    [Description("[指定]")]
    Des,

    /// <summary>
    /// (特指)
    /// </summary>
    [Description("(特指)")]
    Sd,

    /// <summary>
    /// 牝
    /// </summary>
    [Description("牝")]
    Fandm,

    /// <summary>
    /// 牝 (指定)
    /// </summary>
    [Description("牝 (指定)")]
    FandmDsn,

    /// <summary>
    /// 牝 [指定]
    /// </summary>
    [Description("牝 [指定]")]
    FandmDes,

    /// <summary>
    /// 牝 (特指)
    /// </summary>
    [Description("牝 (特指)")]
    FandmSd,

    /// <summary>
    /// 牡・ｾﾝ
    /// </summary>
    [Description("牡・ｾﾝ")]
    Candg,

    /// <summary>
    /// 牡・ｾﾝ (指定)
    /// </summary>
    [Description("牡・ｾﾝ (指定)")]
    CandgDsn,

    /// <summary>
    /// 牡・ｾﾝ [指定]
    /// </summary>
    [Description("牡・ｾﾝ [指定]")]
    CandgDes,

    /// <summary>
    /// 牡・ｾﾝ (特指)
    /// </summary>
    [Description("牡・ｾﾝ (特指)")]
    CandgSd,

    /// <summary>
    /// 牡・牝
    /// </summary>
    [Description("牡・牝")]
    Candf,

    /// <summary>
    /// 牡・牝 (指定)
    /// </summary>
    [Description("牡・牝 (指定)")]
    CandfDsn,

    /// <summary>
    /// 牡・牝 [指定]
    /// </summary>
    [Description("牡・牝 [指定]")]
    CandfDes,

    /// <summary>
    /// 牡・牝 (特指)
    /// </summary>
    [Description("牡・牝 (特指)")]
    CandfSd,

    /// <summary>
    /// (混合)
    /// </summary>
    [Description("(混合)")]
    Mix,

    /// <summary>
    /// (混合)(指定)
    /// </summary>
    [Description("(混合)(指定)")]
    MixDsn,

    /// <summary>
    /// (混合) 見習騎手 (2003年までの表記) (混合) 若手騎手 (2004年からの表記)
    /// </summary>
    [Description("(混合) 見習騎手 (2003年までの表記) (混合) 若手騎手 (2004年からの表記)")]
    Mix_A02,

    /// <summary>
    /// (混合)[指定]
    /// </summary>
    [Description("(混合)[指定]")]
    MixDes,

    /// <summary>
    /// (混合)(特指)
    /// </summary>
    [Description("(混合)(特指)")]
    MixSd,

    /// <summary>
    /// (混合) 牡
    /// </summary>
    [Description("(混合) 牡")]
    MixColt,

    /// <summary>
    /// (混合) 牡 (指定)
    /// </summary>
    [Description("(混合) 牡 (指定)")]
    MixColtDsn,

    /// <summary>
    /// (混合) 牡 [指定]
    /// </summary>
    [Description("(混合) 牡 [指定]")]
    MixColtDes,

    /// <summary>
    /// (混合) 牡 (特指)
    /// </summary>
    [Description("(混合) 牡 (特指)")]
    MixColtSd,

    /// <summary>
    /// (混合) 牝
    /// </summary>
    [Description("(混合) 牝")]
    MixFandm,

    /// <summary>
    /// (混合) 牝 (指定)
    /// </summary>
    [Description("(混合) 牝 (指定)")]
    MixFandmDsn,

    /// <summary>
    /// (混合) 牝 [指定]
    /// </summary>
    [Description("(混合) 牝 [指定]")]
    MixFandmDes,

    /// <summary>
    /// (混合) 牝 (特指)
    /// </summary>
    [Description("(混合) 牝 (特指)")]
    MixFandmSd,

    /// <summary>
    /// (混合) 牡・ｾﾝ
    /// </summary>
    [Description("(混合) 牡・ｾﾝ")]
    MixCandg,

    /// <summary>
    /// (混合) 牡・ｾﾝ (指定)
    /// </summary>
    [Description("(混合) 牡・ｾﾝ (指定)")]
    MixCandgDsn,

    /// <summary>
    /// (混合) 牡・ｾﾝ [指定]
    /// </summary>
    [Description("(混合) 牡・ｾﾝ [指定]")]
    MixCandgDes,

    /// <summary>
    /// (混合) 牡・ｾﾝ (特指)
    /// </summary>
    [Description("(混合) 牡・ｾﾝ (特指)")]
    MixCandgSd,

    /// <summary>
    /// (混合) 牡・牝
    /// </summary>
    [Description("(混合) 牡・牝")]
    MixCandf,

    /// <summary>
    /// (混合) 牡・牝 (指定)
    /// </summary>
    [Description("(混合) 牡・牝 (指定)")]
    MixCandfDsn,

    /// <summary>
    /// (父)
    /// </summary>
    [Description("(父)")]
    Sire,

    /// <summary>
    /// (父)(指定)
    /// </summary>
    [Description("(父)(指定)")]
    DDsn,

    /// <summary>
    /// (父)[指定]
    /// </summary>
    [Description("(父)[指定]")]
    DDes,

    /// <summary>
    /// (父)(特指)
    /// </summary>
    [Description("(父)(特指)")]
    DSd,

    /// <summary>
    /// (市)
    /// </summary>
    [Description("(市)")]
    Market,

    /// <summary>
    /// (市)(指定)
    /// </summary>
    [Description("(市)(指定)")]
    ADsn,

    /// <summary>
    /// (市)[指定]
    /// </summary>
    [Description("(市)[指定]")]
    ADes,

    /// <summary>
    /// (市)(特指)
    /// </summary>
    [Description("(市)(特指)")]
    ASd,

    /// <summary>
    /// (抽)
    /// </summary>
    [Description("(抽)")]
    Lottery,

    /// <summary>
    /// (抽)(指定)
    /// </summary>
    [Description("(抽)(指定)")]
    SDsn,

    /// <summary>
    /// (抽)[指定]
    /// </summary>
    [Description("(抽)[指定]")]
    SDes,

    /// <summary>
    /// [抽]
    /// </summary>
    [Description("[抽]")]
    ArabLottery,

    /// <summary>
    /// 抽
    /// </summary>
    [Description("抽")]
    Dsn_E01,

    /// <summary>
    /// [抽][指定]
    /// </summary>
    [Description("[抽][指定]")]
    Des_E03,

    /// <summary>
    /// (市)(抽)
    /// </summary>
    [Description("(市)(抽)")]
    AS,

    /// <summary>
    /// (市)(抽)(指定)
    /// </summary>
    [Description("(市)(抽)(指定)")]
    ASDsn,

    /// <summary>
    /// (市)(抽)[指定]
    /// </summary>
    [Description("(市)(抽)[指定]")]
    ASDes,

    /// <summary>
    /// (市)(抽)(特指)
    /// </summary>
    [Description("(市)(抽)(特指)")]
    ASSd,

    /// <summary>
    /// (抽) 関西配布馬
    /// </summary>
    [Description("(抽) 関西配布馬")]
    LotteryKansai,

    /// <summary>
    /// (抽) 関西配布馬 (指定)
    /// </summary>
    [Description("(抽) 関西配布馬 (指定)")]
    Dsn_G01,

    /// <summary>
    /// (抽) 関西配布馬 [指定]
    /// </summary>
    [Description("(抽) 関西配布馬 [指定]")]
    Des_G03,

    /// <summary>
    /// (抽) 関東配布馬
    /// </summary>
    [Description("(抽) 関東配布馬")]
    LotteryKanto,

    /// <summary>
    /// (抽) 関東配布馬 (指定)
    /// </summary>
    [Description("(抽) 関東配布馬 (指定)")]
    Dsn_H01,

    /// <summary>
    /// [抽] 関西配布馬
    /// </summary>
    [Description("[抽] 関西配布馬")]
    ArabLotteryKansai,

    /// <summary>
    /// [抽] 関西配布馬 (指定)
    /// </summary>
    [Description("[抽] 関西配布馬 (指定)")]
    Dsn_I01,

    /// <summary>
    /// [抽] 関西配布馬 [指定]
    /// </summary>
    [Description("[抽] 関西配布馬 [指定]")]
    Des_I03,

    /// <summary>
    /// [抽] 関東配布馬
    /// </summary>
    [Description("[抽] 関東配布馬")]
    ArabLotteryKanto,

    /// <summary>
    /// [抽] 関東配布馬 (指定)
    /// </summary>
    [Description("[抽] 関東配布馬 (指定)")]
    Dsn_J01,

    /// <summary>
    /// (市)(抽) 関西配布馬
    /// </summary>
    [Description("(市)(抽) 関西配布馬")]
    MarketLotteryKansai,

    /// <summary>
    /// (市)(抽) 関西配布馬 (指定)
    /// </summary>
    [Description("(市)(抽) 関西配布馬 (指定)")]
    Dsn_K01,

    /// <summary>
    /// (市)(抽) 関西配布馬 [指定]
    /// </summary>
    [Description("(市)(抽) 関西配布馬 [指定]")]
    Des_K03,

    /// <summary>
    /// (市)(抽) 関東配布馬
    /// </summary>
    [Description("(市)(抽) 関東配布馬")]
    MarketLotteryKanto,

    /// <summary>
    /// (市)(抽) 関東配布馬 (指定)
    /// </summary>
    [Description("(市)(抽) 関東配布馬 (指定)")]
    Dsn_L01,

    /// <summary>
    /// (市)(抽) 関東配布馬 [指定]
    /// </summary>
    [Description("(市)(抽) 関東配布馬 [指定]")]
    Des_L03,

    /// <summary>
    /// 九州産馬
    /// </summary>
    [Description("九州産馬")]
    KyushuBred,

    /// <summary>
    /// 九州産馬 (指定)
    /// </summary>
    [Description("九州産馬 (指定)")]
    Dsn_M01,

    /// <summary>
    /// 九州産馬 [指定]
    /// </summary>
    [Description("九州産馬 [指定]")]
    Des_M03,

    /// <summary>
    /// 九州産馬 (特指)
    /// </summary>
    [Description("九州産馬 (特指)")]
    Sd_M04,

    /// <summary>
    /// (国際)
    /// </summary>
    [Description("(国際)")]
    Int,

    /// <summary>
    /// (国際)(指定)
    /// </summary>
    [Description("(国際)(指定)")]
    IntDsn,

    /// <summary>
    /// (国際)[指定]
    /// </summary>
    [Description("(国際)[指定]")]
    IntDes,

    /// <summary>
    /// (国際)(特指)
    /// </summary>
    [Description("(国際)(特指)")]
    IntSd,

    /// <summary>
    /// (国際) 牝
    /// </summary>
    [Description("(国際) 牝")]
    IntFandm,

    /// <summary>
    /// (国際) 牝 (指定)
    /// </summary>
    [Description("(国際) 牝 (指定)")]
    IntFandmDsn,

    /// <summary>
    /// (国際) 牝 [指定]
    /// </summary>
    [Description("(国際) 牝 [指定]")]
    IntFandmDes,

    /// <summary>
    /// (国際) 牝 (特指)
    /// </summary>
    [Description("(国際) 牝 (特指)")]
    IntFandmSd,

    /// <summary>
    /// (国際) 牡・ｾﾝ
    /// </summary>
    [Description("(国際) 牡・ｾﾝ")]
    IntCandg,

    /// <summary>
    /// (国際) 牡・ｾﾝ (指定)
    /// </summary>
    [Description("(国際) 牡・ｾﾝ (指定)")]
    IntCandgDsn,

    /// <summary>
    /// (国際) 牡・牝
    /// </summary>
    [Description("(国際) 牡・牝")]
    IntCandf,

    /// <summary>
    /// (国際) 牡・牝 (指定)
    /// </summary>
    [Description("(国際) 牡・牝 (指定)")]
    IntCandfDsn,

    /// <summary>
    /// (国際) 牡・牝 (特指)
    /// </summary>
    [Description("(国際) 牡・牝 (特指)")]
    IntCandfSd,

}

/// <summary>
/// 競走記号コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
public record RaceSymbolInfo(
    string Code,
    string Name,
    string EnglishName
);

/// <summary>
/// 競走記号コード拡張メソッド
/// </summary>
public static class RaceSymbolCodeExtensions
{
    /// <summary>
    /// 競走記号コード情報を取得します
    /// </summary>
    public static RaceSymbolInfo GetInfo(this RaceSymbolCode code)
    {
        return code switch
        {
            RaceSymbolCode.None => new RaceSymbolInfo(
                "000",
                "記号なし　または未設定・未整備時の初期値(主に地方競馬・海外国際レースに関するデータ)",
                ""),
            RaceSymbolCode.Dsn => new RaceSymbolInfo(
                "001",
                "(指定)",
                "DSN"),
            RaceSymbolCode.ApprenticeOrYoungJockey => new RaceSymbolInfo(
                "002",
                "見習騎手 (2003年までの表記) 若手騎手 (2004年からの表記)",
                ""),
            RaceSymbolCode.Des => new RaceSymbolInfo(
                "003",
                "[指定]",
                "DES"),
            RaceSymbolCode.Sd => new RaceSymbolInfo(
                "004",
                "(特指)",
                "SD"),
            RaceSymbolCode.Fandm => new RaceSymbolInfo(
                "020",
                "牝",
                "F&M"),
            RaceSymbolCode.FandmDsn => new RaceSymbolInfo(
                "021",
                "牝 (指定)",
                "F&M DSN"),
            RaceSymbolCode.FandmDes => new RaceSymbolInfo(
                "023",
                "牝 [指定]",
                "F&M DES"),
            RaceSymbolCode.FandmSd => new RaceSymbolInfo(
                "024",
                "牝 (特指)",
                "F&M SD"),
            RaceSymbolCode.Candg => new RaceSymbolInfo(
                "030",
                "牡・ｾﾝ",
                "C･G"),
            RaceSymbolCode.CandgDsn => new RaceSymbolInfo(
                "031",
                "牡・ｾﾝ (指定)",
                "C･G DSN"),
            RaceSymbolCode.CandgDes => new RaceSymbolInfo(
                "033",
                "牡・ｾﾝ [指定]",
                "C･G DES"),
            RaceSymbolCode.CandgSd => new RaceSymbolInfo(
                "034",
                "牡・ｾﾝ (特指)",
                "C･G SD"),
            RaceSymbolCode.Candf => new RaceSymbolInfo(
                "040",
                "牡・牝",
                "C･F"),
            RaceSymbolCode.CandfDsn => new RaceSymbolInfo(
                "041",
                "牡・牝 (指定)",
                "C･F DSN"),
            RaceSymbolCode.CandfDes => new RaceSymbolInfo(
                "043",
                "牡・牝 [指定]",
                "C･F DES"),
            RaceSymbolCode.CandfSd => new RaceSymbolInfo(
                "044",
                "牡・牝 (特指)",
                "C･F SD"),
            RaceSymbolCode.Mix => new RaceSymbolInfo(
                "A00",
                "(混合)",
                "MIX"),
            RaceSymbolCode.MixDsn => new RaceSymbolInfo(
                "A01",
                "(混合)(指定)",
                "MIX DSN"),
            RaceSymbolCode.Mix_A02 => new RaceSymbolInfo(
                "A02",
                "(混合) 見習騎手 (2003年までの表記) (混合) 若手騎手 (2004年からの表記)",
                "MIX"),
            RaceSymbolCode.MixDes => new RaceSymbolInfo(
                "A03",
                "(混合)[指定]",
                "MIX DES"),
            RaceSymbolCode.MixSd => new RaceSymbolInfo(
                "A04",
                "(混合)(特指)",
                "MIX SD"),
            RaceSymbolCode.MixColt => new RaceSymbolInfo(
                "A10",
                "(混合) 牡",
                "MIX C"),
            RaceSymbolCode.MixColtDsn => new RaceSymbolInfo(
                "A11",
                "(混合) 牡 (指定)",
                "MIX C"),
            RaceSymbolCode.MixColtDes => new RaceSymbolInfo(
                "A13",
                "(混合) 牡 [指定]",
                "MIX C DES"),
            RaceSymbolCode.MixColtSd => new RaceSymbolInfo(
                "A14",
                "(混合) 牡 (特指)",
                "MIX C SD"),
            RaceSymbolCode.MixFandm => new RaceSymbolInfo(
                "A20",
                "(混合) 牝",
                "MIX F&M"),
            RaceSymbolCode.MixFandmDsn => new RaceSymbolInfo(
                "A21",
                "(混合) 牝 (指定)",
                "MIX F&M DSN"),
            RaceSymbolCode.MixFandmDes => new RaceSymbolInfo(
                "A23",
                "(混合) 牝 [指定]",
                "MIX F&M DES"),
            RaceSymbolCode.MixFandmSd => new RaceSymbolInfo(
                "A24",
                "(混合) 牝 (特指)",
                "MIX F&M SD"),
            RaceSymbolCode.MixCandg => new RaceSymbolInfo(
                "A30",
                "(混合) 牡・ｾﾝ",
                "MIX C･G"),
            RaceSymbolCode.MixCandgDsn => new RaceSymbolInfo(
                "A31",
                "(混合) 牡・ｾﾝ (指定)",
                "MIX C･G DSN"),
            RaceSymbolCode.MixCandgDes => new RaceSymbolInfo(
                "A33",
                "(混合) 牡・ｾﾝ [指定]",
                "MIX C･G DES"),
            RaceSymbolCode.MixCandgSd => new RaceSymbolInfo(
                "A34",
                "(混合) 牡・ｾﾝ (特指)",
                "MIX C･G SD"),
            RaceSymbolCode.MixCandf => new RaceSymbolInfo(
                "A40",
                "(混合) 牡・牝",
                "MIX C･F"),
            RaceSymbolCode.MixCandfDsn => new RaceSymbolInfo(
                "A41",
                "(混合) 牡・牝 (指定)",
                "MIX C･F DSN"),
            RaceSymbolCode.Sire => new RaceSymbolInfo(
                "B00",
                "(父)",
                "(D)"),
            RaceSymbolCode.DDsn => new RaceSymbolInfo(
                "B01",
                "(父)(指定)",
                "(D) DSN"),
            RaceSymbolCode.DDes => new RaceSymbolInfo(
                "B03",
                "(父)[指定]",
                "(D) DES"),
            RaceSymbolCode.DSd => new RaceSymbolInfo(
                "B04",
                "(父)(特指)",
                "(D) SD"),
            RaceSymbolCode.Market => new RaceSymbolInfo(
                "C00",
                "(市)",
                "(A)"),
            RaceSymbolCode.ADsn => new RaceSymbolInfo(
                "C01",
                "(市)(指定)",
                "(A) DSN"),
            RaceSymbolCode.ADes => new RaceSymbolInfo(
                "C03",
                "(市)[指定]",
                "(A) DES"),
            RaceSymbolCode.ASd => new RaceSymbolInfo(
                "C04",
                "(市)(特指)",
                "(A) SD"),
            RaceSymbolCode.Lottery => new RaceSymbolInfo(
                "D00",
                "(抽)",
                "(S)"),
            RaceSymbolCode.SDsn => new RaceSymbolInfo(
                "D01",
                "(抽)(指定)",
                "(S) DSN"),
            RaceSymbolCode.SDes => new RaceSymbolInfo(
                "D03",
                "(抽)[指定]",
                "(S) DES"),
            RaceSymbolCode.ArabLottery => new RaceSymbolInfo(
                "E00",
                "[抽]",
                ""),
            RaceSymbolCode.Dsn_E01 => new RaceSymbolInfo(
                "E01",
                "抽",
                "DSN"),
            RaceSymbolCode.Des_E03 => new RaceSymbolInfo(
                "E03",
                "[抽][指定]",
                "DES"),
            RaceSymbolCode.AS => new RaceSymbolInfo(
                "F00",
                "(市)(抽)",
                "(A) (S)"),
            RaceSymbolCode.ASDsn => new RaceSymbolInfo(
                "F01",
                "(市)(抽)(指定)",
                "(A) (S) DSN"),
            RaceSymbolCode.ASDes => new RaceSymbolInfo(
                "F03",
                "(市)(抽)[指定]",
                "(A) (S) DES"),
            RaceSymbolCode.ASSd => new RaceSymbolInfo(
                "F04",
                "(市)(抽)(特指)",
                "(A) (S) SD"),
            RaceSymbolCode.LotteryKansai => new RaceSymbolInfo(
                "G00",
                "(抽) 関西配布馬",
                ""),
            RaceSymbolCode.Dsn_G01 => new RaceSymbolInfo(
                "G01",
                "(抽) 関西配布馬 (指定)",
                "DSN"),
            RaceSymbolCode.Des_G03 => new RaceSymbolInfo(
                "G03",
                "(抽) 関西配布馬 [指定]",
                "DES"),
            RaceSymbolCode.LotteryKanto => new RaceSymbolInfo(
                "H00",
                "(抽) 関東配布馬",
                ""),
            RaceSymbolCode.Dsn_H01 => new RaceSymbolInfo(
                "H01",
                "(抽) 関東配布馬 (指定)",
                "DSN"),
            RaceSymbolCode.ArabLotteryKansai => new RaceSymbolInfo(
                "I00",
                "[抽] 関西配布馬",
                ""),
            RaceSymbolCode.Dsn_I01 => new RaceSymbolInfo(
                "I01",
                "[抽] 関西配布馬 (指定)",
                "DSN"),
            RaceSymbolCode.Des_I03 => new RaceSymbolInfo(
                "I03",
                "[抽] 関西配布馬 [指定]",
                "DES"),
            RaceSymbolCode.ArabLotteryKanto => new RaceSymbolInfo(
                "J00",
                "[抽] 関東配布馬",
                ""),
            RaceSymbolCode.Dsn_J01 => new RaceSymbolInfo(
                "J01",
                "[抽] 関東配布馬 (指定)",
                "DSN"),
            RaceSymbolCode.MarketLotteryKansai => new RaceSymbolInfo(
                "K00",
                "(市)(抽) 関西配布馬",
                ""),
            RaceSymbolCode.Dsn_K01 => new RaceSymbolInfo(
                "K01",
                "(市)(抽) 関西配布馬 (指定)",
                "DSN"),
            RaceSymbolCode.Des_K03 => new RaceSymbolInfo(
                "K03",
                "(市)(抽) 関西配布馬 [指定]",
                "DES"),
            RaceSymbolCode.MarketLotteryKanto => new RaceSymbolInfo(
                "L00",
                "(市)(抽) 関東配布馬",
                ""),
            RaceSymbolCode.Dsn_L01 => new RaceSymbolInfo(
                "L01",
                "(市)(抽) 関東配布馬 (指定)",
                "DSN"),
            RaceSymbolCode.Des_L03 => new RaceSymbolInfo(
                "L03",
                "(市)(抽) 関東配布馬 [指定]",
                "DES"),
            RaceSymbolCode.KyushuBred => new RaceSymbolInfo(
                "M00",
                "九州産馬",
                ""),
            RaceSymbolCode.Dsn_M01 => new RaceSymbolInfo(
                "M01",
                "九州産馬 (指定)",
                "DSN"),
            RaceSymbolCode.Des_M03 => new RaceSymbolInfo(
                "M03",
                "九州産馬 [指定]",
                "DES"),
            RaceSymbolCode.Sd_M04 => new RaceSymbolInfo(
                "M04",
                "九州産馬 (特指)",
                "SD"),
            RaceSymbolCode.Int => new RaceSymbolInfo(
                "N00",
                "(国際)",
                "INT"),
            RaceSymbolCode.IntDsn => new RaceSymbolInfo(
                "N01",
                "(国際)(指定)",
                "INT DSN"),
            RaceSymbolCode.IntDes => new RaceSymbolInfo(
                "N03",
                "(国際)[指定]",
                "INT DES"),
            RaceSymbolCode.IntSd => new RaceSymbolInfo(
                "N04",
                "(国際)(特指)",
                "INT SD"),
            RaceSymbolCode.IntFandm => new RaceSymbolInfo(
                "N20",
                "(国際) 牝",
                "INT F&M"),
            RaceSymbolCode.IntFandmDsn => new RaceSymbolInfo(
                "N21",
                "(国際) 牝 (指定)",
                "INT F&M DSN"),
            RaceSymbolCode.IntFandmDes => new RaceSymbolInfo(
                "N23",
                "(国際) 牝 [指定]",
                "INT F&M DES"),
            RaceSymbolCode.IntFandmSd => new RaceSymbolInfo(
                "N24",
                "(国際) 牝 (特指)",
                "INT F&M SD"),
            RaceSymbolCode.IntCandg => new RaceSymbolInfo(
                "N30",
                "(国際) 牡・ｾﾝ",
                "INT C･G"),
            RaceSymbolCode.IntCandgDsn => new RaceSymbolInfo(
                "N31",
                "(国際) 牡・ｾﾝ (指定)",
                "INT C･G DSN"),
            RaceSymbolCode.IntCandf => new RaceSymbolInfo(
                "N40",
                "(国際) 牡・牝",
                "INT C･F"),
            RaceSymbolCode.IntCandfDsn => new RaceSymbolInfo(
                "N41",
                "(国際) 牡・牝 (指定)",
                "INT C･F DSN"),
            RaceSymbolCode.IntCandfSd => new RaceSymbolInfo(
                "N44",
                "(国際) 牡・牝 (特指)",
                "INT C･F SD"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
