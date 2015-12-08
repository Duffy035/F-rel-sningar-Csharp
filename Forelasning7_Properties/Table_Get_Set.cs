using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{

    //TABLE med Getter och Setter:
    class Table3
    {
        int chairs;
        string color;

        public void SetChairs(int chairs)
        {
            this.chairs = chairs;
        }
        public int GetChairs()
        {
            return chairs;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return color;
        }
    }
}
