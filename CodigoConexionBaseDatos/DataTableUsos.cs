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

            DataTable miDataTable = new DataTable();
            miDataTable.Columns.Add("Nombre", typeof(string));
            miDataTable.Columns.Add("Edad", typeof(int));

            //Agregar una fila
            miDataTable.Rows.Add(new object[] { "Juan", 32 });
            miDataTable.Rows.Add(new object[] { "Javier", 12 });

            //Leer fila
            var nombre = miDataTable.Rows[0]["Nombre"];
            //Borrar la data del datatable
            miDataTable.Clear();


            Console.Read();
        }
    }

}
