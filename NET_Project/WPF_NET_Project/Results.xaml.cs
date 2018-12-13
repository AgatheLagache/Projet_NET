using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_NET_Project
{
    /// <summary>
    /// Logique d'interaction pour Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        private BackgroundWorker thread;
        NetworkStream serverStream = default(NetworkStream);
        TcpClient clientSocket = new TcpClient();

        public Results()
        {
            InitializeComponent();

            thread = new BackgroundWorker();
            thread.WorkerReportsProgress = true;
            thread.WorkerSupportsCancellation = true;
            thread.DoWork += Thread_DoWork;
            thread.ProgressChanged += Thread_ProgressChanged;
            thread.RunWorkerCompleted += Thread_RunWorkerCompleted;


            MessageAdd(new Message { Text = "Connexion au serveur...", Color = Brushes.White});
            clientSocket.Connect("127.0.0.1", 8888);
            serverStream = clientSocket.GetStream();

            byte[] outStream = Encoding.ASCII.GetBytes("lancement");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            thread.RunWorkerAsync();

            //Results_Textbox.IsEnabled = false;

            //clientSocket.Connect("127.0.0.1", int.Parse("8888"));
            //serverStream = clientSocket.GetStream();
        }
        private void Thread_DoWork(object sender, DoWorkEventArgs e)
        {
            Byte[] bytes = new Byte[256];
            BackgroundWorker worker = sender as BackgroundWorker;
            while (worker.CancellationPending == false)
            {
                serverStream = clientSocket.GetStream();
                int i;
                while ((i = serverStream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    string message = Encoding.ASCII.GetString(bytes, 0, i);
                    Dictionary<string, string> paramList = message.Split('&').Select(m => m.Split('|')).ToDictionary(m => m.FirstOrDefault(), m => m.Skip(1).FirstOrDefault());
                    

                    worker.ReportProgress(0, new Message
                    {
                        Text = "cc",
                        Color = Brushes.Green
                    });
                }
                Thread.Sleep(1000);
            }
        }

        private void Thread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageAdd(new Message { Text = "Ciao !", Color = Brushes.Orange, Author = "Client" });
        }

        private void Thread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Message message = e.UserState as Message;
            MessageAdd(new Message { Text = message.Text, Color = message.Color, Author = message.Author });
        }

        private void MessageAdd(Message message)
        {
            Run newLine = new Run("> " /*+ DateTime.Now.ToString("T") + " ["*/ + message.Author + /*"] " +*/ message.Text + "\n") { Foreground = message.Color };
            messageBox.Inlines.InsertBefore(messageBox.Inlines.FirstInline, newLine);
        }

        /*public Results GetResults()
        {
            if (results == null)
            {
                results = new Results();
            }
            clientSocket.Connect("127.0.0.1", int.Parse("8888"));
            serverStream = clientSocket.GetStream();

            thread.RunWorkerAsync();
            results.Show();
            return results;
        }*/

        private void Results1_Closed(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
