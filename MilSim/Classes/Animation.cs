using MilSim.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    class Animation
    {
        public Animation() { }

        public void BeginFlight(PictureBox Plane, Panel panel)
        {
            string path, name;

            Plane.Visible = true;

            //Determines where planes starts
            foreach (PictureBox item in panel.Controls)
            {
                if (!(item.Image == null))
                {
                    path = item.ImageLocation;
                    name = path.Substring(path.LastIndexOf('\\') + 1);

                    if(name == "StartSmall.png")
                    {
                        Plane.Parent = panel;
                        Plane.BringToFront();
                        Plane.Location = item.Location;
                    }
                }
            }

            new Thread(new ThreadStart(() => Move(Plane,Plane.Location.X, Plane.Location.Y))).Start();

        }

        public void Move(PictureBox Plane,int X, int Y)
        {
            int curX;
            int newX = X;
            int curY;
            int newY = Y;

            foreach (Points item in Globals.shortestPath)
            {
                if (item != null)
                {
                    switch (item.direction)
                    {
                        case 'R':
                            {
                                curX = Plane.Location.X;

                                newY = Plane.Location.Y;
                                newX = curX + 60;
                            }
                            break;
                        case 'U':
                            {
                                curY = Plane.Location.Y;

                                newX = Plane.Location.X;
                                newY = curY - 60;
                            }
                            break;
                        case 'D':
                            {
                                curY = Plane.Location.Y;

                                newX = Plane.Location.X;
                                newY = curY + 60;
                            }
                            break;
                        case 'L':
                            {
                                curX = Plane.Location.X;

                                newY = Plane.Location.Y;
                                newX = curX - 60;
                            }
                            break;
                        case 'S':
                            {
                                newX = Plane.Location.X;
                                newY = Plane.Location.Y;
                            }
                            break;
                    }
                }

                var updateAction = new Action(() => { Plane.Location = new Point(newX, newY); });
                Plane.Invoke(updateAction);

                Thread.Sleep(Globals.Plane.CalculateSpeed());
            }

            new DataHandler().AddReport();
            MessageBox.Show("Flight Complete \nProceed to Reports for more detial ");
        }
    }
}
