using System;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = { 23, 12, 54, 65 };
            int numeroMasGrande = NumeroMayor(listaNumeros);
            Console.WriteLine("el numero mayor es " + numeroMasGrande);
            Console.Read();

        }

        static int NumeroMayor(int[] listaNumeros)
        {
            int numeroMayor = listaNumeros.Max();

            return numeroMayor;
        }

    }
}