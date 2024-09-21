using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //SkipWhile y TakeWhile 
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>()
            {
                4, 1, 5, 2, 43, 12, 43, 5, -65, 12, -322
            };
            //TakeWhile
            //selecciona los elementos siguiendo una condicion en especifico 
            List<int> listaNumerosMayorSeis = listaNumeros.TakeWhile(numero => numero > 6).ToList();

            //SkipWhile
            //salta todos los elementos que cumpla con la condicion
            List<int> listaNumerosMayoresSeis = listaNumeros.SkipWhile(numero => numero < 6).ToList();

        }
    }
}