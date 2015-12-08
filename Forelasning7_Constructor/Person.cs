using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Constructor
{
    class Person
    {
        /*En constructor används för att konstruera/skapa ett objekt
          - Ser ut som en metod fast har samma namn som klassen som vi skapar
          - Default constructor som har inte några parametrar
          - Constructorn körs alltid när new anropas på berörd klass
          - Man kan skapa överlagrade cosctructors med inparametrar i
          - Consctructorn bygger upp objektet/klasssen
          - Inget returvärde!
        */

        int age;
        string lastName;
        public Person(string lastName)  //<--- inget returvärde. Överlagrad konstruktor
        {
            age = 0;    //alla objekt vi skapar får detta värde (se 'lisa)  
            this.lastName = lastName; //Nu tvingar vi anv. att ange ett                               efternamn!
        }                 //finns ingen tom konstruktor tvingar vi                            användaren att följa signaturen för en annan                       konstruktor
        public Person(int age, string lastName)
        {
            this.age = age;     //'stina' får dock värdet 7. Det är en                           överlagrad konstruktor
            this.lastName = lastName;
        }
    }
}
