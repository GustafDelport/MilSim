using MilSim.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    class EventHandler
    {
        public EventHandler() { }

        //=======================================================================================================================================
        //ADMIN-PANEL COMMANDS/EVENTS
        //=======================================================================================================================================
        #region Admin-Panel-Commands
        public void Controler(string _message)
        {
            switch (_message)
            {
                case "1":
                    {
                        ResetDB();
                        
                    }
                    break;
                case "2":
                    {
                        ReturnHome();

                    }
                    break;
                case "100":
                    {
                        ExitAll();
                    }
                    break;
                default:
                    break;
            }
        }

        public void ResetDB()
        {
            new DataHandler().ResetDB();
        }

        public void ReturnHome()
        {
            Globals.main.Show();
        }

        public void ExitAll()
        {
            Environment.Exit(0);
        }
        #endregion
        //=======================================================================================================================================
        //=======================================================================================================================================
    }
}
