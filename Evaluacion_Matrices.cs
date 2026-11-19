// Evaluación Matrices y Recursividad:
// Torneo Pokemon:

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("EJERCICIO 1: ");
Console.WriteLine("");

int pokemones = 6;
string[] nombrePokemon = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
string[] Tipos = { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };

Random random = new Random();

// Fila 0: nombre del equipo (solo columna 0). Filas 1 a 6: los Pokémon.
string[,] Red = new string[pokemones + 1, 3];
string[,] Green = new string[pokemones + 1, 3];
string[,] Blue = new string[pokemones + 1, 3];
string[,] Yellow = new string[pokemones + 1, 3];

void CrearEquipo(string[,] equipo, string nombreEquipo)
{
    equipo[0, 0] = nombreEquipo;

    for (int i = 1; i <= pokemones; i++)
    {
        int index = random.Next(nombrePokemon.Length);
        equipo[i, 0] = nombrePokemon[index];
        equipo[i, 1] = Tipos[index];
        equipo[i, 2] = random.Next(50, 100).ToString();
    }
}

void MostrarEquipo(string[,] equipo)
{
    Console.WriteLine("Equipo " + equipo[0, 0] + ":");
    Console.WriteLine("");
    Console.WriteLine("Nombre | Tipo | Nivel");
    Console.WriteLine("");

    for (int i = 1; i <= pokemones; i++)
    {
        Console.WriteLine(equipo[i, 0] + " | " + equipo[i, 1] + " | " + equipo[i, 2]);
    }

    Console.WriteLine("");
}

int CalcularNivel(string[,] equipo)
{
    int nivelTotal = 0;
    for (int i = 1; i <= pokemones; i++)
    {
        nivelTotal += int.Parse(equipo[i, 2]);
    }
    return nivelTotal;
}

// Devuelve la matriz del equipo con mayor nivel total
string[,] Ganador(string[,] equipoA, string[,] equipoB)
{
    return CalcularNivel(equipoA) > CalcularNivel(equipoB) ? equipoA : equipoB;
}

CrearEquipo(Red, "Rojo");
CrearEquipo(Green, "Verde");
CrearEquipo(Blue, "Azul");
CrearEquipo(Yellow, "Amarillo");

MostrarEquipo(Red);
MostrarEquipo(Green);
MostrarEquipo(Blue);
MostrarEquipo(Yellow);

Console.WriteLine("Resultados de los equipos:");
Console.WriteLine("");

Console.WriteLine("Nivel Total del Equipo " + Red[0, 0] + ": " + CalcularNivel(Red));
Console.WriteLine("Nivel Total del Equipo " + Green[0, 0] + ": " + CalcularNivel(Green));
Console.WriteLine("Nivel Total del Equipo " + Blue[0, 0] + ": " + CalcularNivel(Blue));
Console.WriteLine("Nivel Total del Equipo " + Yellow[0, 0] + ": " + CalcularNivel(Yellow));
Console.WriteLine("");

string[,] ganadorRG = Ganador(Red, Green);
string[,] ganadorBY = Ganador(Blue, Yellow);
string[,] ganadorTorneo = Ganador(ganadorRG, ganadorBY);

Console.WriteLine("Ganador entre " + Red[0, 0] + " y " + Green[0, 0] + ": " + ganadorRG[0, 0]);
Console.WriteLine("Ganador entre " + Blue[0, 0] + " y " + Yellow[0, 0] + ": " + ganadorBY[0, 0]);
Console.WriteLine("Ganador del torneo: " + ganadorTorneo[0, 0]);

// Funcion Recursiva:
Console.WriteLine("");
Console.WriteLine("EJERCICIO 2: Funcion Recursiva");
Console.WriteLine("De 50 a 0 de 5 en 5");

void Contador(int numero)
{
    if (numero < 0)
    {
        return;
    }
    Console.WriteLine(numero);
    Contador(numero - 5);
}
Contador(50);
