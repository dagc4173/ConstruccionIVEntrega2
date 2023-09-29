namespace Jugador.src;

public class Equipo
{
    private List<IJugador> jugadores;

    public Equipo()
    {
        jugadores = new List<IJugador>();
    }

    public void AgregarJugador(IJugador jugador)
    {
        jugadores.Add(jugador);
    }

    public int CalcularPuntajeTotal()
    {
        int puntajeTotal = 0;
        foreach (var jugador in jugadores)
        {
            puntajeTotal += jugador.Rendimiento;
        }
        return puntajeTotal;
    }
}