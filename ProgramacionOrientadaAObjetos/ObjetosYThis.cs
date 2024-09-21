using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaCursoSichar
{
    class Program
    {
        //Objetos y contextos
        static void Main(string[] args)
        {
            Empresa empresa1 = new Empresa();
            empresa1._NombreLegal = "Primer Empresa";
            empresa1._Direccion = "Primera Direccion";

            Empresa empresa2 = new Empresa();
            empresa2._NombreLegal = "Segunda Empresa";
            empresa2._Direccion = "Segunda Direccion";

            //llamar metodos de objeto 
            empresa1.metodo(empresa2);
            empresa2.metodo(empresa1);
            empresa1.metodo(empresa1);
        }

    class Empresa
        {
            //campos
            public string _NombreLegal;
            public string _Direccion;

            //metodo de clase 
            public void metodo(Empresa empresa2)
            {
                //Usamos this para referirnos al objeto
                string this_nombreLegal = this._NombreLegal;
                string this_direccion = this._Direccion;
                string miDireccion = _Direccion;
                string miNombreLegal = _NombreLegal;

                string empresa2_nombreLegal = empresa2._NombreLegal;
                string empresa2_direccion = empresa2._Direccion;
            }
        }
    }
}