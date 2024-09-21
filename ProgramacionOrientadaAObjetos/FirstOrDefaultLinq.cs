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
                5,3,2 ,5 ,6 ,3 ,5
            };

            //obtiene el primer elemento de la coleccion, si esta vacia retorna el cero 
            int primerElemento = listaNumeros.FirstOrDefault();
            Console.WriteLine(primerElemento);

            //First
            //Obtiene el primer elemento pero si la lista esta vacia arroja una excepción
            List<int> listaNumerosFirst = new List<int>()
            {
                
            };

            //int primerElementoFirst = listaNumerosFirst.First();
            //SobreCargaFirstOrDefault
            List<int> listaElementosPar = new List<int>()
            {
                5,6,78,8,43,23
            };
            int primerElementoPar = listaElementosPar.FirstOrDefault(numero => numero % 2 == 0);
            Console.WriteLine(primerElementoPar);

            //Ejemplo lista personas
            List<Persona> listaPersonas = new List<Persona>()
            {
                new Persona {Nombre = "Pedro" , Edad = 43, Salario = 1000000 },
                new Persona {Nombre = "Marta", Edad = 23, Salario = 53412423},
                new Persona {Nombre = "Julian", Edad = 12, Salario = 1000000},
                new Persona {Nombre = "Carlo", Edad = 43, Salario = 20000}
            };

            Persona PersonaMenorEdad = listaPersonas.FirstOrDefault(persona => persona.Edad < 18);
            Console.WriteLine(PersonaMenorEdad.Edad);
            Console.Read();

        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public int Salario { get; set; }
        }

    }
}