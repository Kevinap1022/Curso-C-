using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {

        static void Main(string[] args)
        {
            Predicate<Persona> _predicado = EsMayorDeEdad;
            Persona persona = new Persona()
            {
                Nombre = "Juan",
                Edad = 32
            };
            Console.WriteLine(_predicado(persona));
            Console.Read();
        }

        static bool EsMayorDeEdad(Persona persona)
        {
            return persona.Edad >= 18;
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }




    }
}