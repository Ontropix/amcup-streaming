using System.Net;
using AmericasCup.Streaming;
using AmericasCup.Streaming.Messages;
using AmericasCup.Streaming.StreamingSource;

namespace AmericasCup.Console
{

    public class MessageReceiver : IMessageReceiver
    {
        public void OnMessageReceived(Message message)
        {
            System.Console.WriteLine("{0} {1} {2}", message.Header.SourceId, message.Header.TimeStamp, message.Header.Type);
        }
    }

    class Program
    {
        static void Main()
        {
            StreamingGateway gateway = new StreamingGateway(new MessageReceiver());
           

#if DEBUG
            IStreamingSource source =  new FileSource("test.dump");
#else
            IStreamingSource source = new NetworkSource(IPAddress.Parse("178.124.157.27"), 2096); // 4940 - live, 4941 - debug
            //IStreamingSource source = new NetworkSource(IPAddress.Parse("157.125.69.155"), 4941); 
#endif
            gateway.Connect(source);

            System.Console.ReadLine();

        }

    }
}
