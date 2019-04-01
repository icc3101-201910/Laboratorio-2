using System;
namespace Laboratorio2
{
    public class VentaJuego
    {
        public Juego juego;
        public Persona persona;

        public VentaJuego(Juego juego, Persona persona)
        {
            this.juego = juego;
            this.persona = persona;
        }

        public string GetDescripcion()
        {
            return "";
        }
    }
}
