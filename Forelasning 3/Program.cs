using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Klasser och instanser
namespace Forelasning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boat maria = new Boat();  //Vi skapar en ny instans av 'Boat'
            ////maria.type = "nisse";  //Vi kommmer inte åt 'type' för den är private
            //maria.SetType("Buster");
            //Console.WriteLine(maria.GetType());

            //Boat lisa = new Boat();
            //maria.SetType("Quicksilver");
            //maria.SetNumberOfPassengers(4);
            //Console.WriteLine(lisa.GetNumberOfPassengers());



            //for (int i = 0; i < 3; i++)
            //{
            //    Motorcycle Ninja = new Motorcycle();
            //    Console.WriteLine("Skriv in hästkrafter:");
            //    int horsepower = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Skriv in maxhastighet:");
            //    int speed = int.Parse(Console.ReadLine());

            //    Ninja.SetHorsePowers(horsepower);
            //    Ninja.SetMaxSpeed(speed);

            //    Console.WriteLine(Ninja.PrintBike());
            //}


            //Plane Jumbojet = new Plane();
            //Console.WriteLine("Hur många hjul har planet?");
            //int wheels = int.Parse(Console.ReadLine());

            //Jumbojet.SetAmountOfWheels(wheels);

            //Console.WriteLine(Jumbojet.PrintWheelsAmount());


            Rektangel New = new Rektangel();
            Console.WriteLine("Write width: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Write height: ");
            int height = int.Parse(Console.ReadLine());

            New.SetWidth(width);
            New.SetHeight(height);

            Console.WriteLine(New.PrintOut());
        }
    }
}
