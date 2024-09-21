using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Where con indice
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>()
            {
              3,5,6,3,2,6,-100,433
            };

             listaNumeros.Reverse(1,8);

            foreach(var item in listaNumeros)
            {
                Console.WriteLine(item);
            }

            Console.Read();


        }

        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public int Salario { get; set; }
        }







    }
}