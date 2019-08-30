# Echo_Server_Client
Mission: 
To design and program two programs one to be an echo-server and one to be an echo-client. 
Do not implement a gui with 'bells and whistles' only plain screen. NO UWP APP-application.
Background: 
CN chapter 2.7 p. 185-187 + 192-198
For programming server and client in C# Console Application
 (Server site) TCPListener: https://msdn.microsoft.com/en-us/library/system.net.sockets.tcplistener(v=vs.110).aspx 
 (Client site) TCPClient: https://msdn.microsoft.com/en-us/library/system.net.sockets.tcpclient(v=vs.110).aspx 
Assignment A: An Echo Server
  In Visual Studio 2017   Create a new solution 'Console App (.Net Core)', and name it e.g. 'EchoServer'.
(Please! do NOT choose 'Console App framework') 
  
Create a class 'Server' and create a method 'Start'. 
  
In the start method 
Create a TcpListener with the parameter IP = IPAddress.Loopback and PORT = 7 or 7777 (port 7 is the stadard for echo server (see RFC 862)).
Start the TcpListener.
Open for incomming socket and for reading and writing -- All these should be in an using-statement (This give you the benefit of indirrect closing all sockets and streams in the using-statement) 
On the TcpListener 'AcceptTcpClient()' and name it 'socket'.
From the TcpClient 'GetStream()' and name it 'ns'.
Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
Read a line from your stream-reader ('ReadLine()') save it in a String and name it 'line'.
Write back the line to your stream-writer ('WriteLine(line)') -- then remember to 'Flush()' the stream-writer.
  
In Main create an object of your Server-class and call the method 'Start()'. 
  
Commit and push your server-solution to a Git-Repository.
  
Try your server with the Socket-Test program - for installation see tools 
Assignment B: Refactor Your Server
Refactor your server so all the code to handle your client is extracted in a method 'DoClient'. 
  
The signature of the method should be similar to: 

             public void DoClient(TcpClient socket) 
  
Put all your code of StreamReader, StreamWriter and ReadLine, WriteLine in this method 
  
Try with SocketTest program to see it still works. 
  
Commit your project.
Assignment C:  An Echo Client
In your solution create a new project (AGAIN    'ConsoleApp (.Net Core)' and name it 'EchoClient'. 
  
Create a class 'Client' and create a method 'Start'. 
  
In the start method 
Open for a new socket and for reading and writing -- All these should be in an using-statement 
Create a TcpClient with the parameter IP = "localhost" and PORT = 7 or 7777 and name it 'socket'.
From the TcpClient 'GetStream()' and name it 'ns'.
Wrap the stream into reading and writing i.e. 'new StreamReader(ns)' & 'new StreamWriter(ns)'.
Write a line to your stream-writer ('WriteLine(<<Your line to be echoed e.g. "Peter">>)') -- then remember to 'Flush()' the stream-writer.
Read a line from your stream-reader ('ReadLine()') save it in a String and name it 'line'.
Print out the line in the console window ('Console.WriteLine(line)). 
In Main create an object of your Client-class and call the method 'Start()'. 
Commit and push your Client-solution to a Git-Repository. 
  
Try your Client with the Socket-Test program - for installation see tools 
Assignment D:  Run Both the server and the Client
In your solution 
Start your server
start your client
Hint: To make it more smooth; Open the properties for the solution, Then choose multiple startup projects and configure to start first.
Remember to have the server up before the client. -- Now you can 'just' push the green arrow and both projects will start. 
Assignment E:  Refactor the server
Refactor the server to count the number of words sent to the server and send back the number.
  
Try this new feature.
  
Commit and push your Client-solution to a Git-Repository. 
 
Assignment Extra A:  Consider how to test your server
Consider how to test your server code.
Make a unit test of your server.
