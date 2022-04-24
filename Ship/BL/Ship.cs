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
        public string shipNumber;
        public Angle longitude = new Angle(0, 0, 'n');
        public Angle latitude = new Angle(0, 0, 'n');

    }
}
