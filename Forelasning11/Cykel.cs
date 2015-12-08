using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11
{
    public class Cykel : Fordon
    {
        //Cykel är nu 'Fordon'
        public override void Print()
        {
            Console.WriteLine("Cykel");
        }
    }
}
