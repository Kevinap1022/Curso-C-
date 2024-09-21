
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{

    class Program
    {

        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 3, 4, 5, 3, 1, 4 };
            numeros.Add(5);
            List<Persona> personas = new List<Persona>()
            {
                new Persona(){ Nombre = "Carlos"},
                new Persona(){ Nombre = "Olga"}
            };

        }


        private int Duplicar(int valor)
        {
            return valor * 2;
        }

        private int Duplicar(int valor)
        {
            return valor * 2;
        }


        private double Duplicar(double valor)
        {
            return valor * 2;
        }



        class Persona
        {
            public string Nombre { get; set; }
        }
        class Empresa
        {
            public string Direccion { get; set; }
        }
    }
}