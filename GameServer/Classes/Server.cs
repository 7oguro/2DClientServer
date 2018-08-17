using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace GameServer.Classes
{
    public class Server
    {
        public string _serverName;
        public int _serverPort;
        public UdpClient _serverClient;
        public Thread _serverThread;
        public Thread _udpThread;
        public Database _database;
        public List<User> _users;
        

        public enum serverStatuses
        {
            Offline = 0,
            Initializing = 1,
            Online = 2,
            Shutting = 3
        }

        serverStatuses _serverStatus = serverStatuses.Offline;
        public serverStatuses serverStatus
        {
            get{ return _serverStatus; }
            set
            {
                _serverStatus = value;
                Program._formInstance.updateServerStatusText(value);                
            }
        }
        

        public Server(string serverName, int serverPort)
        {
            _serverName = serverName;
            _serverPort = serverPort;
            this.serverStart();
        }

        private void serverStart()
        {
            try
            {            
                Console.WriteLine("Iniciando Servidor...");
                serverStatus = serverStatuses.Initializing;
                _serverThread = new Thread(new ThreadStart(this.serverLoop));


                _database = new Database();
                

                //END
                Console.WriteLine("Servidor Online!");
                serverStatus = serverStatuses.Online;
                _serverThread.IsBackground = true;
                _serverThread.Start();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        private void serverLoop()
        {
            bool loopStatus = true;
            UDPServer udp = new UDPServer();            
            _serverClient = new UdpClient(_serverPort);

            _udpThread = new Thread(new ThreadStart(udp.udpLoop));
            _udpThread.IsBackground = true;
            _udpThread.Start();

            while (loopStatus)
            {           

                if (_serverStatus != serverStatuses.Online)
                {
                    //THEN CLOSE THE CONNECTION
                    _serverClient.Close();
                    loopStatus = false;
                }
                
            }
        }

        public void stopServer()
        {
            //FIRST END THE THREAD LOOP
            Console.WriteLine("Desligando Servidor...");
            this.serverStatus = serverStatuses.Shutting;

            //DO THE BACKUP AND START TO FINISH STUFF
            Thread.Sleep(2000);

            

            Console.WriteLine("Servidor Offline.");
            this.serverStatus = serverStatuses.Offline;
        }

        public void saveServer()
        {
            

        }

        public void serverLog(string message)
        {
            Program._formInstance.TextBoxSystem.InvokeIfRequired(s => { s.AppendText(message + "\r\n"); });
        }
    }


}
