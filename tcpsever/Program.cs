using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace tcpsever
{
    class Program
    {
        static List<Client> clientlist = new List<Client>();
        static void Main(string[] args)
        {
            Socket tcpsever = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            tcpsever.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.107"),8899));

            tcpsever.Listen(100);
            Console.WriteLine("sever runnig...");

            while (true)
            {
                Socket clientsocket = tcpsever.Accept();
                Console.WriteLine("a client is connected !");
                Client client = new Client(clientsocket);//
                clientlist.Add(client);
            }
            
        }
    }
}
