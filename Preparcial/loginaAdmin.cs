using System;
using System.Windows.Forms;

namespace Preparcial
{
    public partial class loginaAdmin : Form
    {
        public loginaAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin vent = new Admin();
            vent.Show();
        }
    }
}