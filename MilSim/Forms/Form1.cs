using MilSim.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MilSim
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }
        #region NB
        //How to call Server

        //Server S = new Server();
        //new Thread(new ThreadStart(() => S.ServerStart())).Start();

        //string path = @"C:\Users\User-PC\Desktop\Project\MilSim\Admin_Panel\bin\Debug\Admin_Panel.exe";
        //System.Diagnostics.Process.Start(path);

        #endregion

        //===================================================================================================================================
        //Essentials
        //===================================================================================================================================
        #region Essentials
        private void Main_Load(object sender, EventArgs e)
        {
            //Globals.UserLogged = "Admin";

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
            Environment.Exit(0);
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            Server S = new Server();
            new Thread(new ThreadStart(() => S.ServerStart())).Start();

            string appPath = Path.GetFullPath(@"..\..\..\Admin_Panel\Bin\Debug\Admin_Panel.exe");
            System.Diagnostics.Process.Start(appPath);
        }

        private void lblSim_Click(object sender, EventArgs e)
        {
            Globals.simulation.Show();
            Globals.main.Hide();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            Globals.reports.Show();
            Globals.main.Hide();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            Globals.information.Show();
            Globals.main.Hide();
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
            picExit.Image = Resources.Exit;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Resources.Exit2;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel1;
        }

        private void pnlReports_MouseEnter(object sender, EventArgs e)
        {
            pnlReports.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pnlReports_MouseLeave(object sender, EventArgs e)
        {
            pnlReports.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void pnlSim_MouseLeave(object sender, EventArgs e)
        {
            pnlSim.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void pnlSim_MouseEnter(object sender, EventArgs e)
        {
            pnlSim.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pnlInfo_MouseEnter(object sender, EventArgs e)
        {
            pnlInfo.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pnlInfo_MouseLeave(object sender, EventArgs e)
        {
            pnlInfo.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void lblReports_MouseEnter(object sender, EventArgs e)
        {
            lblReports.Font = new Font("Arial", 20, FontStyle.Bold);
        }

        private void lblReports_MouseLeave(object sender, EventArgs e)
        {
            lblReports.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void lblSim_MouseEnter(object sender, EventArgs e)
        {
            lblSim.Font = new Font("Arial", 20, FontStyle.Bold);
        }

        private void lblSim_MouseLeave(object sender, EventArgs e)
        {
            lblSim.Font = new Font("Arial", 18, FontStyle.Regular);
        }

        private void lablInfo_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Font = new Font("Arial", 20, FontStyle.Bold);
        }

        private void lblInfo_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Font = new Font("Arial", 18, FontStyle.Regular);
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
