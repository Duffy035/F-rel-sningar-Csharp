using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    /*TABLE med properties*/
    class Table2
    {
        private int chairs;
        private string color;

        public int Chairs
        {
            get
            {
                return chairs;
            }
            set
            {
                if (value != 0)
                    chairs = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value != null && value.Length > 1)
                    color = value;
            }
        }
    }
}
