using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8_Arv_Atkomstdirektiv
{
    class SubClass : MyClass
    {
        //har tillgång till allt utom private
        public void PrintAll()
        {
            base.public_string = "värde";
            base.internal_string = "";
            base.protected_string = "";
            base.internalProtected_string = "";
        }
    }
}
