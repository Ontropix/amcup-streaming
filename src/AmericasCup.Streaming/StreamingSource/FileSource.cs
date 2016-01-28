using System.IO;

namespace AmericasCup.Streaming.StreamingSource
{
    public class FileSource : IStreamingSource
    {
        private readonly string _filePath;

        public FileSource(string filePath)
        {
            _filePath = filePath;
        }

        public void Connect()
        {
        }

        public Stream GetStream()
        {
            return File.OpenRead(_filePath);
        }
    }
}

