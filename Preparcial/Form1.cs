using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial
{
  public partial class Form1 : Form
  {
      private UserControl current ;
    public Form1()
        {
            InitializeComponent();
            
        }

    private void button1_Click(object sender, EventArgs e)
    {
       this.Hide();
       loginaAdmin ventana = new loginaAdmin();
       
       ventana.Show();

    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Hide();
        Cliente ventana2 = new Cliente();
        ventana2.Show();
    }
  }
}