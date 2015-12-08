using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_kap6
{
    class datamedlemmar
    {
        //Kap 6 i boken!!
        //Egenskaper för klassen:
        //      -Datamedlemmar, fält
        //      -Konstanter
        //Vi kan göra dessa: public, private, static, (OBS!, kan bara finnas 1 av den), const, t.ex!

        /*
        Funktionella medlemmar (kommer ske ngt när vi använder dessa):
            -Metoder  (en förenklad syntax, för ett fält med Get/Set)
            -Properties
            -Constructor    (en byggställning som generar ny data när man skriver new)
            -Destructor     (när en klass slutar fungera kan man tvinga bort den med en sådan här)
            -Operators      (+,-,* osv. Dessa kan överlagras.)
            -Indexer        (En samling av någonting, som man har access till under givna villkor. Egenskaper som en property fast för en hel kollektion)
            -Event          (Händelser (används sällan i konsollapplikationer).
        */

        /*EX:*/
        public static int reachableNumber;
        private static int notReachableNumber;
        public const double PI = 3.141592654;  //const är implicit(automatiskt) static. (motsvarigheten - explicit= man får göra ngt extra)

        /*Detta går inte!*/
        //public void SetNumber(int number)
        //{
        //    this.notReachableNumber = number;
        //}

        /*Detta går!*/
        public static void SetNumber(int number) //Måste vara static, namnkonflikt pga. vi inte kan ha flera 'notReachableNumber'
        {
            notReachableNumber = number;
        }
        public void SetNumber2(int number)
        {
            notReachableNumber = number;
        }
    }
}
