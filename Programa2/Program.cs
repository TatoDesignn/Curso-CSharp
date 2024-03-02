SuperPoder superPoder = new SuperPoder();
SuperHereo superHereo = new SuperHereo();

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

class SuperHereo
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;

}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder nivel;

}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}