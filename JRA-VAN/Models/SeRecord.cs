using JRA_VAN.Infrastructure;

namespace JRA_VAN.Models
{
    /// <summary>
    /// 馬毎レース情報 (レコード種別: SE) を表すクラス。
    /// </summary>
    [JvRecordSpec("SE")]
    public class SeRecord
    {
        /// <summary>
        /// 開催年月日 (RaceDate)
        /// オフセット: 11, 長さ: 8
        /// </summary>
        [JvField(11, 8)]
        public string RaceDate { get; set; } = string.Empty;

        /// <summary>
        /// レース番号 (Race Number)
        /// オフセット: 25, 長さ: 2
        /// </summary>
        [JvField(25, 2)]
        public string RaceNumber { get; set; } = string.Empty;

        /// <summary>
        /// 馬名 (Horse Name)
        /// オフセット: 37, 長さ: 36
        /// </summary>
        [JvField(37, 36)]
        public string HorseName { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"開催日: {RaceDate} | {RaceNumber}R | 馬名: {HorseName}";
        }
    }
}
