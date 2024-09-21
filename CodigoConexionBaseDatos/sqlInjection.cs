using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PracticaCursoSichar
{
    class Program
    {
        //Sql injection 
        static void Main(string[] args)
        {

            string mensaje = ConfigurationManager.AppSettings["mensaje"];
            Console.WriteLine(mensaje);

            //Leer configuration string
            string connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;

            Console.WriteLine("Escribe un valor en pantalla");
            var valor = Console.ReadLine();
            string query = @"SELECT * FROM Tabla1 
                             WHERE COL1 =  '" + valor + "'";

            using(SqlConnection sql = new SqlConnection(connectionString))
            {
                sql.Open();
                using(SqlCommand cmd = new SqlCommand(query, sql))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                }
            }



            Console.Read();
        }
    }

}
