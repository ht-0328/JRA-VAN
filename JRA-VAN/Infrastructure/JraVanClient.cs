using JVDTLabLib;
using System;
using System.Collections.Generic;

namespace JRA_VAN.Infrastructure
{
    public class JraVanClient : IDisposable
    {
        private readonly JVLink _jvLink;
        private readonly JvRecordMapper _mapper;
        private bool _disposed;

        public JraVanClient()
        {
            _jvLink = new JVLink();
            _mapper = new JvRecordMapper();
        }

        /// <summary>
        /// Initializes the JV-Link component.
        /// </summary>
        /// <param name="sid">Service ID (usually "UNKNOWN" for default or specific ID)</param>
        public void Initialize(string sid)
        {
            int result = _jvLink.JVInit(sid);
            if (result != 0)
            {
                throw new JraVanException($"JVInit failed with return code: {result}");
            }
        }

        /// <summary>
        /// Retrieves records matching the specified criteria.
        /// Handles JVOpen, JVGets, and JVClose automatically.
        /// </summary>
        /// <typeparam name="T">The type of record to map to.</typeparam>
        /// <param name="dataSpec">Data specification (e.g., "RACE")</param>
        /// <param name="key">Key for retrieval (e.g., "20260101000000")</param>
        /// <param name="option">Option (e.g., 1)</param>
        /// <returns>An enumerable of mapped records.</returns>
        public IEnumerable<T> GetRecords<T>(string dataSpec, string key, int option) where T : new()
        {
            int readCount = 0;
            int downloadCount = 0;
            string lastTimestamp = "";

            int openResult = _jvLink.JVOpen(dataSpec, key, option, ref readCount, ref downloadCount, out lastTimestamp);
            if (openResult != 0)
            {
                throw new JraVanException($"JVOpen failed with return code: {openResult}");
            }

            // Using try-finally to ensure JVClose is called
            try
            {
                byte[] buffer = new byte[102400]; // Standard buffer size
                int buffSize = buffer.Length;
                string filename = "";

                while (true)
                {
                    object buffObj = buffer;
                    int readResult = _jvLink.JVGets(ref buffObj, buffSize, out filename);

                    if (readResult == 0) break; // End of file
                    if (readResult < 0)
                    {
                         // Treat negative values as error
                         throw new JraVanException($"JVGets failed with return code: {readResult}");
                    }

                    // readResult is the number of bytes read.
                    // Create a slice of the valid data.
                    byte[] recordBytes = new byte[readResult];
                    Array.Copy((byte[])buffObj, recordBytes, readResult);

                    yield return _mapper.Map<T>(recordBytes);

                    // Clear buffer for next read
                    Array.Clear(buffer, 0, buffer.Length);
                }
            }
            finally
            {
                _jvLink.JVClose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Call JVClose if not already closed?
                    // JVClose is safe to call multiple times? Assuming yes or handled in GetRecords.
                    // But if Initialize was called but GetRecords wasn't, we might not need to close anything
                    // except the session if JVInit opens one?
                    // JVLink documentation usually says JVClose closes the *data reading session*.
                    // JVInit doesn't need a close usually, but JVLink object disposal handles cleanup.
                    // We can just rely on GC or explicit Close if needed.
                    try
                    {
                        _jvLink.JVClose();
                    }
                    catch
                    {
                        // Ignore errors during dispose
                    }
                }
                _disposed = true;
            }
        }
    }

    public class JraVanException : Exception
    {
        public JraVanException(string message) : base(message) { }
    }
}
