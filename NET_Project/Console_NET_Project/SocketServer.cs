using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_NET_Project
{
    public class SocketServer
    {
        static void Main(string[] args)
        {
            int serverPort = 8888;
            IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = null;

            try
            {
                serverSocket = new TcpListener(serverAddress, serverPort);

                // Start the socket
                serverSocket.Start();
                Console.WriteLine("Connection au serveur réussi");

                while (true)
                {
                    TcpClient client = serverSocket.AcceptTcpClient();

                    Client user = new Client(client);

                    Thread thread = new Thread(() => user.Communication());
                    thread.Start();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Exception : {0}", error);
            }
            finally
            {
                serverSocket.Stop();
            }
        }
    }
}