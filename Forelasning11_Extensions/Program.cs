using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11_Extensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = MyStringExtension.Dotify("hej");
            Console.WriteLine(name);
            Console.WriteLine("Kalle".Dotify());
            Console.WriteLine("Freddie".PlussPussa());
            Console.ReadLine();
        }
    }
}
