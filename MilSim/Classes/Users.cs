using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilSim.Classes
{
    class Users
    {
        //Properties
        private int userID;
        private string username;
        private string name;
        private string surname;
        private int age;
        private string password;

        //Fields
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //Full Constructor
        public Users(int _userID, string _username, string _name, string _surname,int _age, string _password)
        {
            this.UserID = _userID;
            this.Age = _age;
            this.Username = _username;
            this.Name = _name;
            this.Surname = _surname;
            this.Password = _password;
        }
        //Empty Constructor
        public Users()
        {

        }
    }
}
