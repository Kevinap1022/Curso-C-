using Modulo2Matematicas;
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{

    class Program
    {
        //Clase abstracta 
        static void Main(string[] args)
        {

            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal pelicano = new Pelicano();
            Animal gusano = new Gusano();

            //Animal animal = new Animal();

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);

            Console.Read();

        }

        public static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    abstract class Animal
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido Generico");
        }
    }
    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Woof");
        }
    }
    sealed class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }

    //class Tigre : Gato
    //{
    //    public override void HacerRuido()
    //    {
    //        Console.WriteLine("Guaa");
    //    }
    //}

    class Pelicano : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("CUaa");
        }
    }

    class Gusano : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("SHSHSHS");
        }
    }

}