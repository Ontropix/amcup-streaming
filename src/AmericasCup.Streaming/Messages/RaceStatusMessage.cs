using System;
using System.Collections.Generic;

namespace AmericasCup.Streaming.Messages
{
    public enum RaceStatus
    {
        NotActive = 0,
        /// <remarks>Typically period from 5 to 4 minutes before start</remarks>
        Warning = 1,
        /// <remarks>Typically period from 4 minutes before start until the start</remarks>
        Preparatory = 2,
        Started = 3,
        Finished = 4,
        Retired = 5,
        Abandoned = 6,
        Postponed = 7,
        /// <remarks>All boats finished</remarks>
        Terminated = 8,
        /// <remarks>Race in future. Race Start time not set yet</remarks>
        RaceTimeNotKnown = 9,
        Prestart = 10
    }

    public enum RaceType
    {
        Match = 1,
        Fleet = 2
    }

    public enum BoatStatus
    {
        NotActive = 0,
        Prestart = 1,
        Racing = 2,
        Finished = 3,

        /// <summary>
        /// Did not start
        /// </summary>
        DNS = 4,

        /// <summary>
        /// Did not finish
        /// </summary>
        DNF = 5,

        /// <summary>
        /// Disqualified
        /// </summary>
        DSQ = 6
    }

    public class Boat
    {
        public uint SourceId { get; set; }
        public BoatStatus BoatStatus { get; set; }

        /// <remarks>0 => Prestart, 1 => From start to first mark, 
        /// 2 and above => sequential number as race moves past marks</remarks>
        public uint LegNumber { get; set; }

        public byte NumberPenaltyAwarded { get; set; }
        public byte NumberPenaltyServed { get; set; }
        public TimeSpan EstimatedTimeAtNextMark { get; set; }
        public TimeSpan EstimatedTimeAtFinish { get; set; }
    }

    public class RaceStatusMessage : Message, IParser
    {

        private const int BOAT_MESSAGE_LENGTH = 20;

        public byte Version { get; private set; }
        public DateTime Time { get; private set; }
        public uint RaceId { get; private set; }
        public RaceStatus RaceStatus { get; private set; }
        public DateTime ExpectedStartTime { get; private set; }
        public uint RaceCourseWindDirection { get; private set; }
        public uint RaceCourseWindSpeed { get; private set; }
        public RaceType RaceType { get; private set; }
        public List<Boat> Boats { get; private set; }

        public Message Parse(Header header, byte[] data, uint crc)
        {
            RaceStatusMessage result = new RaceStatusMessage
            {
                Header = header,
                Crc = crc,
                Version = data[0],
                Time = Utility.GetTime(data, 1),
                RaceId = (uint)Utility.GetLongLE(data, 6, 4),
                RaceStatus = (RaceStatus)data[11],
                ExpectedStartTime = Utility.GetTime(data, 12),
                RaceCourseWindDirection = (uint)Utility.GetLongLE(data, 18, 2),
                RaceCourseWindSpeed = (uint)Utility.GetLongLE(data, 20, 2),
                RaceType = (RaceType)data[23],
            };

            List<Boat> boats = new List<Boat>();
            byte count = data[22];
            int offset = 24;
            for (int i = 0; i < count; i++)
            {
                Boat boat = new Boat()
                {
                    SourceId = (uint)Utility.GetLongLE(data, offset, 4),
                    BoatStatus = (BoatStatus)data[offset + 4],
                    LegNumber = data[offset + 5],
                    NumberPenaltyAwarded = data[offset + 6],
                    NumberPenaltyServed = data[offset + 7],
                    EstimatedTimeAtNextMark =  TimeSpan.FromMilliseconds(Utility.GetLongLE(data, offset + 8, 6)),
                    EstimatedTimeAtFinish = TimeSpan.FromMilliseconds(Utility.GetLongLE(data, offset + 14, 6 ))
                };

                boats.Add(boat);
                offset += BOAT_MESSAGE_LENGTH;
            }

            result.Boats = boats;

            return result;
        }
    }
}