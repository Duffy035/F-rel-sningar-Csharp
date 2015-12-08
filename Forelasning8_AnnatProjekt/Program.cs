using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning8_Arv_Atkomstdirektiv; //lagt till mha referenser!

namespace Forelasning8_AnnatProjekt
{
    class Program
    {
        //Vi är nu i ett annat projekt där vi ska se villka åtkomster vi har från 'Forelasning8_Arv_Atkomstdirektiv' projektet.
        static void Main(string[] args)
        {
            MyClass myClassFromAnotherProject = new MyClass();
            myClassFromAnotherProject.public_string = "";
        }
    }
}
