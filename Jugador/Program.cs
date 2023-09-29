namespace Jugador.src;

class Program
{
    static void Main()
    {
        // Crear una lista de jugadores registrados
        List<IJugador> jugadoresRegistrados = new List<IJugador>
        {
            new Jugador("Jugador1", "ANDRES", 8),
            new Jugador("Jugador2", "JULIAN", 7),
            new Jugador("Jugador3", "DAVID", 9),
            new Jugador("Jugador4", "JOSUE", 6),
            new Jugador("Jugador5", "SERGIO", 7),
            new Jugador("Jugador6", "ADRIAN", 8)
        };

        Equipo equipo1 = new Equipo();
        Equipo equipo2 = new Equipo();

        Random random = new Random();
        while (jugadoresRegistrados.Count > 0)
        {
            int index = random.Next(jugadoresRegistrados.Count);
            IJugador jugadorSeleccionado = jugadoresRegistrados[index];
            if (equipo1.CalcularPuntajeTotal() <= equipo2.CalcularPuntajeTotal())
            {
                equipo1.AgregarJugador(jugadorSeleccionado);
            }
            else
            {
                equipo2.AgregarJugador(jugadorSeleccionado);
            }
            jugadoresRegistrados.RemoveAt(index);
        }

        int puntajeEquipo1 = equipo1.CalcularPuntajeTotal();
        int puntajeEquipo2 = equipo2.CalcularPuntajeTotal();

        Console.WriteLine("Equipo 1 - Puntaje Total: " + puntajeEquipo1);
        Console.WriteLine("Equipo 2 - Puntaje Total: " + puntajeEquipo2);

        if (puntajeEquipo1 > puntajeEquipo2)
        {
            Console.WriteLine("EL EQUIPO N1 GANA");
        }
        else if (puntajeEquipo1 < puntajeEquipo2)
        {
            Console.WriteLine("EL EQUIPO N2 GANA ");
        }
        else
        {
            Console.WriteLine("EMPATE");
        }
    }
}
