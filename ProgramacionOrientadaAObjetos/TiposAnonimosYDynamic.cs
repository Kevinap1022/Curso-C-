using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            //persona
            Persona persona1 = new Persona();
            persona1.Edad = 32;

            //tipo anonimos 
            var animal = new { animal = "perro", nombre = "Carlo", vidas = 3 };
            var animal2 = new { animal = "leon", nombre = "Pedro", vidas = 8 };

            //lista de dinamico 
            List<dynamic> animales = new List<dynamic>();
            animales.Add(animal);
            animales.Add(animal2);
            foreach(dynamic animalito in animales)
            {
                Console.WriteLine("El {0} de nombre {1} tiene {2} vidas  ", animalito.animal, animalito.nombre, animalito.vidas);
            }

            Console.Read();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }


}