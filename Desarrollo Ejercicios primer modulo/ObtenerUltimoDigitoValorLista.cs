using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListaString = new List<string> { "Marcos", "Maria", "Jose", "Alberto" };
            ObtenerPrimerValor(ListaString);
            Console.Read();


        }

        static List<string> ObtenerPrimerValor(List<string> ListaString)
        {
            foreach (string nombre in ListaString)
            {
                int ultimoDigito = nombre.Length - 1;
                Console.WriteLine(nombre[ultimoDigito]);
            }

            return ListaString;
        }

    }
}