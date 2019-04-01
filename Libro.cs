using System;
namespace Laboratorio2
{
    public class Libro
    {
        public string nombre;
        public string autor;
        public int precio;
        public int stock;

        public Libro(string nombre, string autor, int precio, int stock)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.precio = precio;
            this.stock = stock;
        }

        public string GetDescripcion() {
            return "";
        }
    }
}
