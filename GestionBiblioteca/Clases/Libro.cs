using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBiblioteca.Clases
{
    internal class Libro //clase
    {
        public string titulo, autor, isbn;
        public bool disponible;

        public Libro(string titulo, string autor, string isbn) //constructor
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            disponible = true;
        }

        public string Titulo //encapsule
        {  
            get { return titulo; }
            set { titulo = value.Trim(); }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value.Trim(); }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value.Trim(); }
        }

        public void Prestar()
        {
            if (disponible)
            {
                disponible = false;
                Console.WriteLine($"El libro {titulo} ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro {titulo} no esta disponible");
            }
        }

        public void Devolver()
        {
            disponible = true;
            Console.WriteLine($"El libro {titulo} ha sido devuelto.");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Titulo: {titulo} \nAutor: {Autor} \nISBN: {isbn} \nDisponible: {disponible}");
        }
    }
}
