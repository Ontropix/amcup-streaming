using System;

namespace AmericasCup.Streaming.Messages
{
    public enum EventType
    {
        EnteredEarly = 1,
        NotOverStartline1MinBeforeStart = 2,
        OverStartlineEarly = 3,
        ClearBehindStartline = 4,
        YFlagPenalty = 5,
        NoPenalty = 6,
        DSQ41 = 7,
        DSQ = 8,
        PenaltyComplete = 9,
        PenaltyOffset = 10,
        Finished = 11,
        YFlagProtestAcknowledgement = 12,
        PenaltyDealtWith = 13,
        DNS = 14,
        DNF = 15,
        RaceTerminated = 16,
        Penalty442b = 17,
        YachtLimitBoundaryViolation = 18,
        ClearSinglePenalty = 19,
        ClearAtStart = 20,
        NotAFinish = 21,
        OCSPenaltyComplete = 22,
        ZeroPenaly = 100,
        OnePenalty = 101,
        TwoPenalty = 102,
        ThreePenalty = 103,
        FourPenalty = 104,
        FivePenalty = 105,
        SixPenalty = 106,
        SevenPenalty = 107,
        EightPenalty = 108
    }

    public class YachtEventCode : Message, IParser
    {

        public byte Version { get; private set; }

        /// <summary>
        /// When the button was pressed
        /// </summary>
        public DateTime Time { get; private set; }

        /// <summary>
        /// Unique RaceId
        /// </summary>
        public uint RaceId { get; private set; }

        /// <summary>
        /// Source Id fot the destination device (Subject yacht)
        /// </summary>
        public uint DestinationSourceId { get; private set; }

        public EventType EventType { get; private set; }


        public Message Parse(Header header, byte[] data, uint crc)
        {
            YachtEventCode message = new YachtEventCode()
            {
                Header = header,
                Crc = crc,
                Version = data[0],
                Time = Utility.GetTime(data, 1),
                RaceId = (uint)Utility.GetLongLE(data, 9, 4),
                DestinationSourceId = (uint)Utility.GetLongLE(data, 13, 4),
                EventType = (EventType)data[17]
            };

            return message;
        }
    }
}