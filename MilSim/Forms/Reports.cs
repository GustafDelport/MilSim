using MilSim.Forms;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        //===================================================================================================================================
        //Essentials
        //===================================================================================================================================
        #region Essentials
        private void Reports_Load(object sender, EventArgs e)
        {
            if (Globals.UserLogged == "Admin")
            {
                picAdmin.Visible = true;
            }
            else { picAdmin.Visible = false; }

            new DataHandler().ShowAllReports(this.dataGridView1);
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
            Globals.reports.Hide();
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            Server S = new Server();
            new Thread(new ThreadStart(() => S.ServerStart())).Start();

            string appPath = Path.GetFullPath(@"..\..\..\Admin_Panel\Bin\Debug\Admin_Panel.exe");
            System.Diagnostics.Process.Start(appPath);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRep.Text) || txtRep.Text == "Report ID" )
            {
                MessageBox.Show("Please Enter A Report ID");
            }
            else
            {
                new DataHandler().RepID(int.Parse(txtRep.Text),this.dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpDataFilter.Value > DateTime.Now)
            {
                MessageBox.Show("The Future is unforseen");
            }
            else
            {
                new DataHandler().SearchByDate(dtpDataFilter.Value, this.dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlane.Text) || txtPlane.Text == "Plane ID")
            {
                MessageBox.Show("Please Enter A Plane ID");
            }
            else
            {
                new DataHandler().planeID(txtPlane.Text, this.dataGridView1);
            }
        }

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Animantions
        //===================================================================================================================================
        #region Animations
        private void picAdmin_MouseEnter_1(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel2;
        }

        private void picAdmin_MouseLeave_1(object sender, EventArgs e)
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

        private void txtRep_MouseClick(object sender, MouseEventArgs e)
        {
            txtRep.Text = "";
        }

        private void txtRep_MouseLeave(object sender, EventArgs e)
        {
            string val = txtRep.Text;

            if (txtRep.Text == "")
            {
                txtRep.Text = "Report ID";
            }
            else
            {
                txtRep.Text = val;
            }
        }

        private void txtPlane_MouseClick(object sender, MouseEventArgs e)
        {
            txtPlane.Text = "";
        }

        private void txtPlane_MouseLeave(object sender, EventArgs e)
        {
            string val = txtPlane.Text;

            if (txtPlane.Text == "")
            {
                txtPlane.Text = "Plane ID";
            }
            else
            {
                txtPlane.Text = val;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            new DataHandler().ShowAllReports(this.dataGridView1);
        }

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
