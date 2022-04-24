using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sea.BL;
using Sea.UI;
using Sea.DL;
namespace Sea
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            string path = "C:\\Users\\kali\\Documents\\Pro\\oceon\\oceon\\oceon\\files\\a.txt";
           
            ShipDL.ReadDataFromShip(path);
            while (option != "5")
            {
                option = MainUI.Menu();
                if (option == "1")
                {
                    bool isAppend = true;
                    Ship s = ShipUI.takeInputForShip();
                    ShipDL.addShip(s); // Adding Ship s to list
                    ShipDL.storeShipData(path,isAppend);
                }
                else if (option == "2")
                {
                    string shipNumber = ShipUI.takeInputForSerialNumber();
                    ShipUI.showShipPosition(shipNumber);
                }
                else if (option == "3")
                {
                    string longitude = MainUI.takeInputForAngleDirection("longitude");
                    string latitude = MainUI.takeInputForAngleDirection("latitude");
                    string shipNumber = ShipDL.isShipNumberExists(longitude, latitude);
                    ShipUI.showShipNumber(shipNumber);
                }
                else if (option == "4")
                {
                    bool isAppend = false;
                    string shipNumber = ShipUI.takeInputForSerialNumber();
                    Ship s = ShipDL.isShipExists(shipNumber);
                    if (s != null)
                    {
                        ShipDL.changeShipPosition(shipNumber);
                    }
                    ShipDL.storeShipData(path, isAppend);
                }
            }
        }
    }
}
