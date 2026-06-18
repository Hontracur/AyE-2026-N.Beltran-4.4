// Evaluación Matrices y Recursividad:
// Torneo Pokemon:

Console.WriteLine("EJERCICIO 1: ");
Console.WriteLine("");

int pokemones = 6;
string[] nombrePokemon = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
string[] Tipos = { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };

Random random = new Random();

string[,] Red = new string[pokemones, 3];
string[,] Green = new string[pokemones, 3];
string[,] Blue = new string[pokemones, 3];
string[,] Yellow = new string[pokemones, 3];

void CrearEquipo(string[,] equipo)
{
    for (int i = 0; i < pokemones; i++)
    {
        int index = random.Next(nombrePokemon.Length);
        equipo[i, 0] = nombrePokemon[index];
        equipo[i, 1] = Tipos[index];
        equipo[i, 2] = random.Next(50, 81).ToString();
    }
}

CrearEquipo(Red);
CrearEquipo(Green);
CrearEquipo(Blue);
CrearEquipo(Yellow);

Console.WriteLine("Equipo Rojo:");
Console.WriteLine("");
Console.WriteLine("Nombre | Tipo | Nivel");
Console.WriteLine("");

for (int i = 0; i < pokemones; i++)
{
    Console.WriteLine(Red[i, 0] + " | " + Red[i, 1] + " | " + Red[i, 2]);
}

Console.WriteLine("");
Console.WriteLine("Equipo Verde:");
Console.WriteLine("");
Console.WriteLine("Nombre | Tipo | Nivel");
Console.WriteLine("");

for (int i = 0; i < pokemones; i++)
{
    Console.WriteLine(Green[i, 0] + " | " + Green[i, 1] + " | " + Green[i, 2]);
}

Console.WriteLine("");
Console.WriteLine("Equipo Azul:");
Console.WriteLine("");
Console.WriteLine("Nombre | Tipo | Nivel");
Console.WriteLine("");

for (int i = 0; i < pokemones; i++)
{
    Console.WriteLine(Blue[i, 0] + " | " + Blue[i, 1] + " | " + Blue[i, 2]);
}

Console.WriteLine("");
Console.WriteLine("Equipo Amarillo:");
Console.WriteLine("");
Console.WriteLine("Nombre | Tipo | Nivel");
Console.WriteLine("");

for (int i = 0; i < pokemones; i++)
{
    Console.WriteLine(Yellow[i, 0] + " | " + Yellow[i, 1] + " | " + Yellow[i, 2]);
}

for (int i = 0; i < pokemones; i++)
    Console.WriteLine("");

int CalcularNivel(string[,] equipo)
    {
    int nivelTotal = 0;
    for (int i = 0; i < pokemones; i++)
    {
        nivelTotal += int.Parse(equipo[i, 2]);
    }
    return nivelTotal;
}

Console.WriteLine("Resultados de los equipos:");
Console.WriteLine("");

int nivelRed = CalcularNivel(Red);
int nivelGreen = CalcularNivel(Green);
int nivelBlue = CalcularNivel(Blue);
int nivelYellow = CalcularNivel(Yellow);

Console.WriteLine("Nivel Total del Equipo Rojo: " + nivelRed);
Console.WriteLine("Nivel Total del Equipo Verde: " + nivelGreen);
Console.WriteLine("Nivel Total del Equipo Azul: " + nivelBlue);
Console.WriteLine("Nivel Total del Equipo Amarillo: " + nivelYellow);
Console.WriteLine("");

Console.WriteLine("Ganador entre Rojo y Verde: " + (nivelRed > nivelGreen ? "Rojo" : "Verde"));
Console.WriteLine("Ganador entre Azul y Amarillo: " + (nivelBlue > nivelYellow ? "Azul" : "Amarillo"));

string ganadorTorneo = "";

if (nivelRed > nivelGreen && nivelRed > nivelBlue && nivelRed > nivelYellow)
{
    ganadorTorneo = "Rojo";
}

else if (nivelGreen > nivelRed && nivelGreen > nivelBlue && nivelGreen > nivelYellow)
{
    ganadorTorneo = "Verde";
}

else if (nivelBlue > nivelRed && nivelBlue > nivelGreen && nivelBlue > nivelYellow)
{
    ganadorTorneo = "Azul";
}

else
{
    ganadorTorneo = "Amarillo";
}

Console.WriteLine("Ganador del torneo: " + ganadorTorneo);

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