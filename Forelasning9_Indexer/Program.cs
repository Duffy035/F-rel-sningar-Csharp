using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning9_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer2 test = new Indexer2();
            //test[0] = "Plats 0";
            //test[7] = "Plats 7";
            //test[11] = "fail - does not compute (out of bounds)";
            //var hej = test[11];

            //Brukar loopas ut
            for (int i = 0; i < 10; i++)
            {
                test[i] = i.ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test på position i");
            }
            Console.ReadLine();
        }
    }
}
