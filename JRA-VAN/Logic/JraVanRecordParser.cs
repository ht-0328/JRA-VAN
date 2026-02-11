using System.Text;
using JRA_VAN.Dtos;
using JRA_VAN.Models;
using JRA_VAN.Parsers;

namespace JRA_VAN.Logic;

public static class JraVanRecordParser
{
    private static readonly Encoding Sjis;

    static JraVanRecordParser()
    {
        // Ensure Shift_JIS is available
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Sjis = Encoding.GetEncoding("Shift_JIS");
    }

    /// <summary>
    /// バイト配列からレース情報をパースします。
    /// </summary>
    /// <param name="data">JRA-VANから取得した生データ</param>
    /// <returns>パースされたRaceRecord</returns>
    public static RaceRecord Parse(byte[] data)
    {
        // 1. 開催日 (11バイト目から8文字)
        string raceDate = Sjis.GetString(data, 11, 8);

        // 2. レース番号 (25バイト目から2文字)
        string raceNum = Sjis.GetString(data, 25, 2);

        // 3. 馬名 (37バイト目から36文字分)
        string horseName = Sjis.GetString(data, 37, 36).Trim();

        return new RaceRecord(raceDate, raceNum, horseName);
    }

    /// <summary>
    /// 文字列からRAレコードをパースします。
    /// </summary>
    /// <param name="line">1行文字列</param>
    /// <returns>パースされたRaDto</returns>
    public static RaDto ParseRa(string line)
    {
        return RaParser.Parse(line);
    }
}
