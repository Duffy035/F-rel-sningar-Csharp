using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zelda();
            //BiCycle();
            //GettersAndSetters();
            //PropertiesAndObjInitializer();
            //InstansieringAndConstructor();
            //Tractor();
            //Va();
            //Runestone();
            //Bulbs();
            //Hats();
            ConstructorAnrop();
        }

        private static void ConstructorAnrop()
        {
            Burk sevenUp = new Burk(33, 11.9, "Zingo");

            Burk objectInitializerStyle = new Burk() { Name = "Heinieken", Height = 4.2, Centiliter = 50 };
        }
        private static void Hats()
        {
            Hat indiana_jones = new Hat(10, "Indiana Jones", "Brown");
            Hat dundee = new Hat(8, "Crociodile Dundee", "Black");

            Console.WriteLine(indiana_jones);
            Console.WriteLine(dundee);
            Console.ReadLine();
        }
        private static void Zelda()
        {
            Game zelda = new Game();    //skapat spelet
            zelda.Lives = 4;  //Tilldelat ett värde. Agerar som en variabel
            Console.WriteLine(zelda.Lives); //Hämtar värdet
        }
        private static void BiCycle()
        {
            Bicycle crescent = new Bicycle();
            crescent.Brand = "Crescent";
            crescent.Gears = 12;

            Bicycle rex = new Bicycle() { Brand = "rex", Gears = 7 };//<--Detta kallas object initializer. Anger vad de olika propertysen är i constructoranropet.
        }
        private static void InstansieringAndConstructor()
        {
            //Utan named parameters:
            Table1 sovrummet = new Table1(2, "Vit");
            Table1 vardagsrum = new Table1(6, "Brun");
            Table1 köket = new Table1(8, "Beige");
            //Console.WriteLine($"Sovrummet: {sovrummet}, vardagsrummet: {vardagsrum}, köket: {köket}"); //Hur skriver jag ut?

            //Med named parameters:
            Table1 altan = new Table1(colors: "svart", chairs: 4);
            Table1 vedbod = new Table1(chairs: 1, colors: "naturell");
        }
        private static void PropertiesAndObjInitializer()
        {
            Table2 vardagsrum = new Table2() { Chairs = 8, Color = "Black" };
        }
        private static void GettersAndSetters()
        {
            Table3 ekholms = new Table3();
            Console.WriteLine("Hur många stolar har ditt bord?");
            int chairAmount = int.Parse(Console.ReadLine());
            ekholms.SetChairs(chairAmount);
            Console.WriteLine("Vilken färg har ditt bord?");
            string chairColor = Console.ReadLine();
            ekholms.SetColor(chairColor);

            Console.WriteLine($"Ditt bord har {ekholms.GetChairs()} stolar, och {ekholms.GetColor()} färg.");
            Console.ReadLine();
        }
        private static void Tractor()
        {
            var tractor = new Tractor();
            var tractor2 = new Tractor(6);
            var tractor3 = new Tractor(17, 1234567);  //Det vi skriver in här är vårt 'value' i klassen 'Tractor'
            Console.WriteLine(tractor);
            Console.WriteLine(tractor2);
            Console.WriteLine(tractor3);
            Console.ReadLine();
        }
        private static void Va()
        {
            Va va = new Va();
            Va va2 = new Va("Hej?");  //True vid stor bokstav och ?
            Va va3 = new Va("Hej?", 9.5); //True vid stor bokstav och '?' och värden mellan 3-17!

            Console.WriteLine(va);
            Console.WriteLine(va2);
            Console.WriteLine(va3);
            Console.ReadLine();
        }
        private static void Runestone()
        {
            Runestone runestone = new Runestone(age: 420, weight: 500, name: "hihi");  //Named parameters
            Console.WriteLine(runestone);
            Console.ReadLine();
        }
        private static void Bulbs()
        {
            Bulb philips = new Bulb(0, 50, 60);
            Console.WriteLine(philips);
        }

    }
}


//Gör detta:
//Ett bord (se klassen 'Table'):
//Egenskaper: stolar och färg

//Gör med vanliga getters och setters
//ersätt med properties
//använd object initializer
//använd instansiering med konstruktoranrop