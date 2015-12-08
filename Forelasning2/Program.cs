using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning2
{
    class Program
    {
        static int[] numbers = new int[20];   //Dataarayen är en typ av int. Vi skapar ett nytt objekt på heapen (minnet) som innehåller 20 positioner
        static void Main(string[] args)
        {
            ReadUserInputToNumbersArray();          //Refaktoriserat! Med högerklick och 'quickactions' sen retur. Metoden har vi sedan döpt till 'ReadUserDataToArray'
            PrintArray();                           //Samma som ovan
        }
        private static void ReadUserInputToNumbersArray()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Skriv in ett tal:");     //Läser in 20 tal
                numbers[i] = int.Parse(Console.ReadLine());       //Lägger talen i vektorn
            }
        }
        private static void PrintArray()
        {
            for (int i = 0; i < numbers.Length; i++)        //Anv. arrayens längd
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}



