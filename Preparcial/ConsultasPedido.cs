using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Preparcial
{
    public class ConsultasPedido
    {
        public static List<Pedido> GetListaPedido()
        {
            string sql = "select * from \"Pedido\"";

            DataTable dt = ConexionBD.Query(sql);
            
            var lista = new List<Pedido>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Pedido ped = new Pedido();
                ped.IdInventario = Convert.ToInt32(fila[0].ToString());
                ped.IdUsuario = Convert.ToInt32(fila[1].ToString());
                ped.IdPedido = Convert.ToInt32(fila[2].ToString());
                ped.cantidad = Convert.ToInt32(fila[3].ToString());
                lista.Add(ped);
            }
            return lista;
        }
        
        public static void AgregarPedido(Usuario u,Inventario inc, String cant)
        {
            int cantidad = Convert.ToInt32(cant);
            string sql = String.Format(
                "insert into \"Pedido\"" + 
                "(\"IdUsuario\", \"IdInventario\", \"Cantidad\")" +
                "values ('{0}', '{1}', {2});",
                u.IdUsuario, inc.idInventario, cantidad);
                
            ConexionBD.noQuery(sql);
        }
        
        public static List<Pedido> PedidodeUsuario(Usuario u)
        {
            string sql = String.Format("select idpedido, idusuario, idinventario, cantidad "+
                                       "from \"Pedido\"" +
                                       "Where idusuario={0}", u.IdUsuario);

            DataTable dt = ConexionBD.Query(sql);
            
            var lista = new List<Pedido>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Pedido ped = new Pedido();
                ped.IdInventario = Convert.ToInt32(fila[0].ToString());
                ped.IdUsuario = Convert.ToInt32(fila[1].ToString());
                ped.IdPedido = Convert.ToInt32(fila[2].ToString());
                ped.cantidad = Convert.ToInt32(fila[3].ToString());
                lista.Add(ped);
            }
            return lista;
        }
    }
}