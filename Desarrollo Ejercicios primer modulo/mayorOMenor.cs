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
            int primerNumero = int.Parse(Console.ReadLine());
            int segundoNumero = int.Parse(Console.ReadLine());

            if (primerNumero > segundoNumero)
            {
                Console.WriteLine("el numero mayor es " + primerNumero);
            }
            else if(segundoNumero > primerNumero)
            {
                Console.WriteLine("el numero mayor es " + segundoNumero);
            }
            else
            {
                int[] arrayNumeros = {primerNumero, segundoNumero};
                Random rnd = new Random();
                var aleatorio = rnd.Next(0, 1);
                Console.WriteLine("son iguales " + arrayNumeros[aleatorio]);
            }
            Console.Read();
        }
    }
}