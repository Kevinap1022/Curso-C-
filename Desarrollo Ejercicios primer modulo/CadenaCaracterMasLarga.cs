using System;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1 = Console.ReadLine();
            string texto2 = Console.ReadLine();

            Console.WriteLine(EvaluarCantidadCaracteres(texto1, texto2));
            Console.Read();
        }

        static string EvaluarCantidadCaracteres(string texto1, string texto2)
        {
            if(texto1.Length > texto2.Length)
            {
                return "el texto mas largo es " + texto1;
            }
            else if(texto2.Length > texto1.Length)
            {
                return "el texto mas largo es " + texto2;
            }

            return "nada";
        }
    }
}