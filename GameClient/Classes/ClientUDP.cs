using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using GameClient.Classes;
using System.Threading;
using GameClient.Scenes;

namespace GameClient.Classes
{
    static class ClientUDP
    {
        public static void sendMessage(string messaType, string messageBody)
        {
            UdpClient uclient = new UdpClient();
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.25.7"), 11000);
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
        
        public static void ReceiveMessages()
        {
            Thread _serverThread = new Thread(new ThreadStart(ServerLoop));           
            _serverThread.IsBackground = true;
            _serverThread.Start();
        }

        private static void ServerLoop()
        {
            bool loopStatus = true;
            UdpClient _serverClient = new UdpClient(11001);
            while (loopStatus)
            {

                Console.WriteLine("TIC...");
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                try
                {
                    Byte[] receiveBytes = _serverClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string[] requestParams = returnData.Split('@');

                    if (requestParams[0] == "LoginConfirmation")
                    {
                        string[] extraParams = requestParams[1].Split(':');
                        var token = extraParams[0];
                        var date = extraParams[1];

                        Console.WriteLine("LoginConfirmation = "+ token + " - " + date);

                        Events._sceneList.Add(typeof(TransitionScene));

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }
    }
}