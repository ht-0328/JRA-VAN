import re

def to_pascal_case(s):
    s = s.strip()
    s = s.replace('&', 'And')
    # Remove other special chars
    s = re.sub(r'[^a-zA-Z0-9 ]', '', s)
    words = s.split()
    return "".join(word.capitalize() for word in words)

def parse_line(line):
    # Split by '|'
    parts = [p.strip() for p in line.split('|')]
    # Expected columns:
    # 0: ""
    # 1: Byte Count (may be empty)
    # 2: Value (Code)
    # 3: Name
    # 4: EnglishName
    # 5: Description

    if len(parts) < 6:
        return None

    if '---' in line:
        return None

    if "名称" in parts[3]:
        return None
    if "バイト数" in parts[1]:
        return None

    code = parts[2].strip()
    if not code: return None

    jp_name = parts[3]
    eng_name = parts[4] if len(parts) > 4 else ""
    desc = parts[5] if len(parts) > 5 else ""

    # Clean up
    def clean(s):
        if s == "\u00A0" or s == "&nbsp;": return ""
        return s.strip()

    code = clean(code)
    jp_name = clean(jp_name)
    eng_name = clean(eng_name)
    desc = clean(desc)

    return {
        "code": code,
        "name": jp_name,
        "eng_name": eng_name,
        "desc": desc,
    }

def generate_enum():
    lines = []
    with open('temp_weighttype_table.md', 'r', encoding='utf-8') as f:
        lines = f.readlines()

    entries = []

    for line in lines:
        data = parse_line(line)
        if not data:
            continue

        code = data["code"]
        eng_name = data["eng_name"]

        # Determine Member Name
        member_name = ""

        if code == "0":
            member_name = "None"
        elif code == "4":
            # Special handling for "定量" (Fixed Weight) to separate from "別定" (Special Weight)
            member_name = "FixedWeight"
        elif eng_name:
            member_name = to_pascal_case(eng_name)
        else:
            member_name = f"Code{code}"

        data["member_name"] = member_name
        entries.append(data)

    # Generate File Content
    content = """using System.ComponentModel;

namespace JRA_VAN.Shared.Domain.Enums;

/// <summary>
/// 2008.重量種別コード
/// </summary>
public enum WeightTypeCode
{
"""
    for entry in entries:
        content += f"""    /// <summary>
    /// {entry['name']}
    /// </summary>
    [Description("{entry['name']}")]
    {entry['member_name']},\n\n"""

    content += """}

/// <summary>
/// 重量種別コード情報
/// </summary>
/// <param name="Code">値</param>
/// <param name="Name">名称</param>
/// <param name="EnglishName">欧字名</param>
/// <param name="Description">説明</param>
public record WeightTypeInfo(
    string Code,
    string Name,
    string EnglishName,
    string Description
);

/// <summary>
/// 重量種別コード拡張メソッド
/// </summary>
public static class WeightTypeCodeExtensions
{
    /// <summary>
    /// 重量種別コード情報を取得します
    /// </summary>
    public static WeightTypeInfo GetInfo(this WeightTypeCode code)
    {
        return code switch
        {
"""
    for entry in entries:
        content += f"""            WeightTypeCode.{entry['member_name']} => new WeightTypeInfo(
                "{entry['code']}",
                "{entry['name']}",
                "{entry['eng_name']}",
                "{entry['desc']}"),\n"""

    content += """            _ => throw new ArgumentOutOfRangeException(nameof(code), code, null)
        };
    }
}
"""

    with open('WeightTypeCode.cs', 'w', encoding='utf-8') as f:
        f.write(content)

if __name__ == "__main__":
    generate_enum()
