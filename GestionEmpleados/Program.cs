
using GestionEmpleados.Clases;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Departamento> departamentos = new List<Departamento>();
        int respuesta = 0;
        Console.WriteLine("Bienvenido al gestor de empleados y departamentos!");

        do
        {
            Console.WriteLine("\nOpciones!\n1. Añadir Departamento \n2. Añadir Empleado \n3. Mostrar Departamentos y Empleados \n4. Salir");
            Console.Write("\nIngresa el numero: ");
            respuesta = int.Parse(Console.ReadLine());

            if (respuesta == 1)
            {
                Departamentos();
            }
            else if (respuesta == 2)
            {
                Empleados();
            }
            else if (respuesta == 3)
            {
                Mostrar();
            }
            else if(respuesta == 4)
            {
                Console.WriteLine("Saliste con exito!");
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta");
            }

        } while (respuesta != 4);


        void Departamentos()
        {
            Console.Write("\nCuantos departamentos desea añadir: ");
            int cantidadDepartamentos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadDepartamentos; i++)
            {
                Console.Write($"\nNombre del {i + 1} departamendo: ");
                string nombreDepartamento = Console.ReadLine();

                Console.Write($"\nCodigo del {i + 1} departamento: ");
                string codigoDepartamento = Console.ReadLine();

                departamentos.Add(new Departamento(nombreDepartamento, codigoDepartamento));
            }
        }

        void Empleados()
        {
            Console.Write("\nCuantos empleados desea agregar: ");
            int cantidadEmpleados = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write("\nCual es el nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("\nCual es el puesto: ");
                string puesto = Console.ReadLine();

                Console.Write("\nCual es el salario: ");
                decimal salario = decimal.Parse(Console.ReadLine());

                Empleado nuevoEmpleado = new Empleado(i + 1, nombre, puesto, salario);

                Console.WriteLine("\nCual departamento desea añadirlo ingrese el numero: ");
                for (int j = 0; j < departamentos.Count; j++)
                {
                    Console.WriteLine($"{j + 1}. {departamentos[j].Nombre}");
                }
                int departamentoDeseado = int.Parse(Console.ReadLine()) - 1;

                departamentos[departamentoDeseado].AgregarEmpleado(nuevoEmpleado);
            }
        }

        void Mostrar()
        {
            foreach (Departamento departamento in departamentos)
            {
                departamento.ListarEmpleados();
                Console.WriteLine();
            }
        }


    }


}