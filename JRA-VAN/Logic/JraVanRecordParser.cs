using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using JRA_VAN.Attributes;
using JRA_VAN.Models;

namespace JRA_VAN.Logic;

public static class JraVanRecordParser
{
    private static readonly Encoding Sjis;

    static JraVanRecordParser()
    {
        // Ensure Shift_JIS is available
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Sjis = Encoding.GetEncoding("Shift_JIS");
    }

    /// <summary>
    /// バイト配列から指定された型のオブジェクトをパースします。
    /// </summary>
    /// <typeparam name="T">対象のDTO型</typeparam>
    /// <param name="data">JRA-VANから取得した生データ</param>
    /// <returns>パースされたオブジェクト</returns>
    public static T Parse<T>(byte[] data) where T : new()
    {
        var instance = new T();
        var type = typeof(T);
        var properties = type.GetProperties();

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<JvFieldAttribute>();
            if (attr == null) continue;

            // 1始まりのオフセットを0始まりに補正
            int startOffset = attr.Offset - 1;

            // バッファ長チェック
            if (data.Length < startOffset + attr.Length)
            {
                // データが足りない場合はスキップ、またはデフォルト値
                // ここでは安全にスキップするか、可能な範囲で読む実装にする
                // 今回は単純に範囲外なら無視する
                continue;
            }

            if (prop.PropertyType == typeof(string))
            {
                string value = Sjis.GetString(data, startOffset, attr.Length).Trim();
                prop.SetValue(instance, value);
            }
            else if (prop.PropertyType == typeof(int))
            {
                string strVal = Sjis.GetString(data, startOffset, attr.Length).Trim();
                if (int.TryParse(strVal, out int intVal))
                {
                    prop.SetValue(instance, intVal);
                }
            }
            else if (prop.PropertyType == typeof(long))
            {
                string strVal = Sjis.GetString(data, startOffset, attr.Length).Trim();
                if (long.TryParse(strVal, out long longVal))
                {
                    prop.SetValue(instance, longVal);
                }
            }
            else if (typeof(IEnumerable).IsAssignableFrom(prop.PropertyType) && prop.PropertyType != typeof(string))
            {
                // List<T> の処理
                Type itemType = prop.PropertyType.GetGenericArguments()[0];
                var list = (IList?)Activator.CreateInstance(typeof(List<>).MakeGenericType(itemType));
                if (list == null) continue;

                for (int i = 0; i < attr.Count; i++)
                {
                    int currentOffset = startOffset + (i * attr.Length);

                    // リスト項目のバッファ範囲チェック
                    if (data.Length < currentOffset + attr.Length) break;

                    if (itemType == typeof(int))
                    {
                        string strVal = Sjis.GetString(data, currentOffset, attr.Length).Trim();
                        if (int.TryParse(strVal, out int val)) list.Add(val);
                        else list.Add(0); // パース失敗時は0
                    }
                    else if (itemType == typeof(long))
                    {
                        string strVal = Sjis.GetString(data, currentOffset, attr.Length).Trim();
                        if (long.TryParse(strVal, out long val)) list.Add(val);
                        else list.Add(0L);
                    }
                    else if (itemType.IsClass)
                    {
                        // 複合型の場合は再帰的にパース
                        // 対象部分を切り出す
                        byte[] itemBytes = new byte[attr.Length];
                        Array.Copy(data, currentOffset, itemBytes, 0, attr.Length);

                        // ジェネリックメソッド Parse<ItemType> を呼び出す
                        MethodInfo method = typeof(JraVanRecordParser)
                            .GetMethods(BindingFlags.Public | BindingFlags.Static)
                            .First(m => m.Name == nameof(Parse) && m.IsGenericMethodDefinition);
                        MethodInfo generic = method.MakeGenericMethod(itemType);
                        var itemInstance = generic.Invoke(null, new object[] { itemBytes });

                        list.Add(itemInstance);
                    }
                }
                prop.SetValue(instance, list);
            }
        }

        return instance;
    }

    // 既存互換性のために残すか、削除するか。
    // Program.cs を更新する前提なので、削除してもよいが、安全のために残して警告を出す形にするか、
    // あるいは単純に新しいロジックを使う形にラップする。
    // RaceRecord は DTO と構造が違うため、マッピングが必要。
    public static RaceRecord Parse(byte[] data)
    {
        // レガシーサポート: 直接パースする（既存ロジックの再利用）
        // ただし、今回はジェネリックパーサーの作成が主目的なので、
        // 既存のコードはそのまま残しつつ、新しいメソッドを追加する形が一番安全だが、
        // クラス全体を書き換えているので、ここも手動でパースする

        string raceDate = Sjis.GetString(data, 10, 8); // Offset 11 -> 10
        string raceNum = Sjis.GetString(data, 24, 2);  // Offset 25 -> 24
        string horseName = Sjis.GetString(data, 36, 36).Trim(); // Offset 37 -> 36

        return new RaceRecord(raceDate, raceNum, horseName);
    }
}
