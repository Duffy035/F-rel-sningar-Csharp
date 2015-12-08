using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_kap6
{
    class Program
    {
       static int tal = 9;  //obs att den är static
        int talSomÄrInstans = 0;
        static void Main(string[] args) //static
        {
            tal = 5;        //Går eftersom vi deklarerat 'static int tal' i vårt fält ovan. Hade inte gått om vi bara skrivit 'int tal'.
            Program program = new Program();
            program.talSomÄrInstans = 77;


            //datamedlemmar datamedlem = new datamedlemmar(); //hade inte gått att nå instansen 'datamedlem' sålänge 'reachableNumber' är static i klassen 'datamedlemmar'

            datamedlemmar.reachableNumber = 7;  //vi använder DATATYPEN (pga. 'static')

            /*datamedlemmar.notReachableNumber = 9;*/ //GÅR INTE - satt till 'private' i klassen 'datamedlemmar'.

            Console.WriteLine(datamedlemmar.PI); //Vi kan skriva ut denna.



        }
    }
}
