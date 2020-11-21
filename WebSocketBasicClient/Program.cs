using System;
using System.Net;
using System.Threading.Tasks;
using SuperSocket.Client;

namespace WebSocketBasicClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new EasyClient<MyPackage>(new MyPackageFilter()).AsClient();

            if (!await client.ConnectAsync(new IPEndPoint(IPAddress.Loopback, 4040)))
            {
                Console.WriteLine("Failed to connect the target server.");
                return;
            }

            while (true)
            {
                var p = await client.ReceiveAsync();

                if (p == null) // connection dropped
                    break;
                
                Console.WriteLine(p.Body);
            }
        }
    }
}