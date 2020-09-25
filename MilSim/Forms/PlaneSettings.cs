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
    public partial class PlaneSettings : Form
    {
        public PlaneSettings()
        {
            InitializeComponent();
        }

        //===================================================================================================================================
        //Essentials
        //===================================================================================================================================
        #region Essentials
        private void PlaneSettings_Load(object sender, EventArgs e)
        {
            if (Globals.UserLogged == "Admin")
            {
                picAdmin.Visible = true;
            }
            else { picAdmin.Visible = false; }

            picCurrentPlane.Image = Globals.Plane.Box.Image;
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Clicks
        //===================================================================================================================================
        #region Clicks

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Server S = new Server();
            new Thread(new ThreadStart(() => S.ServerStart())).Start();

            string appPath = Path.GetFullPath(@"..\..\..\Admin_Panel\Bin\Debug\Admin_Panel.exe");
            System.Diagnostics.Process.Start(appPath);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Globals.simulation.Show();
            Globals.planeSettings.Hide();
        }

        private void picPlane1_Click(object sender, EventArgs e)
        {
            Globals.Plane = new DataHandler().GetPlane("JTONE", Globals.Plane.Box);
            Globals.Plane.Plane1();
            picCurrentPlane.Image = Globals.Plane.Box.Image;
        }

        private void picPlane2_Click(object sender, EventArgs e)
        {
            Globals.Plane = new DataHandler().GetPlane("JTTWO", Globals.Plane.Box);
            Globals.Plane.Plane2();
            picCurrentPlane.Image = Globals.Plane.Box.Image;
        }

        private void picPlane3_Click(object sender, EventArgs e)
        {
            Globals.Plane = new DataHandler().GetPlane("JTTHR", Globals.Plane.Box);
            Globals.Plane.Plane3();
            picCurrentPlane.Image = Globals.Plane.Box.Image;
        }

        private void picPlane4_Click(object sender, EventArgs e)
        {
            Globals.Plane = new DataHandler().GetPlane("JTFOU", Globals.Plane.Box);
            Globals.Plane.Plane4();
            picCurrentPlane.Image = Globals.Plane.Box.Image;
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlaneSpeed.Text))
            {
                if (!string.IsNullOrEmpty(txtWeight.Text))
                {
                    Globals.Plane.FreightWeight = float.Parse(txtWeight.Text);
                    Globals.Plane.Speed = int.Parse(txtPlaneSpeed.Text);
                }
                else
                {
                    Globals.Plane.Speed = int.Parse(txtPlaneSpeed.Text);
                }
            }
            else if (!string.IsNullOrEmpty(txtWeight.Text))
            {
                Globals.Plane.Speed = int.Parse(txtPlaneSpeed.Text);
            }

            Globals.simulation.Show();
            Globals.planeSettings.Hide();
        }

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Animantions
        //===================================================================================================================================
        #region Animations
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Admin_Panel2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Admin_Panel1;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.ReturnTwo;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.ReturnOne;
        }

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
