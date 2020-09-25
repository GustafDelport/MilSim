using MilSim.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MilSim.Forms
{
    class DataHandler
    {
        public DataHandler() { }

        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog = MillSimDB; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();

        string Q = "";

        //=======================================================================================================
        //Inserts
        //=======================================================================================================
        #region Data Inserts
        public void AddUser(string _Username, string _Name, string _Surname, string _Age, string _Password)
        {
            Q = $"INSERT INTO Users(Username,Name,Surname,Age,Password) VALUES ('{_Username}','{_Name}','{_Surname}',{_Age},'{_Password}')";

            SqlCommand Cmd = new SqlCommand(Q, conn);
            conn.Open();
            Cmd.ExecuteNonQuery();
            Console.WriteLine("User Inserted");
            conn.Close();
        }

        public void AddReport()
        {
            string planeID = Globals.Plane.ID;
            int c = Globals.shortestPath.Count;

            int Efficency = (int)(Globals.Plane.FuelEfficency * Globals.shortestPath[c - 1].dis);

            string Des = GetDes(c);

            Q = $"INSERT INTO Reports(Efficency,Description,Date,PlaneID) VALUES ('{Efficency}','{Des}','{DateTime.Now}','{planeID}') ";

            SqlCommand Cmd = new SqlCommand(Q, conn);
            conn.Open();
            Cmd.ExecuteNonQuery();
            Console.WriteLine("Report Added");
            conn.Close();
        }
        #endregion
        //=======================================================================================================
        //=======================================================================================================

        //=======================================================================================================
        //Retrieves
        //=======================================================================================================
        #region Data Retrieves
        public List<Users> GetUsers()
        {
            List<Users> _Users = new List<Users>();
            //DO SQL Here

            Q = $"SELECT * FROM Users";
            cmd = new SqlCommand(Q, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    _Users.Add(new Users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5)));
                }
            }
            return _Users;
        }

        public Plane GetPlane(string ID, PictureBox box)
        {
            Plane plane = null;
            Q = $"SELECT * FROM Planes WHERE PlaneID = '{ID}'";
            cmd = new SqlCommand(Q, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    plane = new Plane(reader.GetInt32(1), reader.GetString(0), reader.GetInt32(2), reader.GetInt32(3), box);
                }
            }

            return plane;

            //do sql to return base plane
        }

        public void SearchByDate(DateTime date, DataGridView dataGrid)
        {
            try
            {
                Q = $"SELECT * FROM Reports WHERE Date = '{date}'";
                DataTable table = new DataTable();

                SqlDataAdapter reader = new SqlDataAdapter(Q, conn);

                reader.Fill(table);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void planeID(string ID, DataGridView dataGrid)
        {
            try
            {
                Q = $"SELECT * FROM Reports WHERE PlaneID = '{ID}'";
                DataTable table = new DataTable();

                SqlDataAdapter reader = new SqlDataAdapter(Q, conn);

                reader.Fill(table);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void RepID(int ID, DataGridView dataGrid)
        {
            try
            {
                Q = $"SELECT * FROM Reports WHERE ReportID = {ID}";
                DataTable table = new DataTable();

                SqlDataAdapter reader = new SqlDataAdapter(Q, conn);

                reader.Fill(table);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void ShowAllReports(DataGridView dataGrid)
        {
            try
            {
                Q = $"SELECT * FROM Reports";
                DataTable table = new DataTable();

                SqlDataAdapter reader = new SqlDataAdapter(Q, conn);

                reader.Fill(table);
                dataGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion
        //=======================================================================================================
        //=======================================================================================================

        //=======================================================================================================
        //Methods
        //=======================================================================================================
        #region Methods
        public string GetDes(int c)
        {
            int distance = Globals.shortestPath[c - 1].dis;

            int startX = Globals.shortestPath[1].x;
            int startY = Globals.shortestPath[1].y;

            int endX = Globals.shortestPath[c - 1].x;
            int endY = Globals.shortestPath[c - 1].y;

            //This is a quick description START : x,y END : x,y Distance : x units

            return $"Start : x = {startX}, y = {startY} End : x = {endX}, y = {endY} Distance : {distance}";
        }

        public void ResetDB()
        {
            var fileContent = new FileHandler().getDBLocation();
            var sqlqueries = fileContent.Split(new[] {"GO"}, StringSplitOptions.RemoveEmptyEntries);

            var cmd = new SqlCommand("query", conn);
            conn.Open();
            foreach (var query in sqlqueries)
            {
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        #endregion
        //=======================================================================================================
        //=======================================================================================================
    }
}
