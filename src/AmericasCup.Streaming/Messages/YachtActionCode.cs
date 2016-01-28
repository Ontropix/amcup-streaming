using System;

namespace AmericasCup.Streaming.Messages
{
    public enum YachtActionType
    {
        YFlagProtest = 1,
        BFlagProtest = 2
    }

    public class YachtActionCode : Message, IParser
    {
        public byte Version { get; set; }
        public DateTime TimeStamp { get; set; }
        public uint OriginatorSourceId { get; set; }
        public YachtActionType YachtActionType { get; set; }


        public Message Parse(Header header, byte[] data, uint crc)
        {
            YachtActionCode message = new YachtActionCode()
            {
                Header = header,
                Crc = crc,
                Version = data[0],
                TimeStamp = Utility.GetTime(data, 1),
                OriginatorSourceId = (uint)Utility.GetLongLE(data, 9, 4),
                YachtActionType = (YachtActionType)data[13]
            };

            return message;
        }
    }
}