using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(new List<int> { 1, 2 });
            Console.WriteLine(vector1[0]);
            vector1[0] = 43;//asigna valor por medio del indice
            Console.WriteLine(vector1.Componentes[0]); //valor de la lista 
            Console.Read();
        }

        class Vector
        {
            //campo
            private List<int> _componentes;
            //propiedad
            public List<int> Componentes
            {
                get
                {
                    return _componentes;
                }
            }
            //indexador
            public int this[int i]
            {
                get
                {
                    return _componentes[i];
                }
                set
                {
                    _componentes[i] = value;
                }
            }

            //constructor 
            public Vector(List<int> valores)
            {
                _componentes = valores;
            }

        }


    }
}