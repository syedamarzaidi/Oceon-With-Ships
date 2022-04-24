using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Sea.BL;
using Sea.UI;
namespace Sea.DL
{
    class ShipDL
    {
        public static List<Ship> ships = new List<Ship>();
        public static void addShip(Ship newShip)
        {
            ships.Add(newShip);
        }
        public static Ship isShipExists(string shipNumber)
        {
            foreach (var s in ships)
            {
                if (s.shipNumber == shipNumber)
                {
                    return s;
                }
            }
            return null;
        }
        public static string isShipNumberExists(string longitude, string latitude)
        {
            Angle Longitude = Angle.getAngle(longitude);
            Angle Latitude = Angle.getAngle(latitude);
            foreach (var st in ships)
            {
                if (Angle.isObjectsEqual(st.longitude, Longitude) && Angle.isObjectsEqual(st.latitude, Latitude))
                {
                    return st.shipNumber;
                }
            }
            return null;
        }
        static string getSerialNumber(string longitude, string latitude)
        {
            Angle Longitude = Angle.getAngle(longitude);
            Angle Latitude = Angle.getAngle(latitude);
            foreach (var st in ships)
            {
                if (st.longitude == Longitude && st.latitude == Latitude)
                {
                    return st.shipNumber;
                }
            }
            MainUI.tempStop();
            return "INVALID";
        }
        public static bool changeShipPosition(string shipNumber, Ship s)
        {
            for (int i = 0; i < ships.Count; i++)
            {
                if (ships[i].shipNumber == shipNumber)
                {
                    ships[i].longitude = s.longitude;
                    ships[i].latitude = s.latitude;
                    return true;
                }
            }
            return false;
        }
        public static Ship isShipExist(string shipNumber)
        {
            foreach (var s in ships)
            {
                if (shipNumber == s.shipNumber)
                {
                    return s;
                }
            }
            return null;
        }
        public static void changeShipPosition(string shipNumber)
        {
            Ship s = isShipExists(shipNumber);
            Angle longitude = AngleUI.takeInputForAngle("longitude");
            Angle latitude = AngleUI.takeInputForAngle("latitude");
            s.longitude.changeCompleteAngle(longitude);
            s.latitude.changeCompleteAngle(latitude);

        }

        public static void storeShipData(string path,bool isAppend)
        {
            StreamWriter file = new StreamWriter(path, isAppend);
            foreach (var s in ships)
            {
                file.Write(s.shipNumber + ";");
                Angle longitude = s.longitude;
                Angle latitude = s.latitude;
                file.Write(longitude.getDegree() + "," + longitude.getMinutes() + "," + longitude.getDirection() + ";");
                file.Write(latitude.getDegree() + "," + latitude.getMinutes() + "," + latitude.getDirection());
                file.WriteLine();
            }
            file.Flush();
            file.Close();
        }
        public static void ReadDataFromShip(string path)
        {
            string record;
            string serialNumber;
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splitedShip = record.Split(';');
                    serialNumber = splitedShip[0];
                    Angle longitude = ReturnAngle(splitedShip[1]);
                    Angle latitude = ReturnAngle(splitedShip[2]);
                    Ship s = new Ship(serialNumber, longitude, latitude);
                   ships.Add(s);
                }
            }
        }
        public static Angle ReturnAngle(string t)
        {
            string[] longitudeSplited = t.Split(',');
            int degree, minutes;
            char direction;
            degree = int.Parse(longitudeSplited[0]);
            minutes = int.Parse(longitudeSplited[1]);
            direction = char.Parse(longitudeSplited[2]);
            Angle l = new Angle(degree, minutes, direction);
            return l;
        }
        public static string isShipSerialNumberExists(Angle longitude, Angle latitude)
        {
            foreach (var st in ships)
            {
                if (st.longitude == longitude && st.latitude == latitude)
                {
                    return st.shipNumber;
                }
            }
            return null;
        }
    }
}

    
