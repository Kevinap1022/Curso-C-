using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Take y skip 
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>()
            {
                3 ,3 ,5, 6, 7, 8, 1
            };
            //Take
            List<int> primerosDosElementos = listaNumeros.Take(2).ToList();

            //Skip
            //saltamos el 3 y el 3 y escogemos el 5 y el 6
            List<int> listaSeleccionPersonalizada = listaNumeros.Skip(2).Take(2).ToList();

            //Ejemplo skip y take 
            //usando where skip y take 
            List<int> listaNumerosPersonalizada = listaNumeros.Where(numero => numero > 3)
                                                              .Skip(2)
                                                              .Take(2).ToList();

        }


    }
}