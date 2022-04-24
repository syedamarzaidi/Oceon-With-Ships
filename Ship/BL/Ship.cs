using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea.BL
{
    class Ship
    {
        public Ship()
        {

        }
        public Ship(string shipNumber, Angle longitude, Angle latitude)
        {
            this.shipNumber = shipNumber;
            this.longitude = longitude;
            this.latitude = latitude;
        }
        private string shipNumber;
        private Angle longitude = new Angle(0, 0, 'n');
        private Angle latitude = new Angle(0, 0, 'n');
        public string getShipNumber()
        {
            return shipNumber;
        }
        public Angle getLongitude()
        {
            return longitude;
        }
        public Angle getLatitude()
        {
            return latitude;
        }
        public void setShipNumber(string shipNumber)
        {
            this.shipNumber = shipNumber;
        }
        public void setLongitude(Angle longitude)
        {
            this.longitude = longitude;
        }
        public void setLatitude(Angle latitude)
        {
            this.latitude = latitude;
        }
    }
}
