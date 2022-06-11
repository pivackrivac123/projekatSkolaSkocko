using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skockoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        void Changecolor(Button x)
        {
            i++;
            if (i == 1)
                x.BackColor = Color.Blue;
            if (i == 2)
                x.BackColor = Color.Red;
            if (i == 3)
                x.BackColor = Color.Green;
            if (i == 4)
                x.BackColor = Color.Yellow;
            if (i == 5)
                x.BackColor = Color.Pink;
            if (i == 6)
                x.BackColor = Color.Purple;
            if (i == 7)
                i = 0;
        }
        private void Col1_Click(object sender, EventArgs e)
        {
            Changecolor(Col1);
        }

        private void Col2_Click(object sender, EventArgs e)
        {
            Changecolor(Col2);
        }

        private void Col3_Click(object sender, EventArgs e)
        {
            Changecolor(Col3);
        }

        private void Col4_Click(object sender, EventArgs e)
        {
            Changecolor(Col4);
        }

        private void Col5_Click(object sender, EventArgs e)
        {
            Changecolor(Col5);
        }

        private void Col6_Click(object sender, EventArgs e)
        {
            Changecolor(Col6);
        }

        private void Col7_Click(object sender, EventArgs e)
        {
            Changecolor(Col7);
        }

        private void Col8_Click(object sender, EventArgs e)
        {
            Changecolor(Col8);
        }

        private void Col9_Click(object sender, EventArgs e)
        {
            Changecolor(Col9);
        }

        private void Col10_Click(object sender, EventArgs e)
        {
            Changecolor(Col10);
        }

        private void Col11_Click(object sender, EventArgs e)
        {
            Changecolor(Col11);
        }

        private void Col12_Click(object sender, EventArgs e)
        {
            Changecolor(Col12);
        }

        private void Col13_Click(object sender, EventArgs e)
        {
            Changecolor(Col13);
        }

        private void Col14_Click(object sender, EventArgs e)
        {
            Changecolor(Col14);
        }

        private void Col15_Click(object sender, EventArgs e)
        {
            Changecolor(Col15);
        }

        private void Col16_Click(object sender, EventArgs e)
        {
            Changecolor(Col16);
        }

        private void Col17_Click(object sender, EventArgs e)
        {
            Changecolor(Col17);
        }

        private void Col18_Click(object sender, EventArgs e)
        {
            Changecolor(Col18);
        }

        private void Col19_Click(object sender, EventArgs e)
        {
            Changecolor(Col19);
        }

        private void Col20_Click(object sender, EventArgs e)
        {
            Changecolor(Col20);
        }

        private void GO_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 7);
            int b = rnd.Next(1, 7);
            int c = rnd.Next(1, 7);
            int d = rnd.Next(1, 7);
            int blue = 1, red = 2, green = 3, yellow = 4, pink = 5, purple = 6;
            cool1.Visible = true;
            cool2.Visible = true;
            cool3.Visible = true;
            cool4.Visible = true;
            if (a == blue)
                cool1.BackColor = Color.Blue;
            if (a == red)
                cool1.BackColor = Color.Red;
            if (a == green)
                cool1.BackColor = Color.Green;
            if (a == yellow)
                cool1.BackColor = Color.Yellow;
            if (a == pink)
                cool1.BackColor = Color.Pink;
            if (a == purple)
                cool1.BackColor = Color.Purple;

            if (b == blue)
                cool2.BackColor = Color.Blue;
            if (b == red)
                cool2.BackColor = Color.Red;
            if (b == green)
                cool2.BackColor = Color.Green;
            if (b == yellow)
                cool2.BackColor = Color.Yellow;
            if (b == pink)
                cool2.BackColor = Color.Pink;
            if (b == purple)
                cool2.BackColor = Color.Purple;

            if (c == blue)
                cool3.BackColor = Color.Blue;
            if (c == red)
                cool3.BackColor = Color.Red;
            if (c == green)
                cool3.BackColor = Color.Green;
            if (c == yellow)
                cool3.BackColor = Color.Yellow;
            if (c == pink)
                cool3.BackColor = Color.Pink;
            if (c == purple)
                cool3.BackColor = Color.Purple;

            if (d == blue)
                cool4.BackColor = Color.Blue;
            if (d == red)
                cool4.BackColor = Color.Red;
            if (d == green)
                cool4.BackColor = Color.Green;
            if (d == yellow)
                cool4.BackColor = Color.Yellow;
            if (d == pink)
                cool4.BackColor = Color.Pink;
            if (d == purple)
                cool4.BackColor = Color.Purple;
            ch1.Visible = true;
        }
        void Check_button(Button Col1, Button Col2, Button Col3, Button Col4,
                   Button cool1, Button cool2, Button cool3, Button cool4,
                   Button Show1, Button Show2, Button Show3, Button Show4)
        {
            int q = 0;
            int w = 0;

            if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                q++;
            if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                q++;
            if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                q++;
            if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                q++;


            if (q == 1)
                Show1.BackColor = Color.Yellow;
           else if (q == 2)
            {
                Show1.BackColor = Color.Yellow;
                Show2.BackColor = Color.Yellow;
            }
            else if (q == 3)
            {
                Show1.BackColor = Color.Yellow;
                Show2.BackColor = Color.Yellow;
                Show3.BackColor = Color.Yellow;
            }

            else if (q == 4)
            {
                Show1.BackColor = Color.Yellow;
                Show2.BackColor = Color.Yellow;
                Show3.BackColor = Color.Yellow;
                Show4.BackColor = Color.Yellow;
            }
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor != cool4.BackColor)
            {
                w = 3;
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
            }
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor != cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 3;
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
            }
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor != cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 3;
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
            }
            if (Col1.BackColor != cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 3;
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 3;
                //    q = 0;
                //}
            }
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor != cool3.BackColor && Col4.BackColor != cool4.BackColor)
            {
                w = 2;
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
            }
            if (Col1.BackColor != cool1.BackColor && Col2.BackColor != cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 2;
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
            }
            if (Col1.BackColor != cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor != cool4.BackColor)
            {
                w = 2;
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
            }
                
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor != cool2.BackColor && Col3.BackColor != cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 2;
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
            }
                
            if (Col1.BackColor != cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor != cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 2;
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
            }
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor != cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor != cool4.BackColor)
            {
                w = 2;
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 2;
                //    q = 0;
                //}
            }
            
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor != cool2.BackColor && Col3.BackColor != cool3.BackColor && Col4.BackColor != cool4.BackColor)
            {
                w = 1;
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 1;
                //    q = 0;
                //}
            }
            if (Col1.BackColor != cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor != cool3.BackColor && Col4.BackColor != cool4.BackColor)
            {
                w = 1;
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 1;
                //    q = 0;
                //}
            }
            if (Col1.BackColor != cool1.BackColor && Col2.BackColor != cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor != cool4.BackColor)
            {
                w = 1;
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 1;
                //    q = 0;
                //}
            }
            if (Col1.BackColor != cool1.BackColor && Col2.BackColor != cool2.BackColor && Col3.BackColor != cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 1;
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 1;
                //    q = 0;
                //}
            }
            if (Col1.BackColor == cool1.BackColor && Col2.BackColor == cool2.BackColor && Col3.BackColor == cool3.BackColor && Col4.BackColor == cool4.BackColor)
            {
                w = 4;
                //if (Col1.BackColor == cool1.BackColor || Col1.BackColor == cool2.BackColor || Col1.BackColor == cool3.BackColor || Col1.BackColor == cool4.BackColor)
                //{
                //    w = 4;
                //    q = 0;
                //}
                //if (Col2.BackColor == cool1.BackColor || Col2.BackColor == cool2.BackColor || Col2.BackColor == cool3.BackColor || Col2.BackColor == cool4.BackColor)
                //{
                //    w = 4;
                //    q = 0;
                //}
                //if (Col3.BackColor == cool1.BackColor || Col3.BackColor == cool2.BackColor || Col3.BackColor == cool3.BackColor || Col3.BackColor == cool4.BackColor)
                //{
                //    w = 4;
                //    q = 0;
                //}
                //if (Col4.BackColor == cool1.BackColor || Col4.BackColor == cool2.BackColor || Col4.BackColor == cool3.BackColor || Col4.BackColor == cool4.BackColor)
                //{
                //    w = 4;
                //    q = 0;
                //}
            }

            if (w == 1)
                Show1.BackColor = Color.Red;
            else if (w == 1 && q == 0)
            {
                Show1.BackColor = Color.Red;
               
            }
            else if (w == 1 && q == 1)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Yellow;
            }
            else if (w == 1 && q == 3)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Yellow;
                Show3.BackColor = Color.Yellow;
                Show4.BackColor = Color.Yellow;
            }
            else if (w == 1 && q == 4)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Yellow;
                Show3.BackColor = Color.Yellow;
                Show4.BackColor = Color.Yellow;
            }
            else if (w == 2 && q == 4)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Yellow;
                Show4.BackColor = Color.Yellow;
            }
            else if (w == 2 && q == 3)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Yellow;
                Show4.BackColor = Color.Yellow;
            }
            else if (w == 2 && q == 2)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Yellow;
                Show4.BackColor = Color.Yellow;
            }
            else if (w == 2 && q == 1)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Yellow;
                
            }
            else if (w == 2 && q == 0)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
              
            }
            else if (w == 3 && q == 4)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Red;
                Show4.BackColor = Color.Yellow;
            }
            else if (w == 3 && q == 3)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Red;
               
            }
            else if (w == 3 && q == 0)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Red;

            }
            else if (w == 3 && q == 1)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Red;
                Show4.BackColor = Color.Yellow;
            }
            else if (w == 3 && q == 2)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Red;
                Show4.BackColor = Color.Yellow;
            }
            
            else if (w == 4)
            {
                Show1.BackColor = Color.Red;
                Show2.BackColor = Color.Red;
                Show3.BackColor = Color.Red;
                Show4.BackColor = Color.Red;
                VIC.Text = "pobeda";
                cool1.Visible = true;
                cool2.Visible = true;
                cool3.Visible = true;
                cool4.Visible = true;
            }
        }

        private void ch1_Click(object sender, EventArgs e)
        {
            Check_button(Col1, Col2, Col3, Col4, cool1, cool2, cool3, cool4, Show1, Show2, Show3, Show4);
            GO.Visible = false;
        }

        private void ch2_Click(object sender, EventArgs e)
        {
            Check_button(Col5, Col6, Col7, Col8, cool1, cool2, cool3, cool4, Show5, Show6, Show7, Show8);
            ch3.Visible = true;
        }

        private void ch3_Click(object sender, EventArgs e)
        {
            Check_button(Col9, Col10, Col11, Col12, cool1, cool2, cool3, cool4, Show9, Show10, Show11, Show12);
            ch4.Visible = true;
        }

        private void ch4_Click(object sender, EventArgs e)
        {
            Check_button(Col3, Col14, Col15, Col16, cool1, cool2, cool3, cool4, Show13, Show14, Show15, Show16);
            ch5.Visible = true;
        }

        private void ch5_Click(object sender, EventArgs e)
        {
            Check_button(Col17, Col18, Col19, Col20, cool1, cool2, cool3, cool4, Show17, Show18, Show19, Show20);
            if (VIC.Text != "pobeda")
                VIC.Text = "gubitnice";
            ch1.Visible = false;
            ch2.Visible = false;
            ch3.Visible = false;
            ch4.Visible = false;
            ch5.Visible = false;
           

            cool1.Visible = true;
            cool2.Visible = true;
            cool3.Visible = true;
            cool4.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
