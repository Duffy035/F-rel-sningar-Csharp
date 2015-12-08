using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();  //A kan vara A
            A ab = new B();  //A kan vara en B! Polymorphism. Anänds som en härledd klass, kommer därför att använda sin egen A metod.
            B b = new B();   //B kan vara B

            a.Print();
            ab.Print();
            b.Print();

            Console.ReadLine();
        }
    }
    class A
    {
        public void Print()
        {
            Console.WriteLine("Basklassen");
        }
    }
    class B:A
    {
        public new void Print()  //Namnkonflikt har uppstått.. hmm! med 'new' gömmer vi metoden i klass 'A'.
        {
            Console.WriteLine("Gömd metod i subklassen");
        }
    }
}
