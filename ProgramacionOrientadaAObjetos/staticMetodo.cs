using System;

namespace PracticaCursoSichar
{

    class Program
    {
        //Static
        static void Main(string[] args)
        {
            //Matematicas matematica1 = new Matematicas();
            //objetos de factura 
            Factura factura1 = new Factura();
            factura1.Monto = 32000;
            factura1.Id = 1;

            Factura factura2 = new Factura();
            factura2.Id = 2;
            factura2.Monto = 40000;

            //solo podemos acceder a suma por medio de un objeto de la clase Program

            Program programa1 = new Program();
            programa1.Suma1(4,2);


            //llamando al metodo de la clase estatica 
            Matematicas.Suma(3,3);
            //Matematicas.PI;

        }


        public int Suma1(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        static class Matematicas
        {
            const double PI = 3.1415;
            public static int Suma(int sumando1, int sumando2)
            {
                return sumando1 + sumando2;
            }

            public static double AreaDelCirculo(int radio)
            {
                return radio * radio * PI;
            }

        }

        class Factura
        {
            //propiedad
            public int Id { get; set; }
            public decimal Monto { get; set; }
        }

        class FacturaRepositorio
        {
            public void GuardarEnBaseDeDatos(Factura factura)
            {
                //codigo para guardar la factura en base de datos
            }
        }



    }
}