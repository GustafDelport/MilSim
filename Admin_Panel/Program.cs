using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Panel;

namespace Admin_Panel
{
    class Program
    {
        static void Main(string[] args)
        {
            new DataHandler().clientStart();
            Console.ReadLine();
        }
    }
}
