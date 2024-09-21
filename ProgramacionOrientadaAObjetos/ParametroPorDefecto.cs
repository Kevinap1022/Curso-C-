using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Argumentos opcionales
        static void Main(string[] args)
        {
            metodo("valor1");

            metodo("Carlos", "Pedro");
            Console.Read();

        }

        private static void metodo(string val1, string val2 = "valor2")
        {
            Console.WriteLine( val1);
            Console.WriteLine( val2);
        }

    }
}