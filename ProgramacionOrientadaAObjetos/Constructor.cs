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
        }

        class Vector
        {
            //campo
            private List<int> _valores;
            //constructor 
            public Vector(List<int> valores)
            {
                _valores = valores;
            }
        }


    }
}