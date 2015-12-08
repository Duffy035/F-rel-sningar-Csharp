using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning11_Ovning
{
    class Cat : Animal
    {
        private string djur = "katt";
        public override void PrintInfo()  //sometimes pronounced as productInfo... hihihi
        {
            Console.WriteLine($"djur:{djur}, Name: {Name}");
        }
        public override string ToString() => $"Djur: {djur}" + base.ToString();

    }
}
