using System.Text;
using JRA_VAN.Models;

namespace JRA_VAN.Logic;

public static class SeParser
{
    private static readonly Encoding Sjis;

    static SeParser()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Sjis = Encoding.GetEncoding("Shift_JIS");
    }

    public static RaceHorse Parse(byte[] data)
    {
        // 1. HorseName (37, 36)
        string name = Sjis.GetString(data, 37, 36).Trim();
        // 2. Order (73, 2)
        string order = Sjis.GetString(data, 73, 2).Trim();
        // 3. Time (75, 4)
        string time = Sjis.GetString(data, 75, 4).Trim(); // e.g. 2234 -> 2:23.4 formatter can be done in display
        // 4. Weight (80, 3)
        string weight = Sjis.GetString(data, 80, 3).Trim();
        // 5. Jockey (85, 5)
        string jockey = Sjis.GetString(data, 85, 5).Trim();
        // 6. Trainer (90, 5)
        string trainer = Sjis.GetString(data, 90, 5).Trim();

        return new RaceHorse(name, order, time, weight, jockey, trainer);
    }

    public static string GetRaceId(byte[] data)
    {
        // Date(11,8) + Place(19,2) + Kai(21,2) + Nichi(23,2) + Num(25,2)
        string date = Sjis.GetString(data, 11, 8);
        string place = Sjis.GetString(data, 19, 2);
        string kai = Sjis.GetString(data, 21, 2);
        string nichi = Sjis.GetString(data, 23, 2);
        string num = Sjis.GetString(data, 25, 2);
        return $"{date}{place}{kai}{nichi}{num}";
    }
}
