using Modulo2Matematicas;
using System;
using System.Collections.Generic;

namespace PracticaCursoSichar
{

    class Program
    {
        //Static
        static void Main(string[] args)
        {
            IteradorDeLista iteradorLista1 = new IteradorDeLista();
            iteradorLista1.Lista = new List<int>() { 2, 4, 5 };
            iteradorLista1.EscribirLista();

            iteradorLista1.Lista = null;
            iteradorLista1.EscribirLista();
            Console.Read();
        }
    }

    class IteradorDeLista
    {
        //constructor
        public IteradorDeLista()
        {
            _lista = new List<int>();
        }

        //campo
        private List<int> _lista;

        //propiedad
        public List<int> Lista { 
            get 
            {
                return _lista;
            } 
            set 
            {
                if(_lista != null)
                {
                    _lista = value;
                }
                else
                {
                    _lista = new List<int>();
                }
            }
        }

        //metodo
        public void EscribirLista()
        {
            foreach(var item in _lista) 
            {
                Console.WriteLine(item);
            }
        }
    }
}