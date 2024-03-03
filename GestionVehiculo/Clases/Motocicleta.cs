using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestionVehiculo.Clases
{
    internal class Motocicleta: Vehiculo
    {
        public int Cilindraje {  get; set; }

        public Motocicleta(string marca, string modelo, int año, int cilindraje) : base(marca, modelo, año)
        {
            Cilindraje = cilindraje;
        }

        public override decimal CalcularImpuesto()
        {
            decimal valor = 50;

            if(Cilindraje > 500)
            {
                decimal porcentaje = 50 * 0.1m;
                valor += porcentaje;
            }

            return valor;
        }
    }
}
