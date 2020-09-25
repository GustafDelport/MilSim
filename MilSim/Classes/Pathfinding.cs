using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim.Classes
{
    class Pathfinding
    {
        public Pathfinding() { }

        //=================================================================================================================================
        #region MajorMethods
        static int[,] mat;
         //= Globals.Maze;

        public static Queue<Points> q = new Queue<Points>();

        public static Points GetBFS(int x, int y)
        {
            //int[,] mat = Globals.Maze;

            q.Enqueue(new Points(x, y, null, 0, 'S'));

            while (q.Count != 0)
            {
                Points p = q.Dequeue();

                if (mat[p.x, p.y] == 9)
                {
                    Points endP = new Points(p.x + 1, p.y, p, p.dis + 1, 'E');
                    return endP;
                }

                if (isFree(p.x + 1, p.y))
                {
                    mat[p.x, p.y] = -1;
                    Points nextP = new Points(p.x + 1, p.y, p, p.dis + 1, 'D');
                    q.Enqueue(nextP);
                }

                if (isFree(p.x - 1, p.y))
                {
                    mat[p.x, p.y] = -1;
                    Points nextP = new Points(p.x - 1, p.y, p, p.dis + 1, 'U');
                    q.Enqueue(nextP);
                }

                if (isFree(p.x, p.y + 1))
                {
                    mat[p.x, p.y] = -1;
                    Points nextP = new Points(p.x, p.y + 1, p, p.dis + 1, 'R');
                    q.Enqueue(nextP);
                }

                if (isFree(p.x, p.y - 1))
                {
                    mat[p.x, p.y] = -1;
                    Points nextP = new Points(p.x, p.y - 1, p, p.dis + 1, 'L');
                    q.Enqueue(nextP);
                }
            }
            return null;
        }

        public static bool isFree(int x, int y)
        {
            if ((x >= 0 && x < mat.Length) && (y >= 0 && y < mat.Length) && (mat[x, y] == 0 || mat[x, y] == 9))
            {
                return true;
            }
            else return false;
        }

        public void Start(int[,] Maze)
        {
            mat = Maze;

            Tuple<int, int> start = GetStart();

            Points p = GetBFS(start.Item1, start.Item2);
            List<Points> path = new List<Points>();

            path.Add(p.getParent());

            for (int i = 0; i < p.dis; i++)
            {
                path.Add(path[i].getParent());
            }

            path.Reverse();

            string pathString = null;

            foreach (Points item in path)
            {
                if (item != null)
                {
                    pathString += $"{item.direction} ";
                }
            }

            Globals.shortestPath = path;
            
        }

        public Tuple<int,int> GetStart()
        {
            Tuple<int, int> start = null;

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 17; k++)
                {
                    if (mat[i,k] == 1)
                    {
                        start = new Tuple<int, int>(i,k);
                    }
                }
            }

            return start;
        }
        #endregion
        //=================================================================================================================================

    }
}
