using System;
using System.Reflection;
using System.Text;

namespace JRA_VAN.Infrastructure
{
    public class JvRecordMapper
    {
        private readonly Encoding _encoding;

        public JvRecordMapper()
        {
            // Ensure CodePages are registered.
            // This might be called multiple times but it's safe.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _encoding = Encoding.GetEncoding("Shift_JIS");
        }

        public T Map<T>(byte[] data) where T : new()
        {
            var result = new T();
            var type = typeof(T);

            foreach (var prop in type.GetProperties())
            {
                var attr = prop.GetCustomAttribute<JvFieldAttribute>();
                if (attr != null)
                {
                    if (attr.Offset < 0 || attr.Length < 0 || attr.Offset + attr.Length > data.Length)
                    {
                        // In a real app, maybe log or handle gracefully.
                        // Here we throw to highlight schema mismatches.
                        throw new ArgumentOutOfRangeException(
                            nameof(data),
                            $"Field '{prop.Name}' (Offset: {attr.Offset}, Length: {attr.Length}) is out of bounds for data length {data.Length}."
                        );
                    }

                    // Decode using Shift-JIS
                    string value = _encoding.GetString(data, attr.Offset, attr.Length);

                    // Trim nulls and spaces
                    value = value.Trim('\0', ' ');

                    if (prop.PropertyType == typeof(string))
                    {
                        prop.SetValue(result, value);
                    }
                    else if (prop.PropertyType == typeof(int))
                    {
                        if (int.TryParse(value, out int intVal))
                        {
                            prop.SetValue(result, intVal);
                        }
                    }
                    // Extend for other types as needed
                }
            }

            return result;
        }
    }
}
