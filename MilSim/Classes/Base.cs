using MilSim.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    class Base
    {
        private PictureBox _box;
        public Base() { }

        public PictureBox box { set { _box = value; } }

        public void Camp1()
        {
            string path = Path.GetFullPath(@"..\..\Resources\CanonSmall.png");
            _box.Load(path);
        }
        public void Camp2()
        {
            string path = Path.GetFullPath(@"..\..\Resources\TankSmall.png");
            _box.Load(path);
        }
        public void Camp3()
        {
            string path = Path.GetFullPath(@"..\..\Resources\GunSmall.png");
            _box.Load(path);
        }

        public void Camp4()
        {
            string path = Path.GetFullPath(@"..\..\Resources\MineSmall.png");
            _box.Load(path);
        }

        public void Remove()
        {
            _box.Image = null;
        }

        public void StartPos()
        {
            string path = Path.GetFullPath(@"..\..\Resources\StartSmall.png");
            _box.Load(path);
        }

        public void EndPos()
        {
            string path = Path.GetFullPath(@"..\..\Resources\EndSmall.png");
            _box.Load(path);
        }
    }
}
