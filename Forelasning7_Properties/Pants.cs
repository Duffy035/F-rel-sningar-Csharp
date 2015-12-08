using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{
    class Pants
    {
        private int size;
        private string color;
        private string brand;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Pants()
        {
            size = 31;
            color = "black";
            brand = "Lewis";
        }
        public Pants(int size)
        {
            Size = size;
            color = "Blue";
            brand = "Lee";
        }
        public Pants(int size, string color, string brand)
        {
            Size = size;
            Color = color;
            Brand = brand;
        }
    }
}
