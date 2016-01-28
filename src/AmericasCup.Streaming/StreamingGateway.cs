using System;
using System.Collections.Generic;
using System.IO;
using AmericasCup.Streaming.Messages;
using AmericasCup.Streaming.StreamingSource;

namespace AmericasCup.Streaming
{
    public class StreamingGateway
    {

        private const int HEADER_LENGTH = 15;
        private const int HEADER_MESSAGE_LENGTH = 2;
        private const int CRC_LENGTH = 4;
        private const int HEADER_SOURCEID_LENGTH = 4;
        private const int SYNC1 = 0x47;
        private const int SYNC2 = 0x83;
        private const int READ_BUFFER_SIZE = 32; // There is an issue on Mac/iPhone: stream.Read returns data only when the buffer is full
        private const int BUFFER_SIZE = 32 * 1024;

        private bool _stop;

        private readonly Dictionary<MessageTypes, IParser> _parsers;
        private IMessageReceiver _receiver;

        public StreamingGateway(IMessageReceiver receiver)
        {
            _receiver = receiver;
            _parsers = new Dictionary<MessageTypes, IParser>()
            {
                {MessageTypes.BoatLocation, new BoatLocation()},
                {MessageTypes.Heartbeat, new Heartbeat()},
                {MessageTypes.DisplayTextMessage, new DisplayTextMessage()},
                {MessageTypes.XmlMessage, new XmlMessage()},
                {MessageTypes.RaceStartStatus, new RaceStartStatus()},
                {MessageTypes.YachtEventCode, new YachtEventCode()},
                {MessageTypes.RaceStatus, new RaceStatusMessage()},
                {MessageTypes.YachtActionCode, new YachtActionCode()},
                {MessageTypes.ChatterText, new ChatterText()},
                {MessageTypes.MarkRounding, new MarkRounding()}
            };
        }


        public void Connect(IStreamingSource streamingSource)
        {
            _stop = false;

            byte[] readBuffer = new byte[READ_BUFFER_SIZE];
            byte[] buffer = new byte[BUFFER_SIZE];
            int offset = 0;

            streamingSource.Connect();
            using (Stream stream = streamingSource.GetStream())
            {
                do
                {
                    int read = stream.Read(readBuffer, 0, readBuffer.Length);
                    if (read != 0)
                    {
                        //from readbuffer to buffer
                        Array.Copy(readBuffer, 0, buffer, offset, read);
                        int parsed = Parse(buffer, read + offset);
                        offset = offset + read - parsed;
                        //offset parset bytes
                        Array.Copy(buffer, parsed, buffer, 0, offset);
                    }

                } while (!_stop);
            }
        }

        private int Parse(byte[] buffer, int length)
        {
            int offset = 0;

            if (length < HEADER_LENGTH) return 0; //nothing to parse
            for (int index = 0; index < length - 1; index++)
            {
                if (buffer[index] == SYNC1 && buffer[index + 1] == SYNC2 && length - index > HEADER_LENGTH)
                {
                    int messageLength = GetMessageLength(buffer, index);
                    int total = HEADER_LENGTH + messageLength + CRC_LENGTH;
                    if (total + index > length) break;

                    //the message can be parsed
                    Header header = ParseHeader(buffer, index, messageLength);
                    ParseMessage(header, buffer, index);
                    offset += total;
                    index += total - 1; //because of index++

                }
            }

            return offset;
        }

        private void ParseMessage(Header header, byte[] buffer, int index)
        {
            byte[] message = new byte[HEADER_LENGTH + header.MessageLength];
            Array.Copy(buffer, index, message, 0, message.Length);
            UInt32 actualCrc = CalculateCrc(message);
            UInt32 expectedCrc = (UInt32)Utility.GetLongLE(buffer, index + message.Length, CRC_LENGTH);
            if (actualCrc != expectedCrc) return; //crc is not valid, do not parse

            IParser parser;
            if (_parsers.TryGetValue(header.Type, out parser))
            {
                if (_receiver != null)
                {
                    byte[] body = new byte[header.MessageLength];
                    Array.Copy(message, HEADER_LENGTH, body, 0, body.Length);

                    _receiver.OnMessageReceived(parser.Parse(header, body, actualCrc));
                }
            }
        }

        private static uint CalculateCrc(byte[] data)
        {
            var c = new Crc32();
            c.ComputeHash(data);
            UInt32 crc = c.CrcValue;
            return crc;
        }

        private Header ParseHeader(byte[] buffer, int index, int messageLength)
        {
            Header header = new Header
            {
                MessageLength = messageLength,
                Type = (MessageTypes)buffer[index + 2], //2 sync bytes
                TimeStamp = Utility.GetTime(buffer, index + 3), //2 sync bytes + 1 message type = 3
                SourceId = Utility.GetLongLE(buffer, index + 9, HEADER_SOURCEID_LENGTH) //2 sync bytes + 1 message type + 6 timestamp = 9
            };

            return header;
        }

        private static int GetMessageLength(byte[] buffer, int index)
        {
            int offset = index + HEADER_LENGTH - HEADER_MESSAGE_LENGTH;
            return (int)Utility.GetLongLE(buffer, offset, HEADER_MESSAGE_LENGTH);
        }

        public void Stop()
        {
            _stop = true;
        }

    }
}
