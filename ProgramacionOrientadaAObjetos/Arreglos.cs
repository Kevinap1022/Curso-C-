using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{
    class Program
    {
        //Arrays
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(2);
            listaNumeros.Add(4);

            //arreglos
            int[] arregloNumeros = new int[3];
            arregloNumeros[0] = 3;
            arregloNumeros[1] = 2;
            arregloNumeros[2] = 5;
            //arregloNumeros[2] = 7;


            string[] arregloLetras = new string[] { "A", "B", "C", "D" };
            //arregloLetras[4] = "Z";


            //Redimensionar arreglo
            Array.Resize<string>(ref arregloLetras, 5);
            arregloLetras[4] = "Z";

            Console.Read();
        }


    }
}