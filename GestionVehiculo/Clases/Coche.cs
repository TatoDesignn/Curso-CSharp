using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionVehiculo.Clases
{
    internal class Coche: Vehiculo
    {
        public bool EsLujo {  get; set; }
        
        public Coche(string marca, string modelo, int año, bool esLujo) : base(marca, modelo, año)
        {
            EsLujo = esLujo;
        }

        public override decimal CalcularImpuesto()
        {
            decimal valor = 100;
            if (EsLujo)
            {
                decimal porcentaje = 100m * 0.5m;
                valor += porcentaje;
            }
            return valor;
        }
    }
}
