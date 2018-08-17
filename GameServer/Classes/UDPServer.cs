using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameServer.Classes
{
    class UDPServer
    {
        public static bool messageReceived = false;

        public void udpLoop()
        {   
            while(Program._serverInstance._serverThread.IsAlive)
            { 
                Console.WriteLine("TIC...");
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                try
                {
                    Byte[] receiveBytes = Program._serverInstance._serverClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string[] requestParams = returnData.Split('@');

                    if(requestParams[0] == "LoginAttempt")
                    {
                        string[] extraParams = requestParams[1].Split(':');
                        var username = extraParams[0];
                        var password = extraParams[1];

                        Program._serverInstance.serverLog(RemoteIpEndPoint.Address.ToString() + ":" + RemoteIpEndPoint.Port.ToString() + " - Login attempt by " + username);

                        DataRow[] user = Program._serverInstance._database._gameserverDS.users.Select("username = '" + username + "' AND password = '" + password + "'");
                        if(user.Length > 0)
                        {
                            Console.WriteLine("Tentativa de Login com sucesso, usuário " + username);
                            Login.Registration(RemoteIpEndPoint, user);
                            sendMessage(RemoteIpEndPoint.Address, "LoginConfirmation", "token:valid");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public void sendMessage(IPAddress adress, string messaType, string messageBody)
        {
            UdpClient uclient = new UdpClient();
            IPEndPoint ipEndPoint = new IPEndPoint(adress, 11001);
            //IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 11000);
            try
            {
                Byte[] senddata = Encoding.ASCII.GetBytes(messaType + "@" + messageBody);

                uclient.Send(senddata, senddata.Length, ipEndPoint);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                uclient.Client.Shutdown(SocketShutdown.Both);
                uclient.Client.Close();
                uclient.Close();
            }

        }
    }
}

