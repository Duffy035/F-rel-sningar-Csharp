using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning9_Indexer
{
    class Indexer2  //Varit biblioteket
    {
        //string motsvarar böcker i ett biliotek
        string[] values = new string[10];  //backing store (field). Vi har många (10) att göra back-up på. 
        public string this[int index]  //Exakt samma syntax som för en property, men har 'this' ist för ett namn + []
        {
            get {

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
    }
}
