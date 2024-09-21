using System;

namespace PracticaCursoSichar
{

    class Program
    {
        //Polimorfismo
        static void Main(string[] args)
        {
            //Object letra = "nuevo texto";
            //letra = true;
            //letra = 32;
            //letra = DateTime.Today;
            
            Object objeto = DateTime.Today;

            if(objeto is DateTime)
            {
                DateTime fecha = (DateTime)objeto;

            }else if(objeto is string)
            {
                var unString = (string)objeto;
            }
            Console.Read();
        }

        public static void ToStringObjeto(Object objeto)
        {
            Console.WriteLine(objeto.ToString());
        }

    }

}