using Modulo2Matematicas;
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diccionarios
            Dictionary<string, int> NombreEdad = new Dictionary<string, int>();
            NombreEdad.Add("Brandom", 32);
            NombreEdad.Add("Roberto", 12);
            NombreEdad.Add("Juliana", 18);
            //NombreEdad.Add("Juliana", 12);
            Console.WriteLine(NombreEdad["Brandom"]);
            if (NombreEdad.ContainsKey("BSDAF"))
            {
                Console.WriteLine("Contiene llave");
            }
            else
            {
                Console.WriteLine("No contiene llave");
            }

            Dictionary<string, int> EstudiantePuesto = new Dictionary<string, int>();
            EstudiantePuesto.Add("Carlos", 1);
            EstudiantePuesto.Add("Roberto", 4);
            EstudiantePuesto.Add("Julian", 2);
            //Eliminar elemento por medio de llave
            EstudiantePuesto.Remove("Carlos");
            //Devolver coleccion de llaves
            foreach(string llaves in EstudiantePuesto.Keys)
            {
                Console.WriteLine(llaves);
            }


            //Diccionarios de entero y tipo de referencia de una clase
            Dictionary<int, Persona> enteroPersona = new Dictionary<int, Persona>();
            Persona persona = new Persona();
            persona.Edad = 21;
            persona.Nombre = "Kevin";
            enteroPersona.Add(1, persona);


            
            Console.Read();
        }

        //clase persona 
        public class Persona {
            public int Edad { get; set; }
            public string Nombre { get; set; }
        }

    }
}