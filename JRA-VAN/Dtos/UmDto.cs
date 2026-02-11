using System.Collections.Generic;

namespace JRA_VAN.Dtos;

/// <summary>
/// １３．競走馬マスタ (UM)
/// レコード長 1609 バイト
/// </summary>
public class UmDto
{
    /// <summary>
    /// レコード種別ID (1, 2)
    /// "UM" をセットレコードフォーマットを特定する
    /// </summary>
    public string RecordSpec { get; set; } = string.Empty;

    /// <summary>
    /// データ区分 (3, 1)
    /// 1:新規馬名登録 2:馬名変更 3:再登録(抹消後の再登録) 4:その他更新
    /// 9:抹消 0:該当レコード削除(提供ミスなどの理由による)
    /// </summary>
    public string DataCategory { get; set; } = string.Empty;

    /// <summary>
    /// データ作成年月日 (4, 8)
    /// 西暦4桁＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string DataCreationDate { get; set; } = string.Empty;

    /// <summary>
    /// 血統登録番号 (12, 10)
    /// 生年(西暦)4桁＋品種1桁&lt;コード表2201.品種コード&gt;参照＋数字5桁
    /// </summary>
    public string BloodlineNum { get; set; } = string.Empty;

    /// <summary>
    /// 競走馬抹消区分 (22, 1)
    /// 0:現役 1:抹消
    /// </summary>
    public string DeletionFlag { get; set; } = string.Empty;

    /// <summary>
    /// 競走馬登録年月日 (23, 8)
    /// 年4桁(西暦)＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string RegistrationDate { get; set; } = string.Empty;

    /// <summary>
    /// 競走馬抹消年月日 (31, 8)
    /// 年4桁(西暦)＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string DeletionDate { get; set; } = string.Empty;

