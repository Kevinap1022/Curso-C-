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

            List<string> nombres = new List<string>() { "Kevin", "Pedro" };

            MiColeccion<decimal,string> miColeccion = new MiColeccion<decimal, string>();
            miColeccion.Agregar(32m);

            Console.Read();

        }

        class MiColeccion<T, M>
        {
            public List<T> MiLista { get; set; }

            //constructor
            //aqui inicializamos la lista 
            public MiColeccion()
            {
                MiLista = new List<T>();
            }

            //agregamos cualquier valor a la lista 
            public void Agregar( T valor)
            {
                MiLista.Add(valor);
            }

            //agregamos cualquier valor a la lista 
            public void Agregar(M valor2)
            {
                //MiLista.Add(valor2);
            }
        }
    }

}