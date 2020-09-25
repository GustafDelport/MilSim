using MilSim.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    public partial class BaseInfo : Form
    {
        public BaseInfo()
        {
            InitializeComponent();
        }
        //===================================================================================================================================
        //Essentials
        //===================================================================================================================================
        #region Essentials
        private void BaseInfo_Load(object sender, EventArgs e)
        {
            //Globals.UserLogged = "Admin";

            if (Globals.UserLogged == "Admin")
            {
                picAdmin.Visible = true;
            }
            else { picAdmin.Visible = false; }

            new FileHandler().readBaseInfo(this.rtxBaseInfo);
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Clicks
        //===================================================================================================================================
        #region Clicks
        private void picExit_Click(object sender, EventArgs e)
        {
            Globals.simulation.Show();
            Globals.baseInfo.Hide();
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            Server S = new Server();
            new Thread(new ThreadStart(() => S.ServerStart())).Start();

            string appPath = Path.GetFullPath(@"..\..\..\Admin_Panel\Bin\Debug\Admin_Panel.exe");
            System.Diagnostics.Process.Start(appPath);
        }

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================

        //===================================================================================================================================
        //Animantions
        //===================================================================================================================================
        #region Animations
        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picReturn.Image = Resources.ReturnOne;
        }

        private void picReturn_MouseLeave(object sender, EventArgs e)
        {
            picReturn.Image = Resources.ReturnTwo;
        }

        private void picAdmin_MouseLeave(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel1;
        }

        private void picAdmin_MouseEnter(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel2;
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
