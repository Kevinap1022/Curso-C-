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
            Vector vector2 = new Vector(new List<int> { 4, 2 });
            Vector vectorSuma = vector1.Suma(vector2);
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
            //propiedad dimension 
            public int Dimension { get { return _componentes.Count; } }

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

            //metodo de clase 
            public Vector Suma(Vector v2)
            {
                if(Dimension != v2.Dimension)
                {
                    throw new ApplicationException("las dimensiones no son iguales");
                }

                //guardamos resultado en una lista
                List<int> resultado = new List<int>();

                //iteramos los n componentes que tengamos 
                for(int i = 0; i < Dimension; i++)
                {
                    resultado.Add(this[i] + v2[i]);
                }

                return new Vector(resultado);


            }
        }


        public int SumarNumeros()
        {
            return 32 + 23;
        }

    }
}