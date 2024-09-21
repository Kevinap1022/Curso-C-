using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Arrays
        static void Main(string[] args)
        {
            //intanciamos clase Matriz
            Matriz matrizA = new Matriz(2, 2);
            matrizA[0, 0] = 5;
            matrizA[0, 1] = 2;
            matrizA[1, 0] = 1;
            matrizA[1, 1] = 4;

            //intanciamos clase Matriz
            Matriz matrizB = new Matriz(2, 2);
            matrizB[0, 0] = 1;
            matrizB[0, 1] = 6;
            matrizB[1, 0] = 3;
            matrizB[1, 1] = 10;

            Console.WriteLine("matriz 1");
            Console.WriteLine(matrizA.ToString());

            Console.WriteLine("matriz 2");
            Console.WriteLine(matrizB.ToString());

            Console.WriteLine("Resultado suma");
            Matriz matrizSuma = matrizA + matrizB;
            Console.WriteLine(matrizSuma.ToString());

            Console.Read();


        }

        public static void EscribirArrayBidimensional<T>(T[,] matriz)
        {
            int filas = matriz.GetLength(0); //obtenemos filas
            int columnas = matriz.GetLength(1); //obtenemos columnas 
            StringBuilder sb = new StringBuilder();
            T[] tmpFila = new T[matriz.GetLength(1)]; //crear array unidimensional
            //iterar matriz 
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    tmpFila[j] = matriz[i, j];
                }

                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }

            Console.WriteLine(sb.ToString());

        }


    }
}