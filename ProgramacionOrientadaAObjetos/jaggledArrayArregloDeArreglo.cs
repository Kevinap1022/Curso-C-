using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Arrays de Arrays JaggledArray
        static void Main(string[] args)
        {
            int[][] jaggledArray = new int[2][];
            //creamos arreglo de 4 elementos en el indice 0
            jaggledArray[0] = new int[4];
            jaggledArray[0][0] = 43;
            jaggledArray[0][1] = 12;
            jaggledArray[0][2] = 43;
            jaggledArray[0][3] = 54;

            //segundo arreglo
            jaggledArray[1] = new int[7]
                {
                    4, 2 ,5 ,3 ,4 ,5 ,6
                };

            for(int i = 0; i < jaggledArray.GetLength(0); i++)
            {
                //separamos las columnas con , 
                string join = string.Join(",", jaggledArray[i]);
                Console.WriteLine(join);

            }
            Console.Read();


        }



    }
}