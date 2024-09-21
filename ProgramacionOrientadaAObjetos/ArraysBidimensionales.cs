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
            //Arreglo bidimensional
            int[,] matriz = new int[2,2];
            matriz[0, 0] = 1; //fila 0  y columna 0 = 1
            matriz[0, 1] = 2;
            matriz[1, 0] = 3;
            matriz[1, 1] = 4;


            //inicializar rapidamente
            int[,] matriz2 = new int[2, 2]
            {
                {2, 2} , {3, 4}
            };

            //leer los valores de la matriz
            Console.WriteLine(matriz2[0, 1]);

            //matris de string
            string[,] matrizLetras = new string[3, 2]
            {
                {"A", "B" },
                {"C", "D"}, 
                {"E", "F"}
            };

            EscribirArrayBidimensional<int>(matriz);
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