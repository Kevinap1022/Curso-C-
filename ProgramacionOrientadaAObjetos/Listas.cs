using Modulo2Matematicas;
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{

    class Program
    {
        //Clase abstracta 
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(4);
            listaNumeros.Add(43);
            //listaNumeros.Add("Hola");

            //Inicializar lista rapidamente
            List<string> listaLetras = new List<string> { "Buenos", "Dias", "Pedro" };
            listaLetras.Remove("Buenos");
            listaLetras.RemoveAt(0);
            listaLetras.RemoveAt(listaLetras.Count - 1);
            //insertar valores en un indice especifico 
            listaLetras.Insert(0, "Carlitos");

            //lista personas 
            List<string> listaPersonas = new List<string> { "Carlos", "Roberto", "Pedro" };
            string primerPersona = listaLetras[0];
            Console.WriteLine(primerPersona); //Carlos 
            listaPersonas[0] = "Mario";
            Console.WriteLine(listaPersonas[0]);
        }




    }
}