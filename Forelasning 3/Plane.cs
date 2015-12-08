using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Skapa ett flygplan
//Fråga anv. "Hur många hjul har flygplanet?"
//skriv ut det
namespace Forelasning_3
{
    class Plane
    {
        private int wheels;

        public int GetWheels()
        {
            return wheels;
        }
        public void SetAmountOfWheels(int Wheels)
        {
            this.wheels = Wheels;
        }

        internal string PrintWheelsAmount()
        {
            return $"Your plane has {wheels} wheels!";
        }
    }
}