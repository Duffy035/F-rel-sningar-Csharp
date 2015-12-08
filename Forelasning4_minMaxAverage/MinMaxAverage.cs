using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning4_minMaxAverage
{
    class MinMaxAverage
    {
        public void PrintMinMaxAverage(int[] theArray)
        {
            int min = theArray[0];
            int max = theArray[0];
            double sum = 0;
            for (int i = 0; i < theArray.Length; i++)
            {
                if (min > theArray[i])
                {
                    min = theArray[i];
                }
                if (max < theArray[i])
                {
                    max = theArray[i];
                }
                sum = sum + theArray[i];
            }
            Console.WriteLine("Min är: " + min);
            Console.WriteLine("Max är: " + max);
            Console.WriteLine("Average är: " + sum/theArray.Length);
        }

    }
}
