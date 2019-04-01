using System;
namespace Laboratorio2
{
    public class Juego
    {
        public string nombre;
        public string plataforma;
        public int precio;
        public int stock;

        public Juego(string nombre, string plataforma, int precio, int stock)
        {
            this.nombre = nombre;
            this.plataforma = plataforma;
            this.precio = precio;
            this.stock = stock;
        }

        public string GetDescripcion()
        {
            return "";
        }
    }
}
