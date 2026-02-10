using System.Collections.Generic;

namespace JRA_VAN.Dtos;

/// <summary>
/// １．特別登録馬 (TK)
/// レコード長 21657 バイト
/// </summary>
public class TkDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "TK" をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:ハンデ発表前(通常日曜) 2:ハンデ発表後(通常月曜)
    /// 0:該当レコード削除(提供ミスなどの理由による)
    /// </summary>
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// 開催年 (12, 4)
    /// 該当レース施行年 西暦4桁 yyyy形式
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 開催月日 (16, 4)
    /// 該当レース施行月日 各2桁 mmdd形式
    /// </summary>
    public string MonthDay { get; set; } = string.Empty;

    /// <summary>
    /// 競馬場コード (20, 2)
    /// 該当レース施行競馬場 &lt;コード表 2001.競馬場コード&gt;参照
    /// </summary>
    public string RacetrackCode { get; set; } = string.Empty;

    /// <summary>
    /// 開催回[第N回] (22, 2)
    /// 該当レース施行回 その競馬場でその年の何回目の開催かを示す
    /// </summary>
    public int MeetingNum { get; set; }

    /// <summary>
    /// 開催日目[N日目] (24, 2)
    /// 該当レース施行日目 そのレース施行回で何日目の開催かを示す
    /// </summary>
    public int DayNum { get; set; }

    /// <summary>
    /// レース番号 (26, 2)
    /// 該当レース番号
    /// </summary>
    public int RaceNum { get; set; }

    /// <summary>
    /// 曜日コード (28, 1)
    /// 該当レース施行曜日 &lt;コード表 2002.曜日コード&gt;参照
    /// </summary>
    public string DayOfWeekCode { get; set; } = string.Empty;

    /// <summary>
    /// 特別競走番号 (29, 4)
    /// 重賞レースのみ設定 原則的には過去の同一レースと一致する番号(多数例外有り)
    /// </summary>
    public int SpecialRaceNum { get; set; }

    /// <summary>
    /// 競走名本題 (33, 60)
    /// 全角30文字　レース名の本題
    /// </summary>
    public string RaceName { get; set; } = string.Empty;

    /// <summary>
    /// 競走名副題 (93, 60)
    /// 全角30文字　レース名の副題（スポンサー名や記念名など）
    /// </summary>
    public string RaceNameSubtitle { get; set; } = string.Empty;

    /// <summary>
    /// 競走名カッコ内 (153, 60)
    /// 全角30文字　レースの条件やトライアル対象レース名、レース名通称など
    /// </summary>
    public string RaceNameNote { get; set; } = string.Empty;

    /// <summary>
    /// 競走名本題欧字 (213, 120)
    /// 半角120文字
    /// </summary>
    public string RaceNameEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名副題欧字 (333, 120)
    /// 半角120文字
    /// </summary>
    public string RaceNameSubtitleEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名カッコ内欧字 (453, 120)
    /// 半角120文字
    /// </summary>
    public string RaceNameNoteEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称10文字 (573, 20)
    /// 全角10文字
    /// </summary>
    public string RaceNameAbbr10 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称6文字 (593, 12)
    /// 全角6文字
    /// </summary>
    public string RaceNameAbbr6 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称3文字 (605, 6)
    /// 全角3文字
    /// </summary>
    public string RaceNameAbbr3 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名区分 (611, 1)
    /// 重賞回次[第N回]を本題･副題･カッコ内のうちどれに設定すべきかを示す
    /// （0:初期値 1:本題 2:副題 3:カッコ内）重賞のみ設定
    /// </summary>
    public string RaceNameCategory { get; set; } = string.Empty;

    /// <summary>
    /// 重賞回次[第N回] (612, 3)
    /// そのレースの重賞としての通算回数を示す
    /// </summary>
    public int GradeRaceNum { get; set; }

    /// <summary>
    /// グレードコード (615, 1)
    /// &lt;コード表 2003.グレードコード&gt;参照
    /// ※国際グレード表記(G) または その他の重賞表記（Jpn）の判別方法については、特記事項を参照
    /// </summary>
    public string GradeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走種別コード (616, 2)
    /// &lt;コード表 2005.競走種別コード&gt;参照
    /// </summary>
    public string RaceTypeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走記号コード (618, 3)
    /// &lt;コード表 2006.競走記号コード&gt;参照
    /// </summary>
    public string RaceSymbolCode { get; set; } = string.Empty;

    /// <summary>
    /// 重量種別コード (621, 1)
    /// &lt;コード表 2008.重量種別コード&gt;参照
    /// </summary>
    public string WeightTypeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 2歳条件 (622, 3)
    /// 2歳馬の競走条件 　　&lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    public string RaceConditionCode2yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 3歳条件 (625, 3)
    /// 3歳馬の競走条件 　　&lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    public string RaceConditionCode3yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 4歳条件 (628, 3)
    /// 4歳馬の競走条件 　　&lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    public string RaceConditionCode4yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 5歳以上条件 (631, 3)
    /// 5歳以上馬の競走条件 &lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    public string RaceConditionCode5yoOrOver { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 最若年条件 (634, 3)
    /// 出走可能な最も馬齢が若い馬に対する条件 &lt;コード表 2007.競走条件コード&gt;参照　特記事項を参照
    /// </summary>
    public string RaceConditionCodeYoungest { get; set; } = string.Empty;

    /// <summary>
    /// 距離 (637, 4)
    /// 単位:メートル
    /// </summary>
    public int Distance { get; set; }

    /// <summary>
    /// トラックコード (641, 2)
    /// &lt;コード表 2009.トラックコード&gt;参照
    /// </summary>
    public string TrackCode { get; set; } = string.Empty;

    /// <summary>
    /// コース区分 (643, 2)
    /// 半角2文字　使用するコースを設定
    /// "A " ～ "E " を設定 尚、2002年以前の東京競馬場は"A1"、"A2"も存在
    /// </summary>
    public string CourseCategory { get; set; } = string.Empty;

    /// <summary>
    /// ハンデ発表日 (645, 8)
    /// ハンデキャップレースにおいてハンデが発表された日
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string HandicapDate { get; set; } = string.Empty;

    /// <summary>
    /// 登録頭数 (653, 3)
    /// 特別登録された頭数
    /// </summary>
    public int EntryCount { get; set; }

    /// <summary>
    /// 登録馬毎情報
    /// 連番1～300
    /// </summary>
    public List<TkHorseDto> RegisteredHorses { get; set; } = new();
}

