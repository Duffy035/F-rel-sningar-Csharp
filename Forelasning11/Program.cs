using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Virtual_o_Override();

            Vehicle vechicle = new Car();// new Car();  //Hmmm abstract klass...
            vechicle.Print();
            Console.ReadLine();
        }

        private static void Virtual_o_Override()
        {
            Cykel cykel = new Cykel();
            Fordon fordon = new Fordon();// (Fordon)cykel;
            Bil bil = new Bil();
            Fordon[] fordonare = new Fordon[3] { cykel, fordon, bil };

            foreach (var item in fordonare)
            {
                item.Print();
            }
            Console.ReadLine();

            //cykel.Print();
            //fordon.Print();
            //Console.ReadLine();
        }
    }
}
