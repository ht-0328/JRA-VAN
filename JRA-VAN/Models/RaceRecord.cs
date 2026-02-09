namespace JRA_VAN.Models;

/// <summary>
/// JRA-VANから取得したレース情報のレコード
/// </summary>
/// <param name="RaceDate">開催日</param>
/// <param name="RaceNum">レース番号</param>
/// <param name="HorseName">馬名</param>
public record RaceRecord(string RaceDate, string RaceNum, string HorseName)
{
    public override string ToString()
    {
        return $"開催日: {RaceDate} | {RaceNum}R | 馬名: {HorseName}";
    }
}
