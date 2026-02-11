using System;
using System.Collections.Generic;
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

    /// <summary>
    /// バイト配列からRAレコードを直接パースします。
    /// </summary>
    /// <param name="data">バイト配列</param>
    /// <returns>パースされたRaDto</returns>
    public static RaDto ParseRaFromBytes(byte[] data)
    {
        var dto = new RaDto();

        dto.RecordSpec = GetString(data, 1, 2);
        dto.DataCategory = GetString(data, 3, 1);
        dto.DataCreationDate = GetString(data, 4, 8);
        dto.Year = GetInt(data, 12, 4);
        dto.MonthDay = GetString(data, 16, 4);
        dto.RacetrackCode = GetString(data, 20, 2);
        dto.MeetingNum = GetInt(data, 22, 2);
        dto.DayNum = GetInt(data, 24, 2);
        dto.RaceNum = GetInt(data, 26, 2);
        dto.DayOfWeekCode = GetString(data, 28, 1);
        dto.SpecialRaceNum = GetInt(data, 29, 4);
        dto.RaceName = GetString(data, 33, 60);
        dto.RaceNameSubtitle = GetString(data, 93, 60);
        dto.RaceNameNote = GetString(data, 153, 60);
        dto.RaceNameEng = GetString(data, 213, 120);
        dto.RaceNameSubtitleEng = GetString(data, 333, 120);
        dto.RaceNameNoteEng = GetString(data, 453, 120);
        dto.RaceNameAbbr10 = GetString(data, 573, 20);
        dto.RaceNameAbbr6 = GetString(data, 593, 12);
        dto.RaceNameAbbr3 = GetString(data, 605, 6);
        dto.RaceNameCategory = GetString(data, 611, 1);
        dto.GradeRaceNum = GetInt(data, 612, 3);
        dto.GradeCode = GetString(data, 615, 1);
        dto.OldGradeCode = GetString(data, 616, 1);
        dto.RaceTypeCode = GetString(data, 617, 2);
        dto.RaceSymbolCode = GetString(data, 619, 3);
        dto.WeightTypeCode = GetString(data, 622, 1);
        dto.RaceConditionCode2yo = GetString(data, 623, 3);
        dto.RaceConditionCode3yo = GetString(data, 626, 3);
        dto.RaceConditionCode4yo = GetString(data, 629, 3);
        dto.RaceConditionCode5yoOrOver = GetString(data, 632, 3);
        dto.RaceConditionCodeYoungest = GetString(data, 635, 3);
        dto.RaceConditionName = GetString(data, 638, 60);
        dto.Distance = GetInt(data, 698, 4);
        dto.OldDistance = GetInt(data, 702, 4);
        dto.TrackCode = GetString(data, 706, 2);
        dto.OldTrackCode = GetString(data, 708, 2);
        dto.CourseCategory = GetString(data, 710, 2);
        dto.OldCourseCategory = GetString(data, 712, 2);

        // PrizeMoney (714, 56) -> 7 items * 8 len
        for (int i = 0; i < 7; i++)
        {
            dto.PrizeMoney.Add(GetLong(data, 714 + i * 8, 8));
        }

        // OldPrizeMoney (770, 40) -> 5 items * 8 len
        for (int i = 0; i < 5; i++)
        {
            dto.OldPrizeMoney.Add(GetLong(data, 770 + i * 8, 8));
        }

        // AddedPrizeMoney (810, 40) -> 5 items * 8 len
        for (int i = 0; i < 5; i++)
        {
            dto.AddedPrizeMoney.Add(GetLong(data, 810 + i * 8, 8));
        }

        // OldAddedPrizeMoney (850, 24) -> 3 items * 8 len
        for (int i = 0; i < 3; i++)
        {
            dto.OldAddedPrizeMoney.Add(GetLong(data, 850 + i * 8, 8));
        }

        dto.PostTime = GetString(data, 874, 4);
        dto.OldPostTime = GetString(data, 878, 4);
        dto.RegistrationCount = GetInt(data, 882, 2);
        dto.StarterCount = GetInt(data, 884, 2);
        dto.FinisherCount = GetInt(data, 886, 2);
        dto.WeatherCode = GetString(data, 888, 1);
        dto.TurfConditionCode = GetString(data, 889, 1);
        dto.DirtConditionCode = GetString(data, 890, 1);

        // LapTimes (891, 75) -> 25 items * 3 len
        for (int i = 0; i < 25; i++)
        {
            dto.LapTimes.Add(GetInt(data, 891 + i * 3, 3));
        }

        dto.ObstacleMileTime = GetString(data, 966, 4);
        dto.First3Furlong = GetInt(data, 970, 3);
        dto.First4Furlong = GetInt(data, 973, 3);
        dto.Last3Furlong = GetInt(data, 976, 3);
        dto.Last4Furlong = GetInt(data, 979, 3);

        // CornerPassingInfo (982, 288) -> 4 items * 72 len
        // Corner (1, 1), LapNum (2, 1), PassingOrder (3, 70)
        for (int i = 0; i < 4; i++)
        {
            int basePos = 982 + i * 72;
            var cornerDto = new RaCornerPassingDto
            {
                Corner = GetString(data, basePos, 1),
                LapNum = GetString(data, basePos + 1, 1),
                // PassingOrderはTrimEndのみ
                PassingOrder = GetString(data, basePos + 2, 70, trimEndOnly: true)
            };
            dto.CornerPassingInfo.Add(cornerDto);
        }

        dto.RecordUpdateSpec = GetString(data, 1270, 1);

        return dto;
    }

    private static string GetString(byte[] data, int start1Based, int length, bool trimEndOnly = false)
    {
        // 1-based start -> 0-based index
        int start = start1Based - 1;
        if (start < 0 || start >= data.Length) return string.Empty;

        int safeLen = Math.Min(length, data.Length - start);
        string s = Sjis.GetString(data, start, safeLen);

        return trimEndOnly ? s.TrimEnd() : s.Trim();
    }

    private static int GetInt(byte[] data, int start1Based, int length)
    {
        string s = GetString(data, start1Based, length);
        if (string.IsNullOrWhiteSpace(s)) return 0;
        return int.TryParse(s, out int result) ? result : 0;
    }

    private static long GetLong(byte[] data, int start1Based, int length)
    {
        string s = GetString(data, start1Based, length);
        if (string.IsNullOrWhiteSpace(s)) return 0;
        return long.TryParse(s, out long result) ? result : 0;
    }
}
