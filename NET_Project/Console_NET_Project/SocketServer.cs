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
                Console.WriteLine("Bienvenue sur le serveur.");

                // BUFFER FOR READING DATA
                Byte[] bytes = new Byte[256];
                String data = null;


                while (true)
                {                 
                    TcpClient client = serverSocket.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    int i;
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        byte[] msg;

                        // CONVERT DATA BYTES TO ASCII STRING.
                        data = Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine("IN: {0}", data);


                        string messageRetour = "message retour";
                        stream.Write(Encoding.ASCII.GetBytes(messageRetour), 0, messageRetour.Length);
                    }

                    client.Close();
                    Console.WriteLine("cc le client");
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