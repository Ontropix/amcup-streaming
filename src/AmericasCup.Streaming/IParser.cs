


    using AmericasCup.Streaming.Messages;

namespace AmericasCup.Streaming
    {
        public interface IParser
        {
            /// <summary>
            /// Parse the given data
            /// </summary>
            /// <param name="header">Header</param>
            /// <param name="data">Raw data</param>
            /// <param name="crc">Crc hash</param>
            /// <returns>Parsed message</returns>
            Message Parse(Header header, byte[] data, uint crc);
        }
    }
