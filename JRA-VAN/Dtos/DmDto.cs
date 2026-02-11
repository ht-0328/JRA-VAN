using System.Collections.Generic;

namespace JRA_VAN.Dtos;

/// <summary>
/// ２８．タイム型データマイニング予想 (DM)
/// レコード長 303 バイト
/// </summary>
public class DmDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "DM"をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:前日予想(出馬発表後)　2:当日予想(天候馬場発表後) 3:直前予想(馬体重発表後)
    /// 7:成績(月曜)　0:該当レコード削除(提供ミスなどの理由による)
    /// ※1 7:成績(月曜)は蓄積系データのみ設定されます。蓄積系データにて7:成績(月曜)提供後も速報系データには3:直前予想(馬体重発表後)が提供されます。
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
    /// データ作成時分 (28, 4)
    /// 時分各2桁
    /// </summary>
    public string CreationTime { get; set; } = string.Empty;

    /// <summary>
    /// マイニング予想 (32, 270)
    /// 繰返し18回
    /// </summary>
    public List<DmPredictionDto> Predictions { get; set; } = new();
}

/// <summary>
/// マイニング予想
/// </summary>
public class DmPredictionDto
{
    /// <summary>
    /// 馬番 (1, 2)
    /// 該当馬番01～18
    /// </summary>
    public string HorseNum { get; set; } = string.Empty;

    /// <summary>
    /// 予想走破タイム (3, 5)
    /// 9分99秒99で設定 (単位:0.01秒)
    /// </summary>
    public int PredictedTime { get; set; }

    /// <summary>
    /// 予想誤差(信頼度)＋ (8, 4)
    /// 99秒99で設定 (単位:0.01秒)
    /// 予想タイムの＋誤差を設定(＋方向の誤差。予想走破タイムに対して早くなる方向。予想走破タイムからマイナスする。)
    /// </summary>
    public int PredictedErrorPlus { get; set; }

    /// <summary>
    /// 予想誤差(信頼度)－ (12, 4)
    /// 99秒99で設定 (単位:0.01秒)
    /// 予想タイムの－誤差を設定(－方向の誤差。予想走破タイムに対して遅くなる方向。予想走破タイムにプラスする。)
    /// </summary>
    public int PredictedErrorMinus { get; set; }
}
