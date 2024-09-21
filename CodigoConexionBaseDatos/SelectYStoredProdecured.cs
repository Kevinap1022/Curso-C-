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

            int idPais = 5;
            //Consultar datos de la base de datos 
            var query = @"SELECT * FROM Personas
                          WHERE Id = @idPais ";

            using(SqlConnection sql = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.Add(new SqlParameter("@idPais", idPais));
                    DataTable dataTable = new DataTable(); //donde se va a guardar la informacion de la tabla 
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd); //adapatador que se encarga de ejecutar nuestro comando 
                    sql.Open();
                    dataAdapter.Fill(dataTable);//guardar informacion en dataTable 
                }
            }

            //stored procedure 
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_BuscarPersonaXPais", sql))
                {
                   cmd.CommandType = CommandType.StoredProcedure; //indicamos el tipo de comando
                    cmd.Parameters.Add(new SqlParameter("@idPais", idPais));
                    DataTable dataTable = new DataTable(); //donde se va a guardar la informacion de la tabla 
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd); //adapatador que se encarga de ejecutar nuestro comando 
                    sql.Open();
                    dataAdapter.Fill(dataTable);//guardar informacion en dataTable 
                }
            }

            Console.Read();
        }
    }

}
