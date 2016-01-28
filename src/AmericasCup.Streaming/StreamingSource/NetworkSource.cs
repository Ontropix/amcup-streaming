using System.IO;
using System.Net;
using System.Net.Sockets;

namespace AmericasCup.Streaming.StreamingSource
{
    public class NetworkSource : IStreamingSource
    {
        private readonly IPAddress _address;
        private readonly int _port;
        private TcpClient _client;

        public NetworkSource(IPAddress address, int port)
        {
            _port = port;
            _address = address;
        }

        public void Connect()
        {
            _client = new TcpClient();
            _client.Connect(_address, _port);
        }

        public Stream GetStream()
        {
            return _client.GetStream();
        }
    }
}

