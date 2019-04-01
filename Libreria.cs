using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    public class Libreria
    {
        public string nombre;
        public string direccion;
        public List<Libro> libros;
        public List<Juego> juegos;
        public List<VentaJuego> ventaJuegos;
        public List<VentaLibro> ventaLibros;

        public Libreria(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            libros = new List<Libro>();
            juegos = new List<Juego>();
            ventaJuegos = new List<VentaJuego>();
            ventaLibros = new List<VentaLibro>();
        }

        public bool VenderLibro(Libro libro, Persona persona) {
            if (libro.stock < 1) {
                return false;
            }

            libro.stock -= 1;
            ventaLibros.Add(new VentaLibro(libro, persona));

            return true;
        }

        public bool VenderJuego(Juego juego, Persona persona)
        {
            if (juego.stock < 1)
            {
                return false;
            }

            juego.stock -= 1;
            ventaJuegos.Add(new VentaJuego(juego, persona));

            return true;
        }

        public int ObtenerCantidadDeVentas() {
            return ventaJuegos.Count + ventaLibros.Count;
        }

        public int ObtenerMontoDeVentas() {
            int montoVentas = 0;

            foreach(VentaJuego venta in ventaJuegos) {
                montoVentas += venta.juego.precio;
            }

            foreach (VentaLibro venta in ventaLibros)
            {
                montoVentas += venta.libro.precio;
            }

            return montoVentas;
        }
    }
}
