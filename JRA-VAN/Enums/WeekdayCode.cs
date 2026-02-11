using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2002.曜日コード
/// </summary>
public enum WeekdayCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 土曜日
    /// </summary>
    [Description("土曜日")]
    Saturday,

    /// <summary>
    /// 日曜日
    /// </summary>
    [Description("日曜日")]
    Sunday,

    /// <summary>
    /// 祝日
    /// </summary>
    [Description("祝日")]
    NationalHoliday,

    /// <summary>
    /// 月曜日
    /// </summary>
    [Description("月曜日")]
    Monday,

    /// <summary>
    /// 火曜日
    /// </summary>
    [Description("火曜日")]
    Tuesday,

    /// <summary>
    /// 水曜日
    /// </summary>
    [Description("水曜日")]
    Wednesday,

    /// <summary>
    /// 木曜日
    /// </summary>
    [Description("木曜日")]
    Thursday,

    /// <summary>
    /// 金曜日
    /// </summary>
    [Description("金曜日")]
    Friday,

}

/// <summary>
/// 曜日コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="Abbr1">略名(1文字)</param>
/// <param name="Abbr2">略名(2文字)</param>
/// <param name="Abbr3">略名(3文字)</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="EnglishAbbr3">欧字略名(3文字)</param>
public record WeekdayInfo(
    string Code,
    string Name,
    string Abbr1,
    string Abbr2,
    string Abbr3,
    string EnglishName,
    string EnglishAbbr3
);

/// <summary>
/// 曜日コード拡張メソッド
/// </summary>
public static class WeekdayCodeExtensions
{
    /// <summary>
    /// 曜日コード情報を取得します
    /// </summary>
    public static WeekdayInfo GetInfo(this WeekdayCode code)
    {
        return code switch
        {
            WeekdayCode.None => new WeekdayInfo(
                "0",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                "",
                "",
                "",
                "",
                ""),
            WeekdayCode.Saturday => new WeekdayInfo(
                "1",
                "土曜日",
                "土",
                "土曜",
                "土曜日",
                "SATURDAY",
                "SAT"),
            WeekdayCode.Sunday => new WeekdayInfo(
                "2",
                "日曜日",
                "日",
                "日曜",
                "日曜日",
                "SUNDAY",
                "SUN"),
            WeekdayCode.NationalHoliday => new WeekdayInfo(
                "3",
                "祝日",
                "祝",
                "祝日",
                "祝日",
                "NATIONAL HOLIDAY",
                "HOL"),
            WeekdayCode.Monday => new WeekdayInfo(
                "4",
                "月曜日",
                "月",
                "月曜",
                "月曜日",
                "MONDAY",
                "MON"),
            WeekdayCode.Tuesday => new WeekdayInfo(
                "5",
                "火曜日",
                "火",
                "火曜",
                "火曜日",
                "TUESDAY",
                "TUE"),
            WeekdayCode.Wednesday => new WeekdayInfo(
                "6",
                "水曜日",
                "水",
                "水曜",
                "水曜日",
                "WEDNESDAY",
                "WED"),
            WeekdayCode.Thursday => new WeekdayInfo(
                "7",
                "木曜日",
                "木",
                "木曜",
                "木曜日",
                "THURSDAY",
                "THU"),
            WeekdayCode.Friday => new WeekdayInfo(
                "8",
                "金曜日",
                "金",
                "金曜",
                "金曜日",
                "FRIDAY",
                "FRI"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
