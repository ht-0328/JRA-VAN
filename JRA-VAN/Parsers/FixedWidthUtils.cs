using System;

namespace JRA_VAN.Parsers;

public static class FixedWidthUtils
{
    /// <summary>
    /// 指定された位置から指定された長さの文字列を安全に切り出します。
    /// 入力文字列が短い場合は、切り出せる部分のみを返します（範囲外の場合は空文字列）。
    /// </summary>
    /// <param name="line">入力文字列</param>
    /// <param name="start1Based">開始位置（1始まり）</param>
    /// <param name="length">長さ</param>
    /// <returns>切り出された文字列</returns>
    public static string SafeSlice(string line, int start1Based, int length)
    {
        if (string.IsNullOrEmpty(line))
        {
            return string.Empty;
        }

        int startIndex = start1Based - 1;

        if (startIndex < 0)
        {
            return string.Empty;
        }

        if (startIndex >= line.Length)
        {
            return string.Empty;
        }

        int actualLength = Math.Min(length, line.Length - startIndex);
        return line.Substring(startIndex, actualLength);
    }

    /// <summary>
    /// 文字列を安全にintにパースします。
    /// 空文字、空白のみ、パース失敗時は0を返します。
    /// </summary>
    public static int ParseInt(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return 0;
        }

        if (int.TryParse(value.Trim(), out int result))
        {
            return result;
        }

        return 0;
    }

    /// <summary>
    /// 指定位置からintをパースします。
    /// </summary>
    public static int ParseInt(string line, int start1Based, int length)
    {
        return ParseInt(SafeSlice(line, start1Based, length));
    }

    /// <summary>
    /// 文字列を安全にlongにパースします。
    /// 空文字、空白のみ、パース失敗時は0を返します。
    /// </summary>
    public static long ParseLong(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return 0;
        }

        if (long.TryParse(value.Trim(), out long result))
        {
            return result;
        }

        return 0;
    }

    /// <summary>
    /// 指定位置からlongをパースします。
    /// </summary>
    public static long ParseLong(string line, int start1Based, int length)
    {
        return ParseLong(SafeSlice(line, start1Based, length));
    }

    /// <summary>
    /// 指定された位置から切り出し、トリムを行います。
    /// </summary>
    /// <param name="line">入力文字列</param>
    /// <param name="start1Based">開始位置（1始まり）</param>
    /// <param name="length">長さ</param>
    /// <param name="trimEndOnly">末尾のみトリムするかどうか（デフォルトは両端トリム）</param>
    /// <returns>トリムされた文字列</returns>
    public static string ParseString(string line, int start1Based, int length, bool trimEndOnly = false)
    {
        var slice = SafeSlice(line, start1Based, length);
        return trimEndOnly ? slice.TrimEnd() : slice.Trim();
    }
}
