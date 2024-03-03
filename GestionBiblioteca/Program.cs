using GestionBiblioteca.Clases;

class Program
{
    static void Main(string[] args)
    {
        var biblioteca = new Biblioteca();

        var libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez", "123456789");
        var libro2 = new Libro("El principito", "Antoine de Saint-Exupéry", "987654321");

        var usuario1 = new Usuario("Juan Pérez", "1");

        biblioteca.RegistrarLibro(libro1);
        biblioteca.RegistrarLibro(libro2);
        biblioteca.RegistrarUsuario(usuario1);

        biblioteca.PrestarLibro("123456789", "1");
        usuario1.MostrarLibrosPrestados();

        biblioteca.DevolverLibro("123456789", "1");
        usuario1.MostrarLibrosPrestados();
    }
}