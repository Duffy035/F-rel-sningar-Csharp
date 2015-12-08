using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //användaren skriver in ett tal
            string text = "4 eller något där omkring";
            int nummer; //ni vill översätta användarens tal till ett heltalssvar
            bool validNumber = int.TryParse(text, out nummer);  //'int.TryParse' - försöker att översätta strängen som skickas in till ett heltal. Hade vi bara kört                                                          'int.Parse' hade vi fått prog.crash eftersom vi kanske matar in ett nummer.
            if (validNumber == false)
            {
                Console.WriteLine("Inget giltigt nummer!!!");
            }
            else
            {
                Console.WriteLine(3 * nummer);
            }
            Console.ReadLine();


            /*-------FÖRENKLAD VARIANT--------*/

            string texten = "100j";
            int tal;
            if (int.TryParse(texten, out tal))
            {
                //Scoopet körs bara om giltigt värde gär att översätta till 'int'
                Console.WriteLine($"Talet är:{tal}");
            }
            System.Threading.Thread.Sleep(3000);
        }
    }
}
