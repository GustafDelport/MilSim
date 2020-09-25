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
    public partial class BaseBuild : Form
    {
        public BaseBuild()
        {
            InitializeComponent();
        }

        //===================================================================================================================================
        //Essentials
        //===================================================================================================================================
        #region Essentials
        private void BaseBuild_Load(object sender, EventArgs e)
        {
            if (Globals.UserLogged == "Admin")
            {
                picAdmin.Visible = true;
            }
            else { picAdmin.Visible = false; }
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
            Globals.baseBuild.Hide();
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            Server S = new Server();
            new Thread(new ThreadStart(() => S.ServerStart())).Start();

            string appPath = Path.GetFullPath(@"..\..\..\Admin_Panel\Bin\Debug\Admin_Panel.exe");
            System.Diagnostics.Process.Start(appPath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Globals.Base.Camp1();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Globals.Base.Camp2();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Globals.Base.Camp3();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Globals.Base.Camp4();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Globals.Base.Remove();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Globals.simulation.Show();
            Globals.baseBuild.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Globals.Base.StartPos();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Globals.Base.EndPos();
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Animation
        //===================================================================================================================================
        #region Animation

        private void picAdmin_MouseEnter(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel2;
        }

        private void picAdmin_MouseLeave(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel1;
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Resources.ReturnTwo;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Resources.ReturnOne;
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
