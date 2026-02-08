using JRA_VAN.Infrastructure;

namespace JRA_VAN.Models
{
    /// <summary>
    /// 速報レース情報 (レコード種別: RA) を表すクラス。
    /// </summary>
    [JvRecordSpec("RA")]
    public class RaRecord
    {
        /// <summary>
        /// 開催年 (Year)
        /// オフセット: 11, 長さ: 4
        /// </summary>
        [JvField(11, 4)]
        public string Year { get; set; } = string.Empty;

        /// <summary>
        /// 開催月日 (MonthDay)
        /// オフセット: 15, 長さ: 4
        /// </summary>
        [JvField(15, 4)]
        public string MonthDay { get; set; } = string.Empty;

        /// <summary>
        /// 競馬場コード (Course Code)
        /// オフセット: 19, 長さ: 2
        /// </summary>
        [JvField(19, 2)]
        public string CourseCode { get; set; } = string.Empty;

        /// <summary>
        /// レース番号 (Race Number)
        /// オフセット: 25, 長さ: 2
        /// </summary>
        [JvField(25, 2)]
        public string RaceNumber { get; set; } = string.Empty;

        /// <summary>
        /// レース名 (Race Name)
        /// オフセット: 33, 長さ: 60
        /// </summary>
        [JvField(33, 60)]
        public string RaceName { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"[{Year}/{MonthDay}] {CourseCode} {RaceNumber}R : {RaceName}";
        }
    }
}
