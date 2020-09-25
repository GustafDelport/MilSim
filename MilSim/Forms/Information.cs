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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        //===================================================================================================================================
        //Essentials
        //===================================================================================================================================
        #region Essentials
        private void Information_Load(object sender, EventArgs e)
        {
            if (Globals.UserLogged == "Admin")
            {
                picAdmin.Visible = true;
            }
            else { picAdmin.Visible = false; }

            new FileHandler().readInfo(this.rtbInfo);
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
            Globals.main.Show();
            Globals.information.Hide();
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
        private void picExit_MouseEnter_1(object sender, EventArgs e)
        {
            picExit.Image = Resources.ReturnTwo;
        }

        private void picExit_MouseLeave_1(object sender, EventArgs e)
        {
            picExit.Image = Resources.ReturnOne;
        }

        private void picAdmin_MouseEnter_1(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel2;
        }

        private void picAdmin_MouseLeave_1(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel1;
        }

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
