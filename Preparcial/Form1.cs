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
        {if (Encriptador.CompararMD5(textBoxContra.Text,comboBox1.SelectedValue.ToString()))
            {

            Usuario us = (Usuario) comboBox1.SelectedItem;
                
                string Contra = Encriptador.CrearMD5(textBoxContra.Text);
                bool admi;
                if (Admi.Checked) admi = true;
                else admi = false;
                if (ConsultasUsuario.ExisteUsuario(us, Contra, admi))
                {//Si existe obtener el dato booleano de Admi
                    //ocultar ventana form
                    if (us.Admi)
                    {
                        
                        UserAdmi form = new UserAdmi(us);
                        form.Show(this);
                        this.Hide();
                        
                    }
                    else
                    {
                       
                        UserCliente form = new UserCliente(us);
                        form.Show(this);
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("no existe el Usuario o algun dato esta malo");
                }
               
          }
            else
            {
                MessageBox.Show("¡Contraseña incorrecta!", "Preparcial",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
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

    private void Form1_Load(object sender, EventArgs e)
    {
        comboBox1.DataSource = null;
        comboBox1.ValueMember = "IdUsuario";
        comboBox1.DisplayMember = "Nombre";
        comboBox1.DataSource = ConsultasUsuario.GetListaUsuarios();
    }
  }
}