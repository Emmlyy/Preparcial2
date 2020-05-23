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
      private UserControl current = null;
    public Form1()
        {
            InitializeComponent();
        }

    private void ButtonIngresar_Click(object sender, EventArgs e)
    {
        //Revisar en la Base de datos
        //Si existe obtener el dato booleano de Admi
        /*if(Admi==true){
            tableLayoutPanel1.Controls.Remove(LoginUser);
            current = new Admin();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
         }else{
            tableLayoutPanel1.Controls.Remove(LoginUser);
            current = new UserCliente();
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,2);
         }
         */
    }
  }
}