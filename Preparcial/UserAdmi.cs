using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Preparcial
{
    public partial class UserAdmi : Form
    {
       private Usuario Usuario =new Usuario() ;
       private Inventario invent ;

        public UserAdmi(Usuario u)
        {
            InitializeComponent();
           Usuario = u;
           actualizarControles();
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
                    Usuario usu=new Usuario();
                    usu.Nombre = tbtNombre.Text;
                    usu.Contra = Encriptador.CrearMD5(tbtContra.Text);
                    if (rbAdmi.Checked) usu.Admi = true;
                    else usu.Admi = false;
                    ConsultasUsuario.agregarUsuario(usu);
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
                    Usuario elim = (Usuario) cmbProductoConsulta.SelectedItem;
                    elim.Nombre = cmbProductoConsulta.Text;
                    ConsultasUsuario.EliminarUsuario(elim);
                
                    MessageBox.Show("¡Usuario eliminado exitosamente!", 
                        "Clase GUI 06", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                    actualizarControles();
                }


            }


            private void cmbProductoConsulta_SelectedIndexChanged(object sender, EventArgs e)
            {
                Usuario U = (Usuario) cmbProductoConsulta.SelectedItem;
            }
        

        private void UserAdmi_Load(object sender, EventArgs e)
        {
        if (Usuario.Admi)
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
            List<Pedido> pedidos = ConsultasPedido.GetListaPedido();
            // Tabla (data grid view)
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = pedidos;
            // Menu desplegable (combo box)
            cmbProductoConsulta.DataSource = null;
            cmbProductoConsulta.ValueMember = "contrasenia";
            cmbProductoConsulta.DisplayMember = "usuario";
            cmbProductoConsulta.DataSource = lista;
            comboBox3.DataSource = null;
            comboBox3.ValueMember = "contrasenia";
            comboBox3.DisplayMember = "usuario";
            comboBox3.DataSource = lista;
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "Descrip";
            comboBox1.DataSource = lista20;

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Usuario Usu = (Usuario) comboBox3.SelectedItem;
            
             string Contra = textBox1.Text;
             bool admi;
             if (radioButton2.Checked) admi = true;
             else admi = false;
            ConsultasUsuario.ModificarUsuario(Usu, Contra, admi);
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
                    Inventario invent=new Inventario();
                    invent.Nombre = txtNombre.Text;
                    invent.Descrip = txtDescripcion.Text;
                    invent.Precio = Convert.ToInt32(txtPrecio.Text);
                    invent.Stock = Convert.ToInt32(txtStock.Text);
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
            Inventario invent = (Inventario) comboBox1.SelectedItem;

            int Stock = Convert.ToInt32(txtNewstock.Text);
            ConsultasInventario.ModificarStock(invent, Stock);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Inventario invent = (Inventario) comboBox1.SelectedItem;
            ConsultasInventario.EliminarInventario(invent);
        }
    }

    }