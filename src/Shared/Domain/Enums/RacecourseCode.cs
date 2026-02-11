using System.ComponentModel;

namespace JRA_VAN.Shared.Domain.Enums;

/// <summary>
/// 2001.競馬場コード
/// </summary>
public enum RacecourseCode : ushort
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None = 0x3030,

    /// <summary>
    /// 札幌競馬場
    /// </summary>
    [Description("札幌競馬場")]
    Sapporo = 0x3031,

    /// <summary>
    /// 函館競馬場
    /// </summary>
    [Description("函館競馬場")]
    Hakodate = 0x3032,

    /// <summary>
    /// 福島競馬場
    /// </summary>
    [Description("福島競馬場")]
    Fukushima = 0x3033,

    /// <summary>
    /// 新潟競馬場
    /// </summary>
    [Description("新潟競馬場")]
    Niigata = 0x3034,

    /// <summary>
    /// 東京競馬場
    /// </summary>
    [Description("東京競馬場")]
    Tokyo = 0x3035,

    /// <summary>
    /// 中山競馬場
    /// </summary>
    [Description("中山競馬場")]
    Nakayama = 0x3036,

    /// <summary>
    /// 中京競馬場
    /// </summary>
    [Description("中京競馬場")]
    Chukyo = 0x3037,

    /// <summary>
    /// 京都競馬場
    /// </summary>
    [Description("京都競馬場")]
    Kyoto = 0x3038,

    /// <summary>
    /// 阪神競馬場
    /// </summary>
    [Description("阪神競馬場")]
    Hanshin = 0x3039,

    /// <summary>
    /// 小倉競馬場
    /// </summary>
    [Description("小倉競馬場")]
    Kokura = 0x3130,

    /// <summary>
    /// 門別競馬場
    /// </summary>
    [Description("門別競馬場")]
    Monbetsu = 0x3330,

    /// <summary>
    /// 北見競馬場
    /// </summary>
    [Description("北見競馬場")]
    Kitami = 0x3331,

    /// <summary>
    /// 岩見沢競馬場
    /// </summary>
    [Description("岩見沢競馬場")]
    Iwamizawa = 0x3332,

    /// <summary>
    /// 帯広競馬場
    /// </summary>
    [Description("帯広競馬場")]
    Obihiro = 0x3333,

    /// <summary>
    /// 旭川競馬場
    /// </summary>
    [Description("旭川競馬場")]
    Asahikawa = 0x3334,

    /// <summary>
    /// 盛岡競馬場
    /// </summary>
    [Description("盛岡競馬場")]
    Morioka = 0x3335,

    /// <summary>
    /// 水沢競馬場
    /// </summary>
    [Description("水沢競馬場")]
    Mizusawa = 0x3336,

    /// <summary>
    /// 上山競馬場
    /// </summary>
    [Description("上山競馬場")]
    Kaminoyama = 0x3337,

    /// <summary>
    /// 三条競馬場
    /// </summary>
    [Description("三条競馬場")]
    Sanjyo = 0x3338,

    /// <summary>
    /// 足利競馬場
    /// </summary>
    [Description("足利競馬場")]
    Ashikaga = 0x3339,

    /// <summary>
    /// 宇都宮競馬場
    /// </summary>
    [Description("宇都宮競馬場")]
    Utsunomiya = 0x3430,

    /// <summary>
    /// 高崎競馬場
    /// </summary>
    [Description("高崎競馬場")]
    Takasaki = 0x3431,

    /// <summary>
    /// 浦和競馬場
    /// </summary>
    [Description("浦和競馬場")]
    Urawa = 0x3432,

    /// <summary>
    /// 船橋競馬場
    /// </summary>
    [Description("船橋競馬場")]
    Funabashi = 0x3433,

    /// <summary>
    /// 大井競馬場
    /// </summary>
    [Description("大井競馬場")]
    Ohi = 0x3434,

    /// <summary>
    /// 川崎競馬場
    /// </summary>
    [Description("川崎競馬場")]
    Kawasaki = 0x3435,

    /// <summary>
    /// 金沢競馬場
    /// </summary>
    [Description("金沢競馬場")]
    Kanazawa = 0x3436,

    /// <summary>
    /// 笠松競馬場
    /// </summary>
    [Description("笠松競馬場")]
    Kasamatsu = 0x3437,

    /// <summary>
    /// 名古屋競馬場
    /// </summary>
    [Description("名古屋競馬場")]
    Nagoya = 0x3438,

    /// <summary>
    /// 紀三井寺競馬場
    /// </summary>
    [Description("紀三井寺競馬場")]
    Kimiidera = 0x3439,

    /// <summary>
    /// 園田競馬場
    /// </summary>
    [Description("園田競馬場")]
    Sonoda = 0x3530,

    /// <summary>
    /// 姫路競馬場
    /// </summary>
    [Description("姫路競馬場")]
    Himeji = 0x3531,

    /// <summary>
    /// 益田競馬場
    /// </summary>
    [Description("益田競馬場")]
    Masuda = 0x3532,

    /// <summary>
    /// 福山競馬場
    /// </summary>
    [Description("福山競馬場")]
    Fukuyama = 0x3533,

    /// <summary>
    /// 高知競馬場
    /// </summary>
    [Description("高知競馬場")]
    Kochi = 0x3534,

    /// <summary>
    /// 佐賀競馬場
    /// </summary>
    [Description("佐賀競馬場")]
    Saga = 0x3535,

    /// <summary>
    /// 荒尾競馬場
    /// </summary>
    [Description("荒尾競馬場")]
    Arao = 0x3536,

    /// <summary>
    /// 中津競馬場
    /// </summary>
    [Description("中津競馬場")]
    Nakatsu = 0x3537,

    /// <summary>
    /// 札幌競馬場（地方競馬）
    /// </summary>
    [Description("札幌競馬場（地方競馬）")]
    SapporoNar = 0x3538,

    /// <summary>
    /// 函館競馬場（地方競馬）
    /// </summary>
    [Description("函館競馬場（地方競馬）")]
    HakodateNar = 0x3539,

    /// <summary>
    /// 新潟競馬場（地方競馬）
    /// </summary>
    [Description("新潟競馬場（地方競馬）")]
    NiigataNar = 0x3630,

    /// <summary>
    /// 中京競馬場（地方競馬）
    /// </summary>
    [Description("中京競馬場（地方競馬）")]
    ChukyoNar = 0x3631,

    /// <summary>
    /// その他の外国
    /// </summary>
    [Description("その他の外国")]
    OtherForeign = 0x4130,

    /// <summary>
    /// 日本
    /// </summary>
    [Description("日本")]
    Japan = 0x4132,

    /// <summary>
    /// アメリカ
    /// </summary>
    [Description("アメリカ")]
    UnitedStatesOfAmerica = 0x4134,

    /// <summary>
    /// イギリス
    /// </summary>
    [Description("イギリス")]
    GreatBritain = 0x4136,

    /// <summary>
    /// フランス
    /// </summary>
    [Description("フランス")]
    France = 0x4138,

    /// <summary>
    /// インド
    /// </summary>
    [Description("インド")]
    India = 0x4230,

    /// <summary>
    /// アイルランド
    /// </summary>
    [Description("アイルランド")]
    Ireland = 0x4232,

    /// <summary>
    /// ニュージーランド
    /// </summary>
    [Description("ニュージーランド")]
    NewZealand = 0x4234,

    /// <summary>
    /// オーストラリア
    /// </summary>
    [Description("オーストラリア")]
    Australia = 0x4236,

    /// <summary>
    /// カナダ
    /// </summary>
    [Description("カナダ")]
    Canada = 0x4238,

    /// <summary>
    /// イタリア
    /// </summary>
    [Description("イタリア")]
    Italy = 0x4330,

    /// <summary>
    /// ドイツ
    /// </summary>
    [Description("ドイツ")]
    Germany = 0x4332,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedC4 = 0x4334,

    /// <summary>
    /// オマーン
    /// </summary>
    [Description("オマーン")]
    Oman = 0x4335,

    /// <summary>
    /// イラク
    /// </summary>
    [Description("イラク")]
    Iraq = 0x4336,

    /// <summary>
    /// アラブ首長国連邦
    /// </summary>
    [Description("アラブ首長国連邦")]
    UnitedArabEmirates = 0x4337,

    /// <summary>
    /// シリア
    /// </summary>
    [Description("シリア")]
    Syrian = 0x4338,

    /// <summary>
    /// スウェーデン
    /// </summary>
    [Description("スウェーデン")]
    Sweden = 0x4430,

    /// <summary>
    /// ハンガリー
    /// </summary>
    [Description("ハンガリー")]
    Hungary = 0x4432,

    /// <summary>
    /// ポルトガル
    /// </summary>
    [Description("ポルトガル")]
    Portugal = 0x4434,

    /// <summary>
    /// ロシア
    /// </summary>
    [Description("ロシア")]
    Russia = 0x4436,

    /// <summary>
    /// ウルグアイ
    /// </summary>
    [Description("ウルグアイ")]
    Uruguay = 0x4438,

    /// <summary>
    /// ペルー
    /// </summary>
    [Description("ペルー")]
    Peru = 0x4530,

    /// <summary>
    /// アルゼンチン
    /// </summary>
    [Description("アルゼンチン")]
    Argentina = 0x4532,

    /// <summary>
    /// ブラジル
    /// </summary>
    [Description("ブラジル")]
    Brazil = 0x4534,

    /// <summary>
    /// ベルギー
    /// </summary>
    [Description("ベルギー")]
    Belgium = 0x4536,

    /// <summary>
    /// トルコ
    /// </summary>
    [Description("トルコ")]
    Turkey = 0x4538,

    /// <summary>
    /// 韓国
    /// </summary>
    [Description("韓国")]
    Korea = 0x4630,

    /// <summary>
    /// 中国
    /// </summary>
    [Description("中国")]
    China = 0x4631,

    /// <summary>
    /// チリ
    /// </summary>
    [Description("チリ")]
    Chile = 0x4632,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedF4 = 0x4634,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedF6 = 0x4636,

    /// <summary>
    /// パナマ
    /// </summary>
    [Description("パナマ")]
    Panama = 0x4638,

    /// <summary>
    /// 香港
    /// </summary>
    [Description("香港")]
    HongKong = 0x4730,

    /// <summary>
    /// スペイン
    /// </summary>
    [Description("スペイン")]
    Spain = 0x4732,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedG4 = 0x4734,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedG6 = 0x4736,

    /// <summary>
    /// (未使用)
    /// </summary>
    [Description("(未使用)")]
    UnusedG8 = 0x4738,

    /// <summary>
    /// 西ドイツ
    /// </summary>
    [Description("西ドイツ")]
    WestGermany = 0x4830,

    /// <summary>
    /// 南アフリカ
    /// </summary>
    [Description("南アフリカ")]
    SouthAfrica = 0x4832,

    /// <summary>
    /// スイス
    /// </summary>
    [Description("スイス")]
    Switzerland = 0x4834,

    /// <summary>
    /// モナコ
    /// </summary>
    [Description("モナコ")]
    Monaco = 0x4836,

    /// <summary>
    /// フィリピン
    /// </summary>
    [Description("フィリピン")]
    Philippines = 0x4838,

    /// <summary>
    /// プエルトリコ
    /// </summary>
    [Description("プエルトリコ")]
    PuertoRico = 0x4930,

    /// <summary>
    /// コロンビア
    /// </summary>
    [Description("コロンビア")]
    Colombia = 0x4932,

    /// <summary>
    /// チェコスロバキア
    /// </summary>
    [Description("チェコスロバキア")]
    Czechoslovakia = 0x4934,

    /// <summary>
    /// チェコ
    /// </summary>
    [Description("チェコ")]
    CzechRepublic = 0x4936,

    /// <summary>
    /// スロバキア
    /// </summary>
    [Description("スロバキア")]
    Slovakia = 0x4938,

    /// <summary>
    /// エクアドル
    /// </summary>
    [Description("エクアドル")]
    Ecuador = 0x4A30,

    /// <summary>
    /// ギリシャ
    /// </summary>
    [Description("ギリシャ")]
    Greece = 0x4A32,

    /// <summary>
    /// マレーシア
    /// </summary>
    [Description("マレーシア")]
    Malaysia = 0x4A34,

    /// <summary>
    /// メキシコ
    /// </summary>
    [Description("メキシコ")]
    Mexico = 0x4A36,

    /// <summary>
    /// モロッコ
    /// </summary>
    [Description("モロッコ")]
    Morocco = 0x4A38,

    /// <summary>
    /// パキスタン
    /// </summary>
    [Description("パキスタン")]
    Pakistan = 0x4B30,

    /// <summary>
    /// ポーランド
    /// </summary>
    [Description("ポーランド")]
    Poland = 0x4B32,

    /// <summary>
    /// パラグアイ
    /// </summary>
    [Description("パラグアイ")]
    Paraguay = 0x4B34,

    /// <summary>
    /// サウジアラビア
    /// </summary>
    [Description("サウジアラビア")]
    SaudiArabia = 0x4B36,

    /// <summary>
    /// キプロス
    /// </summary>
    [Description("キプロス")]
    Cyprus = 0x4B38,

    /// <summary>
    /// タイ
    /// </summary>
    [Description("タイ")]
    Thailand = 0x4C30,

    /// <summary>
    /// ウクライナ
    /// </summary>
    [Description("ウクライナ")]
    Ukraine = 0x4C32,

    /// <summary>
    /// ベネズエラ
    /// </summary>
    [Description("ベネズエラ")]
    Venezuela = 0x4C34,

    /// <summary>
    /// ユーゴスラビア
    /// </summary>
    [Description("ユーゴスラビア")]
    Yugoslavia = 0x4C36,

    /// <summary>
    /// デンマーク
    /// </summary>
    [Description("デンマーク")]
    Denmark = 0x4C38,

    /// <summary>
    /// シンガポール
    /// </summary>
    [Description("シンガポール")]
    Singapore = 0x4D30,

    /// <summary>
    /// マカオ
    /// </summary>
    [Description("マカオ")]
    Macau = 0x4D32,

    /// <summary>
    /// オーストリア
    /// </summary>
    [Description("オーストリア")]
    Austria = 0x4D34,

    /// <summary>
    /// ヨルダン
    /// </summary>
    [Description("ヨルダン")]
    Jordan = 0x4D36,

    /// <summary>
    /// カタール
    /// </summary>
    [Description("カタール")]
    Qatar = 0x4D38,

    /// <summary>
    /// 東ドイツ
    /// </summary>
    [Description("東ドイツ")]
    EastGermany = 0x4E30,

    /// <summary>
    /// バーレーン
    /// </summary>
    [Description("バーレーン")]
    Bahrain = 0x4E32,

    /// <summary>
    /// カザフスタン
    /// </summary>
    [Description("カザフスタン")]
    Kazakhstan = 0x4E34,

    /// <summary>
    /// モーリシャス
    /// </summary>
    [Description("モーリシャス")]
    Mauritius = 0x4E36,
}
