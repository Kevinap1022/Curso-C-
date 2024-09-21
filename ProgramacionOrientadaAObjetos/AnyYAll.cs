using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Any y All
        static void Main(string[] args)
        {
            //lista de numeros pares e impares
            List<int> listaNumeros = new List<int>()
            {
                43, 51 ,64 ,3, 3,2,4,5, 77
            };

            //lista de numeros pares
            List<int> listaNumerosPares = new List<int>()
            {
                44, 22, 12, 66, 88
            };

            //True si todos los numeros  son pares y si no false
            bool consultaNumerosPares = listaNumeros.All(numero => numero % 2 == 0);
            Console.WriteLine(consultaNumerosPares); //false

            bool consultaNumerosParesDos = listaNumerosPares.All(numero => numero % 2 == 0);
            Console.WriteLine(consultaNumerosParesDos); //true

            //Consulta los numeros
            Console.Read();

            //Any
            //True si tenemos algun numero que sea par
            bool existeAlgunPar = listaNumeros.Any(numero => numero % 2 == 0);
            Console.WriteLine(existeAlgunPar);//true 

            //Algun numero es mayor que 1000
            bool existeAlgunNumeroMayorAMil = listaNumeros.Any(numero => numero > 1000);
            Console.WriteLine(existeAlgunNumeroMayorAMil);//false
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
