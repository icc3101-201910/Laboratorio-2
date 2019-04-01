using System;
namespace Laboratorio2
{
    public class Libreria
    {
        public string nombre;
        public string direccion;


        public Libreria(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public bool VenderLibro(Libro libro, Persona persona) {
            return false;
        }

        public bool VenderJuego(Juego juego, Persona persona)
        {
            return false;
        }

        public int ObtenerCantidadDeVentas() {
            return 0;
        }

        public int ObtenerMontoDeVentas() {
            return 0;
        }
    }
}
