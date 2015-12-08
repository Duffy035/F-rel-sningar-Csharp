using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Hat
    {
        private int size;
        private string name;
        private string color;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Hat()
        {
            Size = 9;
            Name = "indiana Jones";
            Color = "brown";
        }
        public Hat(int size = 50)
        {
            Size = size;
            Name = "Crocodile Dundee";
            Color = "Black";
        }
        public Hat(int size, string name, string color)
        {
            Size = size;
            Name = name;
            Color = color;
        }
        public override string ToString() => $"Size: {Size}, Name: {Name}, Color: {Color}";
    }
}
