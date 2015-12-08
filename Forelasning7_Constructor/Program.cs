using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //finns ingen tom konstruktor tvingar vi användaren att följa signaturen för en annan konstruktor - se nedan.

            //string name = Console.ReadLine();
            //Person lisa = new Person("Baltazar");
            //Person stina = new Person(7, "Svensson"); //Går in i den överlagrade konstruktorn och tar DENNA (this) instansens värde, vilket blir 7 och Svensson. Vi måste följa satta datakonventionen, så vi måste ange en int och en string. 





            /*REKTANGEL ÖVNING*/
            //skapa rektangel som sätter width och height i konstruktorn

            Rektangel rektangel = new Rektangel();
            Rektangel rektangel2 = new Rektangel(3.2);
            Rektangel rektangel3 = new Rektangel(3.2, 9.0);

            //named parameters - går att ändra ordningen på + att vi ser vad vi ändrar värde på. JOBBA UTIFRÅN DETTA!
            Rektangel rektangel4 = new Rektangel(width: 44.3, height: 23.2);
            Rektangel rektangel5 = new Rektangel(height: 23.2, width: 44.3);

        }
    }
}



