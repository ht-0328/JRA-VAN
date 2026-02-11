using System;

namespace JRA_VAN.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class JvFieldAttribute : Attribute
{
    /// <summary>
    /// 仕様書上の開始位置 (1始まり)
    /// </summary>
    public int Offset { get; set; }

    /// <summary>
    /// バイト長
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// 繰り返し回数 (Listの場合のみ有効)
    /// デフォルトは1
    /// </summary>
    public int Count { get; set; } = 1;
}
