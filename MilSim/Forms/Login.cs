using MilSim.Classes;
using MilSim.Forms;
using MilSim.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //We Load A new instance of all the Forms here in a global class so we can use them without creating new instances
            Globals.login = this;
            Globals.register = new Register();
            Globals.main = new Main();
            Globals.simulation = new pnlSimOptions();
            Globals.baseInfo = new BaseInfo();
            Globals.reports = new Reports();
            Globals.planeSettings = new PlaneSettings();
            Globals.information = new Information();
            Globals.baseBuild = new BaseBuild();


        }
        //===================================================================================================================================
        //Clicks
        //===================================================================================================================================
        #region Clicks
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (new Validation().CheckLogin(this.txtUsername,this.txtPassword))
            {
                Globals.UserLogged = txtUsername.Text; 
                Globals.login.Hide();
                Globals.main.Show();
            }
            else { MessageBox.Show("Password was incorrect", "Incorrect Password"); }
        }

        private void lblAU_Click(object sender, EventArgs e)
        {
            Globals.login.Hide();
            Globals.register.Show();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Animantions
        //===================================================================================================================================
        #region Animations
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            string val = txtUsername.Text;

            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            else
            {
                txtUsername.Text = val;
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            string val = txtPassword.Text;

            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }
            else
            {
                txtPassword.Text = val;
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        private void lblAU_MouseEnter(object sender, EventArgs e)
        {
            lblAU.Font = new Font("Arial", 10, FontStyle.Underline);
        }

        private void lblAU_MouseLeave(object sender, EventArgs e)
        {
            lblAU.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            picExit.Image = Resources.Exit;
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Image = Resources.Exit2;
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
