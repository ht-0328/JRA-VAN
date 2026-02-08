using System;

namespace JRA_VAN.Infrastructure
{
    /// <summary>
    /// クラスが特定のJV-LinkレコードID（データ種別）に対応することを示します。
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class JvRecordSpecAttribute : Attribute
    {
        /// <summary>
        /// レコードID（例: "RA"）
        /// </summary>
        public string RecordId { get; }

        public JvRecordSpecAttribute(string recordId)
        {
            RecordId = recordId;
        }
    }

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
