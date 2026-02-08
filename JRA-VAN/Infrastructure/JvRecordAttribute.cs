using System;

namespace JRA_VAN.Infrastructure
{
    /// <summary>
    /// プロパティがJV-Linkレコードのフィールドに対応することを示します。
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class JvFieldAttribute : Attribute
    {
        /// <summary>
        /// フィールドの開始バイトオフセット (0始まり)
        /// </summary>
        public int Offset { get; }

        /// <summary>
        /// フィールドのバイト長
        /// </summary>
        public int Length { get; }

        public JvFieldAttribute(int offset, int length)
        {
            Offset = offset;
            Length = length;
        }
    }
}
