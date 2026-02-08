using System;

namespace JRA_VAN.Infrastructure
{
    /// <summary>
    /// Indicates that the property maps to a field in a JV-Link record.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class JvFieldAttribute : Attribute
    {
        /// <summary>
        /// The byte offset (0-based) where the field starts.
        /// </summary>
        public int Offset { get; }

        /// <summary>
        /// The length of the field in bytes.
        /// </summary>
        public int Length { get; }

        public JvFieldAttribute(int offset, int length)
        {
            Offset = offset;
            Length = length;
        }
    }
}
