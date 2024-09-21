using System;
using System.Configuration;
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
            Console.WriteLine("Mensaje en consola");

            //Connection string 
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @".\"; //nombre de servidor 
            builder.InitialCatalog = "Prueba"; //nombre de base de datos 
            builder.UserID = "sa"; //nombre de usuario
            builder.Password = "1022344094"; //contraseña

            //crear connection string 
            string connectionString = builder.ToString();

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                sql.Open();
            }

            Console.Read();
        }
    }

}
