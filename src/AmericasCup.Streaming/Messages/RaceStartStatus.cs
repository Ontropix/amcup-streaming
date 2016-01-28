using System;

namespace AmericasCup.Streaming.Messages
{
    public enum NotificationType
    {
        SetRaceStartTime = 1,
        RacePostponed = 2,
        RaceAbandoned = 3,
        RaceTerminated = 4
    }

    /// <summary>
    /// This message defines when a race is supposed to start
    /// </summary>
    public class RaceStartStatus : Message, IParser
    {
        public byte Version { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime RaceStartTime { get; set; }
        public uint RaceId { get; set; }
        public NotificationType NotificationType { get; set; }

        public Message Parse(Header header, byte[] data, uint crc)
        {
            RaceStartStatus message = new RaceStartStatus
            {
                Header = header,
                Crc = crc,
                Version = data[0],
                TimeStamp = Utility.GetTime(data, 1),
                RaceStartTime = Utility.GetTime(data, 9),
                RaceId = (uint)Utility.GetLongLE(data, 15 , 4),
                NotificationType = (NotificationType)data[19]
            };

            return message;
        }
    }
}