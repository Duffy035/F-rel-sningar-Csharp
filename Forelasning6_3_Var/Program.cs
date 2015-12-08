using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6_3_Var
{
    class Program
    {
        /*var*/ //funkar Ej Här Ute EFtersom Det Är En Instans
        static void Main(string[] args)
        {
            //SupermanRadioActiveSuperLongNameBooo supermanRadioActiveSuperLongNameBooo = new SupermanRadioActiveSuperLongNameBooo();   //Svårförståeligt! anv. 'var'
            var stålis = new SupermanRadioActiveSuperLongNameBooo();
            var heltal = 5;  //blir en 'int'
            var decimaltal = 5.9;   //blir en 'double'
            var stortHeltal = 23455L;
            var litetDecimalTal = 4.9f;
            var text = "some text";
            text = "Tjosan hejsan din filur";  //går bra! samma datatyp
            //text = 7; //Går inte! EJ samma datatyp!

            var tal = new int[] { 34, 35, 36, 37, 38, 39 };
            foreach (var item in tal)  //datatyp från vektorn
            {
                Console.WriteLine(item);
            }
        }
    }
}
