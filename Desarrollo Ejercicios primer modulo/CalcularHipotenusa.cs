using System;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cateto a");
            int catetoA = int.Parse(Console.ReadLine());
            Console.WriteLine("cateto b");
            int catetoB = int.Parse(Console.ReadLine());

            Console.WriteLine("resultado =" + CalcularHipotenusa(catetoA, catetoB));
            Console.Read();
        }

        static double CalcularHipotenusa(int catetoa, int catetob)
        {
            int primerResultado = (catetoa * catetoa) + (catetob * catetob);
            double resultadoHipotenusa = Math.Sqrt(primerResultado);

            return resultadoHipotenusa;
        }
    }
}