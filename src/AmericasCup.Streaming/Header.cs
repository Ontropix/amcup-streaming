using System;

namespace AmericasCup.Streaming
{
    public class Header
    {
        public MessageTypes Type { get; set; }
        public DateTime TimeStamp { get; set; }
        public long SourceId { get; set; }
        public int MessageLength { get; set; }
    }
}
