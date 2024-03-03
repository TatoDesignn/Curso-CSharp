using Programa2.Models;

SuperPoder superPoder = new SuperPoder();
SuperHereo superHereo = new SuperHereo();
AntiHeroe wolverin = new AntiHeroe();

superPoder.Nombre = "Rayos laser";
superPoder.Descripcion = "Puede sacar un rayo laser de sus ojos";
superPoder.nivel = NivelPoder.NivelTres;

List<SuperPoder> poderes = new List<SuperPoder>();
poderes.Add(superPoder);

superHereo.Id = 1;
superHereo.Nombre = "Superman";
superHereo.IdentidadSecreta = "Clark Kent";
superHereo.Ciudad = "Metropolis";
superHereo.PuedeVolar = true;
superHereo.SuperPoderes = poderes;

wolverin.Id = 2;
wolverin.Nombre = "Wolverin";
wolverin.IdentidadSecreta = "Logan";
wolverin.PuedeVolar = false;

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}