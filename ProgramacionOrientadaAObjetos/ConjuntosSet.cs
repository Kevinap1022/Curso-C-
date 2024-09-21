using Modulo2Matematicas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Conjuntos 
        static void Main(string[] args)
        {
            HashSet<int> conjuntoNumeros = new HashSet<int>();
            //Agregamos elementos 
            conjuntoNumeros.Add(3);
            conjuntoNumeros.Add(2);
            conjuntoNumeros.Add(5);
            //conjuntoNumeros.Add(3);

            //segundo Conjunto 
            HashSet<int> segundoConjunto = new HashSet<int>();
            segundoConjunto.Add(5);
            segundoConjunto.Add(4);
            conjuntoNumeros.Add(2);

            //Unión conjuntos
            HashSet<int> union_set1_set2 = new HashSet<int>(conjuntoNumeros);
            union_set1_set2.UnionWith(segundoConjunto);

            //foreach (var numero in union_set1_set2) 
            //{
            //    Console.WriteLine(numero);
            //}

            //interseccion
            HashSet<int> intersection_set1_set2 = new HashSet<int>(conjuntoNumeros);
            intersection_set1_set2.IntersectWith(segundoConjunto);

            //foreach (int  elementoComun in intersection_set1_set2)
            //{
            //    Console.WriteLine(elementoComun);
            //}

            HashSet<int> diferenteDe_set1_set2 = new HashSet<int>(conjuntoNumeros);
            diferenteDe_set1_set2.ExceptWith(segundoConjunto);

            //foreach (int elementoDiferente in diferenteDe_set1_set2)
            //{
            //    Console.WriteLine(elementoDiferente);
            //}

            //diferencia simetrica
            HashSet<int> diferenciaSimetrica_set1_set2 = new HashSet<int>(conjuntoNumeros);
            diferenciaSimetrica_set1_set2.SymmetricExceptWith(segundoConjunto);

            //foreach (int diferencia in diferenciaSimetrica_set1_set2)
            //{
            //    Console.WriteLine(diferencia);
            //}
            //Console.Read();


            //Remover los elementos comunes 
            List<int> listaNumeros = new List<int>() { 3, 3, 4, 6, 1, 1, 8, 8, 5 };

            //convertimos a conjunto para utilizarlo 
            listaNumeros = new HashSet<int>(listaNumeros).ToList();

            foreach (int numeros in listaNumeros)
            {
                Console.WriteLine(numeros);
            }
            Console.Read();

        }


    }
}