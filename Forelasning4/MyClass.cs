using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning4
{
     class MyClass
    {

        //Högsta talet
        public int Numbers(int[] calculationArray)
        {
            //[0], [1], [2]
            // 1,   2,   3
            int highestNumber = calculationArray[0];
            for (int i = 0; i < calculationArray.Length; i++)
            {
                if (calculationArray[i] > highestNumber)
                    highestNumber = calculationArray[i];
            }
            return highestNumber;
        }

        //Minsta talet
        public int GetMinFromArray(int[] theArray)
        {
            int lowestNumber = theArray[0];
            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] < lowestNumber)
                    lowestNumber = theArray[i];
            }
            return lowestNumber;
        }
    }
}
