using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forelasning9_LektionsOvning;
using Forelasning9_miniraknare2;

namespace Forelasning9_calculatorLogik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string s = "5";
            if (s[0] >= '0' || s[0] <= 9)
            {
                return s;
                tal1 = s;
            }
            char operand = '+';
        }
    }
}
