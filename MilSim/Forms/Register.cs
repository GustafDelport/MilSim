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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        //===================================================================================================================================
        //Clicks
        //===================================================================================================================================
        #region Clicks
        private void picExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblAU_Click(object sender, EventArgs e)
        {
            Globals.register.Hide();
            Globals.login.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (new Validation().CheckRegister(this.txtName, this.txtSurname, this.txtAge, this.txtUsername, this.txtPassword, this.txtCPassword))
            {
                new DataHandler().AddUser(txtUsername.Text, txtName.Text, txtSurname.Text, txtAge.Text, txtPassword.Text);
                Globals.UserLogged = txtUsername.Text;
                Globals.main.Show();
                Globals.register.Hide();
            }
            
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

        private void lblAU_MouseEnter(object sender, EventArgs e)
        {
            lblAU.Font = new Font("Arial", 10, FontStyle.Underline);
        }

        private void lblAU_MouseLeave(object sender, EventArgs e)
        {
            lblAU.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = "";
        }

        private void txtSurname_MouseClick(object sender, MouseEventArgs e)
        {
            txtSurname.Text = "";
        }

        private void txtAge_MouseClick(object sender, MouseEventArgs e)
        {
            txtAge.Text = "";
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtCPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtCPassword.Text = "";
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            string val = txtName.Text;

            if (txtName.Text == "")
            {
                txtName.Text = "Name";
            }
            else
            {
                txtName.Text = val;
            }
        }

        private void txtSurname_MouseLeave(object sender, EventArgs e)
        {
            string val = txtSurname.Text;

            if (txtSurname.Text == "")
            {
                txtSurname.Text = "Surname";
            }
            else
            {
                txtSurname.Text = val;
            }
        }

        private void txtAge_MouseLeave(object sender, EventArgs e)
        {
            string val = txtAge.Text;

            if (txtAge.Text == "")
            {
                txtAge.Text = "Age";
            }
            else
            {
                txtAge.Text = val;
            }
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
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

        private void txtCPassword_MouseLeave(object sender, EventArgs e)
        {
            string val = txtCPassword.Text;

            if (txtCPassword.Text == "")
            {
                txtCPassword.Text = "Confirm Password";
            }
            else
            {
                txtCPassword.Text = val;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
