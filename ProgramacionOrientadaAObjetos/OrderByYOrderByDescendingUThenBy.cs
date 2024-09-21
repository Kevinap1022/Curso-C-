using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Where con indice
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>() 
            {
                4, 5, 6, 7, 8, 1, 2
            };
            //filtrar numeros para que esten en orden ascendente
            List<int> listaNumerosPositivosOrdenados = listaNumeros.Where(numero => numero > 0).OrderBy(numero => numero).ToList();

            //filtrar numeros para que esten en orden descendiente
            List<int> listaNumerosPositivosOrdenDescendiente = listaNumeros.Where(numero => numero > 0).OrderByDescending(numero => numero).ToList();

            //Lista de personas
            List<Persona> listaPersonas = new List<Persona>()
            {
                new Persona{NombrePersona = "Kevin", Edad= 18, Salario = 3},
                new Persona{NombrePersona = "Heymar", Edad = 43, Salario = 1},
                new Persona{NombrePersona = "Jose", Edad = 12, Salario = 65}
            };

            //ordenamos esta lista por nombre 
            List<Persona> listaPersonaOrdenXNombre = listaPersonas.OrderByDescending(persona => persona.NombrePersona).ToList();

            //ordenamos en orden descendente por edad
            List<Persona> listaPersonaOrdenXEdad = listaPersonas.OrderByDescending(persona => persona.Edad).ToList();

            List<Persona> personasOrdenadasPoNombreYSalario = listaPersonas.OrderBy(persona => persona.NombrePersona).ThenBy(persona => persona.Salario).ToList();
            IterarListaPersonas(personasOrdenadasPoNombreYSalario);

            //Ordenar por edad y salario
            Console.Read();



        }

        public class Persona
        {
            static int id = 0;

            public Persona()
            {
                id = id + 1;
            }
            public int _id
            {
                get
                {
                    return id;
                }
            }
            public string NombrePersona { get; set; }
            public int Edad { get; set; }
            public int Salario { get; set; }
        }

        public static void IterarListaPersonas(List<Persona> listaPersonas)
        {
            foreach(Persona persona in listaPersonas)
            {
                Console.WriteLine(persona.NombrePersona + " " + persona.Salario);
            };
        }





    }
}