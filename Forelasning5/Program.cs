using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5
{
    class Program
    {
        //int hej = 9;  //ett fält
        static void Main(string[] args)
        {
            //WhileLoop();
            //OlikaExempel();
            //ForEach();  //En forEach tar alla element, såvida man inte gör ngt speciellt med dem.
            //contBreak();
            //myIntArray();
            //myLoopInt();

            Console.WriteLine(MadMath.Add(5, 10, 15, 20, 25, 45, 12, 235, 3243, 35));  //kan skriva såhär mha 'params'

            Console.ReadLine();
        }

        private static void myLoopInt()
        {
            int[] ages = new int[] { 12, 42, 65, 666, 12, 645, 212, 43 };
            foreach (var item in ages)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("FOR minus 666:");

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] == 666)
                    continue;
                    Console.WriteLine(ages[i]);
            }
        }

        private static void myIntArray()
        {
            int[] ages = new int[] { 11, 22, 3, 41, 45, 16 };
            foreach (var item in ages)
            {
                Console.WriteLine(ages);
            }
        }

        //private: åtkomstdirektiv | static: klassmetod | void: returtypen | identifieraren: contBreak | inparameterar: ()
        //OBS! inparameterar dör efter scopet ({ det innanför här är ett scope })
        private static void contBreak()
        {
            //1-100, hoppar över 50
            for (int i = 0; i <= 100; i++)
            {
                if (i == 50)
                    continue;       //innebär att allt inom scopet avbryts, och vi går till console.readline(); Görs när vårt condition är                    sant. dvs. I === 999;
                    //break;        //Avbryter allt
                    //return;      //Avbryter hela metoden.
                Console.WriteLine(i);
            }
            Console.WriteLine("Nisse");
            Console.ReadLine();
        }

        private static void ForEach()
        {
            string[] names = new string[] { "Göran", "Åke", "Lisa", "Maja", "My" };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static void WhileLoop()
        {
            int n = 0;   //startvärde
            while (n > -4)    //Villkor
                Console.WriteLine("talet är {0}", n);
            n--;        //Förändring
        }

        private static void OlikaExempel()
        {
            Menu.PrintMenu();

            //System.Int32 tal = 5; //Detta är samma som int tal = 5;
            int tal = 5;          //bara access inom metoden!!!

            for (double i = 0.0d; i < 2.0d; i += 0.1d)   //Bättre att använda 'double' här en säg 'float'. double är mer precis för uträkning av små tal. double och int                                               är föredragna datatyper. Använder vi en 'float' måste vi sätta f ist. för d i loopen

            //const double GRAVITY = 9.82;
            //GRAVITY++;  //Detta går inte för vi använder 'const'. Det är en konstant som vi skyddar. const skrivs med uppercase. tar vi bort const kommer det funka.
            {
            }
            Console.ReadLine();
        }
    }
}
