using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//skriv 'propfull' och sen tab+tab så får vi intellisense på properties! lägg sedan alla backing fields överst.

namespace Forelasning7_Properties
{
    class Bulb
    {
        private int h;  //backing-field
        private byte s;
        private byte l;

        public int H
        {
            get
            {
                return h;
            }
            set
            {
                h = value % 360;
            }
        }  
        public byte S   //Property som arbetar mot backing-field
        {
            get { return s; }
            set
            {
                var vaildPercentage = value >= 0 && value <= 100;
                if (vaildPercentage)
                    s = value;
            }
        }
        public byte L
        {
            get { return l; }
            set
            {
                var validPercentage = value >= 0 && value <= 100;
                if (validPercentage)
                    l = value;
            }
        }

        public Bulb(int h, byte s = 50, byte l = 50)
        {
            H = h;
            S = s;
            L = l;
        }
        public override string ToString() => $"H: {H}, S: {S}, L: {L}";  //one line kod (C# 6.0)
    }
}
