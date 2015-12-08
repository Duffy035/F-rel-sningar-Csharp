using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning4_myMaths;

//Övning: 
//1.Skapa en klass "MyClass"
//2.Gör en metod som tar en int-array som inparameter och returnerar det största talet
//3.SKapa en instans i main och anropa metoden
//4. Gör samma sak för det minsta talet. - se 'MyClass'
//5. Skriv ut min, max och average i konsollen

namespace Forelasning4
{
    class Program       //Står egentligen internal här, men skrivs inte ut
    {
        static void Main(string[] args)
        {
            //MyForLoopClass one = new MyForLoopClass();  //Vi skapar 'MyFoorLoopClass' KALLAR på den som vi skapat - 'MyForLoopClass'
            //one.OneTooHundred();
            //int[] testArray = { 1, 3, 3 };
            //Console.WriteLine(one.GetAverage(testArray));
            //one.GetAverage(testArray);
            //System.Threading.Thread.Sleep(3000);


            /*Högsta talet - se 'MyCLass**/
            MyClass high1 = new MyClass();
           Console.WriteLine(high1.Numbers(new int[] { 1, 2, 3 }));

            MyClass high2 = new MyClass();
            Console.WriteLine(high2.Numbers(new int[] { 4, 5, 6 }));

            /*Minsta talet*/
            MyClass lowest = new MyClass();
            Console.WriteLine(lowest.GetMinFromArray(new int[] { 15, 5, 37 }));

            System.Threading.Thread.Sleep(3000);

            /*Mathclass*/
            Mathclass mathClass = new Mathclass();
            mathClass.PrintValues(new double[] { 5.5, 4, 6.7, 8, 9.1, 3.2 });
            System.Threading.Thread.Sleep(6000);
        }
    }
}
