
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning4
{
    internal class MyForLoopClass
    {
        int[] skostorlekar = {43, 44, 45, 46, 36, 12, 42 };  //Fält, eller eng. 'Field'

        //nedan: åtkomstdirektiv (internal) - returvärde (void) - identifierare (OneToHundred)
        internal void OneTooHundred() //måste vara internal för att komma åt den! Precis som hela klassen i sig - 'MyForLoopClass'
        {
            //for(startvärde); villkor; förändring){saker som sker i loopen}
            for (int i = 1; i <= 100; i = i + 2)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);  
            }
        }
        internal double GetAverage(int[] arrayToCalculateOn)
        {
            double sum = 0;  //måste ligga här, och inte i scopet.
            for (int i = 0; i < arrayToCalculateOn.Length; i++)
            {
                sum += arrayToCalculateOn[i];     //plusar på varje gång vi loopar.
            }
            //Vi ska dela hela summan av alla tal med hur många tal det finns...
            //delar med detta: arrayToCalculateOn.Length
            double result = sum / arrayToCalculateOn.Length;
            return result;
        }
    }
}
