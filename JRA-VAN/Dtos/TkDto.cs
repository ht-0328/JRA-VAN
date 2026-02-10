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
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// </summary>
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// </summary>
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// 開催年 (12, 4)
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 開催月日 (16, 4)
    /// </summary>
    public string MonthDay { get; set; } = string.Empty;

    /// <summary>
    /// 競馬場コード (20, 2)
    /// </summary>
    public string RacetrackCode { get; set; } = string.Empty;

    /// <summary>
    /// 開催回[第N回] (22, 2)
    /// </summary>
    public int MeetingNum { get; set; }

    /// <summary>
    /// 開催日目[N日目] (24, 2)
    /// </summary>
    public int DayNum { get; set; }

    /// <summary>
    /// レース番号 (26, 2)
    /// </summary>
    public int RaceNum { get; set; }

    /// <summary>
    /// 曜日コード (28, 1)
    /// </summary>
    public string DayOfWeekCode { get; set; } = string.Empty;

    /// <summary>
    /// 特別競走番号 (29, 4)
    /// </summary>
    public int SpecialRaceNum { get; set; }

    /// <summary>
    /// 競走名本題 (33, 60)
    /// </summary>
    public string RaceName { get; set; } = string.Empty;

    /// <summary>
    /// 競走名副題 (93, 60)
    /// </summary>
    public string RaceNameSubtitle { get; set; } = string.Empty;

    /// <summary>
    /// 競走名カッコ内 (153, 60)
    /// </summary>
    public string RaceNameNote { get; set; } = string.Empty;

    /// <summary>
    /// 競走名本題欧字 (213, 120)
    /// </summary>
    public string RaceNameEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名副題欧字 (333, 120)
    /// </summary>
    public string RaceNameSubtitleEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名カッコ内欧字 (453, 120)
    /// </summary>
    public string RaceNameNoteEng { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称10文字 (573, 20)
    /// </summary>
    public string RaceNameAbbr10 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称6文字 (593, 12)
    /// </summary>
    public string RaceNameAbbr6 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称3文字 (605, 6)
    /// </summary>
    public string RaceNameAbbr3 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名区分 (611, 1)
    /// </summary>
    public string RaceNameCategory { get; set; } = string.Empty;

    /// <summary>
    /// 重賞回次[第N回] (612, 3)
    /// </summary>
    public int GradeRaceNum { get; set; }

    /// <summary>
    /// グレードコード (615, 1)
    /// </summary>
    public string GradeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走種別コード (616, 2)
    /// </summary>
    public string RaceTypeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走記号コード (618, 3)
    /// </summary>
    public string RaceSymbolCode { get; set; } = string.Empty;

    /// <summary>
    /// 重量種別コード (621, 1)
    /// </summary>
    public string WeightTypeCode { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 2歳条件 (622, 3)
    /// </summary>
    public string RaceConditionCode2yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 3歳条件 (625, 3)
    /// </summary>
    public string RaceConditionCode3yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 4歳条件 (628, 3)
    /// </summary>
    public string RaceConditionCode4yo { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 5歳以上条件 (631, 3)
    /// </summary>
    public string RaceConditionCode5yoOrOver { get; set; } = string.Empty;

    /// <summary>
    /// 競走条件コード 最若年条件 (634, 3)
    /// </summary>
    public string RaceConditionCodeYoungest { get; set; } = string.Empty;

    /// <summary>
    /// 距離 (637, 4)
    /// </summary>
    public int Distance { get; set; }

    /// <summary>
    /// トラックコード (641, 2)
    /// </summary>
    public string TrackCode { get; set; } = string.Empty;

    /// <summary>
    /// コース区分 (643, 2)
    /// </summary>
    public string CourseCategory { get; set; } = string.Empty;

    /// <summary>
    /// ハンデ発表日 (645, 8)
    /// </summary>
    public string HandicapDate { get; set; } = string.Empty;

    /// <summary>
    /// 登録頭数 (653, 3)
    /// </summary>
    public int EntryCount { get; set; }

    /// <summary>
    /// 登録馬毎情報
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
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// 血統登録番号 (4, 10)
    /// </summary>
    public string BloodlineNum { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (14, 36)
    /// </summary>
    public string HorseName { get; set; } = string.Empty;

    /// <summary>
    /// 馬記号コード (50, 2)
    /// </summary>
    public string HorseSymbolCode { get; set; } = string.Empty;

    /// <summary>
    /// 性別コード (52, 1)
    /// </summary>
    public string SexCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師東西所属コード (53, 1)
    /// </summary>
    public string TrainerCenterCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師コード (54, 5)
    /// </summary>
    public string TrainerCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名略称 (59, 8)
    /// </summary>
    public string TrainerNameAbbr { get; set; } = string.Empty;

    /// <summary>
    /// 負担重量 (67, 3)
    /// </summary>
    public int BurdenWeight { get; set; }

    /// <summary>
    /// 交流区分 (70, 1)
    /// </summary>
    public string ExchangeCategory { get; set; } = string.Empty;
}
