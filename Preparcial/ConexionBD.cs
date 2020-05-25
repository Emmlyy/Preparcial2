using Npgsql;
using System.Data;
using  System;

namespace Preparcial
{
    public static class ConexionBD{

    private static string CadenaConexion = 
            "Server=127.0.0.1;Port=5432;User Id=postgres;Password=UCA;Database=preParcial";
        
        public static DataTable Query(string sql)
        {
            NpgsqlConnection connection = new NpgsqlConnection(CadenaConexion);
            DataSet ds = new DataSet();
            
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, connection);
            da.Fill(ds);
            connection.Close();
            
            return ds.Tables[0];
        }

        public static void noQuery(string sql)
        {
            NpgsqlConnection connection = new NpgsqlConnection(CadenaConexion);
            
            connection.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, connection);
            nc.ExecuteNonQuery();
            connection.Close();
        }
    }
}