using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8_Arv_Atkomstdirektiv
{
   /*public sealed class MyClass*/  //'sealed' innebär att man försluter klassen. Andra klasser får inte ärva från 'MyClass'.

        public class MyClass
    {
        //Åtkomstdirektiven!!
        private string private_string = "private";
        internal string internal_string = "internal";
        internal protected string internalProtected_string = "internal-protected";
        public string public_string = "public";
        protected string protected_string = "protected";

    }
}
