using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6_3_Recursion
{
    class Program
    {
        static int startValue = 0;
        static int stopValue = 2;
        static void Main(string[] args)
        {
            //Vi vill göra detta med 'recursion' för att snabba upp det. Vi vet att minne är väsentligt. Går ngt långsamt, ska vi köra med recursion
            //WithForLoop();
            RecursionPrint(startValue);
            System.Threading.Thread.Sleep(4000);
        }
        private static void RecursionPrint(int i)
        {
            Console.WriteLine(i);
            i++;
            if (i <= stopValue)
                RecursionPrint(i);
            Console.WriteLine("Loopen är färdig" + i);
        }
        private static void WithForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
