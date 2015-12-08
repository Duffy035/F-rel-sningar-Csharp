using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11
{
    public class Cool
    {
        public int Number { get; set; }


        //overrride skriver en ny och förbättrar version som vi ärvt från en basklass

        //override tar befälet över metoden
        //basklassens 'virtual' säger att det är OK att göra en override
        //Kan göras på metoder, event properties och indexer

            //Här görs override från objektet, F12 och titta:
             Object obj;
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
