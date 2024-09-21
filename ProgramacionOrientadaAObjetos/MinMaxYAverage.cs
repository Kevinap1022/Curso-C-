using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Min, Max y Average
        static void Main(string[] args)
        {
            //Lista de numeros
            List<int> listaNumeros = new List<int>()
            {
                4,4,6,56,12,100,12
            };

            //conseguir el valor maximo de la lista de numeros 
            int ValorMaximoListaNumeros = listaNumeros.Max(); //100

            //Conseguir el valor minimo de la lista de numeros
            int ValorMinimoListaNumeros = listaNumeros.Min(); //4

            //Conseguir el promedio de la lista de numeros
            double PromedioListaNumeros = listaNumeros.Average();

            //Lista de tipo persona 
            List<Persona> listaPersonas = new List<Persona>()
            {
                new Persona{Nombre = " Mario", Edad= 56, Salario = 4000},
                new Persona{Nombre = "Maelo", Edad=12, Salario = 3000},
                new Persona{Nombre = "Anna", Edad=18, Salario = 7000},
                new Persona{Nombre = "Yanpi", Edad=38, Salario = 90000},
                new Persona{Nombre = "Garzon", Edad=28, Salario = 70000},
            };

            //Salario minimo de la lista de personas
            int salarioMinimo = listaPersonas.Min(persona => persona.Salario);
            //Salario maximo de la lista de personas 
            int salarioMaximo = listaPersonas.Max(persona => persona.Salario);
            //Edad promedio de la lista de personas 
            double edadPromedioPersona = listaPersonas.Average(persona => persona.Edad);

        }
    }

    //Clase de persona 
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Salario { get; set; }
    }
}
