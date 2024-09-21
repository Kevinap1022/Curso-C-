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
            //Instanciar dataTable

            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_BuscarPersonaXPais", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        sql.Open();

                        //command TimeOut = 10
                        cmd.CommandTimeout = 10;

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter();
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            Console.Read();
        }
    }

}
