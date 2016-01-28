using System.Collections.Generic;
using System.Text;

namespace AmericasCup.Streaming.Messages
{
    public class TextMessage
    {
        /// <summary>
        /// Line number where message should be displayed
        /// </summary>
        public byte LineNumber { get; set; }

        /// <summary>
        /// ASCII content of the message
        /// </summary>
        public string Text { get; set; }
    }


    /// <summary>
    /// This message is used to display on the Stowe Displays on the race yachts. 
    /// The contents of this message can be used to emulate the existing AC45 Stowe Display
    /// </summary>
    public class DisplayTextMessage : Message, IParser
    {
        public byte Version { get; set; }
        public List<TextMessage> TextMessages { get; set; } 

        public Message Parse(Header header, byte[] data, uint crc)
        {
            DisplayTextMessage result = new DisplayTextMessage()
            {
                Header = header,
                Crc = crc,
                Version = data[0],
            };

            List<TextMessage> messages = new List<TextMessage>();
            byte count = data[3];

            int offset = 4;

            for (int i = 0; i < count; i ++ )
            {
                TextMessage message = new TextMessage();
                message.LineNumber = data[offset];
                int length = data[offset + 1];
                message.Text = Encoding.ASCII.GetString(data, offset + 1, length);
                offset += length + 2; // 2 because "Line Number" length takes 1 byte and "Message Text Length" takes 1 byte
                messages.Add(message);
            }

            result.TextMessages = messages;

            return result;
        }
    }
}