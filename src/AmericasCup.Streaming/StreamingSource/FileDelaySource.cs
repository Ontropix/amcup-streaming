using System.IO;

namespace AmericasCup.Streaming.StreamingSource
{
    public class FileDelaySource : IStreamingSource
    {
        private readonly string _filePath;
        private readonly int _delay;

        public FileDelaySource(string filePath, int delay)
        {
            _filePath = filePath;
            _delay = delay;
        }

        public void Connect()
        {
        }

        public Stream GetStream()
        {
            return new DelayFileStream(_filePath, _delay);
        }

        private class DelayFileStream : FileStream
        {
            private readonly int _delay;
            public DelayFileStream(string path, int delay)
                : base(path, FileMode.Open)
            {
                _delay = delay;
            }

            public override int ReadByte()
            {
                Wait();
                return base.ReadByte();
            }

            public override int Read(byte[] array, int offset, int count)
            {
                Wait();
                return base.Read(array, offset, count);
            }

            private void Wait()
            {
                System.Threading.Thread.Sleep(_delay);
            }
        }
    }
}
