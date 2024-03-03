using GestionVehiculo.Clases;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Vehiculo> vehiculosList = new List<Vehiculo>();
        string temp;
        int dato = 0;

        Console.WriteLine("Bienvenido al Consecionario TatoCar!");

        do
        {
            Console.WriteLine("\nOpciones: \n1.Añadir Vehiculo \n2.Ver listado \n3.Salir");
            Console.Write("\nIngresa el numero: ");
            temp = Console.ReadLine();

            if(int.TryParse(temp, out dato))
            {
                if(dato == 1)
                {
                    Añadir();
                }
                else if(dato == 2)
                {
                    Listado();
                }
                else if( dato == 3)
                {
                    Console.WriteLine("Saliste con exito!");
                }
            }
            else
            {
                Console.WriteLine("Debes ingresar un numero!");
            }
        } while (dato != 3);

        void Añadir()
        {
            Console.Write("\nCuantos vehiculos deseas añadir: ");
            int contadorVehiculos = int.Parse(Console.ReadLine());

            for(int i = 0; i< contadorVehiculos; i++)
            {
                Console.Write("\nCual es la marca: ");
                string marca = Console.ReadLine();

                Console.Write("\nCual es el modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("\nCual es el año: ");
                int año = int.Parse(Console.ReadLine());

                Console.WriteLine("Que tipo de vehiculo es: \n1.Coche \n2.Motocicleta \n3.Camion");
                Console.Write("\nIngresa el numero: ");
                int tipoVehiculo = int.Parse(Console.ReadLine());

                if(tipoVehiculo == 1)
                {
                    Console.Write("Es un coche lujoso: ");
                    string respuestaLujoso = Console.ReadLine();

                    if(respuestaLujoso == "si")
                    {
                        Coche nuevoAuto = new Coche(marca,modelo,año,true);
                        vehiculosList.Add(nuevoAuto);
                    }
                    else
                    {
                        Coche nuevoAuto = new Coche(marca, modelo, año, false);
                        vehiculosList.Add(nuevoAuto);
                    }
                }
                else if(tipoVehiculo == 2)
                {
                    Console.Write("\nCual es el cilindraje: ");
                    int cilindraje = int.Parse(Console.ReadLine());

                    Motocicleta nuevoAuto = new Motocicleta(marca, modelo, año, cilindraje);
                    vehiculosList.Add(nuevoAuto);
                }
                else if(tipoVehiculo == 3)
                {
                    Console.Write("\nCuanto es la capacidad de carga: ");
                    int capacidadCarga = int.Parse(Console.ReadLine());

                    Camion nuevoAuto = new Camion(marca, modelo, año, capacidadCarga);
                    vehiculosList.Add(nuevoAuto);
                }
                Console.WriteLine("Agregado exitosamente!");
            }
        }

        void Listado()
        {
            foreach(Vehiculo vehiculo in vehiculosList)
            {
                Console.WriteLine($"{vehiculo} - {vehiculo.CalcularImpuesto()}");
            }
        }
    }
}