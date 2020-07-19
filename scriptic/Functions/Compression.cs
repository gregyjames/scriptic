using System.IO;
using System.IO.Compression;

namespace scriptic.Functions
{
    public static class Compression
    {
        #region In Memory Compression/Decompression

        public static byte[] CompressStream(byte[] originalSource)
        {
            using (var outStream = new MemoryStream())
            {
                using (var gzip = new GZipStream(outStream, CompressionMode.Compress))
                {
                    gzip.Write(originalSource, 0, originalSource.Length);
                }

                return outStream.ToArray();
            }
        }

        public static byte[] DecompressStream(byte[] originalSource)
        {
            using (var source = new MemoryStream(originalSource))
            {

                using (var outStream = new MemoryStream())
                {
                    using (var gzip = new GZipStream(source, CompressionMode.Decompress))
                    {
                        gzip.CopyTo(outStream);
                    }

                    return outStream.ToArray();
                }
            }
        }

        #endregion
    }
}
