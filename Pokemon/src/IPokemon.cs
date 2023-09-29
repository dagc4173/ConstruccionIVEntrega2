namespace Pokemon.src;

using System;
using System.Collections.Generic;

public interface IPokemon
{
    string Nombre { get; }
    string Tipo { get; }
    int[] Ataques { get; }
    int Defensa { get; }
    int Atacar();
    double Defenderte();
}

public abstract class PokemonBase : IPokemon
{
    public string Nombre { get; private set; }
    public string Tipo { get; private set; }
    public int[] Ataques { get; private set; }
    public int Defensa { get; private set; }

    protected PokemonBase(string nombre, string tipo, int[] ataques, int defensa)
    {
        Nombre = nombre;
        Tipo = tipo;
        Ataques = ataques;
        Defensa = defensa;
    }

    public abstract int Atacar();
    public abstract double Defenderte();
}
