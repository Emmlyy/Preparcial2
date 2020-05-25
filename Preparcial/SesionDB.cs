using System;
namespace Preparcial
{
    public class SesionDB
    {
        public static void iniciarSesion(string pUsuario)
        {
            agregarRegistro(pUsuario, true);
        }
        
        public static void cerrarSesion(string pUsuario)
        {
            agregarRegistro(pUsuario, false);
        }
        
        private static void agregarRegistro(string pUsuario, bool entra)
        {
            string sql = String.Format(
                "insert into registro(usuario, entrar) values ('{0}', {1});",
                pUsuario, entra);

            ConexionBD.noQuery(sql);
        }
    }
}