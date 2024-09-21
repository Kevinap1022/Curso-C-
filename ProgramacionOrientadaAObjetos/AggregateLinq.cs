using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Aggregate
        static void Main(string[] args)
        {
            //lista de numeros
            List<int> listaNumeros = new List<int>()
        {
            3,45,7,34,76,23
        };

            //multiplicar lista de numeros 
            //multiplica de dos en dos 
            int multiplicacionListaNumeros = listaNumeros.Aggregate((anterior, actual) => anterior * actual);
        }
    }

    //Clase de persona 
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Salario { get; set; }
    }
}
