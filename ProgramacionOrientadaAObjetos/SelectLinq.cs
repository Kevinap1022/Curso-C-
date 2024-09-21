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
            List<int> numeros = new List<int>() 
            { 
                4,3,5,6,7,8,1,32,65,23,76
            };
            //trae primer numero para de la lista 
            int primerElemento = numeros.FirstOrDefault(numero => numero % 2 == 0);

            //Lista de personas
            List<Persona> listaPersonas = new List<Persona>(){
              new Persona{Nombre="Bruno", Edad = 32, Salario = 10000000},
              new Persona{Nombre = "Brandom", Edad = 12, Salario = 2003242},
              new Persona{Nombre = "Jaime", Edad= 54, Salario = 2300000}
            };

            //seleccionar el nombre de la persona 
            string nombre = listaPersonas.Where(persona => persona.Edad < 18)
                                         .Select(persona => persona.Nombre).FirstOrDefault();
            //lista personas con edad menor a 18
            List<string> listaNombre = listaPersonas.Where(persona => persona.Edad < 18)
                                       .Select(persona => persona.Nombre).ToList();

            //Realizar proyeccion 
            //creamos una nueva persona con los nuevos valores que le damos en la consulta 
            Persona nuevaPersonaConNuestraConsulta = listaPersonas.Where(persona => persona.Edad < 18)
                                          .Select(persona => new Persona
                                          {
                                                 Edad = persona.Edad,
                                                 Nombre = persona.Nombre,
                                                 Salario = persona.Salario

                                          }).FirstOrDefault();

            //Realizar proyeccion 
            //creamos una nueva persona con los nuevos valores que le damos en la consulta 
            var nuevaPersonaTipoAnonimo = listaPersonas.Where(persona => persona.Edad < 18)
                                          .Select(persona => new 
                                          {
                                              Edad = persona.Edad,
                                              Nombre = persona.Nombre,

                                          }).ToList();




        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public int Salario { get; set; }
        }
    }
}