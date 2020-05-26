
using System;
using System.Collections.Generic;
using System.Data;


namespace Preparcial
{
    public class ConsultasUsuario
    {
        public static List<Usuario> GetListaUsuarios()
        {
            string sql = "select * from Usuario";

            DataTable dt = ConexionBD.Query(sql);
            
            var lista = new List<Usuario>();
            
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.IdUsuario = Convert.ToInt32(fila[0].ToString());
                u.Nombre = fila[1].ToString();
                u.Contra = fila[2].ToString();
                u.Admi = Convert.ToBoolean(fila[3].ToString());
                lista.Add(u);
            }
            return lista;
        }
        
        
        public static void agregarUsuario(Usuario c)
        {
            string sql = String.Format(
                "insert into \"USUARIO\"" + 
                "(\"nombre\", \"contrasenia\", \"admi\")" +
                "values ('{0}', '{1}', '{2}');",
                c.Nombre, c.Contra, c.Admi);
                
            ConexionBD.noQuery(sql);
        }
        public static bool ExisteUsuario(Usuario u, string contra, bool Admi)
        {
            string sql = "select * from \"USUARIO\"";

            DataTable dt = ConexionBD.Query(sql);
            
            
            foreach (DataRow fila in dt.Rows)
            {
                if (fila[1].ToString().Equals(u.Nombre) &
                    fila[2].ToString().Equals(contra) &
                    fila[3].ToString().Equals(Admi.ToString()) )
                {
                    return true ;
                }
                
            }

            return false;
        }

        public static int GetIdUsuario(Usuario u)
        {
            string sql = "select * from \"USUARIO\"";

            DataTable dt = ConexionBD.Query(sql);
            
            
            foreach (DataRow fila in dt.Rows)
            {
                if (fila[1].ToString().Equals(u.Nombre) &
                    fila[2].ToString().Equals(u.Contra) &
                    fila[3].ToString().Equals(u.Admi.ToString()) )
                {
                    u.IdUsuario = Convert.ToInt32(fila[0].ToString());
                    
                    return u.IdUsuario ;
                }
                
            }

            return -1;
        }
        
        public static void EliminarUsuario(Usuario c)
        {
            string sql = String.Format(
                "delete from \"USUARIO\"" +
                "Where idUsuario='{0}';",
                c.IdUsuario);
                
            ConexionBD.noQuery(sql);
        }
        public static void ModificarUsuario(Usuario u, string contra, bool admi)
                        {
                            string sql = String.Format(
                                "UPDATE \"USUARIO\"" +
                                "SET \"contrasenia\"={0} \"admi\"={1}" +
                                "Where idInventario='{2}';",
                                contra, admi,u.IdUsuario);
        
                            ConexionBD.noQuery(sql);
                        }
    }
    
}