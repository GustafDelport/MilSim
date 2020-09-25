using MilSim.Classes;
using MilSim.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    class Maze
    {
        private int[,] maze;

        public int[,] _Maze   
        { 
            get { return maze; } 
            set { maze = value; } 
        }

        public Maze() { }

        public void CreateMaze(Panel panel)
        {
            string path, name;

            int c = 0;
            int[] arr = new int[170];

            foreach (PictureBox item in panel.Controls)
            {
                arr[c] = 0;
                if (!(item.Image == null))
                {
                    path = item.ImageLocation;
                    name = path.Substring(path.LastIndexOf('\\') + 1);

                    switch (name)
                    {
                        case "EndSmall.png":
                            {
                                arr[c] = 9;
                            }
                            break;
                        case "StartSmall.png":
                            {
                                arr[c] = 1;
                            }
                            break;
                        default:
                            {
                                arr[c] = 5;
                            }
                            break;
                    }
                }
                c++;
            }

            if (Validate(arr))
            {
                var twoD = Make2DArray(arr, 10, 17);
                new FileHandler().printMaze(twoD);
                Pathfinding findPath = new Pathfinding();
                findPath.Start(twoD);

            }
            else
            {
                MessageBox.Show("Please Include Start and End positions");
            }

        }

        public bool Validate(int[] _Input)
        {
            bool flag = false;

            if (_Input.Contains(1) && _Input.Contains(9))
            {
                flag = true;
            }
            else flag = false;

            return flag;
        }

        private static T[,] Make2DArray<T>(T[] input, int height, int width)
        {
            T[,] output = new T[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    output[i, j] = input[i * width + j];
                }
            }
            return output;
        }

        //=====================================================================================================================================================
    }
}
