using System.Text;
using JRA_VAN.Models;

namespace JRA_VAN.Logic;

public static class RaParser
{
    private static readonly Encoding Sjis;

    static RaParser()
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Sjis = Encoding.GetEncoding("Shift_JIS");
    }

    public static Race Parse(byte[] data)
    {
        // 1. Date (11, 8)
        string date = Sjis.GetString(data, 11, 8);
        // 2. Place (19, 2)
        string place = Sjis.GetString(data, 19, 2);
        // 3. Kai (21, 2)
        string kai = Sjis.GetString(data, 21, 2);
        // 4. Nichi (23, 2)
        string nichi = Sjis.GetString(data, 23, 2);
        // 5. RaceNum (25, 2)
        string num = Sjis.GetString(data, 25, 2);
        // 6. Name (27, 20) - Mock defined length, might need trim if padded
        string name = Sjis.GetString(data, 27, 20).Trim();
        // 7. Distance (50, 4) - Mock defined
        string dist = Sjis.GetString(data, 50, 4).Trim();
        // 8. Weather (60, 1) - Mock defined
        string weather = Sjis.GetString(data, 60, 1);
        // 9. Track (61, 1) - Mock defined
        string track = Sjis.GetString(data, 61, 1);

        return new Race(date, place, kai, nichi, num, name, dist, weather, track);
    }
}
