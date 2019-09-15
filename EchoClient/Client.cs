using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace EchoClient
{
    class Client
    {
        public void Start()
        {
            Console.ReadKey();
            TcpClient ClientSOcket = new TcpClient("localhost", 7);
            Console.WriteLine("Client connect!");
            Stream ns = ClientSOcket.GetStream();

            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine(Console.ReadLine());
            sw.AutoFlush = true;


            string message = sr.ReadLine();

           
            Console.WriteLine(message);
            Console.ReadKey();
            

        }

    }
}
