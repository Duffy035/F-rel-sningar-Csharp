using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11_Ovning
{
    class Dog : Animal
    {
        private string djur = "hund";
        //public override void PrintInfo()
        public override void PrintInfo()
        {
            Console.WriteLine($"djur:{djur}, Name: {Name}");
        }
        public override string ToString() => $"Djur: {djur} {base.ToString()}";
    }
}