    /// <summary>
    /// 生年月日 (39, 8)
    /// 年4桁(西暦)＋月日各2桁 yyyymmdd 形式
    /// </summary>
    public string BirthDate { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (47, 36)
    /// 全角18文字
    /// </summary>
    public string HorseName { get; set; } = string.Empty;

    /// <summary>
    /// 馬名半角ｶﾅ (83, 36)
    /// 半角36文字
    /// </summary>
    public string HorseNameKana { get; set; } = string.Empty;

    /// <summary>
    /// 馬名欧字 (119, 60)
    /// 半角60文字
    /// </summary>
    public string HorseNameEng { get; set; } = string.Empty;

    /// <summary>
    /// JRA施設在きゅうフラグ (179, 1)
    /// 0:JRA施設に在きゅうしていない。 1:JRA施設の在きゅうしている。
    /// JRA施設とは競馬場およびトレセンなどを指す。
    /// </summary>
    public string JraFacilityFlag { get; set; } = string.Empty;

    /// <summary>
    /// 予備 (180, 19)
    /// 予備
    /// </summary>
    public string Reserve1 { get; set; } = string.Empty;

    /// <summary>
    /// 馬記号コード (199, 2)
    /// &lt;コード表 2204.馬記号コード&gt;参照
    /// </summary>
    public string HorseSymbolCode { get; set; } = string.Empty;

    /// <summary>
    /// 性別コード (201, 1)
    /// &lt;コード表 2202.性別コード&gt;参照
    /// </summary>
    public string SexCode { get; set; } = string.Empty;

    /// <summary>
    /// 品種コード (202, 1)
    /// &lt;コード表 2201.品種コード&gt;参照
    /// </summary>
    public string VarietyCode { get; set; } = string.Empty;

    /// <summary>
    /// 毛色コード (203, 2)
    /// &lt;コード表 2203.毛色コード&gt;参照
    /// </summary>
    public string CoatColorCode { get; set; } = string.Empty;

    /// <summary>
    /// 3代血統情報 (205, 644)
    /// 父･母･父父･父母･母父･母母･父父父･父父母･父母父･父母母･母父父･母父母･母母父･母母母の順に設定
    /// 繰返し14回
    /// </summary>
    public List<UmPedigreeDto> PedigreeInfo { get; set; } = new();

    /// <summary>
    /// 東西所属コード (849, 1)
    /// &lt;コード表 2301.東西所属コード&gt;参照
    /// </summary>
    public string TrainerCenterCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師コード (850, 5)
    /// 調教師マスタへリンク
    /// </summary>
    public string TrainerCode { get; set; } = string.Empty;

    /// <summary>
    /// 調教師名略称 (855, 8)
    /// 全角4文字
    /// </summary>
    public string TrainerNameAbbr { get; set; } = string.Empty;

    /// <summary>
    /// 招待地域名 (863, 20)
    /// 全角10文字
    /// </summary>
    public string InvitationAreaName { get; set; } = string.Empty;

    /// <summary>
    /// 生産者コード (883, 8)
    /// 生産者マスタへリンク
    /// </summary>
    public string BreederCode { get; set; } = string.Empty;

    /// <summary>
    /// 生産者名(法人格無) (891, 72)
    /// 全角36文字 ～ 半角72文字 （全角と半角が混在）
    /// 株式会社、有限会社などの法人格を示す文字列が頭もしくは末尾にある場合にそれを削除したものを設定。
    /// また、外国生産者の場合は、生産者マスタの8.生産者名欧字の頭70バイトを設定。
    /// </summary>
    public string BreederNameShort { get; set; } = string.Empty;

    /// <summary>
    /// 産地名 (963, 20)
    /// 全角10文字　または　半角20文字　(設定値が英数の場合は半角で設定）
    /// </summary>
    public string ProductionAreaName { get; set; } = string.Empty;

    /// <summary>
    /// 馬主コード (983, 6)
    /// 馬主マスタへリンク
    /// </summary>
    public string OwnerCode { get; set; } = string.Empty;

    /// <summary>
    /// 馬主名(法人格無) (989, 64)
    /// 全角32文字 ～ 半角64文字 （全角と半角が混在）
    /// 株式会社、有限会社などの法人格を示す文字列が頭もしくは末尾にある場合にそれを削除したものを設定。
    /// また、外国馬主の場合は、馬主マスタの8.馬主名欧字の頭64バイトを設定。
    /// </summary>
    public string OwnerNameShort { get; set; } = string.Empty;

    /// <summary>
    /// 平地本賞金累計 (1053, 9)
    /// 単位：百円　（中央の平地本賞金の合計）
    /// </summary>
    public long FlatPrizeMoneyTotal { get; set; }

    /// <summary>
    /// 障害本賞金累計 (1062, 9)
    /// 単位：百円　（中央の障害本賞金の合計）
    /// </summary>
    public long ObstaclePrizeMoneyTotal { get; set; }

    /// <summary>
    /// 平地付加賞金累計 (1071, 9)
    /// 単位：百円　（中央の平地付加賞金の合計）
    /// </summary>
    public long FlatAddedPrizeMoneyTotal { get; set; }

    /// <summary>
    /// 障害付加賞金累計 (1080, 9)
    /// 単位：百円　（中央の障害付加賞金の合計）
    /// </summary>
    public long ObstacleAddedPrizeMoneyTotal { get; set; }

    /// <summary>
    /// 平地収得賞金累計 (1089, 9)
    /// 単位：百円　（中央＋中央以外の平地累積収得賞金）
    /// </summary>
    public long FlatEarningsMoneyTotal { get; set; }

    /// <summary>
    /// 障害収得賞金累計 (1098, 9)
    /// 単位：百円　（中央＋中央以外の障害累積収得賞金）
    /// </summary>
    public long ObstacleEarningsMoneyTotal { get; set; }

    /// <summary>
    /// 総合着回数 (1107, 18)
    /// 1着～5着及び着外(6着以下)の回数（中央＋地方＋海外)
    /// 繰返し6回
    /// </summary>
    public List<int> OverallRunCounts { get; set; } = new();

    /// <summary>
    /// 中央合計着回数 (1125, 18)
    /// 1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> JraTotalRunCounts { get; set; } = new();

    /// <summary>
    /// 芝直・着回数 (1143, 18)
    /// 芝・直線コースでの1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfStraightRunCounts { get; set; } = new();

    /// <summary>
    /// 芝右・着回数 (1161, 18)
    /// 芝・右回りコースでの1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfRightRunCounts { get; set; } = new();

    /// <summary>
    /// 芝左・着回数 (1179, 18)
    /// 芝・左回りコースでの1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfLeftRunCounts { get; set; } = new();

    /// <summary>
    /// ダ直・着回数 (1197, 18)
    /// ダート・直線コースでの1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtStraightRunCounts { get; set; } = new();

    /// <summary>
    /// ダ右・着回数 (1215, 18)
    /// ダート・右回りコースでの1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtRightRunCounts { get; set; } = new();

    /// <summary>
    /// ダ左・着回数 (1233, 18)
    /// ダート・左回りコースでの1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtLeftRunCounts { get; set; } = new();

    /// <summary>
    /// 障害・着回数 (1251, 18)
    /// 障害レースでの1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> ObstacleRunCounts { get; set; } = new();

    /// <summary>
    /// 芝良・着回数 (1269, 18)
    /// 芝・良馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfFirmRunCounts { get; set; } = new();

    /// <summary>
    /// 芝稍・着回数 (1287, 18)
    /// 芝・稍重馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfGoodRunCounts { get; set; } = new();

    /// <summary>
    /// 芝重・着回数 (1305, 18)
    /// 芝・重馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfYieldingRunCounts { get; set; } = new();

    /// <summary>
    /// 芝不・着回数 (1323, 18)
    /// 芝・不良馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfSoftRunCounts { get; set; } = new();

    /// <summary>
    /// ダ良・着回数 (1341, 18)
    /// ダート・良馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtFirmRunCounts { get; set; } = new();

    /// <summary>
    /// ダ稍・着回数 (1359, 18)
    /// ダート・稍重馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtGoodRunCounts { get; set; } = new();

    /// <summary>
    /// ダ重・着回数 (1377, 18)
    /// ダート・重馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtYieldingRunCounts { get; set; } = new();

    /// <summary>
    /// ダ不・着回数 (1395, 18)
    /// ダート・不良馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtSoftRunCounts { get; set; } = new();

    /// <summary>
    /// 障良・着回数 (1413, 18)
    /// 障害レース・良馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> ObstacleFirmRunCounts { get; set; } = new();

    /// <summary>
    /// 障稍・着回数 (1431, 18)
    /// 障害レース・稍重馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> ObstacleGoodRunCounts { get; set; } = new();

    /// <summary>
    /// 障重・着回数 (1449, 18)
    /// 障害レース・重馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> ObstacleYieldingRunCounts { get; set; } = new();

    /// <summary>
    /// 障不・着回数 (1467, 18)
    /// 障害レース・不良馬場での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> ObstacleSoftRunCounts { get; set; } = new();

    /// <summary>
    /// 芝16下・着回数 (1485, 18)
    /// 芝･1600M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfUnder1600RunCounts { get; set; } = new();

    /// <summary>
    /// 芝22下・着回数 (1503, 18)
    /// 芝･1601Ｍ以上2200M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfUnder2200RunCounts { get; set; } = new();

    /// <summary>
    /// 芝22超・着回数 (1521, 18)
    /// 芝･2201M以上での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> TurfOver2200RunCounts { get; set; } = new();

    /// <summary>
    /// ダ16下・着回数 (1539, 18)
    /// ダート･1600M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtUnder1600RunCounts { get; set; } = new();

    /// <summary>
    /// ダ22下・着回数 (1557, 18)
    /// ダート･1601Ｍ以上2200M以下での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtUnder2200RunCounts { get; set; } = new();

    /// <summary>
    /// ダ22超・着回数 (1575, 18)
    /// ダート･2201M以上での1着～5着及び着外(6着以下)の回数（中央のみ)
    /// 繰返し6回
    /// </summary>
    public List<int> DirtOver2200RunCounts { get; set; } = new();

    /// <summary>
    /// 脚質傾向 (1593, 12)
    /// 逃げ回数、先行回数、差し回数、追込回数を設定
    /// 過去出走レースの脚質を判定しカウントしたもの(中央レースのみ)
    /// 繰返し4回
    /// </summary>
    public List<int> RunningStyleCounts { get; set; } = new();

    /// <summary>
    /// 登録レース数 (1605, 3)
    /// JRA-VANに登録されている成績レース数
    /// </summary>
    public int RegisteredRaceCount { get; set; }
}

/// <summary>
/// 3代血統情報
/// </summary>
public class UmPedigreeDto
{
    /// <summary>
    /// 繁殖登録番号 (1, 10)
    /// 繁殖馬マスタにリンク
    /// </summary>
    public string BreedingRegNum { get; set; } = string.Empty;

    /// <summary>
    /// 馬名 (11, 36)
    /// 全角18文字 ～ 半角36文字 （全角と半角が混在）
    /// 外国の繁殖馬の場合は、16.繁殖馬マスタの10.馬名欧字の頭36バイトを設定。
    /// </summary>
    public string HorseName { get; set; } = string.Empty;
}
