using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace EchoServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            TcpListener serverSocket = new TcpListener(IPAddress.Loopback,7);
            serverSocket.Start();

            Console.WriteLine("server started witing for connection!");
            DoClient(serverSocket);
          
          
        }

        public static void DoClient(TcpListener socket)
        {
            TcpClient connectionSocket = socket.AcceptTcpClient();
            //Socket connectionSocket = serverSocket.AcceptSocket();
            Console.WriteLine("Server activated");

            Stream ns = connectionSocket.GetStream();
            // Stream ns = new NetworkStream(connectionSocket);
            Console.WriteLine("Server connected");
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            string message = sr.ReadLine();
            string answer = "";
            while (message != null && message != "")
            {
                

                answer = message.Length.ToString();
                sw.WriteLine(answer);
                Console.WriteLine(" server response " + answer);
                message = sr.ReadLine();
            }

            ns.Close();
            Console.WriteLine("StreamClosed");
            connectionSocket.Close();
            Console.WriteLine("Connections socket closed");
            socket.Stop();
            Console.WriteLine("Socket stopped");
        }

    }
}
