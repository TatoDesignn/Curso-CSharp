using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehiculo.Clases
{
    internal class Camion: Vehiculo
    {
        public int CapacidadCarga {  get; set; }

        public Camion(string marca, string modelo, int año, int capacidadCarga) : base(marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override decimal CalcularImpuesto()
        {
            decimal valor = 200;
            decimal porcentaje = valor * 0.05m;

            while(CapacidadCarga >= 0 && CapacidadCarga < 1000)
            {
                valor += porcentaje;
            }

            return valor;
        }
    }
}
