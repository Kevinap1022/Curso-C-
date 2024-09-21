using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Delegados
        //declaramos delegado 
        delegate void EjemploDelegado(int c, string h);
        public delegate string DeEnteroAString(int valor);
        

        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo");
            //instanciamos objeto de delegado
            EjemploDelegado ejemploDelegado = new EjemploDelegado(FuncionSuma);
            //invocar funcion de delegado pasandole argumentos 
            ejemploDelegado(5, "5");

            DeEnteroAString deEnteroAString = new DeEnteroAString(FuncionRetornarString);
            Console.WriteLine(deEnteroAString(4));

            DeEnteroAString deEnteroAString1 = new DeEnteroAString(FuncionRetornarStringMasUno);
            Console.WriteLine(deEnteroAString1(12));

            Template(deEnteroAString1, 10);
            Console.Read();
        }

        public static string FuncionRetornarString(int valor)
        {
            return valor.ToString();
        }

        public static string FuncionRetornarStringMasUno(int valor)
        {
            return (valor + 1).ToString();
        }

        public static void FuncionSuma(int numero, string texto)
        {
            string suma = numero + texto;
            Console.WriteLine("La suma es igual a {0}", suma);
        }

        //funcion que tiene como parametro otro parametro 
        public static void Template(DeEnteroAString algoritmo, int valor)
        {
            Console.WriteLine("Hacer algo antes del algoritmo ");
            Console.WriteLine(algoritmo(valor));
            Console.WriteLine("Hacer algo despues de algoritmo");
        }



    }
}