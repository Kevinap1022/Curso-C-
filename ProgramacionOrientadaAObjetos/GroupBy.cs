using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //GroupBy
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>()
            {
                4,2,645,23,12,54,2,8,7,4,12
            };

            //Agrupa por dos grupos, grupos pares e impares
            var agruparParesImpares = listaNumeros.GroupBy(numero => Math.Abs(numero % 2));

            //Iterar grupos y elementos 
            foreach (var clase in agruparParesImpares)
            {
                //escribimos la llave de la operación, la llave del grupo de impares es uno y la de pares es 0
                Console.WriteLine("Numeros cuyo residuo es " + clase.Key);
                foreach(int numero in clase)
                {
                    Console.WriteLine(numero);
                }

            }
            //Agrupar a personas por edad
            List<Persona> listaPersonas = new List<Persona>()
            {
                new Persona{Nombre = "Pedro" , Edad = 32, Salario = 24},
                new Persona{Nombre = "Dairon", Edad= 34, Salario = 12},
                new Persona{Nombre = "Pablo", Edad = 12, Salario= 1},
                new Persona{Nombre = "Gabriel", Edad= 11, Salario = 3}
            
            };

            //funcion para agrupar a las personas de acuerdo a su edad
            //llave: "menor que 20"
            //valor: lista de personas con esa edad 
            var gruposDePersonas = listaPersonas.GroupBy(persona =>
            {
                if (persona.Edad <= 20)
                {
                    return "Menor que 20";
                }
                else if (persona.Edad > 21 && persona.Edad <= 40)
                {
                    return "Entre 21 y 40";
                }
                else
                {
                    return "Mayores que 41";
                }
            });

            //agrupamos grupo de personas 
            foreach (var grupoPersona in gruposDePersonas)
            {
                Console.WriteLine("Grupo de " + grupoPersona.Key + "-- cantidad: --" + grupoPersona.Count());
                foreach(var persona in grupoPersona)
                {
                    Console.WriteLine(persona.Nombre);
                }
                Console.WriteLine("");
            }
            Console.Read();
        }

        //Clase de persona 
        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public int Salario { get; set; }
        }
    }
}