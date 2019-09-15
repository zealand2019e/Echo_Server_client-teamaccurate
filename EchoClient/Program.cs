using System;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(5000);
            Client client = new Client();
            client.Start();
        }
    }
}
