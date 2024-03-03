using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionEmpleados.Clases
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Puesto { get; set; }
        public decimal Salario { get; set; }

        public Empleado(int id, string name, string puesto, decimal salario)
        {
            Id = id;
            Name = name;
            Puesto = puesto;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Name}, Puesto: {Puesto}, Salario: {Salario:C}";
        }
    }
}
