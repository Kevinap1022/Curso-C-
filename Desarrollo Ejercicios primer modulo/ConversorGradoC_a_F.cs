using System;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroGrados = double.Parse(Console.ReadLine());
            double resultadoOperacion = ConvertirNumero(numeroGrados);
            Console.WriteLine("el resultado de convertir grados C a grado F es " + resultadoOperacion + " F");
            Console.Read();
        }

        static double ConvertirNumero(double numeroCelsius)
        {
            double convertirAFareheit = (numeroCelsius * 9 / 5) + 32;
            return convertirAFareheit;

        }

    }


}