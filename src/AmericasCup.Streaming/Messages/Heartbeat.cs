
    namespace AmericasCup.Streaming.Messages
    {
        public class Heartbeat : Message, IParser
        {
            public uint SequenceNum { get; set; }

            public Message Parse(Header header, byte[] data, uint crc32)
            {
                return new Heartbeat()
                {
                    Header = header,
                    SequenceNum = (uint)Utility.GetLongLE(data, 0, 4),
                    Crc = crc32
                };
            }
        }
    }
