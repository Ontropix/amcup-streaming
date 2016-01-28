
    namespace AmericasCup.Streaming.Messages
    {
        public abstract class Message
        {
            public Header Header { get; set; }
            public uint Crc { get; set; }
        }
    }
