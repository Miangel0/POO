
using System;
using System.Collections.Generic;
using System.Text;
using POO.Models; 

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Permite volar por el aire";
poderVolar.Nivel = NivelPoder.NivelTres;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Permite levantar objetos muy pesados";
superFuerza.Nivel = NivelPoder.NivelDos;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "regeneracion";
regeneracion.Descripcion = "Permite regenerar heridas y prolongar la vida";
regeneracion.Nivel = NivelPoder.NivelDos;

var superman = new SuperHeroe(); ;
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";



List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
superman.UsarSuperPoderes();
string resultado = superman.UsarSuperPoderes();
Console.WriteLine(resultado);
string salvarMundo = superman.SalvarElMundo();
Console.WriteLine(salvarMundo);
string salvarTierra = superman.SalvarLaTierra();
Console.WriteLine(salvarTierra);

var Wolverine = new AntiHeroe();
Wolverine.Id = 2;
Wolverine.Nombre = "Wolverine";
Wolverine.IdentidadSecreta = "Logan";
Wolverine.Ciudad = "Toronto";

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(superFuerza);
poderesWolverine.Add(regeneracion);
Wolverine.SuperPoderes = poderesWolverine;
Wolverine.UsarSuperPoderes();
string resultadoWolverine = Wolverine.UsarSuperPoderes();
Console.WriteLine(resultadoWolverine);

string accionWolverine = Wolverine.AccionAntiHeroe("Atacar a la policia");
Console.WriteLine(accionWolverine);
enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}

public record SuperHeroeRecord(int Id, string Nombre, string IdentidadSecreta, string Ciudad, bool PuedeVolar); 