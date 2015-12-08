using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Bicycle
    {
        private int gears;     //jobbar mot dessa skyddade fält
        private string brand;

        public int Gears
        {
            get
            {
                return gears;
            }
            set
            {
                //introducerar en variabel till det annars kryptiska boolska värdet... Jämför med andra if:en
                var validGears = value >= 0 && value <= 30 && value != 1;
                if (validGears)
                    gears = value;

                //if (value >= 0 && value <= 30 && value != 1)
                //    gears = value;
            }
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (value != null && value.Length >= 3)
                    brand = value;
            }
        }
    }
}
