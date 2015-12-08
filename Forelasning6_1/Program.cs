using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Out
namespace Forelasning6_1
{
    class Program
    {
        //både ref och out pekar på den variabel som ligger utanför metodanropet
        //det yttre värdet förändras innifrån
        static void Main(string[] args)
        {
            Program program = new Program();
            string text;  //måste inte ha ett värde
            string annanText; //måste inte ha ett värde
            program.MusikSkaByggasUtavGlädje(out text);
            program.MusikSkaByggasUtavGlädje(out annanText);
            program.MusikSkaByggasUtavGlädje(33, out text, out annanText);

            Console.WriteLine(annanText+text);
            Console.ReadLine();
        }
        private void MusikSkaByggasUtavGlädje(out string text) //'text' här kan döpas till vadsomhelst.
        {
            text = "Stilla natt, heliga natt...";  //text får sitt värde här
        }
        private void MusikSkaByggasUtavGlädje(int t, out string text, out string text2)  //t skapar text. Vi måste skapa 'text' och 'text2'!
        {
            text = t.ToString() + "PLUSS";
            text2 = text + "hej";
        }
    }
}
