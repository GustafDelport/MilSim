using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace MilSim
{
    class Server
    {
        public Server() { }

        //=======================================================================================================================================
        //COMMUNICATIONS BETWEEN ADMIN PANEL AND SERVER CLASS
        //=======================================================================================================================================
        #region Communications-Server
        public static void ProcessClientRequests(TcpClient client)
        {
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                string message = string.Empty;

                EventHandler eHandler = new EventHandler();

                while (!(message = reader.ReadLine()).Equals("Exit") || (message == null))
                {
                    eHandler.Controler(message);
                }
                MessageBox.Show("Admin Panel Closed");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
        }

        public void ServerStart()
        {
            TcpListener Server;

            if (getNetType(NetworkInterfaceType.Ethernet))
            {
                Server = new TcpListener(IPAddress.Parse(GetLocalIPv4(NetworkInterfaceType.Ethernet)), 2000);
            }
            else
            {
                Server = new TcpListener(IPAddress.Parse(GetLocalIPv4(NetworkInterfaceType.Wireless80211)), 2000);
            }

            try
            {
                Server.Start();
                while (true)
                {
                    TcpClient client = Server.AcceptTcpClient();
                    new Thread(() => ProcessClientRequests(client)).Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (Server != null)
                {
                    Server.Stop();
                }
            }
        }

        internal static string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties adapterProperties = item.GetIPProperties();
                    if (adapterProperties.GatewayAddresses.FirstOrDefault() != null)
                    {
                        foreach (UnicastIPAddressInformation ip in adapterProperties.UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                output = ip.Address.ToString();
                                break;
                            }
                        }
                    }
                }
                if (output != "") { break; }
            }
            return output;
        }

        private bool getNetType(NetworkInterfaceType _Type)
        {
            bool flag = true;
            if (_Type == NetworkInterfaceType.Ethernet)
            {
                flag = true;
            }
            else if (_Type == NetworkInterfaceType.Wireless80211)
            {
                flag = false;
            }

            return flag;
        }

        #endregion
        //=======================================================================================================================================
        //=======================================================================================================================================
    }
}
