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
            DataTable dataTable = new DataTable();

            //Filtrando personas mayores de 45 años 
            DataView mayoresCuarentaCinco = dataTable.AsEnumerable().Where(persona => persona.Field<int>("Edad") > 45).AsDataView();

            //Ordenar de manera descendente el campo nombre 
            DataView OrdenarDescendente = dataTable.AsEnumerable().OrderByDescending(persona => persona.Field<string>("Nombre")).AsDataView();

            //Proyectando 
            var objetos = dataTable.AsEnumerable().Select(persona =>
                    new
                    {
                        Nombre = persona.Field<string>("Nombre"),
                        Edad = persona.Field<int>("Edad")
                    });

            //iterar objetos
            foreach(var objeto in objetos)
            {
                Console.WriteLine($"Nombre: {objeto.Nombre} Edad: {objeto.Edad} ");
            }

            Console.Read();
        }
    }

}
