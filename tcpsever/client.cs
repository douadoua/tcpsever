using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace tcpsever
{
    class Client
    {
        private Socket clientsocket;

        public Client(Socket s)
        {
            clientsocket = s;
        }
    }
}
