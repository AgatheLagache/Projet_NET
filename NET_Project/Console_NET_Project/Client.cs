using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Console_NET_Project
{
    public class Client
    {
        private TcpClient client;
        public Client(TcpClient client)
        {
            this.client = client;
        }
        
        public void Communication()
        {
            NetworkStream stream = client.GetStream();

            client.Close();
        }
    }
}
