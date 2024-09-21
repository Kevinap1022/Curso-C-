
using System;

namespace PracticaCursoSichar
{

    class Program
    {

        static void Main(string[] args)
        {
            Persona persona = new Persona() { Nombre = "Bruno" };


            //Tipo de referencia 
            Console.WriteLine("Tipo de referencia");
            Console.WriteLine("Previo al cambio");
            Console.WriteLine(persona.Nombre);
            EditarPersona(persona, "Jaime");
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(persona.Nombre);


            //Tipo de valor 
            Console.WriteLine("Tipo de valor ");
            Console.WriteLine("Previo al cambio");
            int edad = 4;
            Console.WriteLine(edad);
            EditarEdad(ref edad, 23);
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(edad);
            Console.Read();

            //out 
            int edad2;
            EditarEdad2(out edad2, 23);
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(edad2);


        }

        static void EditarPersona(Persona persona, string nuevoNombre)
        {
            persona.Nombre = nuevoNombre;
        }

        //static void EditarEdad(int edadActual, int nuevaEdad)
        //{
        //    edadActual = nuevaEdad;
        //}

        static void EditarEdad(ref int edadActual, int nuevaEdad)
        {
            edadActual = nuevaEdad;
        }

        static void EditarEdad2(out int edadActual, int nuevaEdad)
        {
            edadActual = nuevaEdad;
        }

        class Persona
        {
            public string Nombre { get; set; }
        }



    }
}