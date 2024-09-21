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

            int numero1 = 32;

            if(numero1 is int numero2)
            {
                Console.WriteLine("Es un numero");
                numero2 = 12;
            }
            Console.Read();
        }
    }

}



