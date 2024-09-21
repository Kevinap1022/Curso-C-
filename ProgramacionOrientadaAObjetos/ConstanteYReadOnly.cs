
namespace PracticaCursoSichar
{

    class Program
    {

        //variable constante con readonly 
        static readonly double PI_2 = RepositorioDeValores.PI;

        static void Main(string[] args)
        {
            //variable 
            int edad = 32;
            edad = 12;
            edad = 53;

            //variable constante 
            const double NUMEROCONSTANTE = 32.43;
            NUMEROCONSTANTE = 12.34;



        }

        //constante readonly
        public static class RepositorioDeValores
        {
            public static double PI = 32.32;
        }

    }
}