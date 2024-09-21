using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variable out
            if (DateTime.TryParse("2019-04-20", out DateTime fecha2)) {

                Console.WriteLine(fecha2);
            }

            

            Console.Read();
        }







    }

}



