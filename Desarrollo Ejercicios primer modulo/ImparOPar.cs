using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            if (EvaluarNumeroParOImpar(7))
            {
                Console.WriteLine("el numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.Read();
        }

        static bool EvaluarNumeroParOImpar(int numero)
        {
            if(numero % 2 == 0)
            {
                return true;
            }
            else if(numero % 2 != 0)
            {
                return false;
            }
            return false;
        }
    }
}