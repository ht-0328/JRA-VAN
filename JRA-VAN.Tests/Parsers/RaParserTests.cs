using Xunit;
using JRA_VAN.Parsers;
using JRA_VAN.Dtos;
using JRA_VAN.Logic;
using System.Linq;
using System.Text;

namespace JRA_VAN.Tests.Parsers;

public class RaParserTests
{
    private string CreateLine(int length = 1272)
    {
        return new string(' ', length);
    }

    private string Inject(string line, int start1Based, string value)
    {
        var chars = line.ToCharArray();
        for (int i = 0; i < value.Length; i++)
        {
            if (start1Based - 1 + i < chars.Length)
            {
                chars[start1Based - 1 + i] = value[i];
            }
        }
        return new string(chars);
    }

    [Fact]
    public void Parse_StandardInput_ReturnsCorrectDto()
    {
        // Arrange
        string line = CreateLine();
        line = Inject(line, 1, "RA"); // RecordSpec
        line = Inject(line, 12, "2023"); // Year
        line = Inject(line, 33, "Test Race Name              "); // RaceName (should be trimmed)

        // PrizeMoney (714, 56) -> 7 * 8
        // 714: "00000100"
        line = Inject(line, 714, "00000100");
        // 722: "00000050"
        line = Inject(line, 722, "00000050");

        // LapTimes (891, 75) -> 25 * 3
        // 891: "123"
        line = Inject(line, 891, "123");

        // CornerPassingInfo (982, 288) -> 4 * 72
        // Corner 1 starts at 982
        // Corner (1,1) -> 982
        line = Inject(line, 982, "1");
        // LapNum (2,1) -> 983
        line = Inject(line, 983, "2");
        // PassingOrder (3,70) -> 984. Preserve leading space.
        // " 1- 2- 3                                                              "
        // 70 chars
        string passingOrder = " 1- 2- 3" + new string(' ', 60);
        line = Inject(line, 984, passingOrder);

        // Act
        var result = JraVanRecordParser.ParseRa(line);

        // Assert
        Assert.Equal("RA", result.RecordSpec);
        Assert.Equal(2023, result.Year);
        Assert.Equal("Test Race Name", result.RaceName);
        Assert.Equal(100, result.PrizeMoney[0]);
        Assert.Equal(50, result.PrizeMoney[1]);
        Assert.Equal(0, result.PrizeMoney[2]); // Default
        Assert.Equal(123, result.LapTimes[0]);
        Assert.Equal(0, result.LapTimes[1]);

        var corner1 = result.CornerPassingInfo[0];
        Assert.Equal("1", corner1.Corner);
        Assert.Equal("2", corner1.LapNum);
        Assert.Equal(" 1- 2- 3", corner1.PassingOrder); // TrimEnd only
    }

    [Fact]
    public void Parse_ShortInput_ReturnsDefaultValues()
    {
        // Arrange
        string line = "RA";

        // Act
        var result = JraVanRecordParser.ParseRa(line);

        // Assert
        Assert.Equal("RA", result.RecordSpec);
        Assert.Equal(0, result.Year);
        Assert.Empty(result.RaceName);

        // Lists should be filled with defaults based on loop counts
        Assert.Equal(7, result.PrizeMoney.Count);
        Assert.All(result.PrizeMoney, x => Assert.Equal(0, x));

        Assert.Equal(25, result.LapTimes.Count);
        Assert.All(result.LapTimes, x => Assert.Equal(0, x));

        Assert.Equal(4, result.CornerPassingInfo.Count);
        Assert.All(result.CornerPassingInfo, x =>
        {
            Assert.Empty(x.Corner);
            Assert.Empty(x.LapNum);
            Assert.Empty(x.PassingOrder);
        });
    }

    [Fact]
    public void Parse_EmptyInput_ReturnsEmptyDto()
    {
        var result = JraVanRecordParser.ParseRa("");
        Assert.Empty(result.RecordSpec);
        Assert.Equal(0, result.Year);
    }
}
