using System.Collections.Generic;

namespace JRA_VAN.Dtos;

/// <summary>
/// ７．オッズ 1（単複枠） (O1)
/// レコード長 962 バイト
/// </summary>
public class O1Dto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "O1"(オー･イチ) をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:中間　2:前日売最終　3:最終　4:確定　5:確定(月曜)
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
    /// 発表月日時分 (28, 8)
    /// 月日時分各2桁
    /// 中間オッズのみ設定
    /// 時系列オッズを使用する場合のみキーとして設定
    /// </summary>
    public string AnnouncementDate { get; set; } = string.Empty;

    /// <summary>
    /// 登録頭数 (36, 2)
    /// 出馬表発表時の登録頭数
    /// </summary>
    public int RegistrationCount { get; set; }

    /// <summary>
    /// 出走頭数 (38, 2)
    /// 登録頭数から出走取消と競走除外･発走除外を除いた頭数
    /// </summary>
    public int StarterCount { get; set; }

    /// <summary>
    /// 発売フラグ　単勝 (40, 1)
    /// 単勝発売の有無　（0:発売なし 1:発売前取消 3:発売後取消 7:発売あり）
    /// </summary>
    public int WinSaleFlag { get; set; }

    /// <summary>
    /// 発売フラグ　複勝 (41, 1)
    /// 複勝発売の有無　（0:発売なし 1:発売前取消 3:発売後取消 7:発売あり）
    /// </summary>
    public int PlaceSaleFlag { get; set; }

    /// <summary>
    /// 発売フラグ　枠連 (42, 1)
    /// 枠連発売の有無　（0:発売なし 1:発売前取消 3:発売後取消 7:発売あり）
    /// </summary>
    public int BracketQuinellaSaleFlag { get; set; }

    /// <summary>
    /// 複勝着払キー (43, 1)
    /// 複勝の着払キー　（0:複勝発売なし 2:2着まで払い 3:3着まで払い）
    /// </summary>
    public int PlacePayKey { get; set; }

    /// <summary>
    /// 単勝オッズ (44, 224)
    /// 28頭立てまで考慮し繰返し28回　馬番昇順01～28
    /// </summary>
    public List<O1WinOddsDto> WinOdds { get; set; } = new();

    /// <summary>
    /// 複勝オッズ (268, 336)
    /// 28頭立てまで考慮し繰返し28回　馬番昇順01～28
    /// </summary>
    public List<O1PlaceOddsDto> PlaceOdds { get; set; } = new();

    /// <summary>
    /// 枠連オッズ (604, 324)
    /// 組番昇順　1-1～8-8
    /// </summary>
    public List<O1BracketQuinellaOddsDto> BracketQuinellaOdds { get; set; } = new();

    /// <summary>
    /// 単勝票数合計 (928, 11)
    /// 単位百円 単勝票数の合計（返還分票数を含む）
    /// </summary>
    public long TotalWinVotes { get; set; }

    /// <summary>
    /// 複勝票数合計 (939, 11)
    /// 単位百円 複勝票数の合計（返還分票数を含む）
    /// </summary>
    public long TotalPlaceVotes { get; set; }

    /// <summary>
    /// 枠連票数合計 (950, 11)
    /// 単位百円 枠連票数の合計（返還分票数を含む）
    /// </summary>
    public long TotalBracketQuinellaVotes { get; set; }
}

/// <summary>
/// 単勝オッズ詳細
/// </summary>
public class O1WinOddsDto
{
    /// <summary>
    /// 馬番 (1, 2)
    /// 該当馬番
    /// </summary>
    public string HorseNum { get; set; } = string.Empty;

    /// <summary>
    /// オッズ (3, 4)
    /// 999.9倍で設定
    /// "9999":999.9倍以上　"0000":無投票　"----":発売前取消　"****":発売後取消　"    ":登録なし(sp)
    /// </summary>
    public string Odds { get; set; } = string.Empty;

    /// <summary>
    /// 人気順 (7, 2)
    /// スペース:登録なし '--':発売前取消 '**':発売後取消  無投票の時は発売されている組合せの最大値を設定
    /// </summary>
    public string Popularity { get; set; } = string.Empty;
}

/// <summary>
/// 複勝オッズ詳細
/// </summary>
public class O1PlaceOddsDto
{
    /// <summary>
    /// 馬番 (1, 2)
    /// 該当馬番
    /// </summary>
    public string HorseNum { get; set; } = string.Empty;

    /// <summary>
    /// 最低オッズ (3, 4)
    /// 999.9倍で設定　ただし2004年8月13日以前は99.9倍が設定できる最高値とする
    /// "0999":99.9倍以上　"0000":無投票　"----":発売前取消　"****":発売後取消　"    ":登録なし(sp)
    /// </summary>
    public string MinOdds { get; set; } = string.Empty;

    /// <summary>
    /// 最高オッズ (7, 4)
    /// 999.9倍で設定　ただし2004年8月13日以前は99.9倍が設定できる最高値とする
    /// "0999":99.9倍以上　"0000":無投票　"----":発売前取消　"****":発売後取消　"    ":登録なし(sp)
    /// </summary>
    public string MaxOdds { get; set; } = string.Empty;

    /// <summary>
    /// 人気順 (11, 2)
    /// スペース:登録なし '--':発売前取消 '**':発売後取消  無投票の時は発売されている組合せの最大値を設定
    /// </summary>
    public string Popularity { get; set; } = string.Empty;
}

/// <summary>
/// 枠連オッズ詳細
/// </summary>
public class O1BracketQuinellaOddsDto
{
    /// <summary>
    /// 組番 (1, 2)
    /// 該当枠番
    /// </summary>
    public string BracketNum { get; set; } = string.Empty;

    /// <summary>
    /// オッズ (3, 5)
    /// 9999.9倍で設定　ただし2004年8月13日以前は999.9倍が設定できる最高値とする
    /// "09999":999.9倍以上　"00000":無投票　"-----":発売前取消
    /// "*****":発売後取消　"     ":登録なし(sp)
    /// </summary>
    public string Odds { get; set; } = string.Empty;

    /// <summary>
    /// 人気順 (8, 2)
    /// スペース:登録なし '--':発売前取消 '**':発売後取消  無投票の時は発売されている組合せの最大値を設定
    /// </summary>
    public string Popularity { get; set; } = string.Empty;
}
