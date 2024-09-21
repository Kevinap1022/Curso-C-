using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Clausula Where 
        static void Main(string[] args)
        {

            List<int> listaNumeros = new List<int>() 
            { 
                4, 5, 1, 6, 7, 8, -5, -1, -6
            };


            IEnumerable<int> resultado = listaNumeros.Where(x => x > 0);
            resultado.ToList();

            foreach(int numero in resultado)
            {
                Console.WriteLine(numero);
            }

            Console.Read();
        }


    }
}