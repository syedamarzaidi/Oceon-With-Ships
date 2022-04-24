using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea.UI
{
    class MainUI
    {
        public static string Menu()
        {
            Console.WriteLine("1_Add Ship");
            Console.WriteLine("2_View Ship Position");
            Console.WriteLine("3_View Ship Serial Number");
            Console.WriteLine("4_Change Ship Position");
            Console.WriteLine("5_Exit");
            Console.WriteLine("Enter your option");
            string option = Console.ReadLine();
            return option;
        }
        public static void tempStop()
        {
            Console.WriteLine("Please Enter any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static string takeInputForAngleDirection(string direc)
        {
            string d = "";
            Console.WriteLine("Press Alt+0176 to print degree symbol And ' to print minute symbol");
            Console.WriteLine("Enter {0}", direc);
            d = Console.ReadLine();
            return d;
        }
        public static string takeInputForAngle(string direc)
        {
            string angl = "";
            Console.WriteLine("Enter " + direc);
            angl = Console.ReadLine();
            return angl;
        }
    }
}
