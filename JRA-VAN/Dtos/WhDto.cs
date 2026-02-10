using System.Collections.Generic;

namespace JRA_VAN.Dtos;

/// <summary>
/// １０１．馬体重 (WH)
/// レコード長 847 バイト
/// </summary>
public class WhDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "WH" をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:初期値
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
    /// 発表月日時分 (28, 8)
    /// 月日時分各2桁
    /// </summary>
    public string AnnouncementTime { get; set; } = string.Empty;

    /// <summary>
    /// 馬体重情報 (36, 810)
    /// 繰返し18回
    /// </summary>
    public List<WhHorseWeightDto> HorseWeights { get; set; } = new();
}

/// <summary>
/// 馬体重情報
/// </summary>
public class WhHorseWeightDto
{
    /// <summary>
    /// 馬番 (1, 2)
    /// 01～18を設定
    /// </summary>
    public string HorseNum { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (3, 36)
    /// 全角18文字　ただし当面は全角9文字のみ設定(9文字を超える馬名は9文字までとする)
    /// </summary>
    public string HorseName { get; set; } = string.Empty;

    /// <summary>
    /// 馬体重 (39, 3)
    /// 単位:kg　002Kg～998Kgまでが有効値
    /// 999:今走計量不能　000:出走取消
    /// </summary>
    public string HorseWeight { get; set; } = string.Empty;

    /// <summary>
    /// 増減符号 (42, 1)
    /// +:増加 -:減少 スペース:その他
    /// </summary>
    public string WeightChangeSign { get; set; } = string.Empty;

    /// <summary>
    /// 増減差 (43, 3)
    /// 単位:kg　001Kg～998Kgまでが有効値
    /// 999:計量不能　000:前差なし　スペース:初出走、出走取消
    /// </summary>
    public string WeightChange { get; set; } = string.Empty;
}
