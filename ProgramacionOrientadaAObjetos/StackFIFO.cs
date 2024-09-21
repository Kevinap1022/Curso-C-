using Modulo2Matematicas;
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{
    class Program
    {
        //FIFO con queue
        static void Main(string[] args)
        {
            Stack<string> nuevoStack = new Stack<string>();
            //primer Elemento insertado
            Console.WriteLine("Primer elemento");
            nuevoStack.Push("Primer elemento");
            //segundo Elemento insertado
            Console.WriteLine("Segundo elemento");
            nuevoStack.Push("Segundo elemento");
            //primer Elemento insertado
            Console.WriteLine("Tercer elemento");
            nuevoStack.Push("Tercer elemento");

            //Elimiinar elementos
            Console.WriteLine("Primer Elemento Extraido");
            Console.WriteLine(nuevoStack.Pop());
            Console.WriteLine("Segundo Elemento Extraido");
            Console.WriteLine(nuevoStack.Pop());
            Console.WriteLine("Tercer Elemento Extraido");
            Console.WriteLine(nuevoStack.Pop());

            Console.Read();


        }


    }
}