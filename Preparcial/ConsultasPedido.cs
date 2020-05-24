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
        
        public static void AgregarPedido(Pedido ped)
        {
            string sql = String.Format(
                "insert into \"Pedido\"" + 
                "(\"IdUsuario\", \"IdInventario\", \"Cantidad\")" +
                "values ('{0}', '{1}', '{2}');",
                ped.IdUsuario, ped.IdInventario, ped.cantidad);
                
            ConexionBD.noQuery(sql);
        }
        
        public static List<Pedido> PedidodeUsuario(Pedido pe)
        {
            string sql = String.Format("select idpedido, idusuario, idinventario, cantidad "+
                                       "from \"Pedido\"" +
                                       "Where idpedido={0}", pe.IdUsuario);

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