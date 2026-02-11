using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2001.競馬場コード
/// </summary>
public enum RacecourseCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 札幌競馬場
    /// </summary>
    [Description("札幌競馬場")]
    Sapporo,

    /// <summary>
    /// 函館競馬場
    /// </summary>
    [Description("函館競馬場")]
    Hakodate,

    /// <summary>
    /// 福島競馬場
    /// </summary>
    [Description("福島競馬場")]
    Fukushima,

    /// <summary>
    /// 新潟競馬場
    /// </summary>
    [Description("新潟競馬場")]
    Niigata,

    /// <summary>
    /// 東京競馬場
    /// </summary>
    [Description("東京競馬場")]
    Tokyo,

    /// <summary>
    /// 中山競馬場
    /// </summary>
    [Description("中山競馬場")]
    Nakayama,

    /// <summary>
    /// 中京競馬場
    /// </summary>
    [Description("中京競馬場")]
    Chukyo,

    /// <summary>
    /// 京都競馬場
    /// </summary>
    [Description("京都競馬場")]
    Kyoto,

    /// <summary>
    /// 阪神競馬場
    /// </summary>
    [Description("阪神競馬場")]
    Hanshin,

    /// <summary>
    /// 小倉競馬場
    /// </summary>
    [Description("小倉競馬場")]
    Kokura,

    /// <summary>
    /// 門別競馬場
    /// </summary>
    [Description("門別競馬場")]
    Monbetsu,

    /// <summary>
    /// 北見競馬場
    /// </summary>
    [Description("北見競馬場")]
    Kitami,

    /// <summary>
    /// 岩見沢競馬場
    /// </summary>
    [Description("岩見沢競馬場")]
    Iwamizawa,

    /// <summary>
    /// 帯広競馬場
    /// </summary>
    [Description("帯広競馬場")]
    Obihiro,

    /// <summary>
    /// 旭川競馬場
    /// </summary>
    [Description("旭川競馬場")]
    Asahikawa,

    /// <summary>
    /// 盛岡競馬場
    /// </summary>
    [Description("盛岡競馬場")]
    Morioka,

    /// <summary>
    /// 水沢競馬場
    /// </summary>
    [Description("水沢競馬場")]
    Mizusawa,

    /// <summary>
    /// 上山競馬場
    /// </summary>
    [Description("上山競馬場")]
    Kaminoyama,

    /// <summary>
    /// 三条競馬場
    /// </summary>
    [Description("三条競馬場")]
    Sanjyo,

    /// <summary>
    /// 足利競馬場
    /// </summary>
    [Description("足利競馬場")]
    Ashikaga,

    /// <summary>
    /// 宇都宮競馬場
    /// </summary>
    [Description("宇都宮競馬場")]
    Utsunomiya,

    /// <summary>
    /// 高崎競馬場
    /// </summary>
    [Description("高崎競馬場")]
    Takasaki,

    /// <summary>
    /// 浦和競馬場
    /// </summary>
    [Description("浦和競馬場")]
    Urawa,

    /// <summary>
    /// 船橋競馬場
    /// </summary>
    [Description("船橋競馬場")]
    Funabashi,

    /// <summary>
    /// 大井競馬場
    /// </summary>
    [Description("大井競馬場")]
    Ohi,

    /// <summary>
    /// 川崎競馬場
    /// </summary>
    [Description("川崎競馬場")]
    Kawasaki,

    /// <summary>
    /// 金沢競馬場
    /// </summary>
    [Description("金沢競馬場")]
    Kanazawa,

    /// <summary>
    /// 笠松競馬場
    /// </summary>
    [Description("笠松競馬場")]
    Kasamatsu,

    /// <summary>
    /// 名古屋競馬場
    /// </summary>
    [Description("名古屋競馬場")]
    Nagoya,

    /// <summary>
    /// 紀三井寺競馬場
    /// </summary>
    [Description("紀三井寺競馬場")]
    Kimiidera,

    /// <summary>
    /// 園田競馬場
    /// </summary>
    [Description("園田競馬場")]
    Sonoda,

    /// <summary>
    /// 姫路競馬場
    /// </summary>
    [Description("姫路競馬場")]
    Himeji,

    /// <summary>
    /// 益田競馬場
    /// </summary>
    [Description("益田競馬場")]
    Masuda,

    /// <summary>
    /// 福山競馬場
    /// </summary>
    [Description("福山競馬場")]
    Fukuyama,

    /// <summary>
    /// 高知競馬場
    /// </summary>
    [Description("高知競馬場")]
    Kochi,

    /// <summary>
    /// 佐賀競馬場
    /// </summary>
    [Description("佐賀競馬場")]
    Saga,

    /// <summary>
    /// 荒尾競馬場
    /// </summary>
    [Description("荒尾競馬場")]
    Arao,

    /// <summary>
    /// 中津競馬場
    /// </summary>
    [Description("中津競馬場")]
    Nakatsu,

    /// <summary>
    /// 札幌競馬場（地方競馬）
    /// </summary>
    [Description("札幌競馬場（地方競馬）")]
    SapporoNar,

    /// <summary>
    /// 函館競馬場（地方競馬）
    /// </summary>
    [Description("函館競馬場（地方競馬）")]
    HakodateNar,

    /// <summary>
    /// 新潟競馬場（地方競馬）
    /// </summary>
    [Description("新潟競馬場（地方競馬）")]
    NiigataNar,

    /// <summary>
    /// 中京競馬場（地方競馬）
    /// </summary>
    [Description("中京競馬場（地方競馬）")]
    ChukyoNar,

    /// <summary>
    /// その他の外国
    /// </summary>
    [Description("その他の外国")]
    OtherForeign,

    /// <summary>
    /// 日本
    /// </summary>
    [Description("日本")]
    Japan,

    /// <summary>
    /// アメリカ
    /// </summary>
    [Description("アメリカ")]
    UnitedStatesOfAmerica,

    /// <summary>
    /// イギリス
    /// </summary>
    [Description("イギリス")]
    GreatBritain,

    /// <summary>
    /// フランス
    /// </summary>
    [Description("フランス")]
    France,

    /// <summary>
    /// インド
    /// </summary>
    [Description("インド")]
    India,

    /// <summary>
    /// アイルランド
    /// </summary>
    [Description("アイルランド")]
    Ireland,

    /// <summary>
    /// ニュージーランド
    /// </summary>
    [Description("ニュージーランド")]
    NewZealand,

    /// <summary>
    /// オーストラリア
    /// </summary>
    [Description("オーストラリア")]
    Australia,

    /// <summary>
    /// カナダ
    /// </summary>
    [Description("カナダ")]
    Canada,

    /// <summary>
    /// イタリア
    /// </summary>
    [Description("イタリア")]
    Italy,

    /// <summary>
    /// ドイツ
    /// </summary>
    [Description("ドイツ")]
    Germany,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedC4,

    /// <summary>
    /// オマーン
    /// </summary>
    [Description("オマーン")]
    Oman,

    /// <summary>
    /// イラク
    /// </summary>
    [Description("イラク")]
    Iraq,

    /// <summary>
    /// アラブ首長国連邦
    /// </summary>
    [Description("アラブ首長国連邦")]
    UnitedArabEmirates,

    /// <summary>
    /// シリア
    /// </summary>
    [Description("シリア")]
    Syrian,

    /// <summary>
    /// スウェーデン
    /// </summary>
    [Description("スウェーデン")]
    Sweden,

    /// <summary>
    /// ハンガリー
    /// </summary>
    [Description("ハンガリー")]
    Hungary,

    /// <summary>
    /// ポルトガル
    /// </summary>
    [Description("ポルトガル")]
    Portugal,

    /// <summary>
    /// ロシア
    /// </summary>
    [Description("ロシア")]
    Russia,

    /// <summary>
    /// ウルグアイ
    /// </summary>
    [Description("ウルグアイ")]
    Uruguay,

    /// <summary>
    /// ペルー
    /// </summary>
    [Description("ペルー")]
    Peru,

    /// <summary>
    /// アルゼンチン
    /// </summary>
    [Description("アルゼンチン")]
    Argentina,

    /// <summary>
    /// ブラジル
    /// </summary>
    [Description("ブラジル")]
    Brazil,

    /// <summary>
    /// ベルギー
    /// </summary>
    [Description("ベルギー")]
    Belgium,

    /// <summary>
    /// トルコ
    /// </summary>
    [Description("トルコ")]
    Turkey,

    /// <summary>
    /// 韓国
    /// </summary>
    [Description("韓国")]
    Korea,

    /// <summary>
    /// 中国
    /// </summary>
    [Description("中国")]
    China,

    /// <summary>
    /// チリ
    /// </summary>
    [Description("チリ")]
    Chile,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedF4,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedF6,

    /// <summary>
    /// パナマ
    /// </summary>
    [Description("パナマ")]
    Panama,

    /// <summary>
    /// 香港
    /// </summary>
    [Description("香港")]
    HongKong,

    /// <summary>
    /// スペイン
    /// </summary>
    [Description("スペイン")]
    Spain,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedG4,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedG6,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedG8,

    /// <summary>
    /// 西ドイツ
    /// </summary>
    [Description("西ドイツ")]
    WestGermany,

    /// <summary>
    /// 南アフリカ
    /// </summary>
    [Description("南アフリカ")]
    SouthAfrica,

    /// <summary>
    /// スイス
    /// </summary>
    [Description("スイス")]
    Switzerland,

    /// <summary>
    /// モナコ
    /// </summary>
    [Description("モナコ")]
    Monaco,

    /// <summary>
    /// フィリピン
    /// </summary>
    [Description("フィリピン")]
    Philippines,

    /// <summary>
    /// プエルトリコ
    /// </summary>
    [Description("プエルトリコ")]
    PuertoRico,

    /// <summary>
    /// コロンビア
    /// </summary>
    [Description("コロンビア")]
    Colombia,

    /// <summary>
    /// チェコスロバキア
    /// </summary>
    [Description("チェコスロバキア")]
    Czechoslovakia,

    /// <summary>
    /// チェコ
    /// </summary>
    [Description("チェコ")]
    CzechRepublic,

    /// <summary>
    /// スロバキア
    /// </summary>
    [Description("スロバキア")]
    Slovakia,

    /// <summary>
    /// エクアドル
    /// </summary>
    [Description("エクアドル")]
    Ecuador,

    /// <summary>
    /// ギリシャ
    /// </summary>
    [Description("ギリシャ")]
    Greece,

    /// <summary>
    /// マレーシア
    /// </summary>
    [Description("マレーシア")]
    Malaysia,

    /// <summary>
    /// メキシコ
    /// </summary>
    [Description("メキシコ")]
    Mexico,

    /// <summary>
    /// モロッコ
    /// </summary>
    [Description("モロッコ")]
    Morocco,

    /// <summary>
    /// パキスタン
    /// </summary>
    [Description("パキスタン")]
    Pakistan,

    /// <summary>
    /// ポーランド
    /// </summary>
    [Description("ポーランド")]
    Poland,

    /// <summary>
    /// パラグアイ
    /// </summary>
    [Description("パラグアイ")]
    Paraguay,

    /// <summary>
    /// サウジアラビア
    /// </summary>
    [Description("サウジアラビア")]
    SaudiArabia,

    /// <summary>
    /// キプロス
    /// </summary>
    [Description("キプロス")]
    Cyprus,

    /// <summary>
    /// タイ
    /// </summary>
    [Description("タイ")]
    Thailand,

    /// <summary>
    /// ウクライナ
    /// </summary>
    [Description("ウクライナ")]
    Ukraine,

    /// <summary>
    /// ベネズエラ
    /// </summary>
    [Description("ベネズエラ")]
    Venezuela,

    /// <summary>
    /// ユーゴスラビア
    /// </summary>
    [Description("ユーゴスラビア")]
    Yugoslavia,

    /// <summary>
    /// デンマーク
    /// </summary>
    [Description("デンマーク")]
    Denmark,

    /// <summary>
    /// シンガポール
    /// </summary>
    [Description("シンガポール")]
    Singapore,

    /// <summary>
    /// マカオ
    /// </summary>
    [Description("マカオ")]
    Macau,

    /// <summary>
    /// オーストリア
    /// </summary>
    [Description("オーストリア")]
    Austria,

    /// <summary>
    /// ヨルダン
    /// </summary>
    [Description("ヨルダン")]
    Jordan,

    /// <summary>
    /// カタール
    /// </summary>
    [Description("カタール")]
    Qatar,

    /// <summary>
    /// 東ドイツ
    /// </summary>
    [Description("東ドイツ")]
    EastGermany,

    /// <summary>
    /// バーレーン
    /// </summary>
    [Description("バーレーン")]
    Bahrain,

    /// <summary>
    /// カザフスタン
    /// </summary>
    [Description("カザフスタン")]
    Kazakhstan,

    /// <summary>
    /// モーリシャス
    /// </summary>
    [Description("モーリシャス")]
    Mauritius,

}

