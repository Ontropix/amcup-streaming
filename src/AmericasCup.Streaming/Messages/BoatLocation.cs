using System;

namespace AmericasCup.Streaming.Messages
{
    public enum DeviceType
    {
        Unknown,
        RacingYacht,
        SignalBoat,
        Mark,
        Pin
    }

    public class BoatLocation : Message, IParser //Message size: 56
    {
        public byte Version { get; set; }
        public DateTime Time { get; set; }
        public uint SourceId { get; set; }
        public uint SequenceNum { get; set; }
        public DeviceType DeviceType { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Altitude { get; set; }

        public float Heading { get; set; }
        public float Pitch { get; set; }
        public float Roll { get; set; }
        public float BoatSpeed { get; set; } //mm/sec

        /// <summary>
        /// Course over ground
        /// </summary>
        public uint COG { get; set; }

        /// <summary>
        /// Speed over ground
        /// </summary>
        public uint SOG { get; set; } //  mm/sec

        public uint ApparentWindSpeed { get; set; } // mm/sec
        public float ApparentWindAngle { get; set; }
        public uint TrueWindSpeed { get; set; }
        public uint TrueWindDirection { get; set; }
        public float TrueWindAngle { get; set; }
        public uint CurrentDrift { get; set; }
        public uint CurrentSet { get; set; }
        public float RudderAngle { get; set; }

        public Message Parse(Header header, byte[] data, uint crc)
        {
            return new BoatLocation
            {
                Version = data[0],
                Time = Utility.GetTime(data, 1),
                SourceId = (uint)Utility.GetLongLE(data, 7, 4),
                SequenceNum = (uint)Utility.GetLongLE(data, 11, 4),
                DeviceType = (DeviceType)data[15],
                Latitude = Utility.ToLatitude(Utility.GetLongLE(data, 16, 4)),
                Longitude = Utility.ToLongitude(Utility.GetLongLE(data, 20, 4)),
                Altitude = (int)Utility.GetLongLE(data, 24, 4), //cm relative to MSL (Mean sea level)
                Heading = Utility.GetHeading(Utility.GetLongLE(data, 28, 2)),
                Pitch = Utility.ToDegree(Utility.GetLongLE(data, 30, 2)),
                Roll = Utility.ToDegree(Utility.GetLongLE(data, 32, 2)),
                BoatSpeed = (uint)Utility.GetLongLE(data, 34, 2),
                COG = (uint)Utility.GetLongLE(data, 36, 2),
                SOG = (uint)Utility.GetLongLE(data, 38, 2),
                ApparentWindSpeed = (uint)Utility.GetLongLE(data, 40, 2), 
                ApparentWindAngle = Utility.ToDegree(Utility.GetLongLE(data, 42, 2)),
                TrueWindSpeed = (uint)Utility.GetLongLE(data, 44, 2),
                TrueWindDirection = (uint)Utility.GetLongLE(data, 46, 2),
                TrueWindAngle = Utility.ToDegree(Utility.GetLongLE(data, 48, 2)),
                CurrentDrift = (uint)Utility.GetLongLE(data, 50, 2),
                CurrentSet = (uint)Utility.GetLongLE(data, 52, 2),
                RudderAngle = Utility.ToDegree(Utility.GetLongLE(data, 54, 2)),
                Header = header,
                Crc = crc
            };
        }
    }
}