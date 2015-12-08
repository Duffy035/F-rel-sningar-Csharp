using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forelasning12_Konverteringar
{
    public class Program
    {
        public void Main(string[] args)
        {
            Konverteringar();

            Cyckel c1 = new Cyckel();  //OK!
            MC mc = new Cyckel();  //Inte OK! 
            MC mc2 = (MC)c1; //Explicit typkonvertering
            //Kompilatorn upptäcker inte felet förens under programkörning.

            //TEST med as:
            Cyckel cyckel = (Cyckel) new MC();
            MC mcTest = c1 as MC;  //Försöker göra om c1 till en MC. Om den lyckas blir den en MC, om den misslyckas blir den en null.
            if (mcTest != null) //Kontrollerar att mc är giltig
            {
                //Konverterad
            }
            //TEST med is:
            Object obj = new Cyckel();
            bool b = obj is Cyckel;  //Allways true
            Cyckel cyckel2 = new Cyckel();
            Boolean f = cyckel2 is object;

            //BOXING:
            int tal = 5;
            object paket = tal;  //Boxing - konverterar värdetyp till referenstyp


            //UNBOXING:
            int tal23 = (int)paket;  //Unboxing - konverterar referenstyp till värdetyp
        }

        private static void Konverteringar()
        {
            long tal = 200;  //implicit typkonvertering sker här. long är int 64, 200 är int 32. Den gör konverteringen för att 32 får plats i 64.
            int tal2 = 200L; //Går inte ( vi har gjort tvärtom här). Stor risk för "förlust" dvs. Vi tappar bitar.
            int tal2 = (int)200L;  //Vi typkonverterar EXPLICIT - (int). Vi gör ngt extra. Då funkar det.   

            System.Int64 longTal = 200L;
            System.Int32 intTal = 200;
            var doubleTal = 4.4;
            float flyttal = (float)4.4; //typkonvertering
            float flyttal2 = 4.4F; //ingen typkonvertering
            int number = (int)doubleTal;  //Typkonverterar vårt dubbeltal. Decimalen kommer försvinna - vi förlorar ett värde. Alltid när vi gör explicit typkonvertering kan vi FÖRLORA NÅGOT! Viktigt att tänka på!

            //Om vi gör en implicit typkonvertering är den nya behållaren "större" så vi får plats med allt.
        }
    }
}
