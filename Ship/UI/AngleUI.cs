using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sea.BL;
namespace Sea.UI
{
    class AngleUI
    {
        public static Angle takeInputForAngle(string direc)
        {
            int degree = 0;
            int minutes = 0;
            char direction = ' ';
            Console.WriteLine("Enter Ship {0}:", direc);
            Console.WriteLine("Enter ship degree");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship minutes");
            minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship direction:");
            direction = char.Parse(Console.ReadLine());
            Angle d = new Angle(degree, minutes, direction);// Making object for longitude
            return d;
        }
    }
}
