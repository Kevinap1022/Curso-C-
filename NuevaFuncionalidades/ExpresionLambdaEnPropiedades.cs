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

            Console.Read();
        }

        public class Figuras
        {
            public int primerNumero { get; set; }
            public int SegundoNumero { get; set; }
            public int resultado => primerNumero * SegundoNumero;

            public int Edad
            {
                get => 32;
                set => Edad = value;
            }
        }





    }

}



