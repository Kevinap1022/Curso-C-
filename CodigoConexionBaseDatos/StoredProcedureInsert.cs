using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PracticaCursoSichar
{
    class Program
    {
        //App config 
        static void Main(string[] args)
        {

            string mensaje = ConfigurationManager.AppSettings["mensaje"];
            Console.WriteLine(mensaje);

            //Leer configuration string
            string connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            string Nombre = "Kevin";
            int Edad = 21;
            int idPais = 5;

            //stored procedure 
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_PersonasAgregar", sql))
                {
                   cmd.CommandType = CommandType.StoredProcedure; //indicamos el tipo de comando
                    cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Edad", Edad));
                    cmd.Parameters.Add(new SqlParameter("@IdPais", idPais));
                    sql.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            Console.Read();
        }
    }

}
