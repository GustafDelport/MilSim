using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    class Plane
    {
        private PictureBox box;
        private int speed;
        private string iD;
        private float freightWeight;
        private float fuelEfficency;

        public int Speed { get { return speed; } set { speed = value; } }
        public string ID { get { return iD; } set { iD = value; } }
        public float FreightWeight { get { return freightWeight; } set { freightWeight = value; } }
        public float FuelEfficency { get { return fuelEfficency; } set { fuelEfficency = value; } }
        public PictureBox Box { get { return box; } set { box = value; } }

        public Plane(int speed, string iD, float freightWeight, float fuelEfficency, PictureBox box)
        {
            this.speed = speed;
            this.iD = iD;
            this.freightWeight = freightWeight;
            this.fuelEfficency = fuelEfficency;
            this.box = box;
        }

        public void Plane1()
        {
            string path = Path.GetFullPath(@"..\..\Resources\JetOne.png");
            box.Load(path);
        }
        public void Plane2()
        {
            string path = Path.GetFullPath(@"..\..\Resources\JetTwo.png");
            box.Load(path);
        }
        public void Plane3()
        {
            string path = Path.GetFullPath(@"..\..\Resources\JetThree.png");
            box.Load(path);
        }

        public void Plane4()
        {
            string path = Path.GetFullPath(@"..\..\Resources\JetFour.png");
            box.Load(path);
        }

        public int CalculateSpeed()
        {
            int speed = Globals.Plane.Speed;

            return speed;
        }

        public Plane() { }


    }
}
