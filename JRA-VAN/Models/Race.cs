namespace JRA_VAN.Models;

public record Race(
    string RaceDate,
    string PlaceCode,
    string Kai,
    string Nichi,
    string RaceNum,
    string RaceName,
    string Distance,
    string Weather,
    string TrackCondition
)
{
    public List<RaceHorse> Horses { get; } = new();

    public string RaceId => $"{RaceDate}{PlaceCode}{Kai}{Nichi}{RaceNum}";

    public override string ToString()
    {
        return $"[{RaceId}] {RaceName} ({Distance}m) 天候:{Weather} 馬場:{TrackCondition} 出走頭数:{Horses.Count}";
    }
}
