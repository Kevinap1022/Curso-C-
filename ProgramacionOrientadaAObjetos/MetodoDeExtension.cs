using System;

namespace PracticaCursoSichar
{

    public static class IntegerExtensionMethods
    {
        public static double ElevandoALa(this int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }
        public static double Doble(this int valor)
        {
            return valor * 2;
        }

    }

    class Program
    {
        //Metodo de extension 
        static void Main(string[] args)
        {
            int numero = 2;
            Console.WriteLine(numero.ElevandoALa(5));

            Console.WriteLine(7.Doble());

            Console.Read();
        }



    }
}