using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Properties
{

    /*INSTANTIERING och CONSTRUCTORANROP*/
    class Table1
    {
        int chairs;
        string colors;

        public Table1(int chairs = 0, string colors = "")
        {
            this.chairs = chairs;
            this.colors = colors;
        }
    }
}


