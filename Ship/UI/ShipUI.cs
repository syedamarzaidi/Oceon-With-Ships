using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sea.BL;
using Sea.DL;
namespace Sea.UI
{
    class ShipUI
    {
        public static Ship takeInputForShip()
        {
            string shipNumber = takeInputForSerialNumber();
            Angle longitude = AngleUI.takeInputForAngle("longitude");
            Angle latitude = AngleUI.takeInputForAngle("latitude");
            Ship newShip = new Ship(shipNumber, longitude, latitude); // Creating object for New Ship;
            return newShip;
        }
        public static string takeInputForSerialNumber()
        {
            string shipNumber = "";
            Console.WriteLine("Enter Ship serial number:");
            shipNumber = Console.ReadLine();
            return shipNumber;
        }
        public static void showShipPosition(string shipNumber)
        {
            Ship stored = ShipDL.isShipExists(shipNumber);
            if (stored != null)
            {
                Angle longitude = stored.getLongitude();
                Angle latitude = stored.getLatitude();
                Console.WriteLine("Ship Position is {0}\u00b0{1}' {2}\t\tAnd {3}\u00b0{4}'{5}", longitude.getDegree(), longitude.getMinutes(), longitude.getDirection(), latitude.getDegree(), latitude.getMinutes(), latitude.getDirection());
            }
            MainUI.tempStop();
        }
        public static void showShipNumber(string shipNumber)
        {
            if (shipNumber != null)
            {
                Console.WriteLine("Ship Number = {0}", shipNumber);
            }
            else
            {
                Console.WriteLine("Ship does not exists");
            }
        }
    }
}

