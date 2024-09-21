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

            //Func
            Func<int, string> delegadoFunc = FuncionRetornarStringMasUno;
            string resultado = delegadoFunc(53);

            Action<int, string> delegadoAction = FuncionSuma;
            delegadoAction(3, "31");

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



    }
}