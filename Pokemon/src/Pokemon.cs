namespace Pokemon.src;

public class Pokemon : PokemonBase
{
    public Pokemon(string nombre, string tipo, int[] ataques, int defensa)
        : base(nombre, tipo, ataques, defensa)
    {
    }

    public override int Atacar()
    {
        Random random = new Random();
        int ataqueSeleccionado = random.Next(0, Ataques.Length);
        int puntaje = Ataques[ataqueSeleccionado] * (random.Next(0, 2)); // Multiplicar por 0 o 1
        return puntaje;
    }

    public override double Defenderte()
    {
        return Defensa * 0.5; // Multiplicar por 0.5
    }
}
