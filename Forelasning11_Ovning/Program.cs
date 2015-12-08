using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11_Ovning
{
    public class Program
    {
        public void Main(string[] args)
        {
            Cat cat = new Cat() { Name = "Morris", Age = 3};
            //cat.PrintInfo();
            Console.WriteLine(cat);

            Dog dog = new Dog() { Name = "Pluto", Age = 10 };
            //dog.PrintInfo();
            Console.WriteLine(dog);
            Console.ReadLine();
        }
    }
}

//Abstract klass: abstract klass, kan inte instansieras. Underliggande subklasser måste också göra samma sak som klassen med abstraktet i sin egen klass. Abstrakt = tvingande.

//Virtual: Deklarerar att en metod kan överskridas vid behov. Virtual = valfri. 

//Override: Skriver över föregående klassled.