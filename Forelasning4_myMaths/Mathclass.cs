using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Forelasning4_myMaths
{
    public class Mathclass
    {
        public void PrintValues(double[] theArray)
        {
            Console.WriteLine("Anropar GetMinValue: " + GetMinValue(theArray));
            Console.WriteLine("Anropar GetMaxValue: " + GetMaxValue(theArray));
            Console.WriteLine("Anropar GetAverageValue: " + GetAverageValue(theArray));
        }

        //tre metoder: min, max och average
        public double GetMinValue(double[] theArray)
        {
            double min = theArray[0];
            for (int i = 1; i < theArray.Length; i++)
            {
                //letar efter det minsta värdet i arrayen...
                if (theArray[i] < min)
                {
                    min = theArray[i];
                }

            }
            return min;
        }
        public double GetMaxValue(double[] theArray)
        {
            double max = theArray[0];
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] > max)
                {
                    max = theArray[i];
                }
            }
            return max;
        }
        public double GetAverageValue(double[] theArray)
        {
            double sum = 0;
            for (int i = 0; i < theArray.Length; i++)
            {
                sum += theArray[i];
            }
            return sum / theArray.Length;
        }

    }
}
