using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AmericasCup.Streaming
{
    public static class Utility
    {
        public static bool IsNorthLatitude = true;
        public static bool IsEastLongitude = true;

        private static readonly DateTime EPOCH = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private const int TIMESTAMP_LENGTH = 6;
        private const float DEVIDER = 2147483648.0f;

        public static DateTime GetTime(byte[] buffer, int offset)
        {
            byte[] timestamp = new byte[TIMESTAMP_LENGTH];
            Array.Copy(buffer, offset, timestamp, 0, timestamp.Length);
            long milliseconds = GetLongLE(timestamp, 0, TIMESTAMP_LENGTH);
            return EPOCH.AddMilliseconds(milliseconds);

        }

        public static long GetLongLE(byte[] buffer, int startIndex, int count)
        {
            long result = 0;
            long multiplier = 1;
            for (int i = 0; i < count; i++)
            {
                result += buffer[startIndex + i] * multiplier;
                multiplier *= 256;
            }
            return result;
        }

        public static float ToLongitude(long packed)
        {
            float value = packed * 180.0f / DEVIDER;
            return IsEastLongitude ? value : value - 360f;
        }

        public static float ToLatitude(long packed)
        {
            float value = packed * 180.0f / DEVIDER;
            return IsNorthLatitude ? value : value - 360f;
        }

        public static float ToDegree(long packed)
        {
            return packed * 180.0f / 32768;
        }
   
        public static T FromXml<T>(string xml)
        {
            using (StringReader reader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof(T));
                return ((T)(serializer.Deserialize(XmlReader.Create(reader))));
            }
        }

        public static float GetHeading(long packed)
        {
            return packed * 360.0f / 65536.0f;
        }
    }
}

