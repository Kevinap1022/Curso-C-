using System;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                bool MultiploTres = i % 3 == 0;
                bool MultiploCinco = i % 5 == 0;
                if (MultiploTres && MultiploCinco)
                {
                    Console.WriteLine($"Fizz Buzz = {i}");
                }
                else if (MultiploTres)
                {
                    Console.WriteLine($"Fizz = {i}");
                }
                else if(MultiploCinco)
                {
                    Console.WriteLine($"Buzz = {i} ");
                }

            }
            Console.Read();

        }

    }
}