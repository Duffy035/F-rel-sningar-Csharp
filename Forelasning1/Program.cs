using System;  //Gör att vi kan använda namespacet 'system' med t.ex. klassen 'Console' i
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Är en inkapsling för projektet. Det kallas antingen för assemblyt, projektet eller namespacet
namespace Forelasning1  //PascalCase - undvik åäö! Använd redan nu engelska namn!
{
    class Program  //inkapsling av en klass
    {
        static void Main(string[] args)   //Metoden som startar hela programmet
        {
            //Console klassen tillhör tangentbord, skärm input - output
            Console.Write(args[3]);
            Console.ReadLine();

            //---------------Pers. note: Kommentera ut allt du inte vill testa. Vi körde massa ex i samma solution---------------------

            Console.WriteLine("Hej mitt namn\r\n är Calle"); //r\n\ se det som en skrivmaskin, man går ned en rad och ställer markören. Det kallas 'escape sekvens'
            Console.Write("hej"); //Allt skrivs ut på en och samma rad.

            ///
            /// 'Ghost script' kommentar - det som finns skrivet i detta hamnar i intellisensen. 
            /// 

            //-------------------Ex.1---------------------------

            //int tal = 4,            //Deklarerar en 'int' 
            //    tal2 = 5, 
            //    summa = tal + tal2;   //Slår ihop till ett uttryck med hjälp av operatorn +

            // alt 2 av detta uttryck:

            int tal = 4;
            int tal2 = 5;
            int summa = tal + tal2;

            Console.WriteLine("Summan av " + tal + " + " + tal2 + " är " + summa + ".");  //Lite luddigt? Se rad nedan
            Console.WriteLine("Summan av {0} + {1} är {2}", tal, tal2, summa);            //använder format sträng. Blir samma sak. GÖR ALLTID DENNA!

            //---------------------Ex.2--------------------------

            for (int i = 0; i < 15; i++)
            {
                Console.Beep();
            }
            Console.Clear();
            Console.WriteLine("Summan av {0} + {1} är {2}", tal, tal2, summa);

            //--------------------Ex.3---------------------------

            Console.WriteLine("Hur varmt är det idag?");
            Console.ReadLine();   //OBS - detta sparas ingenstans. För det måste det läggas någonstans

            int temperature = int.Parse(Console.ReadLine());  //Int.Parse: Converts the string representation of a number to its 32-bit signed integer equivalent

            if (temperature > 100)
            {
                Console.WriteLine("Ånga");
            }
            else if (temperature <= 0)
            {
                Console.WriteLine("is");
            }
            else
            {
                Console.WriteLine("H2O");
            }
        }
    }
}

//----------------------Viktigt nedan-------------------------------


/*
Identifierare: Allt vi döper själva
Döp till vettiga namn, använd INTE förkortningar.
    - klasser, metoder, variabler osv.
    - Undvik nyckelord

PascalCase = Varje nytt ord blir stor bokstav.
    - namespace, class, metoder, enum, struktor, interface och propertys (Sker i en inkapsling! Dvs. det finns måsvingar)

camelCase = Börjar med liten bokstav, varje nytt ord får stor bokstav.
    - främst variabler och fält (finns vissa undantag)
    - ett underscore framför private variabler. Ex: int _mySecret=9; 
        - Betyder att denna variabel enbart existerar för detta scopet

UPPERCASE = Bara stora bokstäver
    - konstanter, t.ex. PI - värden som inte förändras.  

*/

