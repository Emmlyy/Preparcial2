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
        
        Usuario us=new Usuario();
        us.Nombre = textBoxName.Text;
        us.Contra = textBoxContra.Text;
        if (Admi.Checked) us.Admi = true;
        else us.Admi = false;

        if (ConsultasUsuario.ExisteUsuario(us))
        {//Si existe obtener el dato booleano de Admi
            //ocultar ventana form
            if (us.Admi)
            {
               // new UserAdmi(us)
            }
            else
            {
                //UserCliente.
            }
        }
        
        
        /*if(Admi==true){
            ocultar ventana form1
            mistrar ventana UserAdmi
         }else{
            ocultar ventana form1
            mostrar ventana userCliente
         }
         */
    }
  }
}