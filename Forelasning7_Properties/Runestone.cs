using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Runestone
    {
        string name;
        int weight;
        int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                var validWeight = value >= 100 && value <= 7000;
                if (validWeight)
                    weight = value;
                else
                    throw new Exception("Rymdskepp!");
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                var validNumber = value >= 400 && value <= 1200;
                if (validNumber)
                    age = value;
                else
                    throw new Exception("Fel för runsten!");
            }
        }

        public Runestone()
        {
            Weight = 400;
            Name = "Rune Stenhård!";
            Age = 7500;
        }
        public Runestone(int weight, int age = 400, string name = "Rune Runsten") //Default parameters - skrivs om anv. inte vill ange ngt.
        {
            Weight = weight;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Weight: {Weight}, Name: {Name}, Age: {Age}";
        }
    }
}
