namespace Pokemon.src;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los datos del Pokémon 1:");
        Pokemon pokemon1 = CrearPokemon();

        Console.WriteLine("\nIngrese los datos del Pokémon 2:");
        Pokemon pokemon2 = CrearPokemon();

        int puntajePokemon1 = 0;
        int puntajePokemon2 = 0;

        Console.WriteLine($"\nCombate entre {pokemon1.Nombre} y {pokemon2.Nombre}");

        for (int i = 0; i < 3; i++)
        {
            int ataque1 = pokemon1.Atacar();
            int ataque2 = pokemon2.Atacar();

            double defensa1 = pokemon1.Defenderte();
            double defensa2 = pokemon2.Defenderte();

            puntajePokemon1 += (int)(ataque1 - defensa2);
            puntajePokemon2 += (int)(ataque2 - defensa1);


            Console.WriteLine($"Raum {i+1}");
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

    static Pokemon CrearPokemon()
    {
        string nombre, tipo;
        int[] ataques = new int[3];
        int defensa;

        do
        {
            Console.Write("Nombre del Pokémon: ");
            nombre = Console.ReadLine() ?? "";
        } while (string.IsNullOrEmpty(nombre));

        do
        {
            Console.Write("Tipo del Pokémon: ");
            tipo = Console.ReadLine() ?? "";
        } while (string.IsNullOrEmpty(tipo));

        for (int i = 0; i < 3; i++)
        {
            do
            {
                Console.Write($"Ataque {i + 1}. Debe estar entre 0 y 40: ");
                string ataqueStr = Console.ReadLine() ?? "";
                if (int.TryParse(ataqueStr, out int ataque) && ataque >= 0 && ataque <= 40)
                {
                    ataques[i] = ataque;
                    break; 
                }
                else
                {
                    Console.WriteLine("Valor de ataque no válido. Debe estar entre 0 y 40.");
                }
            } while (true); 
        }

        do
        {
            Console.Write("Defensa del Pokémon. Debe estar entre 10 y 35: ");
            string defensaStr = Console.ReadLine() ?? "";
            if (int.TryParse(defensaStr, out defensa) && defensa >= 10 && defensa <= 35)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Valor de defensa no válido. Debe estar entre 10 y 35.");
            }
        } while (true); 
        
        return new Pokemon(nombre, tipo, ataques, defensa);
    }
    
}
