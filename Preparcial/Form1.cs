using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
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
    Usuario AD = new Usuario();
    private void ButtonIngresar_Click(object sender, EventArgs e)
    {
        try
        {if (Encriptador.CompararMD5(textBoxContra.Text, textnombre.ToString()))
            {
            
                Usuario us=new Usuario();
                us.Nombre = textnombre.Text;
                us.Contra = textBoxContra.Text;
                if (Admi.Checked) us.Admi = true;
                else us.Admi = false;
                if (ConsultasUsuario.ExisteUsuario(us))
                {//Si existe obtener el dato booleano de Admi
                    //ocultar ventana form
                    if (us.Admi)
                    {
                        new UserAdmi(us);
                    }
                    else
                    {
                        new UserCliente(us);
                    }
                }
                if(us.Admi)
                {
                    SesionDB.iniciarSesion(us.Nombre);
                    MessageBox.Show("¡Bienvenido!", 
                        "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserAdmi ventanAdmi = new UserAdmi(us);
                    ventanAdmi.Show();
                    this.Hide();
                }
                else{
                    
                    MessageBox.Show("¡Bienvenido!", 
                        "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserCliente ventanCliente = new UserCliente(us);
                    ventanCliente.Show();
                    this.Hide();
                    
                
                }
            }
            else
            {
                MessageBox.Show("¡Contraseña incorrecta!", "Preparcial",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            /*  if(Admi==true){
                  ocultar ventana form1
                  mistrar ventana UserAdmi
               }else{
                  ocultar ventana form1
                  mostrar ventana userCliente
               }*/
            
        }catch(Exception exception){
            MessageBox.Show("ha ocurrido un error");
        }
        
         
    }
    
    private void textBoxContra_TextChanged(object sender, EventArgs e)
    {
        /*throw new System.NotImplementedException();*/
    }
    private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) ButtonIngresar_Click(sender, e);
    }
    
  }
}