using JRA_VAN.Infrastructure;

namespace JRA_VAN.Models
{
    /// <summary>
    /// Represents a "Sokuho Race Info" (RA) record.
    /// </summary>
    public class RaRecord
    {
        /// <summary>
        /// 開催年 (Year)
        /// Offset: 11, Length: 4
        /// </summary>
        [JvField(11, 4)]
        public string Year { get; set; } = string.Empty;

        /// <summary>
        /// 開催月日 (MonthDay)
        /// Offset: 15, Length: 4
        /// </summary>
        [JvField(15, 4)]
        public string MonthDay { get; set; } = string.Empty;

        /// <summary>
        /// 競馬場コード (Course Code)
        /// Offset: 19, Length: 2
        /// </summary>
        [JvField(19, 2)]
        public string CourseCode { get; set; } = string.Empty;

        /// <summary>
        /// レース番号 (Race Number)
        /// Offset: 25, Length: 2
        /// </summary>
        [JvField(25, 2)]
        public string RaceNumber { get; set; } = string.Empty;

        /// <summary>
        /// レース名 (Race Name)
        /// Offset: 33, Length: 60
        /// </summary>
        [JvField(33, 60)]
        public string RaceName { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"[{Year}/{MonthDay}] {CourseCode} {RaceNumber}R : {RaceName}";
        }
    }
}
