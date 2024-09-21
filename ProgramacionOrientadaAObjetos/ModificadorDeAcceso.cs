using Modulo2Matematicas;
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{

    class Program
    {
        //Polimorfismo
        static void Main(string[] args)
        {

            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal pelicano = new Pelicano();
            Animal gusano = new Gusano();

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);

            Console.Read();

        }

        private static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    class Animal
    {
        public virtual void HacerRuido()
        {
            //Program.AnimalHacerRuido(this);
            Console.WriteLine("Ruido Generico");
        }

        protected void MetodoProtegido()
        {

        }
    }
    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Woof");
            MetodoProtegido();

        }

    }
    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }

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