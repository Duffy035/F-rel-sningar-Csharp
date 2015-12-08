using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning9_Indexer
{
    class Indexer_with_access_methods
    {
        int counter = 0;  //Får inte bli störrre än stringens längd (10).
        //string motsvarar böcker i ett bibliotek
        string[] values = new string[10];  //backing store (field). Vi har 10 att göra back-up på. 
        private string this[int index]  //Exakt samma syntax som för en property, men har 'this' istället för ett namn + []. Denna är nu private! Får jobba mot metoder
        {
            get
            {

                if (index >= 0 && index < values.Length) //Kontroll på att man hämtar värden inom arrayens range 
                    return values[index];
                else
                    throw new Exception("Out of boundary"); //Se till att dessa finns med
            }
            set
            {
                //kontrollerar att vi är inom range innan vi sätter ett värde
                if (index >= 0 && index < values.Length)
                    values[index] = value;
                else
                    throw new Exception("Out of boundary");
            }
        }

        public void AddString(string text)  //Vi jobbar här mot vår indexer, tillsammans med vår counter. 
        {
            if (counter < values.Length)
                values[counter] = text;
            counter++;
        } 
    }
}
