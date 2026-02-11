using System.Collections.Generic;
using JRA_VAN.Dtos;

namespace JRA_VAN.Parsers;

public static class RaParser
{
    public static RaDto Parse(string line)
    {
        var dto = new RaDto();

        dto.RecordSpec = FixedWidthUtils.ParseString(line, 1, 2);
        dto.DataCategory = FixedWidthUtils.ParseString(line, 3, 1);
        dto.DataCreationDate = FixedWidthUtils.ParseString(line, 4, 8);
        dto.Year = FixedWidthUtils.ParseInt(line, 12, 4);
        dto.MonthDay = FixedWidthUtils.ParseString(line, 16, 4);
        dto.RacetrackCode = FixedWidthUtils.ParseString(line, 20, 2);
        dto.MeetingNum = FixedWidthUtils.ParseInt(line, 22, 2);
        dto.DayNum = FixedWidthUtils.ParseInt(line, 24, 2);
        dto.RaceNum = FixedWidthUtils.ParseInt(line, 26, 2);
        dto.DayOfWeekCode = FixedWidthUtils.ParseString(line, 28, 1);
        dto.SpecialRaceNum = FixedWidthUtils.ParseInt(line, 29, 4);
        dto.RaceName = FixedWidthUtils.ParseString(line, 33, 60);
        dto.RaceNameSubtitle = FixedWidthUtils.ParseString(line, 93, 60);
        dto.RaceNameNote = FixedWidthUtils.ParseString(line, 153, 60);
        dto.RaceNameEng = FixedWidthUtils.ParseString(line, 213, 120);
        dto.RaceNameSubtitleEng = FixedWidthUtils.ParseString(line, 333, 120);
        dto.RaceNameNoteEng = FixedWidthUtils.ParseString(line, 453, 120);
        dto.RaceNameAbbr10 = FixedWidthUtils.ParseString(line, 573, 20);
        dto.RaceNameAbbr6 = FixedWidthUtils.ParseString(line, 593, 12);
        dto.RaceNameAbbr3 = FixedWidthUtils.ParseString(line, 605, 6);
        dto.RaceNameCategory = FixedWidthUtils.ParseString(line, 611, 1);
        dto.GradeRaceNum = FixedWidthUtils.ParseInt(line, 612, 3);
        dto.GradeCode = FixedWidthUtils.ParseString(line, 615, 1);
        dto.OldGradeCode = FixedWidthUtils.ParseString(line, 616, 1);
        dto.RaceTypeCode = FixedWidthUtils.ParseString(line, 617, 2);
        dto.RaceSymbolCode = FixedWidthUtils.ParseString(line, 619, 3);
        dto.WeightTypeCode = FixedWidthUtils.ParseString(line, 622, 1);
        dto.RaceConditionCode2yo = FixedWidthUtils.ParseString(line, 623, 3);
        dto.RaceConditionCode3yo = FixedWidthUtils.ParseString(line, 626, 3);
        dto.RaceConditionCode4yo = FixedWidthUtils.ParseString(line, 629, 3);
        dto.RaceConditionCode5yoOrOver = FixedWidthUtils.ParseString(line, 632, 3);
        dto.RaceConditionCodeYoungest = FixedWidthUtils.ParseString(line, 635, 3);
        dto.RaceConditionName = FixedWidthUtils.ParseString(line, 638, 60);
        dto.Distance = FixedWidthUtils.ParseInt(line, 698, 4);
        dto.OldDistance = FixedWidthUtils.ParseInt(line, 702, 4);
        dto.TrackCode = FixedWidthUtils.ParseString(line, 706, 2);
        dto.OldTrackCode = FixedWidthUtils.ParseString(line, 708, 2);
        dto.CourseCategory = FixedWidthUtils.ParseString(line, 710, 2);
        dto.OldCourseCategory = FixedWidthUtils.ParseString(line, 712, 2);

        // PrizeMoney (714, 56) -> 7 items * 8 len
        for (int i = 0; i < 7; i++)
        {
            dto.PrizeMoney.Add(FixedWidthUtils.ParseLong(line, 714 + i * 8, 8));
        }

        // OldPrizeMoney (770, 40) -> 5 items * 8 len
        for (int i = 0; i < 5; i++)
        {
            dto.OldPrizeMoney.Add(FixedWidthUtils.ParseLong(line, 770 + i * 8, 8));
        }

        // AddedPrizeMoney (810, 40) -> 5 items * 8 len
        for (int i = 0; i < 5; i++)
        {
            dto.AddedPrizeMoney.Add(FixedWidthUtils.ParseLong(line, 810 + i * 8, 8));
        }

        // OldAddedPrizeMoney (850, 24) -> 3 items * 8 len
        for (int i = 0; i < 3; i++)
        {
            dto.OldAddedPrizeMoney.Add(FixedWidthUtils.ParseLong(line, 850 + i * 8, 8));
        }

        dto.PostTime = FixedWidthUtils.ParseString(line, 874, 4);
        dto.OldPostTime = FixedWidthUtils.ParseString(line, 878, 4);
        dto.RegistrationCount = FixedWidthUtils.ParseInt(line, 882, 2);
        dto.StarterCount = FixedWidthUtils.ParseInt(line, 884, 2);
        dto.FinisherCount = FixedWidthUtils.ParseInt(line, 886, 2);
        dto.WeatherCode = FixedWidthUtils.ParseString(line, 888, 1);
        dto.TurfConditionCode = FixedWidthUtils.ParseString(line, 889, 1);
        dto.DirtConditionCode = FixedWidthUtils.ParseString(line, 890, 1);

        // LapTimes (891, 75) -> 25 items * 3 len
        for (int i = 0; i < 25; i++)
        {
            dto.LapTimes.Add(FixedWidthUtils.ParseInt(line, 891 + i * 3, 3));
        }

        dto.ObstacleMileTime = FixedWidthUtils.ParseString(line, 966, 4);
        dto.First3Furlong = FixedWidthUtils.ParseInt(line, 970, 3);
        dto.First4Furlong = FixedWidthUtils.ParseInt(line, 973, 3);
        dto.Last3Furlong = FixedWidthUtils.ParseInt(line, 976, 3);
        dto.Last4Furlong = FixedWidthUtils.ParseInt(line, 979, 3);

        // CornerPassingInfo (982, 288) -> 4 items * 72 len
        // Corner (1, 1), LapNum (2, 1), PassingOrder (3, 70)
        for (int i = 0; i < 4; i++)
        {
            int basePos = 982 + i * 72;
            var cornerDto = new RaCornerPassingDto
            {
                Corner = FixedWidthUtils.ParseString(line, basePos, 1),
                LapNum = FixedWidthUtils.ParseString(line, basePos + 1, 1),
                // PassingOrderはTrimEndのみ
                PassingOrder = FixedWidthUtils.ParseString(line, basePos + 2, 70, trimEndOnly: true)
            };
            dto.CornerPassingInfo.Add(cornerDto);
        }

        dto.RecordUpdateSpec = FixedWidthUtils.ParseString(line, 1270, 1);

        return dto;
    }
}
