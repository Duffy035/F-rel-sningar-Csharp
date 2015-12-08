using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forelasning9_LektionsOvning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PinkButton();

            TextBox value1 = new TextBox() { Height = 30, Width = 200, Top = 10, Left = 5, Visible = true, BackColor = Color.LavenderBlush, Multiline = true };
            Controls.Add(value1);

            TextBox value2 = new TextBox() {  Height = 30, Width = 200, Top = 60, Left = 5, Visible = true, BackColor = Color.LavenderBlush, Multiline = true };
            Controls.Add(value2);

            TextBox value3 = new TextBox() { Height = 30, Width = 200, Top = 110, Left = 5, Visible = true, BackColor = Color.LavenderBlush, Multiline = true };
            Controls.Add(value3);


            Label label = new Label() { Text = "=" };
            label.Height = 12;
            Controls.Add(label);


            Button add = new Button() { Text = "+", Top = 175, Width = 40, Height = 25, BackColor = Color.LawnGreen};

            add.Bounds = new Rectangle(10, 150, 40, 25);
            Controls.Add(add);

            Button multiply = new Button() { Text = "*", Top = 175, Width = 40, Height = 25, BackColor = Color.LawnGreen};

            multiply.Bounds = new Rectangle(60, 150, 40, 25);
            Controls.Add(multiply);

            Button subtract = new Button() { Text = "-", Top = 175, Width = 40, Height = 25, BackColor = Color.LawnGreen};

            subtract.Bounds = new Rectangle(110, 150, 40, 25);
            Controls.Add(subtract);

            Button divide = new Button() { Text = "/", Top = 175, Width = 40, Height = 25, BackColor = Color.LawnGreen };

            divide.Bounds = new Rectangle(160, 150, 40, 25);
            Controls.Add(divide);



        }

        private void PinkButton()
        {
            //Button button = new Button() { Height = 100, Width = 100, Top = 100, Left = 100, Visible = true, BackColor = Color.HotPink };

            //Controls.Add(button);
        }
    }
}
