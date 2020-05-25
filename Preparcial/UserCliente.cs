using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Preparcial
{
    public partial class UserCliente : Form
    {
        private Inventario inv2;
        private Pedido pet = new Pedido();
        public UserCliente(Usuario u)
        {
            InitializeComponent();
            actualizarTabla(u);
        }
        
        private void actualizarTabla(Usuario u)
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ConsultasPedido.PedidodeUsuario(necesita el id);
        }


        private void cmbProductoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAlmacenarPedido_Click(object sender, EventArgs e)
        {
            pet.IdPedido = cmbProductoPedido.SelectionLength;
            ConsultasPedido.AgregarPedido(pet);
            
        }
    }
}