/// <summary>
/// 登録馬毎情報
/// </summary>
public class TkHorseDto
{
    /// <summary>
    /// 連番 (1, 3)
    /// 該当連番がない場合は全項目(37a～37j)に半角スペースを設定
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// 血統登録番号 (4, 10)
    /// 生年(西暦)4桁＋品種1桁&lt;コード表2201.品種コード&gt;参照＋数字5桁
    /// </summary>
    public string BloodlineNum { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (14, 36)
    /// 全角18文字
    /// </summary>
    public string HorseName { get; set; } = string.Empty;

    /// <summary>
    /// 馬記号コード (50, 2)
    /// &lt;コード表 2204.馬記号コード&gt;参照
    /// </summary>
    public string HorseSymbolCode { get; set; } = string.Empty;

    /// <summary>
    /// 性別コード (52, 1)
    /// &lt;コード表 2202.性別コード&gt;参照 初招待となる競走馬については初期値の場合有り
    /// </summary>
    public string SexCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師東西所属コード (53, 1)
    /// &lt;コード表 2301.東西所属コード&gt;参照 初招待となる競走馬については初期値の場合有り
    /// </summary>
    public string TrainerCenterCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師コード (54, 5)
    /// 調教師マスタへリンク　 初招待となる競走馬については初期値の場合有り
    /// </summary>
    public string TrainerCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名略称 (59, 8)
    /// 全角4文字 初招待となる競走馬については初期値の場合有り
    /// </summary>
    public string TrainerNameAbbr { get; set; } = string.Empty;

    /// <summary>
    /// 負担重量 (67, 3)
    /// 単位:0.1kg　ハンデキャップレースについては月曜以降に設定
    /// </summary>
    public int BurdenWeight { get; set; }

    /// <summary>
    /// 交流区分 (70, 1)
    /// 中央交流登録馬の場合に設定　0:初期値　1:地方馬　2:外国馬
    /// </summary>
    public string ExchangeCategory { get; set; } = string.Empty;
}
