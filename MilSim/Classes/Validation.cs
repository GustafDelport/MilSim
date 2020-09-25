using MilSim.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim.Classes
{
    class Validation
    {
        public Validation() { }

        List<Users> UserList = new List<Users>();

        public bool CheckLogin(TextBox Username, TextBox Password)
        {
            bool flag = false;
            UserList = GetUsers();

            if (!(string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text)))
            {
                foreach (Users user in UserList)
                {
                    if (user.Username == Username.Text && user.Password == Password.Text)
                    {
                        flag = true;
                        break;
                    }
                    else flag = false;
                }
            }
            else
            {
                MessageBox.Show("Ensure that all fields are filled", "Empty fields");
                flag = false;
            }

            return flag;
        }

        public bool CheckRegister(TextBox _Name, TextBox _Surname, TextBox _Age, TextBox _UserName, TextBox _Password, TextBox _CPassword)
        {
            bool flag = false;
            UserList = GetUsers();

            if (!(string.IsNullOrEmpty(_Name.Text) || string.IsNullOrEmpty(_Surname.Text) || string.IsNullOrEmpty(_Age.Text) || string.IsNullOrEmpty(_UserName.Text) || string.IsNullOrEmpty(_Password.Text) || string.IsNullOrEmpty(_CPassword.Text)))
            {
                if (_Password.Text == _CPassword.Text)
                {
                    foreach (Users user in UserList)
                    {
                        if (user.Username == _UserName.Text)
                        {
                            MessageBox.Show("That Username Already Exists", "Invalid Username");
                            flag = false;
                            break;
                        }
                        else { flag = true; }
                    }
                }
                else
                {
                    MessageBox.Show("Please Ensure Passwords Match", "No Match");
                    flag = false;
                }
            }
            else { flag = false; }

            return flag;
        }

        private List<Users> GetUsers()
        {
            List<Users> _Users = new List<Users>();
            _Users = new DataHandler().GetUsers();

            return _Users;
        }
    }
}
