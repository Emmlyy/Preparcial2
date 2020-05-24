using System;
using System.Windows.Forms;

namespace Preparcial
{
    public partial class UserCliente : Form
    {
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
        
    }
}