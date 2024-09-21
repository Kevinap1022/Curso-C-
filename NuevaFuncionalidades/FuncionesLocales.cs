using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PracticaCursoSichar
{
    class Program
    {
        //Funciones locales
        static void Main(string[] args)
        {
            //Funcion dentro de otra
            void FuncionLocal()
            {
                Console.WriteLine("Funcion local");
                void FuncionLocal2()
                {
                    Console.WriteLine("Inception");
                }
                FuncionLocal2();
            }

            FuncionLocal();

            //invocar funcion internar antes de su declaracion
            int resultado = Sumar(6, 7);
            

            //Declaramos funcion 
             int Sumar(int a, int b)
            {
                return a * b;
            }

            //Expresiones lambda en variables 
            int Multiplicar(int a, int b) => a * b;

            Console.Read();
        }
    }

}



