using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning5
{
    static class MadMath
    {
       //internal static double Add(double tal)           //en inparameter
       // {
       //     return tal;
       // }
       // internal static double Add(double a, double b)   //två inparameterar - kallas att överlagra.
       // {
       //     return a + b;
       // }
       // internal static double Add(double a, double b, double c)  //samma som ovan, fast tre inparameterar
       // {
       //     return a + b + c;
       // }
        internal static double Add(params double[] array)          //Här gör vi det med en array, och kan på så vis sätta in hur många tal vi                                                                                        vill (se Program.cs). Params gör att allting behandas som en array när                                                                                          det körs in. Detta sättet ersätter alla de ovan!
        {
            var sum = 0.0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
    }
}
