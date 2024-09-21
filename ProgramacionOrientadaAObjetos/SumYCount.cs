using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Operador Sum
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>()
            {
                4,5,6,78,5,233,623,2,6
            };

            //Sumar numeros 
            int sumaListaNumeros = listaNumeros.Sum();


            //Lista de personas 
            List<Persona> listaPersonas = new List<Persona>()
            {
                new Persona{ Nombre = "Juan", Edad = 43, Salario = 1000},
                new Persona{Nombre= "Pedro", Edad = 23, Salario = 3000},
                new Persona{Nombre = "Guzman", Edad = 32, Salario = 4000},
                new Persona{Nombre = "Juliana", Edad = 18, Salario = 7000},
                new Persona{Nombre = "Brindy", Edad = 32, Salario = 4000},
            };

            //sumamos el salario de las personas 
            int sumaSalarioPersona = listaPersonas.Sum(persona => persona.Salario);


            //Objeto anonimo con el numero total de personas que ahi y la suma del salario 
            var miObjetoAnonimo = new
            {
                TotalSalario = listaPersonas.Sum(persona => persona.Salario),
                CantidadTotalPersonas = listaPersonas.Count()
            };
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
