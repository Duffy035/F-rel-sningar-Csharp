using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Skapa en motorcykel som har:

-Hästkrafter
-getters och setters
-program som frågar efter egenskaperna och sätter dem i en instans
-utskrift av instanse

*/

namespace Forelasning_3
{
    class Motorcycle
    {
        private int horsePowers;
        private int maxSpeed;

        public int GetHorsePowers()
        {
            return horsePowers;
        }
        internal void SetHorsePowers(int horsePowers)  //'internal' gör det lite mer åtstramat tillskillnad från 'public'. Spelar ingen roll vilken vi kör här.
        {
            this.horsePowers = horsePowers;
        }
        public int GetMaxSpeed()
        {
            return maxSpeed;
        }
        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        internal string PrintBike()
        {
            return $"Your motorcycle has {this.GetHorsePowers()}horsepowers and {this.GetMaxSpeed()} in topspeed";
        }
    }
}