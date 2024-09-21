using System;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 3;
            int resultado = CalcularFactorial(numero);
            Console.WriteLine("el resultado del factorial es : " + resultado);
            Console.Read();

        }

        static int CalcularFactorial(int numero)
        {
            int resultadoFactorial = 0;
            int contadorFactorial = 0;
            while(contadorFactorial < numero)
            {
                resultadoFactorial = contadorFactorial * numero;
                contadorFactorial = contadorFactorial + 1;

            }
            return resultadoFactorial;
        }

    }
}