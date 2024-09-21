using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaNumeros = new List<int> { 1, 2, 3, 4, 5, 6 };
            ListaNumeros = reordenarEnteros(ListaNumeros);
            foreach(int numero in ListaNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.Read();

        }

        static List<int> reordenarEnteros(List<int> listaNumeros)
        {
            listaNumeros.Reverse();
            return listaNumeros;
        }

    }
}