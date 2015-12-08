using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8_Arv_Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Wheels = 4, HorsePowers = 55, Passengers = 4 };

            Bicycle bicycle = new Bicycle() { Wheels = 2, Spokes = 20, Passengers = 1 };
            Console.WriteLine(bicycle);
            Console.ReadLine();

            Vehicle vehicle = new Vehicle() { Passengers = 9, Wheels = 8 };
            vehicle.PrintVehicle();
            Console.ReadLine();
        }
    }
}
