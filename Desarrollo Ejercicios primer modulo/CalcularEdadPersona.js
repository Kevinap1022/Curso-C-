using System;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimiento = new DateTime(2006,01,29);
            int edadActual = CalcularEdadPersona(fechaNacimiento);
            Console.WriteLine("Su edad actual es " + edadActual);
            Console.Read();

        }

        static int CalcularEdadPersona(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            int AñoPrimero = fechaNacimiento.Year;
            int AñoSegundo = fechaActual.Year;
            int EdadActual = AñoSegundo - AñoPrimero;


            return EdadActual;
        }

    }
}