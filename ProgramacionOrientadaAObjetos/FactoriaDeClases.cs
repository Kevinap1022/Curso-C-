using System;

namespace PracticaCursoSichar
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaz que ejecuta el metodo de una clase 
            IEnviadorMensaje enviadorMensajeDependencia = FactoriaEnviadorCorreo.Factoria("sms");
            EnviadorMensaje enviadorMensaje = new EnviadorMensaje(enviadorMensajeDependencia);
            enviadorMensaje.EnviarMensaje("un mensaje");
            Console.Read();


            Console.Read();
        }
    }

    public static class FactoriaEnviadorCorreo
    {
        //clase que implemente la interface IEnviadorMensaje
        public static IEnviadorMensaje Factoria(string parametro)
        {
            if( parametro == "sms")
            {
                return new EnviarMiniMensaje();
            }
            else if(parametro == "correo")
            {
                return new EnviarCorreo();
            }

            throw new ApplicationException();
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