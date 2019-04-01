using System;
namespace Laboratorio2
{
    public class VentaLibro
    {
        public Libro libro;
        public Persona persona;

        public VentaLibro(Libro libro, Persona persona)
        {
            this.libro = libro;
            this.persona = persona;
        }

        public string GetDescripcion()
        {
            return $"{libro.precio} - {libro.GetDescripcion()} - {persona.rut}";
        }
    }
}
