using Npgsql;
using System.Data;
using  System;
namespace Preparcial
{
    public class ConexionBD
    {
    using System.Data;
    using System.Security.Cryptography.X509Certificates;
    using Npgsql;
    namespace Preparcial
    {
        public static class ConexionBD
        {
            private static string bd = "127.0.0.1",
                database = "Preparcial",
                userId = "postgres",
                password = "uca";
            private static string sConnection =
                $"Server={bd};Port=5432;User Id={userId};Password={password};Database={database};";

            public static DataTable ExecuteQuery(string query)
            {
                NpgsqlConnection Connection = new NpgsqlConnection();
                DataSet st = new DataSet();
                Connection.Open();
                NpgsqlDataAdapter data = new NpgsqlDataAdapter(query,Connection);
                data.Fill(st);
                Connection.Close();
                return st.Tables[0];
            }
            public static void ExecuteNonQuery(string act)
            {
                    
                NpgsqlConnection connection = new NpgsqlConnection(sConnection);
                    
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(act,connection);
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
    }
}