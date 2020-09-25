using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilSim
{
    public class Points
    {
        public int x;
        public int y;
        public int dis;

        public char direction;

        Points parent;

        public Points(int x, int y, Points parent, int dis, char direction)
        {
            this.x = x;
            this.y = y;
            this.parent = parent;
            this.dis = dis;
            this.direction = direction;
        }

        public Points getParent()
        {
            return this.parent;
        }
    }
}
