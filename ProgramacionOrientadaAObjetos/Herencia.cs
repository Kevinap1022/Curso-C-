using Modulo2Matematicas;
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{

    class Program
    {
        //Herenia
        static void Main(string[] args)
        {

            List<Animal> animales = new List<Animal>();
            animales.Add(new Vaca("Carlos"));
            animales.Add(new Oveja("Roberto"));

            //iteramos animales
            foreach( Animal animal in animales)
            {
                animal.HacerRuido();
            }

            Console.Read();

        }
    }

    class Animal
    {
        //propiedad nombre
        public string Nombre { get; set; }

        //metodo
        public virtual void HacerRuido()
        {
            Console.WriteLine("{0} hace ruido", Nombre);
        }
    }

    class Vaca:Animal
    {
        public Vaca(string nombre)
        {
            Nombre = nombre;
        }

        public void Limpiar()
        {
            Console.WriteLine("la vaca {0} ha sido limpiada", Nombre);
        }
    }

    class Oveja:Animal
    {
        public Oveja(string nombre)
        {
            Nombre = nombre;
        }

        public void Transquilar()
        {
            Console.WriteLine("la oveja {0} ha sido transquilada", Nombre);
        }
    }
}