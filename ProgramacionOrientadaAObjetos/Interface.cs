using System;

namespace PracticaCursoSichar
{

    class Program
    {
        //Polimorfismo
        static void Main(string[] args)
        {
            EnviarMiniMensaje miniMensaje = new EnviarMiniMensaje();
            EnviarCorreo enviarCorreo = new EnviarCorreo();

            Enviar(miniMensaje, "prueba mensaje");
            Enviar(enviarCorreo, "prueba correo");
            Console.Read();

        }

        public static void Enviar (IEnviadorMensaje mensajero, string mensaje)
        {
            mensajero.EnviarMensaje(mensaje);
        }
    }

    //interface
    interface IEnviadorMensaje
    {
        void EnviarMensaje(string mensaje);
    }

    //clase que implementa la interface 
    class EnviarMiniMensaje : IEnviadorMensaje
    {
        //public void EnviarMensajes(string mensaje)
        //{
        //    Console.WriteLine("Enviando miniMensaje");
        //}

        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando miniMensaje");
        }

        public string MetodoAleatorio()
        {
            return "Un mensaje de texto";
        }
    }

    class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando correo ");
        }
    }
}