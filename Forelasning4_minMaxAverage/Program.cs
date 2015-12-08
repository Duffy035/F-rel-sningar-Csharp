using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning4_minMaxAverage;   //Vi har lagt till vår referens. Måste göras!

//Min, max och average (Föreläsning 4)
namespace Forelasning4_minMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMaxAverage minMaxAverage = new MinMaxAverage();
            minMaxAverage.PrintMinMaxAverage(new int[] { 1, 2, 3, 4 });   //Här har vi hoppat över steget att deklarera arrayen:  int[] myArray = new int[] {1, 2, 3, 4};                                                               Vi kör in den direkt, och hoppar över själva deklarationen. Vi kan göra vilket som, mest fråga                                                              om att korta ned raderna.
            System.Threading.Thread.Sleep(3000);
        }
    }
}
