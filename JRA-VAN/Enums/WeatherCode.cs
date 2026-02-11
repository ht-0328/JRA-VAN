using System.ComponentModel;

namespace JRA_VAN.Enums;

/// <summary>
/// 2011.天候コード
/// </summary>
public enum WeatherCode
{
    /// <summary>
    /// 未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)
    /// </summary>
    [Description("未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)")]
    None,

    /// <summary>
    /// 晴
    /// </summary>
    [Description("晴")]
    Fine,

    /// <summary>
    /// 曇
    /// </summary>
    [Description("曇")]
    Cloudy,

    /// <summary>
    /// 雨
    /// </summary>
    [Description("雨")]
    Rainy,

    /// <summary>
    /// 小雨
    /// </summary>
    [Description("小雨")]
    Drizzle,

    /// <summary>
    /// 雪
    /// </summary>
    [Description("雪")]
    Snow,

    /// <summary>
    /// 小雪
    /// </summary>
    [Description("小雪")]
    Lightsnow,

}

/// <summary>
/// 天候コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
public record WeatherInfo(
    string Code,
    string Name,
    string EnglishName
);

/// <summary>
/// 天候コード拡張メソッド
/// </summary>
public static class WeatherCodeExtensions
{
    /// <summary>
    /// 天候コード情報を取得します
    /// </summary>
    public static WeatherInfo GetInfo(this WeatherCode code)
    {
        return code switch
        {
            WeatherCode.None => new WeatherInfo(
                "0",
                "未設定・未整備時の初期値 (主に地方競馬・海外国際レースに関するデータ)",
                ""),
            WeatherCode.Fine => new WeatherInfo(
                "1",
                "晴",
                "Fine"),
            WeatherCode.Cloudy => new WeatherInfo(
                "2",
                "曇",
                "Cloudy"),
            WeatherCode.Rainy => new WeatherInfo(
                "3",
                "雨",
                "Rainy"),
            WeatherCode.Drizzle => new WeatherInfo(
                "4",
                "小雨",
                "Drizzle"),
            WeatherCode.Snow => new WeatherInfo(
                "5",
                "雪",
                "Snow"),
            WeatherCode.Lightsnow => new WeatherInfo(
                "6",
                "小雪",
                "Light Snow"),
            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
