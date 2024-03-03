using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleados.Clases
{
    internal class Departamento
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        private List<Empleado> ListaEmpleado;

        public Departamento(string nombre, string codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
            ListaEmpleado = new List<Empleado>();    
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleado.Add(empleado);
        }

        public void ListarEmpleados()
        {
            int contandor = 1;
            Console.WriteLine($"\nDepartamento: {Nombre} - Código: {Codigo}");

            foreach (Empleado empleado in ListaEmpleado) 
            { 
                Console.WriteLine($"{contandor}. {empleado}"); 
                contandor++;
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
