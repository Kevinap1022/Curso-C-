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
            Queue<string> queue = new Queue<string>();
            Console.WriteLine("Primer elemento insertado");
            //Primer elemento 
            queue.Enqueue("Primero");

            Console.WriteLine("Segundo elemento insertado");
            //Segundo elemento 
            queue.Enqueue("Segundo");

            Console.WriteLine("Tercer elemento insertado");
            //Tercer elemento 
            queue.Enqueue("Tercero");

            //Iterar para ver contenido
            foreach(string item in queue)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Primer elemento extraido");
            string primeroElementoRemovido = queue.Dequeue();
            Console.WriteLine(primeroElementoRemovido);

            Console.WriteLine("Segundo elemento extraido");           
            Console.WriteLine(queue.Dequeue());           
            
            Console.WriteLine("Tercer elemento extraido");
            Console.WriteLine(queue.Dequeue());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.Read();


        }


    }
}