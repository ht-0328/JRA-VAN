using JRA_VAN.Infrastructure;
using JRA_VAN.Models;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Ensure Shift-JIS is available
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        // Verification mode for testing without COM
        if (args.Length > 0 && args[0] == "verify")
        {
            VerifyMapper();
            return;
        }

        Console.WriteLine("Data acquisition and parsing started...");

        try
        {
            // Note: This will throw on environments where JVDTLabLib COM is not registered (e.g., Linux CI)
            using (var client = new JraVanClient())
            {
                // 1. Initialize
                client.Initialize("UNKNOWN");

                // 2. Retrieve Data
                // Example: Fetch "RA" (Sokuho Race Info) from a specific starting point.
                // Adjust the key (timestamp) as needed.
                string targetSpec = "RA";
                string key = "20240101000000";
                int option = 1; // Standard

                Console.WriteLine($"Fetching {targetSpec} records since {key}...");

                var records = client.GetRecords<RaRecord>(targetSpec, key, option);
                int count = 0;

                foreach (var record in records)
                {
                    Console.WriteLine(record.ToString());
                    count++;
                }

                Console.WriteLine($"--------------------------------------------------");
                Console.WriteLine($"Total Records Processed: {count}");
            }
        }
        catch (JraVanException ex)
        {
            Console.WriteLine($"[JRA-VAN Error] {ex.Message}");
        }
        catch (TypeInitializationException ex)
        {
            Console.WriteLine($"[COM Error] Could not initialize COM component. This app requires JRA-VAN JV-Link installed on Windows.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Error] {ex.Message}");
            Console.WriteLine(ex.StackTrace);
        }

        Console.WriteLine("Press any key to exit...");
        // Console.ReadKey(); // Commented out for non-interactive environments
    }

    /// <summary>
    /// Verifies the mapping logic without requiring the COM component.
    /// </summary>
    static void VerifyMapper()
    {
        Console.WriteLine("Running Mapper Verification...");

        try
        {
            // Create a dummy byte array simulating a record
            // Size needs to accommodate the largest offset+length (33+60 = 93)
            byte[] data = new byte[100];
            Encoding sjis = Encoding.GetEncoding("Shift_JIS");

            // Helper to write string at offset
            void Write(int offset, string value)
            {
                byte[] b = sjis.GetBytes(value);
                Array.Copy(b, 0, data, offset, b.Length);
            }

            // Fill data according to RaRecord spec
            // Year: 11, 4
            Write(11, "2024");
            // MonthDay: 15, 4
            Write(15, "0526"); // May 26th
            // Course: 19, 2
            Write(19, "05"); // Tokyo?
            // RaceNum: 25, 2
            Write(25, "11"); // 11R
            // RaceName: 33, 60
            Write(33, "Japanese Derby (G1)");

            // Test Mapping
            var mapper = new JvRecordMapper();
            var record = mapper.Map<RaRecord>(data);

            Console.WriteLine($"Mapped: {record}");

            // Assertions
            if (record.Year != "2024") throw new Exception($"Year mismatch: {record.Year}");
            if (record.MonthDay != "0526") throw new Exception($"MonthDay mismatch: {record.MonthDay}");
            if (record.CourseCode != "05") throw new Exception($"CourseCode mismatch: {record.CourseCode}");
            if (record.RaceNumber != "11") throw new Exception($"RaceNumber mismatch: {record.RaceNumber}");
            if (record.RaceName != "Japanese Derby (G1)") throw new Exception($"RaceName mismatch: {record.RaceName}");

            Console.WriteLine("VERIFICATION PASSED!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"VERIFICATION FAILED: {ex.Message}");
            Environment.Exit(1);
        }
    }
}
