﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning9_Indexer
{
    class MyClass
    {
        int[] ints;
        public int this[int index]  //skriv index + tab tab
        {
            get { return ints[index]; }
            set { ints[index] = value; }
        }
        public MyClass()
        {
            ints = new int[10];
        }
        public int[] GetInts()
        {
            return ints;
        }
    }
}
