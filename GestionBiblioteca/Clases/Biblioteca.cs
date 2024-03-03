using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionBiblioteca.Clases
{
    internal class Biblioteca
    {
        private List<Libro> libros = new List<Libro>();
        private List<Usuario> usuarios = new List<Usuario>();

        public void RegistrarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void PrestarLibro(string isbn, string idUsuario)
        {
            var libro = libros.FirstOrDefault(l => l.Isbn == isbn); // Cambiado de ISBN a Isbn
            var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);

            if (libro != null && usuario != null && libro.disponible) // Nota el cambio aquí también
            {
                usuario.PrestarLibro(libro);
                Console.WriteLine($"El libro '{libro.Titulo}' ha sido prestado a {usuario.Nombre}.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el préstamo.");
            }
        }

        public void DevolverLibro(string isbn, string idUsuario)
        {
            var libro = libros.FirstOrDefault(l => l.Isbn == isbn); // Cambiado de ISBN a Isbn
            var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);

            if (libro != null && usuario != null)
            {
                usuario.DevolverLibro(libro);
            }
        }
    }
}
