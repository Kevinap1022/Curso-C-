using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaNumeros = new List<int> { 13, 6, 16, 84, 57, 16 };
            ListaNumeros = reordenarEnteros(ListaNumeros);
            foreach(int numero in ListaNumeros)
            {
                Console.WriteLine(numero);
            }
            Console.Read();

        }

        static List<int> reordenarEnteros(List<int> listaNumeros)
        {
            listaNumeros.Sort();
            return listaNumeros;
        }

    }
}