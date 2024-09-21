using Modulo2Matematicas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PracticaCursoSichar
{

    class Program
    {
        //Clase abstracta 
        static void Main(string[] args)
        {
            Persona persona1 = new Persona() { Nombre = "Pedro" };
            string xml_persona1 = Serializar(persona1);

            Persona persona2 = new Persona() { Nombre = "Carlos" };
            string xml_persona2 = Serializar(persona2);
            Console.WriteLine(xml_persona2);

            Empresa empresa1 = new Empresa() { NombreEmpresa = "Far" };
            string xml_empresa1 = Serializar(empresa1);

            Empresa empresa2 = new Empresa { NombreEmpresa = "Rafael" };
            string xml_empresa2 = Serializar<Empresa>(empresa2);

            Console.Read();
        }

        //Genericos 
        //Pasamos cualquier tipo de dato 
        private static string Serializar<T>(T valor)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));

            using (StringWriter escritoString = new StringWriter())
            {
                serializador.Serialize(escritoString, valor);
                return escritoString.ToString();
            }
        }

        private static string Serializar(Persona persona)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Persona));

            using(StringWriter escritoString = new StringWriter())
            {
                serializador.Serialize(escritoString, persona);
                return escritoString.ToString();
            }
        }

        private static string Serializar(Empresa persona)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Empresa));

            using (StringWriter escritoString = new StringWriter())
            {
                serializador.Serialize(escritoString, persona);
                return escritoString.ToString();
            }
        }


    }

    public class Persona
    {
        public string Nombre { get; set; }
    }

    public class Empresa
    {
        public string NombreEmpresa { get; set; }
    }
}