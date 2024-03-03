using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculo.Clases
{
    internal class Vehiculo
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        public Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public virtual decimal CalcularImpuesto()
        {
            return 00;
        }

        public override string ToString()
        {
            return $"Marca: {Marca} - Modelo: {Modelo} - Año {Año}";
        }
    }
}
