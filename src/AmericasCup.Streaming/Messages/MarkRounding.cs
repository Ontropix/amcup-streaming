using System;

namespace AmericasCup.Streaming.Messages
{
    /// <summary>
    /// Status of the boat in the race
    /// </summary>
    public enum BoatRaceStatus
    {
        Unknown = 0,
        Racing,
        DSQ,
        Withdrawn
    }


    public enum RoundingSide
    {
        Unknown = 0,
        Port,
        Starboat
    }

    public enum MarkType
    {
        RoundingMark,
        /// <summary>
        /// Windward, leeward, start, finish, etc.
        /// </summary>
        Gate
    }

    public class MarkRounding : Message, IParser
    {
        public byte Version { get; set; }
        public DateTime TimeStamp { get; set; }
        public uint RaceId { get; set; }
        public uint SourceId { get; set; }
        public BoatRaceStatus BoatRaceStatus { get; set; }
        public RoundingSide RoundingSide { get; set; }
        public MarkType MarkType { get; set; }

        /// <summary>
        /// 1 to 50 Mark Number
        ///100 => Entry Line
        ///101 => Port Entry Line
        ///103 => Race Start Startline
        ///104 => Race Finishline
        ///105 => Speed test start
        ///106 => Speed test finish
        /// </summary>
        public byte MarkId { get; set; }

        public Message Parse(Header header, byte[] data, uint crc)
        {
            MarkRounding message = new MarkRounding()
            {
                Header = header,
                Crc = crc,
                Version = data[0],
                TimeStamp = Utility.GetTime(data, 1),
                RaceId = (uint)Utility.GetLongLE(data, 9, 4),
                SourceId = (uint)Utility.GetLongLE(data, 13, 4),
                BoatRaceStatus = (BoatRaceStatus)data[17],
                RoundingSide = (RoundingSide)data[18],
                MarkType = (MarkType)data[19],
                MarkId = data[20]
            };

            return message;
        }
    }
}