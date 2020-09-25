using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Panel
{
    class DataHandler
    {
        public DataHandler() { }
        //=======================================================================================================================================
        //GLOBAL STUFF
        //=======================================================================================================================================
        #region Globals
        enum Commands
        {
            Reset_Database = 1,
            Return_Home,
            Exit_Console = 99,
            Exit_All = 100
        }

        Stream stream;
        StreamWriter writer;
        #endregion
        //=======================================================================================================================================
        //=======================================================================================================================================


        //=======================================================================================================================================
        //COMMUNICATIONS BETWEEN ADMIN PANEL AND SERVER CLASS
        //=======================================================================================================================================
        #region Communications - Client


        public void clientStart()
        {
            TcpClient client;

            //This checks if user is using wifi or ethernet
            if (getNetType(NetworkInterfaceType.Ethernet))
            {
                client = new TcpClient(GetLocalIPv4(NetworkInterfaceType.Ethernet), 2000);
            }
            else
            {
                client = new TcpClient(GetLocalIPv4(NetworkInterfaceType.Wireless80211), 2000);
            }

            /*Stream*/ stream = client.GetStream();
            /*StreamWriter*/ writer = new StreamWriter(stream);

            bool flag = true;

            while (flag)
            {
                foreach (Commands com in Enum.GetValues(typeof(Commands)))
                {
                    Console.WriteLine($"{(int)com} \t {com.ToString()}");
                }
                Console.Write("\nEnter Choice : ");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        {
                            PushMessage(c);
                        }
                        break;
                    case "2":
                        {
                            PushMessage(c);
                        }
                        break;
                    case "99":
                        {
                            PushMessage("Exit");
                            Environment.Exit(0);
                        }
                        break;
                    case "100":
                        {
                            PushMessage(c);
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("\nInvalid Command\n");
                        }
                        break;
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

        private void PushMessage(string _Mes)
        {
            writer.WriteLine(_Mes);
            writer.Flush();
        }
        #endregion
        //=======================================================================================================================================
        //=======================================================================================================================================
    }

}
