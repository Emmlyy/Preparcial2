using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Preparcial
{
    public partial class UserCliente : Form
    {
        private Inventario inv2;
        private Usuario user=new Usuario();
        private Pedido pet = new Pedido();
        public UserCliente(Usuario u)
        {
            InitializeComponent();
            actualizar();
            user = u;
        }
        
        private void actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ConsultasPedido.PedidodeUsuario(user);
            
            cmbProductoPedido.DataSource = null;
            cmbProductoPedido.ValueMember = "idPedido";
            cmbProductoPedido.DisplayMember = "nombre";
            cmbProductoPedido.DataSource = ConsultasInventario.GetListaInventario();

            lblNombre.Text = user.Nombre;
            lbContra.Text = user.Contra;

        }


        private void cmbProductoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAlmacenarPedido_Click(object sender, EventArgs e)
        {
            
            Inventario p = (Inventario) cmbProductoPedido.SelectedItem;
                
            ConsultasPedido.AgregarPedido(user, p, tbCant.Text);
                
            MessageBox.Show("Pedido agregado exitosamente", "Clase GUI 04",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            // Actualizar el data grid view (la tabla)
            actualizar();
        }
    }
}