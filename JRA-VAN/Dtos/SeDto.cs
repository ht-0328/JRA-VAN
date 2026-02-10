using System.Collections.Generic;

namespace JRA_VAN.Dtos;

/// <summary>
/// ３．馬毎レース情報 (SE)
/// レコード長 555 バイト
/// </summary>
public class SeDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "SE" をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:出走馬名表(木曜)　2:出馬表(金･土曜)　3:速報成績(3着まで確定)
    /// 4:速報成績(5着まで確定) 5:速報成績(全馬着順確定)
    /// 6:速報成績(全馬着順+コーナ通過順)　7:成績(月曜)
    /// A:地方競馬　B：海外国際レース
    /// 9:レース中止　0:該当レコード削除(提供ミスなどの理由による)
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
    /// 枠番 (28, 1)
    /// </summary>
    public int Wakuban { get; set; }

    /// <summary>
    /// 馬番 (29, 2)
    /// 特定のレース及び海外レースについては、特記事項を参照
    /// </summary>
    public int Umaban { get; set; }

    /// <summary>
    /// 血統登録番号 (31, 10)
    /// 生年(西暦)4桁＋品種1桁&lt;コード表2201.品種コード&gt;参照＋数字5桁
    /// </summary>
    public string BloodlineNum { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (41, 36)
    /// 通常全角18文字。海外レースにおける外国馬の場合のみ全角と半角が混在
    /// </summary>
    public string HorseName { get; set; } = string.Empty;

    /// <summary>
    /// 馬記号コード (77, 2)
    /// &lt;コード表 2204.馬記号コード&gt;参照
    /// </summary>
    public string HorseSymbolCode { get; set; } = string.Empty;

    /// <summary>
    /// 性別コード (79, 1)
    /// &lt;コード表 2202.性別コード&gt;参照
    /// </summary>
    public string SexCode { get; set; } = string.Empty;

    /// <summary>
    /// 品種コード (80, 1)
    /// &lt;コード表 2201.品種コード&gt;参照
    /// </summary>
    public string BreedCode { get; set; } = string.Empty;

    /// <summary>
    /// 毛色コード (81, 2)
    /// &lt;コード表 2203.毛色コード&gt;参照
    /// </summary>
    public string CoatColorCode { get; set; } = string.Empty;

    /// <summary>
    /// 馬齢 (83, 2)
    /// 出走当時の馬齢（注）2000年以前は数え年表記 2001年以降は満年齢表記
    /// </summary>
    public int HorseAge { get; set; }

    /// <summary>
    /// 東西所属コード (85, 1)
    /// &lt;コード表 2301.東西所属コード&gt;参照
    /// </summary>
    public string TrainerCenterCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師コード (86, 5)
    /// 調教師マスタへリンク
    /// </summary>
    public string TrainerCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名略称 (91, 8)
    /// 全角4文字
    /// </summary>
    public string TrainerNameAbbr { get; set; } = string.Empty;

    /// <summary>
    /// 馬主コード (99, 6)
    /// 馬主マスタへリンク
    /// </summary>
    public string OwnerCode { get; set; } = string.Empty;

    /// <summary>
    /// 馬主名(法人格無) (105, 64)
    /// 全角32文字 ～ 半角64文字 （全角と半角が混在）
    /// 株式会社、有限会社などの法人格を示す文字列が頭もしくは末尾にある場合にそれを削除したものを設定。
    /// また、外国馬主の場合は、馬主マスタの8.馬主名欧字の頭64バイトを設定
    /// </summary>
    public string OwnerName { get; set; } = string.Empty;

    /// <summary>
    /// 服色標示 (169, 60)
    /// 全角30文字　馬主毎に指定される騎手の勝負服の色・模様を示す(レーシングプログラムに記載されているもの）
    /// (例)"水色，赤山形一本輪，水色袖　　　"
    /// </summary>
    public string SilkColors { get; set; } = string.Empty;

    /// <summary>
    /// 負担重量 (289, 3)
    /// 単位0.1kg
    /// </summary>
    public int BurdenWeight { get; set; }

    /// <summary>
    /// 変更前負担重量 (292, 3)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    public int OldBurdenWeight { get; set; }

    /// <summary>
    /// ブリンカー使用区分 (295, 1)
    /// 0:未使用 1:使用
    /// </summary>
    public string BlinkerUse { get; set; } = string.Empty;

    /// <summary>
    /// 騎手コード (297, 5)
    /// 騎手マスタへリンク
    /// </summary>
    public string JockeyCode { get; set; } = string.Empty;

    /// <summary>
    /// 変更前騎手コード (302, 5)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    public string OldJockeyCode { get; set; } = string.Empty;

    /// <summary>
    /// 騎手名略称 (307, 8)
    /// 全角4文字
    /// </summary>
    public string JockeyNameAbbr { get; set; } = string.Empty;

    /// <summary>
    /// 変更前騎手名略称 (315, 8)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    public string OldJockeyNameAbbr { get; set; } = string.Empty;

    /// <summary>
    /// 騎手見習コード (323, 1)
    /// &lt;コード表 2303.騎手見習コード&gt;参照
    /// </summary>
    public string JockeyApprenticeCode { get; set; } = string.Empty;

    /// <summary>
    /// 変更前騎手見習コード (324, 1)
    /// なんらかの理由により変更された場合のみ変更前の値を設定
    /// </summary>
    public string OldJockeyApprenticeCode { get; set; } = string.Empty;

    /// <summary>
    /// 馬体重 (325, 3)
    /// 単位:kg　002Kg～998Kgまでが有効値
    /// 999:今走計量不能　000:出走取消
    /// </summary>
    public string HorseWeight { get; set; } = string.Empty;

    /// <summary>
    /// 増減符号 (328, 1)
    /// +:増加 -:減少 スペース:その他
    /// </summary>
    public string WeightChangeSign { get; set; } = string.Empty;

    /// <summary>
    /// 増減差 (329, 3)
    /// 単位:kg　001Kg～998Kgまでが有効値
    /// 999:計量不能　000:前差なし　スペース:初出走、ただし出走取消の場合もスペースを設定。
    /// 地方馬については初出走かつ計量不能の場合でも"999"を設定。
    /// </summary>
    public string WeightChange { get; set; } = string.Empty;

    /// <summary>
    /// 異常区分コード (332, 1)
    /// &lt;コード表 2101.異常区分コード&gt;参照
    /// </summary>
    public string AbnormalCode { get; set; } = string.Empty;

    /// <summary>
    /// 入線順位 (333, 2)
    /// 失格、降着確定前の順位
    /// </summary>
    public int ArrivalOrder { get; set; }

    /// <summary>
    /// 確定着順 (335, 2)
    /// 失格、降着時は入線順位と異なる
    /// </summary>
    public int ConfirmedRank { get; set; }

    /// <summary>
    /// 同着区分 (337, 1)
    /// 0:同着馬なし　1:同着馬あり
    /// </summary>
    public string DeadHeatSpec { get; set; } = string.Empty;

    /// <summary>
    /// 同着頭数 (338, 1)
    /// 0:初期値　1:自身以外に同着1頭　2:自身以外に同着2頭
    /// </summary>
    public int DeadHeatCount { get; set; }

    /// <summary>
    /// 走破タイム (339, 4)
    /// 9分99秒9で設定
    /// </summary>
    public string Time { get; set; } = string.Empty;

    /// <summary>
    /// 着差コード (343, 3)
    /// 前馬との着差　&lt;コード表 2102.着差コード&gt;参照
    /// </summary>
    public string MarginCode { get; set; } = string.Empty;

    /// <summary>
    /// ＋着差コード (346, 3)
    /// 前馬が失格、降着発生時に設定　前馬と前馬の前馬との着差
    /// </summary>
    public string PlusMarginCode { get; set; } = string.Empty;

    /// <summary>
    /// ＋＋着差コード (349, 3)
    /// 前馬2頭が失格、降着発生時に設定
    /// </summary>
    public string PlusPlusMarginCode { get; set; } = string.Empty;

    /// <summary>
    /// 1コーナーでの順位 (352, 2)
    /// </summary>
    public int Corner1Rank { get; set; }

    /// <summary>
    /// 2コーナーでの順位 (354, 2)
    /// </summary>
    public int Corner2Rank { get; set; }

    /// <summary>
    /// 3コーナーでの順位 (356, 2)
    /// </summary>
    public int Corner3Rank { get; set; }

    /// <summary>
    /// 4コーナーでの順位 (358, 2)
    /// </summary>
    public int Corner4Rank { get; set; }

    /// <summary>
    /// 単勝オッズ (360, 4)
    /// 999.9倍で設定　出走取消し等は初期値を設定
    /// </summary>
    public string Odds { get; set; } = string.Empty;

    /// <summary>
    /// 単勝人気順 (364, 2)
    /// 出走取消し等は初期値を設定
    /// </summary>
    public int PopularityRank { get; set; }

    /// <summary>
    /// 獲得本賞金 (366, 8)
    /// 単位:百円　該当レースで獲得した本賞金
    /// </summary>
    public long PrizeMoney { get; set; }

    /// <summary>
    /// 獲得付加賞金 (374, 8)
    /// 単位:百円　該当レースで獲得した付加賞金
    /// </summary>
    public long AddedMoney { get; set; }

    /// <summary>
    /// 後4ハロンタイム (388, 3)
    /// </summary>
    public int Last4Furlong { get; set; }

    /// <summary>
    /// 後3ハロンタイム (391, 3)
    /// </summary>
    public int Last3Furlong { get; set; }

    /// <summary>
    /// 1着馬(相手馬)情報
    /// 同着を考慮して繰返し3回自身が1着の場合は2着馬を設定
    /// </summary>
    public List<SeOpponentHorseDto> OpponentHorses { get; set; } = new();

    /// <summary>
    /// タイム差 (532, 4)
    /// 1着馬とのタイム差を設定（自身が1着の場合は2着馬を設定)
    /// 符号(+または-)+99秒9　符号は1着:-、2着以下:+
    /// 出走取消･競走除外･発走除外･競走中止の場合は "9999" を設定
    /// </summary>
    public string TimeDiff { get; set; } = string.Empty;

    /// <summary>
    /// レコード更新区分 (536, 1)
    /// 0:初期値　1:基準タイムとなったレース　2:コースレコードを更新したレース
    /// </summary>
    public string RecordUpdateSpec { get; set; } = string.Empty;

    /// <summary>
    /// マイニング区分 (537, 1)
    /// 1:前日 2:当日 3:直前　ただし、確定成績登録時に3:直前のみ設定
    /// </summary>
    public string MiningSpec { get; set; } = string.Empty;

    /// <summary>
    /// マイニング予想走破タイム (538, 5)
    /// 9分99秒99で設定
    /// </summary>
    public string MiningTime { get; set; } = string.Empty;

    /// <summary>
    /// マイニング予想誤差(信頼度)＋ (543, 4)
    /// 99秒99で設定予想タイムの＋誤差を設定(＋方向の誤差。予想走破タイムに対して早くなる方向。予想走破タイムからマイナスする。)
    /// </summary>
    public string MiningErrorPlus { get; set; } = string.Empty;

    /// <summary>
    /// マイニング予想誤差(信頼度)－ (547, 4)
    /// 99秒99で設定予想タイムの－誤差を設定(－方向の誤差。予想走破タイムに対して遅くなる方向。予想走破タイムにプラスする。)
    /// </summary>
    public string MiningErrorMinus { get; set; } = string.Empty;

    /// <summary>
    /// マイニング予想順位 (551, 2)
    /// 01～18位を設定
    /// </summary>
    public int MiningRank { get; set; }

    /// <summary>
    /// 今回レース脚質判定 (553, 1)
    /// 1:逃　2:先　3:差　4:追　0:初期値
    /// </summary>
    public string RunningStyle { get; set; } = string.Empty;
}

/// <summary>
/// 1着馬(相手馬)情報
/// </summary>
public class SeOpponentHorseDto
{
    /// <summary>
    /// 血統登録番号 (1, 10)
    /// 生年(西暦)4桁＋品種1桁&lt;コード表2201.品種コード&gt;参照＋数字5桁
    /// </summary>
    public string BloodlineNum { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (11, 36)
    /// 通常全角18文字。海外レースにおける外国馬の場合のみ全角と半角が混在。
    /// </summary>
    public string HorseName { get; set; } = string.Empty;
}
