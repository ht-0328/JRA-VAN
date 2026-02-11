using System.Collections.Generic;
using JRA_VAN.Attributes;

namespace JRA_VAN.Dtos;

/// <summary>
/// ２．レース詳細 (RA)
/// レコード長 1272 バイト
/// </summary>
public class RaDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "RA" をセットレコードフォーマットを特定する
    /// </summary>
    [JvField(Offset = 1, Length = 2)]
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:出走馬名表(木曜)　2:出馬表(金･土曜)　3:速報成績(3着まで確定)
    /// 4:速報成績(5着まで確定) 5:速報成績(全馬着順確定)
    /// 6:速報成績(全馬着順+コーナ通過順)　7:成績(月曜)
    /// A:地方競馬　B：海外国際レース
    /// 9:レース中止　0:該当レコード削除(提供ミスなどの理由による)
    /// </summary>
    [JvField(Offset = 3, Length = 1)]
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    [JvField(Offset = 4, Length = 8)]
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// 開催年 (12, 4)
    /// 該当レース施行年 西暦4桁 yyyy形式
    /// </summary>
    [JvField(Offset = 12, Length = 4)]
    public int Year { get; set; }

    /// <summary>
    /// 開催月日 (16, 4)
    /// 該当レース施行月日 各2桁 mmdd形式
    /// </summary>
    [JvField(Offset = 16, Length = 4)]
    public string MonthDay { get; set; } = string.Empty;

    /// <summary>
    /// 競馬場コード (20, 2)
    /// 該当レース施行競馬場 &lt;コード表 2001.競馬場コード&gt;参照
    /// </summary>
    [JvField(Offset = 20, Length = 2)]
    public string RacetrackCode { get; set; } = string.Empty;

    /// <summary>
    /// 開催回[第N回] (22, 2)
    /// 該当レース施行回 その競馬場でその年の何回目の開催かを示す
    /// </summary>
    [JvField(Offset = 22, Length = 2)]
    public int MeetingNum { get; set; }

    /// <summary>
    /// 開催日目[N日目] (24, 2)
    /// 該当レース施行日目 そのレース施行回で何日目の開催かを示す
    /// </summary>
    [JvField(Offset = 24, Length = 2)]
    public int DayNum { get; set; }

    /// <summary>
    /// レース番号 (26, 2)
    /// 該当レース番号
    /// また、海外国際レースなどでレース番号情報がない場合は任意に連番を設定
    /// </summary>
    [JvField(Offset = 26, Length = 2)]
    public int RaceNum { get; set; }

    /// <summary>
    /// 曜日コード (28, 1)
    /// 該当レース施行曜日 &lt;コード表 2002.曜日コード&gt;参照
    /// </summary>
    [JvField(Offset = 28, Length = 1)]
    public string DayOfWeekCode { get; set; } = string.Empty;

    /// <summary>
    /// 特別競走番号 (29, 4)
    /// 重賞レースのみ設定 原則的には過去の同一レースと一致する番号(多数例外有り)
    /// </summary>
    [JvField(Offset = 29, Length = 4)]
    public int SpecialRaceNum { get; set; }

    /// <summary>
    /// 競走名本題 (33, 60)
    /// 全角30文字　レース名の本題
    /// </summary>
    [JvField(Offset = 33, Length = 60)]
    public string RaceName { get; set; } = string.Empty;

    /// <summary>
    /// 競走名副題 (93, 60)
    /// 全角30文字　レース名の副題（スポンサー名や記念名など）
    /// </summary>
    [JvField(Offset = 93, Length = 60)]
    public string RaceNameSubtitle { get; set; } = string.Empty;

    /// <summary>
    /// 競走名カッコ内 (153, 60)
    /// 全角30文字　レースの条件やトライアル対象レース名、レース名通称など
    /// </summary>
    [JvField(Offset = 153, Length = 60)]
    public string RaceNameNote { get; set; } = string.Empty;

    /// <summary>
    /// 競走名本題欧字 (213, 120)
    /// 半角120文字
    /// </summary>
    [JvField(Offset = 213, Length = 120)]
    public string RaceNameEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名副題欧字 (333, 120)
    /// 半角120文字
    /// </summary>
    [JvField(Offset = 333, Length = 120)]
    public string RaceNameSubtitleEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名カッコ内欧字 (453, 120)
    /// 半角120文字
    /// </summary>
    [JvField(Offset = 453, Length = 120)]
    public string RaceNameNoteEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称10文字 (573, 20)
    /// 全角10文字
    /// </summary>
    [JvField(Offset = 573, Length = 20)]
    public string RaceNameAbbr10 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称6文字 (593, 12)
    /// 全角6文字
    /// </summary>
    [JvField(Offset = 593, Length = 12)]
    public string RaceNameAbbr6 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称3文字 (605, 6)
    /// 全角3文字
    /// </summary>
    [JvField(Offset = 605, Length = 6)]
    public string RaceNameAbbr3 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名区分 (611, 1)
    /// 重賞回次[第N回]を本題･副題･カッコ内のうちどれに設定すべきかを示す
    /// （0:初期値 1:本題 2:副題 3:カッコ内）重賞のみ設定
    /// </summary>
    [JvField(Offset = 611, Length = 1)]
    public string RaceNameCategory { get; set; } = string.Empty;

    /// <summary>
    /// 重賞回次[第N回] (612, 3)
    /// そのレースの重賞としての通算回数を示す
    /// </summary>
    [JvField(Offset = 612, Length = 3)]
    public int GradeRaceNum { get; set; }

    /// <summary>
    /// グレードコード (615, 1)
    /// &lt;コード表 2003.グレードコード&gt;参照
    /// ※国際グレード表記(G) または その他の重賞表記（Jpn）の判別方法については、特記事項を参照
    /// </summary>
    [JvField(Offset = 615, Length = 1)]
    public string GradeCode { get; set; } = string.Empty;

    /// <summary>
    /// 変更前グレードコード (616, 1)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    [JvField(Offset = 616, Length = 1)]
    public string OldGradeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走種別コード (617, 2)
    /// &lt;コード表 2005.競走種別コード&gt;参照
    /// </summary>
    [JvField(Offset = 617, Length = 2)]
    public string RaceTypeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走記号コード (619, 3)
    /// &lt;コード表 2006.競走記号コード&gt;参照
    /// </summary>
    [JvField(Offset = 619, Length = 3)]
    public string RaceSymbolCode { get; set; } = string.Empty;

    /// <summary>
    /// 重量種別コード (622, 1)
    /// &lt;コード表 2008.重量種別コード&gt;参照
    /// </summary>
    [JvField(Offset = 622, Length = 1)]
    public string WeightTypeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 2歳条件 (623, 3)
    /// 2歳馬の競走条件 　　&lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    [JvField(Offset = 623, Length = 3)]
    public string RaceConditionCode2yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 3歳条件 (626, 3)
    /// 3歳馬の競走条件 　　&lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    [JvField(Offset = 626, Length = 3)]
    public string RaceConditionCode3yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 4歳条件 (629, 3)
    /// 4歳馬の競走条件 　　&lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    [JvField(Offset = 629, Length = 3)]
    public string RaceConditionCode4yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 5歳以上条件 (632, 3)
    /// 5歳以上馬の競走条件 &lt;コード表 2007.競走条件コード&gt;参照　　特記事項を参照
    /// </summary>
    [JvField(Offset = 632, Length = 3)]
    public string RaceConditionCode5yoOrOver { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 最若年条件 (635, 3)
    /// 出走可能な最も馬齢が若い馬に対する条件 &lt;コード表 2007.競走条件コード&gt;参照　特記事項を参照
    /// </summary>
    [JvField(Offset = 635, Length = 3)]
    public string RaceConditionCodeYoungest { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件名称 (638, 60)
    /// 全角30文字　地方競馬の場合のみ設定
    /// </summary>
    [JvField(Offset = 638, Length = 60)]
    public string RaceConditionName { get; set; } = string.Empty;

    /// <summary>
    /// 距離 (698, 4)
    /// 単位：メートル
    /// </summary>
    [JvField(Offset = 698, Length = 4)]
    public int Distance { get; set; }

    /// <summary>
    /// 変更前距離 (702, 4)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    [JvField(Offset = 702, Length = 4)]
    public int OldDistance { get; set; }

    /// <summary>
    /// トラックコード (706, 2)
    /// &lt;コード表 2009.トラックコード&gt;参照
    /// </summary>
    [JvField(Offset = 706, Length = 2)]
    public string TrackCode { get; set; } = string.Empty;

    /// <summary>
    /// 変更前トラックコード (708, 2)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    [JvField(Offset = 708, Length = 2)]
    public string OldTrackCode { get; set; } = string.Empty;

    /// <summary>
    /// コース区分 (710, 2)
    /// 半角2文字　使用するコースを設定
    /// "A " ～ "E " を設定 尚、2002年以前の東京競馬場は"A1"、"A2"も存在
    /// </summary>
    [JvField(Offset = 710, Length = 2)]
    public string CourseCategory { get; set; } = string.Empty;

    /// <summary>
    /// 変更前コース区分 (712, 2)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    [JvField(Offset = 712, Length = 2)]
    public string OldCourseCategory { get; set; } = string.Empty;

    /// <summary>
    /// 本賞金 (714, 56)
    /// 単位:百円　1着～5着の本賞金　5着3同着まで考慮し繰返し7回
    /// </summary>
    [JvField(Offset = 714, Length = 8, Count = 7)]
    public List<long> PrizeMoney { get; set; } = new();

    /// <summary>
    /// 変更前本賞金 (770, 40)
    /// 単位:百円　同着により本賞金の分配が変更された場合のみ変更前の値を設定
    /// 繰返し5回
    /// </summary>
    [JvField(Offset = 770, Length = 8, Count = 5)]
    public List<long> OldPrizeMoney { get; set; } = new();

    /// <summary>
    /// 付加賞金 (810, 40)
    /// 単位:百円　1着～3着の付加賞金　3着3同着まで考慮し繰返し5回
    /// </summary>
    [JvField(Offset = 810, Length = 8, Count = 5)]
    public List<long> AddedPrizeMoney { get; set; } = new();

    /// <summary>
    /// 変更前付加賞金 (850, 24)
    /// 単位:百円　同着により付加賞金の分配が変更された場合のみ変更前の値を設定
    /// 繰返し3回
    /// </summary>
    [JvField(Offset = 850, Length = 8, Count = 3)]
    public List<long> OldAddedPrizeMoney { get; set; } = new();

    /// <summary>
    /// 発走時刻 (874, 4)
    /// 時分各2桁 hhmm形式
    /// </summary>
    [JvField(Offset = 874, Length = 4)]
    public string PostTime { get; set; } = string.Empty;

    /// <summary>
    /// 変更前発走時刻 (878, 4)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    [JvField(Offset = 878, Length = 4)]
    public string OldPostTime { get; set; } = string.Empty;

    /// <summary>
    /// 登録頭数 (882, 2)
    /// 出走馬名表時点：出走馬名表時点での登録頭数
    /// 出馬表発表時点：出馬表発表時の登録頭数
    /// 出馬表発表前(馬番確定前)に取消した馬を除いた頭数
    /// </summary>
    [JvField(Offset = 882, Length = 2)]
    public int RegistrationCount { get; set; }

    /// <summary>
    /// 出走頭数 (884, 2)
    /// 実際にレースに出走した頭数 (登録頭数から出走取消と競走除外･発走除外を除いた頭数)
    /// </summary>
    [JvField(Offset = 884, Length = 2)]
    public int StarterCount { get; set; }

    /// <summary>
    /// 入線頭数 (886, 2)
    /// 出走頭数から競走中止を除いた頭数
    /// </summary>
    [JvField(Offset = 886, Length = 2)]
    public int FinisherCount { get; set; }

    /// <summary>
    /// 天候コード (888, 1)
    /// &lt;コード表 2011.天候コード&gt;参照
    /// </summary>
    [JvField(Offset = 888, Length = 1)]
    public string WeatherCode { get; set; } = string.Empty;

    /// <summary>
    /// 芝馬場状態コード (889, 1)
    /// &lt;コード表 2010.馬場状態コード&gt;参照
    /// </summary>
    [JvField(Offset = 889, Length = 1)]
    public string TurfConditionCode { get; set; } = string.Empty;

    /// <summary>
    /// ダート馬場状態コード (890, 1)
    /// &lt;コード表 2010.馬場状態コード&gt;参照
    /// </summary>
    [JvField(Offset = 890, Length = 1)]
    public string DirtConditionCode { get; set; } = string.Empty;

    /// <summary>
    /// ラップタイム (891, 75)
    /// 99.9秒 平地競走のみ設定
    /// 1ハロン(200メートル)毎地点での先頭馬ラップタイム 距離が1ハロンで割りきれないレースについては
    /// 最初の1ハロン目に距離を200メートルで割ったあまりの距離のラップタイムを設定
    /// 繰返し25回
    /// </summary>
    [JvField(Offset = 891, Length = 3, Count = 25)]
    public List<int> LapTimes { get; set; } = new();

    /// <summary>
    /// 障害マイルタイム (966, 4)
    /// 障害競走のみ設定 先頭馬の1マイル(1600メートル)通過タイムの分＋秒（1分57秒2は'1572'）
    /// </summary>
    [JvField(Offset = 966, Length = 4)]
    public string ObstacleMileTime { get; set; } = string.Empty;

    /// <summary>
    /// 前3ハロン (970, 3)
    /// 99.9秒 平地競走のみ設定 ラップタイム前半3ハロンの合計
    /// 1ハロン(200メートル)毎で割れないレースの場合、200メートルで距離を割ったあまりに400メートルを
    /// 足した距離のタイム
    /// </summary>
    [JvField(Offset = 970, Length = 3)]
    public int First3Furlong { get; set; }

    /// <summary>
    /// 前4ハロン (973, 3)
    /// 99.9秒 平地競走のみ設定 ラップタイム前半4ハロンの合計
    /// 1ハロン(200メートル)毎で割れないレースの場合、200メートルで距離を割ったあまりに600メートルを
    /// 足した距離のタイム
    /// </summary>
    [JvField(Offset = 973, Length = 3)]
    public int First4Furlong { get; set; }

    /// <summary>
    /// 後3ハロン (976, 3)
    /// 99.9秒 ラップタイム後半3ハロンの合計
    /// </summary>
    [JvField(Offset = 976, Length = 3)]
    public int Last3Furlong { get; set; }

    /// <summary>
    /// 後4ハロン (979, 3)
    /// 99.9秒 ラップタイム後半4ハロンの合計
    /// </summary>
    [JvField(Offset = 979, Length = 3)]
    public int Last4Furlong { get; set; }

    /// <summary>
    /// コーナー通過順位 (982, 288)
    /// 繰返し4回
    /// </summary>
    [JvField(Offset = 982, Length = 72, Count = 4)]
    public List<RaCornerPassingDto> CornerPassingInfo { get; set; } = new();

    /// <summary>
    /// レコード更新区分 (1270, 1)
    /// 0:初期値　1:基準タイムとなったレース　2:コースレコードを更新したレース
    /// </summary>
    [JvField(Offset = 1270, Length = 1)]
    public string RecordUpdateSpec { get; set; } = string.Empty;
}

/// <summary>
/// コーナー通過順位情報
/// </summary>
public class RaCornerPassingDto
{
    /// <summary>
    /// コーナー (1, 1)
    /// コーナーを設定　1:1コーナー　2:2コーナー　3:3コーナー　4:4コーナー
    /// </summary>
    [JvField(Offset = 1, Length = 1)]
    public string Corner { get; set; } = string.Empty;

    /// <summary>
    /// 周回数 (2, 1)
    /// 周回数を設定　1:1周　2:2周　3:3周
    /// </summary>
    [JvField(Offset = 2, Length = 1)]
    public string LapNum { get; set; } = string.Empty;

    /// <summary>
    /// 各通過順位 (3, 70)
    /// 順位を先頭内側から設定
    /// 例=1-2,3,8,9(10,11) 12,13
    /// ():集団　=:大差　-:小差　*:先頭集団のうちで先頭の馬番　,:馬番の区切
    /// スペース3桁後ろの馬番はコーナーを通過しなかった馬番
    /// </summary>
    [JvField(Offset = 3, Length = 70)]
    public string PassingOrder { get; set; } = string.Empty;
}
