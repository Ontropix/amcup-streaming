using System.Text;

namespace AmericasCup.Streaming.Messages
{
    public enum ChatterMessageType
    {
        Yacht = 1,
        Umpire = 2,
        RaceOfficer = 3,
        Commentary = 4,
        Machine = 5,
    }

    public class ChatterText : Message, IParser
    {
        public byte Version { get; set; }
        public ChatterMessageType ChatterMessageType { get; set; }
        public string Text { get; set; }

        public Message Parse(Header header, byte[] data, uint crc)
        {
            ChatterText message = new ChatterText()
            {
                Header = header,
                Crc = crc,
                Version = data[0],
                ChatterMessageType = (ChatterMessageType)data[1]
            };

            byte length = data[2];
            message.Text = Encoding.ASCII.GetString(data, 3, length);

            return message;
        }
    }
}