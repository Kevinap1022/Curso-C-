using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCursoSichar
{
    class Program
    {
        //Clausula Where 
        static void Main(string[] args)
        {

            List<int> listaNumeros = new List<int>() 
            { 
                3 , 4, 5, 1, 6, 7, 8, -5, -1, -6, -1213
            };

            List<int> numerosMayoresQueCero = listaNumeros.Where(numero => numero > 0).ToList();
            //numeros positivo y pares
            List<int> numerosPositivoYPares = listaNumeros.Where(numero => numero > 0 && numero % 2 == 0).ToList();
            //iteramos para ver resultado
            foreach(int numero in numerosPositivoYPares)
            {
                Console.WriteLine(numero);
            }

            //Lista de personas
            List<Persona> ListaPersona = new List<Persona>()
            {
                new Persona() {Nombre= "Pedro", Edad = 32 },
                new Persona() {Nombre = "Julian", Edad= 12},
                new Persona() {Nombre= "Ana", Edad = 17},
                new Persona(){Nombre= "Andres", Edad= 43}
            };

            //personas mayores
            List<Persona> personasMayores = ListaPersona.Where(persona => persona.Edad >= 18).ToList();
            
            Console.Read();
        }

        public class Persona
        {
            public int Edad { get; set; }
            public string Nombre { get; set; }
        }


    }
}