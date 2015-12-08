using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Burk
    {
        string name;
        int centiliter;
        double height;

        public string Name
        {
            get;
            set;
        }
        public int Centiliter
        {
            get;
            set;
        }

        public double Height
        {
            get;
            set;
        }
        public Burk()
        {
            Name = "Kalle";
            Centiliter = 33;
            Height = 11.2;
        }
        //:this kastar vidare innan denna konstruktorn körs
        public Burk(string name, double height):this()
        {
            //Detta kan vara klurigt
            Name = name;
            Height = height;
        }

        //:this kastar vidare innan denna konstruktorn körs
        public Burk(int centiliter, double height, string name) : this (name, height)  //anropar från en constructor och skickar vidare
        {
            Centiliter = centiliter;
            Height = height;
        }
    }
}
