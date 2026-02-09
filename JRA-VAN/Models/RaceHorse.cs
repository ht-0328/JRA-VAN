namespace JRA_VAN.Models;

public record RaceHorse(
    string HorseName,
    string FinishOrder,
    string Time,
    string HorseWeight,
    string JockeyCode,
    string TrainerCode
)
{
    public override string ToString()
    {
        return $"{FinishOrder}着 {HorseName} ({Time}) {HorseWeight}kg 騎手:{JockeyCode} 調教師:{TrainerCode}";
    }
}
