using System;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviarMiniMensaje enviadorSMS = new EnviarMiniMensaje();
            EnviadorMensaje enviadorMensaje = new EnviadorMensaje(enviadorSMS);
           //EnviadorMensaje enviadorMensaje = new EnviadorMensaje();
            enviadorMensaje.ImplementacionEnviadorMensaje = enviadorSMS;

            enviadorMensaje.EnviarMensaje("buenos dias");
            Console.Read();
        }
    }

    public class EnviadorMensaje
    {
        //constructor
        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        //propiedad
        public IEnviadorMensaje ImplementacionEnviadorMensaje { get; set; }

        private IEnviadorMensaje _enviadorMensaje;

        //metodo que ejecutara metodo
        public void EnviarMensaje(string mensaje)
        {
            //ImplementacionEnviadorMensaje.EnviarMensaje(mensaje);
            _enviadorMensaje.EnviarMensaje(mensaje);
        }
    }

    //interface
    public interface IEnviadorMensaje
    {
        void EnviarMensaje(string mensaje);
    }

    class EnviarMiniMensaje : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando minimensaje");
        }

        public void MetodoPrueba1()
        {
            Console.WriteLine("enviar mensaje random ");
        }

    }
    class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviar correo");
        }
    }



}