using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Params
        static void Main(string[] args)
        {
            int numero1 = 5;
            int numero2 = 7;
            int numero3 = 5;
            double promedio = CalcularPromedio(numero1, numero2, numero3);
        }

        private static double CalcularPromedio(params int[] numeros)
        {
            //sumamos todos los parametros
            double suma = 0.0;
            foreach (int numero in numeros)
            {
                suma = suma + numero;
            }
            return suma / numeros.Length;
        }

    }
}