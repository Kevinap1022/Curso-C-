using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Where con indice
        static void Main(string[] args)
        {
            //lista de numeros
            List<int> listaNumeros = new List<int>() 
            { 
                4, 5, 6, 7, 4, 6, 8, 6, 4, 3
            };

            //filtramos los elemento de indice par
            List<int> numerosMayoresQueCero = listaNumeros.Where((numero, indice) => indice % 2 == 0).ToList();

            Console.Read();
        }




    }
}