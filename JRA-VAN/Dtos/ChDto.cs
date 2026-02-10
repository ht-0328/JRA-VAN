using System.Collections.Generic;

namespace JRA_VAN.Dtos;

/// <summary>
/// １５．調教師マスタ (CH)
/// レコード長 3862 バイト
/// </summary>
public class ChDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "CH" をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:新規登録 2:更新 0:該当レコード削除(提供ミスなどの理由による)
    /// </summary>
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// 調教師コード (12, 5)
    /// </summary>
    public string TrainerCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師抹消区分 (17, 1)
    /// 0:現役 1:抹消
    /// </summary>
    public string DeletionFlag { get; set; } = string.Empty;

    /// <summary>
    /// 調教師免許交付年月日 (18, 8)
    /// 年4桁(西暦)＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string LicenseDate { get; set; } = string.Empty;

    /// <summary>
    /// 調教師免許抹消年月日 (26, 8)
    /// 年4桁(西暦)＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string LicenseDeletionDate { get; set; } = string.Empty;

    /// <summary>
    /// 生年月日 (34, 8)
    /// 年4桁(西暦)＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string BirthDate { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名 (42, 34)
    /// 全角17文字　姓＋全角空白1文字＋名　外国人の場合は連続17文字
    /// </summary>
    public string TrainerName { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名半角ｶﾅ (76, 30)
    /// 半角30文字　姓15文字＋名15文字　外国人の場合は連続30文字
    /// </summary>
    public string TrainerNameKana { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名略称 (106, 8)
    /// 全角4文字
    /// </summary>
    public string TrainerNameAbbr { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名欧字 (114, 80)
    /// 半角80文字　姓＋半角空白1文字＋名　フルネームで記載
    /// </summary>
    public string TrainerNameEng { get; set; } = string.Empty;

    /// <summary>
    /// 性別区分 (194, 1)
    /// 1:男性　2:女性
    /// </summary>
    public string SexCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師東西所属コード (195, 1)
    /// &lt;コード表 2301.東西所属コード&gt;参照
    /// </summary>
    public string CenterCode { get; set; } = string.Empty;

    /// <summary>
    /// 招待地域名 (196, 20)
    /// 全角10文字
    /// </summary>
    public string InvitationAreaName { get; set; } = string.Empty;

    /// <summary>
    /// 最近重賞勝利情報 (216, 489)
    /// 直近の重賞勝利から順に設定
    /// 繰返し3回
    /// </summary>
    public List<ChRecentGradeWinDto> RecentGradeWinInfo { get; set; } = new();

    /// <summary>
    /// 本年･前年･累計成績情報 (705, 3156)
    /// 現役調教師については本年・前年・累計の順に設定
    /// 引退調教師については引退年、引退前年・累計の順に設定
    /// 繰返し3回
    /// </summary>
    public List<ChPerformanceDto> PerformanceInfo { get; set; } = new();
}

/// <summary>
/// 最近重賞勝利情報
/// </summary>
public class ChRecentGradeWinDto
{
    /// <summary>
    /// 年月日場回日R (1, 16)
    /// レース詳細のキー情報
    /// </summary>
    public string RaceId { get; set; } = string.Empty;

    /// <summary>
    /// 競走名本題 (17, 60)
    /// 全角30文字
    /// </summary>
    public string RaceName { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称10文字 (77, 20)
    /// 全角10文字
    /// </summary>
    public string RaceNameAbbr10 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称6文字 (97, 12)
    /// 全角6文字
    /// </summary>
    public string RaceNameAbbr6 { get; set; } = string.Empty;

    /// <summary>
    /// 競走名略称3文字 (109, 6)
    /// 全角3文字
    /// </summary>
    public string RaceNameAbbr3 { get; set; } = string.Empty;

    /// <summary>
    /// グレードコード (115, 1)
    /// &lt;コード表 2003.グレードコード&gt;参照
    /// </summary>
    public string GradeCode { get; set; } = string.Empty;

    /// <summary>
    /// 出走頭数 (116, 2)
    /// 登録頭数から出走取消と競走除外･発走除外を除いた頭数
    /// </summary>
    public int StarterCount { get; set; }

    /// <summary>
    /// 血統登録番号 (118, 10)
    /// 生年(西暦)4桁＋品種1桁&lt;コード表2201.品種コード&gt;参照＋数字5桁
    /// </summary>
    public string BloodlineNum { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (128, 36)
    /// 全角18文字
    /// </summary>
    public string HorseName { get; set; } = string.Empty;
}

/// <summary>
/// 本年･前年･累計成績情報
/// </summary>
public class ChPerformanceDto
{
    /// <summary>
    /// 設定年 (1, 4)
    /// 成績情報に設定されている年度(西暦)
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 平地本賞金合計 (5, 10)
    /// 単位：百円　（中央の平地本賞金の合計）
    /// </summary>
    public long FlatPrizeMoneyTotal { get; set; }

    /// <summary>
    /// 障害本賞金合計 (15, 10)
    /// 単位：百円　（中央の障害本賞金の合計）
    /// </summary>
    public long ObstaclePrizeMoneyTotal { get; set; }

    /// <summary>
    /// 平地付加賞金合計 (25, 10)
    /// 単位：百円　（中央の平地付加賞金の合計）
    /// </summary>
    public long FlatAddedPrizeMoneyTotal { get; set; }

    /// <summary>
    /// 障害付加賞金合計 (35, 10)
    /// 単位：百円　（中央の障害付加賞金の合計）
    /// </summary>
    public long ObstacleAddedPrizeMoneyTotal { get; set; }

    /// <summary>
    /// 平地着回数 (45, 36)
    /// 1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> FlatRunCounts { get; set; } = new();

    /// <summary>
    /// 障害着回数 (81, 36)
    /// 1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> ObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 札幌平地着回数 (117, 36)
    /// 札幌競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> SapporoFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 札幌障害着回数 (153, 36)
    /// 札幌競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> SapporoObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 函館平地着回数 (189, 36)
    /// 函館競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> HakodateFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 函館障害着回数 (225, 36)
    /// 函館競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> HakodateObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 福島平地着回数 (261, 36)
    /// 福島競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> FukushimaFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 福島障害着回数 (297, 36)
    /// 福島競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> FukushimaObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 新潟平地着回数 (333, 36)
    /// 新潟競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> NiigataFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 新潟障害着回数 (369, 36)
    /// 新潟競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> NiigataObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 東京平地着回数 (405, 36)
    /// 東京競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> TokyoFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 東京障害着回数 (441, 36)
    /// 東京競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> TokyoObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 中山平地着回数 (477, 36)
    /// 中山競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> NakayamaFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 中山障害着回数 (513, 36)
    /// 中山競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> NakayamaObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 中京平地着回数 (549, 36)
    /// 中京競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> ChukyoFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 中京障害着回数 (585, 36)
    /// 中京競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> ChukyoObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 京都平地着回数 (621, 36)
    /// 京都競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> KyotoFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 京都障害着回数 (657, 36)
    /// 京都競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> KyotoObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 阪神平地着回数 (693, 36)
    /// 阪神競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> HanshinFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 阪神障害着回数 (729, 36)
    /// 阪神競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> HanshinObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 小倉平地着回数 (765, 36)
    /// 小倉競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> KokuraFlatRunCounts { get; set; } = new();

    /// <summary>
    /// 小倉障害着回数 (801, 36)
    /// 小倉競馬場での1着～5着及び着外(6着以下)の回数（中央のみ）
    /// 繰返し6回
    /// </summary>
    public List<int> KokuraObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 芝16下・着回数 (837, 36)
    /// 芝･1600M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfUnder1600RunCounts { get; set; } = new();

    /// <summary>
    /// 芝22下・着回数 (873, 36)
    /// 芝･1601Ｍ以上2200M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfUnder2200RunCounts { get; set; } = new();

    /// <summary>
    /// 芝22超・着回数 (909, 36)
    /// 芝･2201M以上での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfOver2200RunCounts { get; set; } = new();

    /// <summary>
    /// ダ16下・着回数 (945, 36)
    /// ダート･1600M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtUnder1600RunCounts { get; set; } = new();

    /// <summary>
    /// ダ22下・着回数 (981, 36)
    /// ダート･1601Ｍ以上2200M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtUnder2200RunCounts { get; set; } = new();

    /// <summary>
    /// ダ22超・着回数 (1017, 36)
    /// ダート･2201M以上での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtOver2200RunCounts { get; set; } = new();
}
