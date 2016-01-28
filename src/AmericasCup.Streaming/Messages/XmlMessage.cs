using System;
using System.Text;
using AmericasCup.Streaming.Xsd;

namespace AmericasCup.Streaming.Messages
{
    public enum XmlMessageSubType
    {
        Regatta = 5,
        Race = 6,
        Boat = 7
    }

    public class XmlMessage : Message, IParser
    {
        public byte Version { get; set; }
        public DateTime TimeStamp { get; set; }
        public XmlMessageSubType SubType { get; set; }

        /// <summary>
        /// Sequence number of XML. Changes whenever the XML content of the particual XmlMsgSubType changes.
        /// </summary>
        public uint SequenceNumber { get; set; }

        /// <summary>
        /// The actual xml paragraph
        /// </summary>
        public string Text { get; set; }


        public object Config { get; set; }

        public Message Parse(Header header, byte[] data, uint crc)
        {
            XmlMessage message = new XmlMessage()
            {
                Header = header,
                Version = data[0],
                TimeStamp = Utility.GetTime(data, 3),
                SubType = (XmlMessageSubType)data[9],
                SequenceNumber = (uint)Utility.GetLongLE(data, 10, 2),
                Crc = crc
            };

            int length = (int)Utility.GetLongLE(data, 12, 2);
            message.Text = Encoding.ASCII.GetString(data, 14, length);

            switch (message.SubType)
            {
                case XmlMessageSubType.Regatta:
                    message.Config = Utility.FromXml<RegattaConfig>(message.Text);
                    break;
                case XmlMessageSubType.Race:
                    message.Config = Utility.FromXml<Race>(message.Text);
                    break;
                case XmlMessageSubType.Boat:
                    string text = message.Text.Replace("\0", "");
                    message.Config = Utility.FromXml<BoatConfig>(text);
                    break;
            }

            return message;
        }
    }
}