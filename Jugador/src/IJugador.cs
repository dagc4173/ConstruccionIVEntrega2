namespace Jugador.src;

using System;
using System.Collections.Generic;

interface IJugador
{
    string Nombre { get; }
    string Posicion { get; }
    int Rendimiento { get; }
}

class Jugador : IJugador
{
    public string Nombre { get; private set; }
    public string Posicion { get; private set; }
    public int Rendimiento { get; private set; }

    public Jugador(string nombre, string posicion, int rendimiento)
    {
        Nombre = nombre;
        Posicion = posicion;
        Rendimiento = rendimiento;
    }
}