using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace AmericasCup.StreamRecorder
{
    internal class Program
    {

        private static void Main()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Parse("157.125.69.155"), 4941);
            NetworkStream stream = client.GetStream();

            FileStream file = File.Create(@"D:\test.dump");

            while (true)
            {
                int @byte = stream.ReadByte();
                if (@byte != -1)
                {
                    file.WriteByte((byte) @byte);
                    file.Flush();
                }
                else
                {
                    sw.Stop();
                    Console.WriteLine("Time: " + sw.Elapsed);
                    Console.ReadKey();
                    return;
                }

            }
        }



    }
}
