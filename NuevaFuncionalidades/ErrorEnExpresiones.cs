using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PracticaCursoSichar
{
    class Program
    {
        //Funciones locales
        static void Main(string[] args)
        {

            //Error en expresion 
            double dividir(double a, double b)
            => (b != 0) ? a / b : throw new ApplicationException("Denominacion no puede ser cero");

            double c = dividir(4, 5);
            double d = dividir(3, 1);

            Console.Read();
        }







    }

}



