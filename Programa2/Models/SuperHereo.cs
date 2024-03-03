using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2.Models
{
    class SuperHereo
    {
        public int Id;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        public SuperHereo() //Constructor
        {
            SuperPoderes = new List<SuperPoder>();
        }
    }
}
