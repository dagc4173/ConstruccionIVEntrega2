namespace Pokemon.src;

class Program
{
    static void Main()
    {
        Pokemon pokemon1 = new Pokemon("Pikachu", "Eléctrico", new int[] { 30, 35, 40 }, 20);
        PokemonEspecial pokemon2 = new PokemonEspecial("Charizard", "Fuego", new int[] { 35, 40, 30 }, 30);

        int puntajePokemon1 = 0;
        int puntajePokemon2 = 0;

        for (int i = 0; i < 3; i++)
        {
            int ataque1 = pokemon1.Atacar();
            int ataque2 = pokemon2.Atacar();

            double defensa1 = pokemon1.Defenderte();
            double defensa2 = pokemon2.Defenderte();

            puntajePokemon1 += (int)(ataque1 - defensa2);
            puntajePokemon2 += (int)(ataque2 - defensa1);

            Console.WriteLine($"{pokemon1.Nombre} Ataque: {ataque1} Defensa: {defensa1} puntaje final: {puntajePokemon1}");
            Console.WriteLine($"{pokemon2.Nombre} Ataque: {ataque2} Defensa: {defensa2} puntaje final: {puntajePokemon2} \n");
        }

        if (puntajePokemon1 > puntajePokemon2)
        {
            Console.WriteLine($"Gana {pokemon1.Nombre}");
        }
        else if (puntajePokemon2 > puntajePokemon1)
        {
            Console.WriteLine($"Gana {pokemon2.Nombre}");
        }
        else
        {
            Console.WriteLine("Empate");
        }
    }
}
