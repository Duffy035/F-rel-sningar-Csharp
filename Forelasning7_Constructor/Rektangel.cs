using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Constructor
{
    class Rektangel
    {
        double width, height;

        //'Rektangel' nedan måste heta så fär att kunna identifieras som konstruktor för klassen!
        public Rektangel(double width = 0, double height = 0)  //går INTE att ändra ordningen på detta! Är 0 per deafult
        {
            this.width = width;
            this.height = height;
        }
    }
}
