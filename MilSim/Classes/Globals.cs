using MilSim.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilSim
{
    static class Globals
    {
        //Forms ================================
        public static Login login;
        public static Register register;
        public static Main main;
        public static pnlSimOptions simulation;
        public static BaseInfo baseInfo;
        public static Reports reports;
        public static Information information;
        public static PlaneSettings planeSettings;
        public static BaseBuild baseBuild;
        //=======================================
        public static Base Base;
        public static Plane Plane;
        public static string UserLogged;
        public static List<Points> shortestPath;

    }
}
