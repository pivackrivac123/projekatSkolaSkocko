using System;
using System.Windows.Forms;

namespace projekat
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Col1_Click(object sender, EventArgs e)
        {
            Col1.BackColor = Color;
        }
    }
}
