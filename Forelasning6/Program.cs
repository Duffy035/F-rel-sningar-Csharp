using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ref
namespace Forelasning6
{
    class Program
    {
        static void Main(string[] args)
        {
            int ickeMagi = 6;   //Måste skapa värdet innan, annars kommer det inte fungera!
            int Häftigt = 9;
            string hihi = "haha";
            Magiska(ref ickeMagi, ref Häftigt, ref hihi);
            Console.WriteLine(ickeMagi);
            Console.WriteLine(Häftigt);
            Console.WriteLine(hihi);
            System.Threading.Thread.Sleep(5000);
        }
        static void Magiska(ref int ickeMagi, ref int Häftigt, ref string hihi)     //Vi går utanför scopet för vår Main, och den som anropas kommer bli förändrad.
        {
            ickeMagi = 0;
            Häftigt = 0;
           hihi = "hohohohohoho";
        }
    }
}
