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
        int i = 0;
        Color[] colors = new Color[] { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.Pink, Color.Purple };
        int c = 0;
        Button[] bttns = new Button[20];
        public Form1()
        {
            InitializeComponent();
            
        }
        void Changecolor(Button x)
        {
            i++;
            x.BackColor = colors[i];
            if(i==6)i = 0;
        }

        private void GO_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 6);
            cool1.Visible = true;
            cool2.Visible = true;
            cool3.Visible = true;
            cool4.Visible = true;
            cool1.BackColor = colors[a];
            a = rnd.Next(1, 6);
            cool2.BackColor = colors[a];
            a = rnd.Next(1, 6);
            cool3.BackColor = colors[a];
            a = rnd.Next(1, 6);
            cool4.BackColor = colors[a];
            ch1.Visible = true;
            foreach(Button btn in panel1.Controls.OfType<Button>())
            {
                bttns[c] = btn;
                c++;
            }
            c = 0;
        }
        private void buttonClicked(object sender, EventArgs e)
        {
            Color a = ((Button)sender).BackColor;
            if(bttns[c]!=null)bttns[c].BackColor = a;
            c++;
            
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
    }
}
