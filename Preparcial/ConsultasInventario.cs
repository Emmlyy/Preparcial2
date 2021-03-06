﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Preparcial
{
    public class ConsultasInventario
    {
        public static List<Inventario> GetListaInventario()
                {
                    string sql = "select * from \"INVENTARIO\"";
        
                    DataTable dt = ConexionBD.Query(sql);
                    
                    var lista = new List<Inventario>();
                    
                    foreach (DataRow fila in dt.Rows)
                    {
                        Inventario inv = new Inventario();
                        inv.idInventario = Convert.ToInt32(fila[0].ToString());
                        inv.Nombre = fila[1].ToString();
                        inv.Descrip = fila[2].ToString();
                        inv.Precio = Convert.ToInt32(fila[3].ToString());
                        inv.Stock = Convert.ToInt32(fila[4].ToString());
                        lista.Add(inv);
                    }
                    return lista;
                }
                
                public static void AgregarInventario(Inventario inv)
                {
                    string sql = String.Format(
                        "insert into \"INVENTARIO\"" + 
                        "(\"nombre\", \"descripcion\", \"precio\", \"stock\")" +
                        "values ('{0}', '{1}', '{2}', '{3}');",
                        inv.Nombre, inv.Descrip, inv.Precio, inv.Stock);
                        
                    ConexionBD.noQuery(sql);
                }
                
       
                public static void EliminarInventario(Inventario inv)
                {
                    string sql = String.Format(
                        "delete from \"INVENTARIO\" " +
                        "Where idInventario='{0}';",
                        inv.idInventario);
                        
                    ConexionBD.noQuery(sql);
                }
                
                public static void ModificarStock(Inventario inv, int stock)
                {
                    string sql = String.Format(
                        "UPDATE \"INVENTARIO\"" +
                        "SET \"stock\"={0}" +
                        "Where idInventario='{1}';",
                        stock, inv.idInventario);

                    ConexionBD.noQuery(sql);
                }
    }
}