/// <summary>
/// 競馬場コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="Abbr1">略名(1文字)</param>
/// <param name="Abbr2">略名(2文字)</param>
/// <param name="Abbr3">略名(3文字)</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="EnglishAbbr3">欧字略名(3文字)</param>
public record RacecourseInfo(
    string Code,
    string Name,
    string Abbr1,
    string Abbr2,
    string Abbr3,
    string EnglishName,
    string EnglishAbbr3
);

/// <summary>
/// 競馬場コード拡張メソッド
/// </summary>
public static class RacecourseCodeExtensions
{
    /// <summary>
    /// 競馬場コード情報を取得します
    /// </summary>
    public static RacecourseInfo GetInfo(this RacecourseCode code)
    {
        return code switch
        {
            RacecourseCode.None => new RacecourseInfo(
                "00",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                "",
                "",
                "",
                ""),
            RacecourseCode.Sapporo => new RacecourseInfo(
                "01",
                "札幌競馬場",
                "札",
                "札幌",
                "札幌",
                "SAPPORO",
                ""),
            RacecourseCode.Hakodate => new RacecourseInfo(
                "02",
                "函館競馬場",
                "函",
                "函館",
                "函館",
                "HAKODATE",
                ""),
            RacecourseCode.Fukushima => new RacecourseInfo(
                "03",
                "福島競馬場",
                "福",
                "福島",
                "福島",
                "FUKUSHIMA",
                ""),
            RacecourseCode.Niigata => new RacecourseInfo(
                "04",
                "新潟競馬場",
                "新",
                "新潟",
                "新潟",
                "NIIGATA",
                ""),
            RacecourseCode.Tokyo => new RacecourseInfo(
                "05",
                "東京競馬場",
                "東",
                "東京",
                "東京",
                "TOKYO",
                ""),
            RacecourseCode.Nakayama => new RacecourseInfo(
                "06",
                "中山競馬場",
                "中",
                "中山",
                "中山",
                "NAKAYAMA",
                ""),
            RacecourseCode.Chukyo => new RacecourseInfo(
                "07",
                "中京競馬場",
                "名",
                "中京",
                "中京",
                "CHUKYO",
                ""),
            RacecourseCode.Kyoto => new RacecourseInfo(
                "08",
                "京都競馬場",
                "京",
                "京都",
                "京都",
                "KYOTO",
                ""),
            RacecourseCode.Hanshin => new RacecourseInfo(
                "09",
                "阪神競馬場",
                "阪",
                "阪神",
                "阪神",
                "HANSHIN",
                ""),
            RacecourseCode.Kokura => new RacecourseInfo(
                "10",
                "小倉競馬場",
                "小",
                "小倉",
                "小倉",
                "KOKURA",
                ""),
            RacecourseCode.Monbetsu => new RacecourseInfo(
                "30",
                "門別競馬場",
                "門",
                "門別",
                "門別",
                "MONBETSU",
                ""),
            RacecourseCode.Kitami => new RacecourseInfo(
                "31",
                "北見競馬場",
                "北",
                "北見",
                "北見",
                "KITAMI",
                ""),
            RacecourseCode.Iwamizawa => new RacecourseInfo(
                "32",
                "岩見沢競馬場",
                "岩",
                "岩見",
                "岩見沢",
                "IWAMIZAWA",
                ""),
            RacecourseCode.Obihiro => new RacecourseInfo(
                "33",
                "帯広競馬場",
                "帯",
                "帯広",
                "帯広",
                "OBIHIRO",
                ""),
            RacecourseCode.Asahikawa => new RacecourseInfo(
                "34",
                "旭川競馬場",
                "旭",
                "旭川",
                "旭川",
                "ASAHIKAWA",
                ""),
            RacecourseCode.Morioka => new RacecourseInfo(
                "35",
                "盛岡競馬場",
                "盛",
                "盛岡",
                "盛岡",
                "MORIOKA",
                ""),
            RacecourseCode.Mizusawa => new RacecourseInfo(
                "36",
                "水沢競馬場",
                "水",
                "水沢",
                "水沢",
                "MIZUSAWA",
                ""),
            RacecourseCode.Kaminoyama => new RacecourseInfo(
                "37",
                "上山競馬場",
                "上",
                "上山",
                "上山",
                "KAMINOYAMA",
                ""),
            RacecourseCode.Sanjyo => new RacecourseInfo(
                "38",
                "三条競馬場",
                "三",
                "三条",
                "三条",
                "SANJYO",
                ""),
            RacecourseCode.Ashikaga => new RacecourseInfo(
                "39",
                "足利競馬場",
                "足",
                "足利",
                "足利",
                "ASHIKAGA",
                ""),
            RacecourseCode.Utsunomiya => new RacecourseInfo(
                "40",
                "宇都宮競馬場",
                "宇",
                "宇都",
                "宇都宮",
                "UTSUNOMIYA",
                ""),
            RacecourseCode.Takasaki => new RacecourseInfo(
                "41",
                "高崎競馬場",
                "高",
                "高崎",
                "高崎",
                "TAKASAKI",
                ""),
            RacecourseCode.Urawa => new RacecourseInfo(
                "42",
                "浦和競馬場",
                "浦",
                "浦和",
                "浦和",
                "URAWA",
                ""),
            RacecourseCode.Funabashi => new RacecourseInfo(
                "43",
                "船橋競馬場",
                "船",
                "船橋",
                "船橋",
                "FUNABASHI",
                ""),
            RacecourseCode.Ohi => new RacecourseInfo(
                "44",
                "大井競馬場",
                "大",
                "大井",
                "大井",
                "OHI",
                ""),
            RacecourseCode.Kawasaki => new RacecourseInfo(
                "45",
                "川崎競馬場",
                "川",
                "川崎",
                "川崎",
                "KAWASAKI",
                ""),
            RacecourseCode.Kanazawa => new RacecourseInfo(
                "46",
                "金沢競馬場",
                "金",
                "金沢",
                "金沢",
                "KANAZAWA",
                ""),
            RacecourseCode.Kasamatsu => new RacecourseInfo(
                "47",
                "笠松競馬場",
                "笠",
                "笠松",
                "笠松",
                "KASAMATSU",
                ""),
            RacecourseCode.Nagoya => new RacecourseInfo(
                "48",
                "名古屋競馬場",
                "古",
                "名古",
                "名古屋",
                "NAGOYA",
                ""),
            RacecourseCode.Kimiidera => new RacecourseInfo(
                "49",
                "紀三井寺競馬場",
                "紀",
                "紀三",
                "紀三寺",
                "KIMIIDERA",
                ""),
            RacecourseCode.Sonoda => new RacecourseInfo(
                "50",
                "園田競馬場",
                "園",
                "園田",
                "園田",
                "SONODA",
                ""),
            RacecourseCode.Himeji => new RacecourseInfo(
                "51",
                "姫路競馬場",
                "姫",
                "姫路",
                "姫路",
                "HIMEJI",
                ""),
            RacecourseCode.Masuda => new RacecourseInfo(
                "52",
                "益田競馬場",
                "益",
                "益田",
                "益田",
                "MASUDA",
                ""),
            RacecourseCode.Fukuyama => new RacecourseInfo(
                "53",
                "福山競馬場",
                "福",
                "福山",
                "福山",
                "FUKUYAMA",
                ""),
            RacecourseCode.Kochi => new RacecourseInfo(
                "54",
                "高知競馬場",
                "高",
                "高知",
                "高知",
                "KOCHI",
                ""),
            RacecourseCode.Saga => new RacecourseInfo(
                "55",
                "佐賀競馬場",
                "佐",
                "佐賀",
                "佐賀",
                "SAGA",
                ""),
            RacecourseCode.Arao => new RacecourseInfo(
                "56",
                "荒尾競馬場",
                "荒",
                "荒尾",
                "荒尾",
                "ARAO",
                ""),
            RacecourseCode.Nakatsu => new RacecourseInfo(
                "57",
                "中津競馬場",
                "中",
                "中津",
                "中津",
                "NAKATSU",
                ""),
            RacecourseCode.SapporoNar => new RacecourseInfo(
                "58",
                "札幌競馬場（地方競馬）",
                "札",
                "札幌",
                "札幌",
                "SAPPORO(NAR)",
                ""),
            RacecourseCode.HakodateNar => new RacecourseInfo(
                "59",
                "函館競馬場（地方競馬）",
                "函",
                "函館",
                "函館",
                "HAKODATE(NAR)",
                ""),
            RacecourseCode.NiigataNar => new RacecourseInfo(
                "60",
                "新潟競馬場（地方競馬）",
                "新",
                "新潟",
                "新潟",
                "NIIGATA(NAR)",
                ""),
            RacecourseCode.ChukyoNar => new RacecourseInfo(
                "61",
                "中京競馬場（地方競馬）",
                "名",
                "中京",
                "中京",
                "CHUKYO(NAR)",
                ""),
            RacecourseCode.OtherForeign => new RacecourseInfo(
                "A0",
                "その他の外国",
                "外",
                "他外",
                "他外国",
                "",
                ""),
            RacecourseCode.Japan => new RacecourseInfo(
                "A2",
                "日本",
                "日",
                "日本",
                "日本",
                "Japan",
                "JPN"),
            RacecourseCode.UnitedStatesOfAmerica => new RacecourseInfo(
                "A4",
                "アメリカ",
                "米",
                "アメ",
                "アメリ",
                "United States of America",
                "USA"),
            RacecourseCode.GreatBritain => new RacecourseInfo(
                "A6",
                "イギリス",
                "英",
                "イギ",
                "イギリ",
                "Great Britain",
                "GB"),
            RacecourseCode.France => new RacecourseInfo(
                "A8",
                "フランス",
                "仏",
                "フラ",
                "フラン",
                "France",
                "FR"),
            RacecourseCode.India => new RacecourseInfo(
                "B0",
                "インド",
                "印",
                "イン",
                "インド",
                "India",
                "IND"),
            RacecourseCode.Ireland => new RacecourseInfo(
                "B2",
                "アイルランド",
                "愛",
                "アイ",
                "アイル",
                "Ireland",
                "IRE"),
            RacecourseCode.NewZealand => new RacecourseInfo(
                "B4",
                "ニュージーランド",
                "新",
                "ニュ",
                "ニュー",
                "New Zealand",
                "NZ"),
            RacecourseCode.Australia => new RacecourseInfo(
                "B6",
                "オーストラリア",
                "豪",
                "オー",
                "オース",
                "Australia",
                "AUS"),
            RacecourseCode.Canada => new RacecourseInfo(
                "B8",
                "カナダ",
                "加",
                "カナ",
                "カナダ",
                "Canada",
                "CAN"),
            RacecourseCode.Italy => new RacecourseInfo(
                "C0",
                "イタリア",
                "伊",
                "イタ",
                "イタリ",
                "Italy",
                "ITY"),
            RacecourseCode.Germany => new RacecourseInfo(
                "C2",
                "ドイツ",
                "独",
                "ドイ",
                "ドイツ",
                "Germany",
                "GER"),
            RacecourseCode.UnusedC4 => new RacecourseInfo(
                "C4",
                "(未使用)",
                "",
                "",
                "",
                "",
                ""),
            RacecourseCode.Oman => new RacecourseInfo(
                "C5",
                "オマーン",
                "オ",
                "オマ",
                "オマー",
                "Oman",
                "OMN"),
            RacecourseCode.Iraq => new RacecourseInfo(
                "C6",
                "イラク",
                "イ",
                "イラ",
                "イラク",
                "Iraq",
                "IRQ"),
            RacecourseCode.UnitedArabEmirates => new RacecourseInfo(
                "C7",
                "アラブ首長国連邦",
                "首",
                "(ア)",
                "ア首",
                "アラブ",
                "United Arab Emirates"),
            RacecourseCode.Syrian => new RacecourseInfo(
                "C8",
                "シリア",
                "叙",
                "シリ",
                "シリア",
                "Syrian",
                "SYR"),
            RacecourseCode.Sweden => new RacecourseInfo(
                "D0",
                "スウェーデン",
                "瑞",
                "スウ",
                "スウェ",
                "Sweden",
                "SWE"),
            RacecourseCode.Hungary => new RacecourseInfo(
                "D2",
                "ハンガリー",
                "洪",
                "ハン",
                "ハンガ",
                "Hungary",
                "HUN"),
            RacecourseCode.Portugal => new RacecourseInfo(
                "D4",
                "ポルトガル",
                "葡",
                "ポル",
                "ポルト",
                "Portugal",
                "POR"),
            RacecourseCode.Russia => new RacecourseInfo(
                "D6",
                "ロシア",
                "露",
                "ロシ",
                "ロシア",
                "Russia",
                "RUS"),
            RacecourseCode.Uruguay => new RacecourseInfo(
                "D8",
                "ウルグアイ",
                "宇",
                "ウル",
                "ウルグ",
                "Uruguay",
                "URU"),
            RacecourseCode.Peru => new RacecourseInfo(
                "E0",
                "ペルー",
                "秘",
                "ペル",
                "ペルー",
                "Peru",
                "PER"),
            RacecourseCode.Argentina => new RacecourseInfo(
                "E2",
                "アルゼンチン",
                "亜",
                "アル",
                "アルゼ",
                "Argentina",
                "ARG"),
            RacecourseCode.Brazil => new RacecourseInfo(
                "E4",
                "ブラジル",
                "伯",
                "ブラ",
                "ブラジ",
                "Brazil",
                "BRZ"),
            RacecourseCode.Belgium => new RacecourseInfo(
                "E6",
                "ベルギー",
                "白",
                "ベル",
                "ベルギ",
                "Belgium",
                "BEL"),
            RacecourseCode.Turkey => new RacecourseInfo(
                "E8",
                "トルコ",
                "土",
                "トル",
                "トルコ",
                "Turkey",
                "TUR"),
            RacecourseCode.Korea => new RacecourseInfo(
                "F0",
                "韓国",
                "韓",
                "韓国",
                "韓国",
                "Korea",
                "KOR"),
            RacecourseCode.China => new RacecourseInfo(
                "F1",
                "中国",
                "中",
                "中国",
                "中国",
                "China",
                "CHN"),
            RacecourseCode.Chile => new RacecourseInfo(
                "F2",
                "チリ",
                "智",
                "チリ",
                "チリ",
                "Chile",
                "CHI"),
            RacecourseCode.UnusedF4 => new RacecourseInfo(
                "F4",
                "(未使用)",
                "",
                "",
                "",
                "",
                ""),
            RacecourseCode.UnusedF6 => new RacecourseInfo(
                "F6",
                "(未使用)",
                "",
                "",
                "",
                "",
                ""),
            RacecourseCode.Panama => new RacecourseInfo(
                "F8",
                "パナマ",
                "巴",
                "パナ",
                "パナマ",
                "Panama",
                "PAN"),
            RacecourseCode.HongKong => new RacecourseInfo(
                "G0",
                "香港",
                "香",
                "香港",
                "香港",
                "Hong Kong",
                "HK"),
            RacecourseCode.Spain => new RacecourseInfo(
                "G2",
                "スペイン",
                "西",
                "スペ",
                "スペイ",
                "Spain",
                "SPA"),
            RacecourseCode.UnusedG4 => new RacecourseInfo(
                "G4",
                "(未使用)",
                "",
                "",
                "",
                "",
                ""),
            RacecourseCode.UnusedG6 => new RacecourseInfo(
                "G6",
                "(未使用)",
                "",
                "",
                "",
                "",
                ""),
            RacecourseCode.UnusedG8 => new RacecourseInfo(
                "G8",
                "(未使用)",
                "",
                "",
                "",
                "",
                ""),
            RacecourseCode.WestGermany => new RacecourseInfo(
                "H0",
                "西ドイツ",
                "独",
                "西独",
                "西独",
                "West Germany",
                "GER"),
            RacecourseCode.SouthAfrica => new RacecourseInfo(
                "H2",
                "南アフリカ",
                "南",
                "(阿)",
                "南ア",
                "南アフ",
                "South Africa"),
            RacecourseCode.Switzerland => new RacecourseInfo(
                "H4",
                "スイス",
                "ス",
                "スイ",
                "スイス",
                "Switzerland",
                "SWI"),
            RacecourseCode.Monaco => new RacecourseInfo(
                "H6",
                "モナコ",
                "モ",
                "モナ",
                "モナコ",
                "Monaco",
                "MCO"),
            RacecourseCode.Philippines => new RacecourseInfo(
                "H8",
                "フィリピン",
                "比",
                "フィ",
                "フィリ",
                "Philippines",
                "PHI"),
            RacecourseCode.PuertoRico => new RacecourseInfo(
                "I0",
                "プエルトリコ",
                "プ",
                "プエ",
                "プエル",
                "Puerto Rico",
                "PUE"),
            RacecourseCode.Colombia => new RacecourseInfo(
                "I2",
                "コロンビア",
                "コ",
                "コロ",
                "コロン",
                "Colombia",
                "COL"),
            RacecourseCode.Czechoslovakia => new RacecourseInfo(
                "I4",
                "チェコスロバキア",
                "チ",
                "チェ",
                "チェコ",
                "Czechoslovakia",
                "CZE"),
            RacecourseCode.CzechRepublic => new RacecourseInfo(
                "I6",
                "チェコ",
                "チ",
                "チェ",
                "チェコ",
                "Czech Republic",
                "CZE"),
            RacecourseCode.Slovakia => new RacecourseInfo(
                "I8",
                "スロバキア",
                "ス",
                "スロ",
                "スロバ",
                "Slovakia",
                "SLO"),
            RacecourseCode.Ecuador => new RacecourseInfo(
                "J0",
                "エクアドル",
                "エ",
                "エク",
                "エクア",
                "Ecuador",
                "ECU"),
            RacecourseCode.Greece => new RacecourseInfo(
                "J2",
                "ギリシャ",
                "ギ",
                "ギリ",
                "ギリシ",
                "Greece",
                "GR"),
            RacecourseCode.Malaysia => new RacecourseInfo(
                "J4",
                "マレーシア",
                "馬",
                "マレ",
                "マレー",
                "Malaysia",
                "MAL"),
            RacecourseCode.Mexico => new RacecourseInfo(
                "J6",
                "メキシコ",
                "墨",
                "メキ",
                "メキシ",
                "Mexico",
                "MEX"),
            RacecourseCode.Morocco => new RacecourseInfo(
                "J8",
                "モロッコ",
                "摩",
                "モロ",
                "モロッ",
                "Morocco",
                "MOR"),
            RacecourseCode.Pakistan => new RacecourseInfo(
                "K0",
                "パキスタン",
                "基",
                "パキ",
                "パキス",
                "Pakistan",
                "PAK"),
            RacecourseCode.Poland => new RacecourseInfo(
                "K2",
                "ポーランド",
                "波",
                "ポー",
                "ポーラ",
                "Poland",
                "POL"),
            RacecourseCode.Paraguay => new RacecourseInfo(
                "K4",
                "パラグアイ",
                "拉",
                "パラ",
                "パラグ",
                "Paraguay",
                "PRY"),
            RacecourseCode.SaudiArabia => new RacecourseInfo(
                "K6",
                "サウジアラビア",
                "サ",
                "サウ",
                "サウジ",
                "Saudi Arabia",
                "SDA"),
            RacecourseCode.Cyprus => new RacecourseInfo(
                "K8",
                "キプロス",
                "キ",
                "キプ",
                "キプロ",
                "Cyprus",
                "CYP"),
            RacecourseCode.Thailand => new RacecourseInfo(
                "L0",
                "タイ",
                "泰",
                "タイ",
                "タイ",
                "Thailand",
                "THA"),
            RacecourseCode.Ukraine => new RacecourseInfo(
                "L2",
                "ウクライナ",
                "烏",
                "ウク",
                "ウクラ",
                "Ukraine",
                "UKR"),
            RacecourseCode.Venezuela => new RacecourseInfo(
                "L4",
                "ベネズエラ",
                "ベ",
                "ベネ",
                "ベネゼ",
                "Venezuela",
                "VEN"),
            RacecourseCode.Yugoslavia => new RacecourseInfo(
                "L6",
                "ユーゴスラビア",
                "ユ",
                "ユー",
                "ユーゴ",
                "Yugoslavia",
                "YUG"),
            RacecourseCode.Denmark => new RacecourseInfo(
                "L8",
                "デンマーク",
                "丁",
                "デン",
                "デンマ",
                "Denmark",
                "DEN"),
            RacecourseCode.Singapore => new RacecourseInfo(
                "M0",
                "シンガポール",
                "嘉",
                "シン",
                "シンガ",
                "Singapore",
                "SIN"),
            RacecourseCode.Macau => new RacecourseInfo(
                "M2",
                "マカオ",
                "澳",
                "澳門",
                "マカオ",
                "Macau",
                "MAC"),
            RacecourseCode.Austria => new RacecourseInfo(
                "M4",
                "オーストリア",
                "墺",
                "墺",
                "墺国",
                "Austria",
                "AUT"),
            RacecourseCode.Jordan => new RacecourseInfo(
                "M6",
                "ヨルダン",
                "約",
                "約",
                "ヨルダ",
                "Jordan",
                "JOR"),
            RacecourseCode.Qatar => new RacecourseInfo(
                "M8",
                "カタール",
                "華",
                "華",
                "カタル",
                "Qatar",
                "QAT"),
            RacecourseCode.EastGermany => new RacecourseInfo(
                "N0",
                "東ドイツ",
                "独",
                "東独",
                "東独",
                "East Germany",
                "GER"),
            RacecourseCode.Bahrain => new RacecourseInfo(
                "N2",
                "バーレーン",
                "巴",
                "巴林",
                "バーレ",
                "Bahrain",
                "BHR"),
            RacecourseCode.Kazakhstan => new RacecourseInfo(
                "N4",
                "カザフスタン",
                "カ",
                "カザ",
                "カザフ",
                "Kazakhstan",
                "KAZ"),
            RacecourseCode.Mauritius => new RacecourseInfo(
                "N6",
                "モーリシャス",
                "毛",
                "毛里",
                "モーリ",
                "Mauritius",
                "MUS"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
