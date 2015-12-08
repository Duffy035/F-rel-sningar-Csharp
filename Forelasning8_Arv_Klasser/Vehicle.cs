using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8_Arv_Klasser
{
    class Vehicle
    {
        public int Wheels { get; set; }
        public int Passengers { get; set; }

        public void PrintVehicle() //mindre bra sätt att skriva ut en instans på...
        {
            //...för här kräver vi ett Console-projekt
            Console.WriteLine($"Metoden i basklassen 'Vehicle' säger:\r\n Wheels: {Wheels}\r\n Passengers: {Passengers}");

            //Object titt; - Använder vi för att F12 oss till Object och se att ToString var virtual
        }
        //ToString() fungerar i alla projekttyper och är därmed att föredra
        public override string ToString() => $"Metoden i basklassen 'Vehicle' säger:\r\n Wheels: {Wheels}\r\n Passengers: {Passengers}";  // '=>' - Lambadauttryck (C# 6.0)...

        
        //...samma som nedan:

        //public override string ToString()
        //{
        //    //public virtual string ToString();
        //    return $"Metoden i basklassen 'Vehicle' säger:\r\n Wheels: {Wheels}\r\n Passengers: {Passengers}";
        //}


    }
    /*Finns det 2 klasser med samma attribut: skapa då en basklass och lägg dem i den. Det som skiljer dem åt läggs i separata underklassser/subklasser. LÄGG ALLTID NYA KLASSER I EN EGEN FIL*/

    class Bicycle : Vehicle  //Arv skrivs såhär - här ärver subklassen 'Bicycle' från basklassen 'Vehicle'.
    {
        public int Spokes { get; set; }
        public override string ToString()
        {
            return string.Format("Spokes: {0}, Resten: {1}", Spokes, base.ToString());  //string.Format gör om ngt till en sträng. 'base.ToString()' innebär att vi går till BASKLASSEN och skriver ut. Vi gör det en enda gång.
        }
    }
    class Car : Vehicle
    {
        public int HorsePowers { get; set; }
    }
}
