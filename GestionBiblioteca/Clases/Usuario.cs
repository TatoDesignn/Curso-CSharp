using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Clases
{
    internal class Usuario
    {
        private string nombre;
        private string id;
        private List<Libro> librosPrestados;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public List<Libro> LibrosPrestados
        {
            get { return librosPrestados; }
        }

        public Usuario(string nombre, string id)
        {
            this.nombre = nombre;
            this.id = id;
            librosPrestados = new List<Libro>();
        }

        public void PrestarLibro(Libro libro)
        {
            if (libro.disponible) // Asumiendo que cambias `disponible` a una propiedad.
            {
                libro.Prestar();
                librosPrestados.Add(libro);
            }
        }

        public void DevolverLibro(Libro libro)
        {
            if (librosPrestados.Remove(libro))
            {
                libro.Devolver();
            }
        }

        public void MostrarLibrosPrestados()
        {
            Console.WriteLine($"Libros prestados por {nombre}:");
            foreach (var libro in librosPrestados)
            {
                libro.MostrarInformacion();
            }
        }
    }
}
