using System.IO;

namespace AmericasCup.Streaming.StreamingSource
{
    public interface IStreamingSource
    {
        /// <summary>
        /// Connect to the stream
        /// </summary>
        void Connect();

        /// <summary>
        /// Returns the stream to read
        /// </summary>
        Stream GetStream();
    }
}
