using System;
using System.Reflection;
using System.Text;

namespace JRA_VAN.Infrastructure;

/// <summary>
/// バイト配列を属性に基づいてPOCOにマッピングするクラス。
/// </summary>
public class JvRecordMapper
{
    private readonly Encoding _encoding;

    public JvRecordMapper()
    {
        // CodePagesのプロバイダーを登録します。
        // 複数回呼び出しても安全です。
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        _encoding = Encoding.GetEncoding("Shift_JIS");
    }

    /// <summary>
    /// バイトデータを指定された型にマップします。
    /// </summary>
    /// <typeparam name="T">マッピング対象のクラス型</typeparam>
    /// <param name="data">データレコードのバイト配列</param>
    /// <returns>マップされたオブジェクト</returns>
    public T Map<T>(byte[] data) where T : new()
    {
        var result = new T();
        var type = typeof(T);

        foreach (var prop in type.GetProperties())
        {
            var attr = prop.GetCustomAttribute<JvFieldAttribute>();
            if (attr == null) continue;

            if (attr.Offset < 0 || attr.Length < 0 || attr.Offset + attr.Length > data.Length)
            {
                // 実運用ではログ出力やエラーハンドリングを適切に行うべき箇所ですが、
                // ここではスキーマ不整合を検知するため例外をスローします。
                throw new ArgumentOutOfRangeException(
                    nameof(data),
                    $"Field '{prop.Name}' (Offset: {attr.Offset}, Length: {attr.Length}) is out of bounds for data length {data.Length}."
                );
            }

            // Shift-JISでデコード
            var value = _encoding.GetString(data, attr.Offset, attr.Length);

            // 前後の空白やNULL文字を削除
            value = value.Trim('\0', ' ');

            if (prop.PropertyType == typeof(string))
            {
                prop.SetValue(result, value);
            }
            else if (prop.PropertyType == typeof(int))
            {
                if (int.TryParse(value, out var intVal))
                {
                    prop.SetValue(result, intVal);
                }
            }
            // 必要に応じて他の型のサポートを追加可能
        }

        return result;
    }
}
