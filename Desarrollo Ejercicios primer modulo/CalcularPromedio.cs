using System;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 23, 12, 54, 65 };
            int resultadoPromedio = CalcularPromedio(listaNumeros);
            Console.WriteLine("El resultado del promedio es " + resultadoPromedio);
            Console.Read();

        }

        static int CalcularPromedio(int[] listaNumeros)
        {
            int sumaTotalLista = listaNumeros.Sum();
            int totalLista = listaNumeros.Length;
            int Promedio = sumaTotalLista / totalLista;
            return Promedio;
        }

    }
}