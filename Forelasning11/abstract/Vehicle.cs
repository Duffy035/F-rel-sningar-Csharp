using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11
{
    abstract class Vehicle
    {
    //abstract innebär att vi lämnar över allt ansvar till alla underliggande subklasser
    public abstract void Print();
    }
    class Car : Vehicle
    {
        public override void Print()
        {
            Console.WriteLine("Tjihooo abstract-override");
        }
    }
    
}
