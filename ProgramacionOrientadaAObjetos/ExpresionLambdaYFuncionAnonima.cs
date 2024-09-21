using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Expresiones lambda
        static void Main(string[] args)
        {

            Func<int, int> duplicar = x =>
            {
                return x * 2;
            };

            //funcion lambda con dos argumentos 
            Func<int, int, int> multiplicar = (x, y) =>
            {
                return x * y;
            };

            int resultado = duplicar(32);

            int resultadoMultiplicar = multiplicar(3, 3);
            Console.WriteLine(resultado);
            Console.WriteLine(resultadoMultiplicar);

            Console.Read();
        }

        public static int Duplicar()
        {
            return 43 * 2;
        }
    }
}