using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using TCPClient;

class Program
{
    private const int PORT = 7777;

    static void Main(string[] args)
    {
        Server server = new Server(PORT);
        server.Start();

        Console.ReadLine();
    }
}