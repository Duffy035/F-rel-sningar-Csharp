using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_3
{
    class Boat   //Denna har vi skapat själva, genom att välja 'add' i vår solution och valt 'class'. Sedan döpte vi den till boat. Detta är en 'internal class' men man behöver inte skriva 'internal' 
    {
        /*public string type="hej";*/   //DÅLIGT! använd inte public här. Gör att man kan komma åt det på andra ställen.
        private string type;    //an behöver inte skriva 'private' egentligen - det är det per default
        private int numberOfPassengers;
        public int GetNumberOfPassengers()
        {
            return numberOfPassengers;
        }
        public void SetNumberOfPassengers(int numberOfPassengers)
        {
            this.numberOfPassengers = numberOfPassengers;
        }


        public string GetType()     //Eftersom det är public kommer de andra klasserna åt den
        {
            return type;    //Returnerar den privata 'type'
        }
        public void SetType(string type)    //public = alla har tillgång till metoden. 
        {
            this.type = type;   //this.  pekar på DENNA instansen. Det blir det objeketet vi skapat (maria, lisa) det DEM .this pekar på när vi skapat dem 
        }
    }
}
