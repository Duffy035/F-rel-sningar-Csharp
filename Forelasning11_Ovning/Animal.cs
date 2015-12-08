using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11_Ovning
{
    abstract class Animal
    {

        public string Name {  get; set;  }
        public int Age { get; set; }
        public abstract void PrintInfo();  //Vi MÅSTE implementera en metod för vårt abstract i klassen 'Cat', just för den är abstract!

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }
}