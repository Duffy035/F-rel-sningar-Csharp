using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning8_Arv_Atkomstdirektiv
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass.internalProtected_string = "Nytt värde";
            myclass.internal_string = "nytt värde";
            myclass.public_string = "nytt värde";
        }
    }
}
