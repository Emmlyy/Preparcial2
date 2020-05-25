using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Preparcial
{
    public partial class UserAdmi : Form
    {
       private Usuario Usu ;
       private Inventario invent ;

        public UserAdmi(Usuario u)
        {
            InitializeComponent();
        }


        private void btCrear_Click(object sender, EventArgs e)
        {
            if (tbtNombre.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");

            }
            else
            {
                try
                {
                    Usu.Nombre = tbtNombre.Text;
                    Usu.Contra = tbtContra.Text;
                    if (rbAdmi.Checked) Usu.Admi = true;
                    else Usu.Admi = false;
                    ConsultasUsuario.agregarUsuario(Usu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ha ocurrido un error");
                }


            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + cmbProductoConsulta.Text + "?", 
                    "Clase GUI 06", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Usu.Nombre = cmbProductoConsulta.Text;
                    ConsultasUsuario.EliminarUsuario(Usu);
                
                    MessageBox.Show("¡Usuario eliminado exitosamente!", 
                        "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                    actualizarControles();
                }


            }


            private void cmbProductoConsulta_SelectedIndexChanged(object sender, EventArgs e)
            {
                Usuario U = (Usuario) cmbProductoConsulta.SelectedValue;
                if (U.Admi)
                {
                    rbAdmi.Checked = true;
                }
                else
                {
                    rbCliente.Checked = true;
                }
            }
        

        private void UserAdmi_Load(object sender, EventArgs e)
        {
        if (Usu.Admi)
        {
            // Los administradores si tienen acceso a esta informacion

            actualizarControles();
        }

        else
        {
            // Los usuarios NO administradores no tienen permiso de acceder a estas pestanas
            tabControl1.TabPages[1].Parent = null;
            tabControl1.TabPages[1].Parent = null;
            tabControl1.TabPages[1].Parent = null;
        }
        }
        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<Usuario> lista = ConsultasUsuario.GetListaUsuarios();
            List<Inventario> lista20 = ConsultasInventario.GetListaInventario();
            
            // Tabla (data grid view)
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = lista;
            // Menu desplegable (combo box)
            cmbProductoConsulta.DataSource = null;
            cmbProductoConsulta.ValueMember = "contrasena";
            cmbProductoConsulta.DisplayMember = "usuario";
            cmbProductoConsulta.DataSource = lista;
            comboBox3.DataSource = null;
            comboBox3.ValueMember = "contrasena";
            comboBox3.DisplayMember = "usuario";
            comboBox3.DataSource = lista;
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "Descrip";
            comboBox1.DataSource = lista20;

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Usu.Nombre = comboBox3.Text;
            Usu.Contra = textBox1.Text;
            ConsultasUsuario.ModificarUsuario(Usu);
        }

        private void btnAlmacenarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")  ||  txtDescripcion.Text.Equals("")  )
            {
                MessageBox.Show("No se pueden dejar campos vacios");

            }
            else
            {
                try
                {
                    invent.Nombre = txtNombre.Text;
                    invent.Descrip = txtDescripcion.Text;
                    // revisa que este bien que sea Length
                    invent.Precio = txtPrecio.TextLength;
                    invent.Stock = txtStock.TextLength;
                    ConsultasInventario.AgregarInventario(invent);
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ha ocurrido un error");
                }


            }
        }

        private void btnAlmacenarProducto_Click(object sender, EventArgs e)
        {
            invent.Nombre = comboBox1.Text;
            invent.Stock = txtNewstock.TextLength;
            ConsultasInventario.ModificarStock(invent);
        }

       

        private void groupBox4_Enter(object sender, EventArgs e)
        {
           /* throw new System.NotImplementedException();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            invent.Nombre = comboBox2.Text;
            ConsultasInventario.EliminarInventario(invent);
        }
    }

    }