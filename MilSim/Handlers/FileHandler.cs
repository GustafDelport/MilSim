using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    class FileHandler
    {
        public FileHandler() { }

        public void readBaseInfo(RichTextBox textBox)
        {
            try
            {
                string path = System.IO.Path.GetFullPath(@"..\..\TextFiles\BaseHowTo.txt");
                textBox.Text = File.ReadAllText(path);
            }
            catch (Exception)
            {
                MessageBox.Show("No Such file Exists", "Error");
            }
        }

        public void printMaze(int[,] _Maze)
        {
            string path = System.IO.Path.GetFullPath(@"..\..\TextFiles\Maze.txt");

            int rowLength = _Maze.GetLength(0);
            int colLength = _Maze.GetLength(1);

            using (StreamWriter stream = new StreamWriter(path))
            {
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        stream.Write(string.Format("{0}", _Maze[i, j]));
                    }
                    stream.Write(Environment.NewLine);
                }
            }
        }

        public void readInfo(RichTextBox textBox)
        {
            try
            {
                string path = System.IO.Path.GetFullPath(@"..\..\TextFiles\Information.txt");
                textBox.Text = File.ReadAllText(path);
            }
            catch (Exception)
            {
                MessageBox.Show("No Such file Exists", "Error");
            }
        }

        public string getDBLocation()
        {
            string script = File.ReadAllText(@"..\..\..\..\MillSimDB.sql");
            return script;
        }
    }
}
