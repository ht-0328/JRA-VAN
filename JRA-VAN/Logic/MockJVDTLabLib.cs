using System.Text;

namespace JVDTLabLib;

public class JVLink
{
    private Queue<byte[]> _mockDataQueue = new();

    public int JVInit(string sid)
    {
        return 0; // Success
    }

    public int JVOpen(string dataspec, string fromtime, int option, ref int readcount, ref int downloadcount, out string lasttime)
    {
        // Simulate returning 3 records
        readcount = 3;
        downloadcount = 3;
        lasttime = "20260208000000";

        _mockDataQueue.Clear();
        // RA Record
        _mockDataQueue.Enqueue(CreateRaRecord("20260208", "05", "01", "01", "11", "Mock Derby", "2400", "1", "1"));
        // SE Record 1
        _mockDataQueue.Enqueue(CreateSeRecord("20260208", "05", "01", "01", "11", "Deep Impact", "01", "2234", "450", "12345", "54321"));
        // SE Record 2
        _mockDataQueue.Enqueue(CreateSeRecord("20260208", "05", "01", "01", "11", "King Kamehameha", "02", "2235", "460", "67890", "09876"));

        return 0;
    }

    public int JVGets(ref object buff, int size, out string fname)
    {
        fname = "MOCK_DATA";
        if (_mockDataQueue.Count == 0)
        {
            return 0; // EOF
        }

        if (_mockDataQueue.TryDequeue(out byte[]? record))
        {
            if (record.Length > size)
            {
                return -3; // Insufficient buffer
            }
            // Copy data to the provided buffer
            Array.Copy(record, (byte[])buff, record.Length);
            return 1; // Return 1 to indicate success and data present
        }

        return 0;
    }

    public int JVClose()
    {
        return 0;
    }

    private byte[] CreateRaRecord(string date, string place, string kai, string nichi, string num, string name, string dist, string weather, string track)
    {
        byte[] buffer = new byte[1024];
        for (int i = 0; i < buffer.Length; i++) buffer[i] = 0x20; // Pad with spaces

        Encoding sjis = Encoding.GetEncoding("Shift_JIS");

        // "RA"
        WriteString(buffer, 0, "RA", sjis);
        // Date 11
        WriteString(buffer, 11, date, sjis);
        // Place 19
        WriteString(buffer, 19, place, sjis);
        // Kai 21
        WriteString(buffer, 21, kai, sjis);
        // Nichi 23
        WriteString(buffer, 23, nichi, sjis);
        // Num 25
        WriteString(buffer, 25, num, sjis);
        // Name 27 (Custom offset)
        WriteString(buffer, 27, name, sjis);
        // Dist 50 (Custom)
        WriteString(buffer, 50, dist, sjis);
        // Weather 60
        WriteString(buffer, 60, weather, sjis);
        // Track 61
        WriteString(buffer, 61, track, sjis);

        return buffer;
    }

    private byte[] CreateSeRecord(string date, string place, string kai, string nichi, string num, string name, string order, string time, string weight, string jCode, string tCode)
    {
        byte[] buffer = new byte[1024];
        for (int i = 0; i < buffer.Length; i++) buffer[i] = 0x20; // Pad with spaces

        Encoding sjis = Encoding.GetEncoding("Shift_JIS");

        // "SE"
        WriteString(buffer, 0, "SE", sjis);
        // Date 11
        WriteString(buffer, 11, date, sjis);
        // Place 19
        WriteString(buffer, 19, place, sjis);
        // Kai 21
        WriteString(buffer, 21, kai, sjis);
        // Nichi 23
        WriteString(buffer, 23, nichi, sjis);
        // Num 25
        WriteString(buffer, 25, num, sjis);
        // Name 37
        WriteString(buffer, 37, name, sjis);
        // Order 73 (Custom)
        WriteString(buffer, 73, order, sjis);
        // Time 75 (Custom)
        WriteString(buffer, 75, time, sjis);
        // Weight 80 (Custom)
        WriteString(buffer, 80, weight, sjis);
        // Jockey 85
        WriteString(buffer, 85, jCode, sjis);
        // Trainer 90
        WriteString(buffer, 90, tCode, sjis);

        return buffer;
    }

    private void WriteString(byte[] buffer, int offset, string value, Encoding encoding)
    {
        byte[] bytes = encoding.GetBytes(value);
        Array.Copy(bytes, 0, buffer, offset, bytes.Length);
    }
}
