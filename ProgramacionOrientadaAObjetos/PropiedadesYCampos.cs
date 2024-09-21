using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Constructores
        static void Main(string[] args)
        {
            Vector vector2 = new Vector(new List<int> { 1, 3 });
            //propiedad de solo lectura
            //vector2.Valores = new List<int> { 3, 5 };
            Console.WriteLine(vector2.Valores);
            //asignamos valor
            vector2.Nombre = "Vector 1";
            Console.WriteLine(vector2.Nombre);
            Console.Read();

        }

        class Vector
        {
            //campo
            private List<int> _valores;

            //propiedad
            //public List<int> Valores { get; set; }
            public string Nombre { get; set; }
            public List<int> Valores { 
                get 
                {
                    return _valores;
                } 
            }

            //constructor 
            public Vector(List<int> valores)
            {
                _valores = valores;
            }
        }


    }
}