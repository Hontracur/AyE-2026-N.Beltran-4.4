// Simulacro de matrices

Console.WriteLine("Ejercicio 1:");
Console.WriteLine("El objetivo es generar una plantilla de 23 jugadores con sus posiciones y calcular el valor total de puntos de rendimiento del equipo.");
Console.WriteLine("");

int numJugadores = 23;
string[] posiciones = { "Delantero", "Mediocampista", "Defensor", "Arquero" };
string[] nombres = { "Federico" + "Juan", "Pedro", "Luis", "Carlos", "Miguel", "Sergio", "Diego", "Fernando", "Jorge", "Andrés", "Lucas", "Pepe", "Etesech", "Goku", "Vegeta", "German", "Fernanfloo", "MrBeast", "It", "Garfield", "Coraje", "ScoobyDoo", "Shaggy", "Batman", "Anomalo", "Lisandro", "Kevin" + "Cesar" + "Ramiro" + "Ojeda" + "Matias" + "Nico" + "Benja" + "Davo" + "LaCobra"};

Random rand = new Random();
for (int i = 0; i < numJugadores; i++)
    {
    string nombre = nombres[rand.Next(nombres.Length)];
    int valoracion = rand.Next(50, 101);
    string posicion = posiciones[rand.Next(posiciones.Length)];
    Console.WriteLine("Jugador " + (i + 1) + ": " + nombre + ", " + "Valoración: " + valoracion + ", " + "Posición: " + posicion);
}
Console.WriteLine("");

int valoracionTotalEquipo1 = 0;
int valoracionTotalEquipo2 = 0;
for (int i = 0;i < numJugadores;i++)
    {
    valoracionTotalEquipo1 += rand.Next(50, 101);
    valoracionTotalEquipo2 += rand.Next(50, 101);
}
Console.WriteLine("Valoración total del equipo 1: " + valoracionTotalEquipo1);
Console.WriteLine("Valoración total del equipo 2: " + valoracionTotalEquipo2);
Console.WriteLine("");
Console.WriteLine("El equipo con mayor valoración total tiene más chances de ganar. " +
    (valoracionTotalEquipo1 > valoracionTotalEquipo2 ? "Equipo 1 tiene más chances de ganar." : "Equipo 2 tiene más chances de ganar.")
);
Console.WriteLine("");

Console.WriteLine("Ejercicio 2:");
Console.WriteLine("Hacer un programa que usando una función recursiva muestre la potencia por un numero elegido de un numero elegido por el usuario.");

int numero(int baseNum, int exponente)
{
    if (exponente == 0)
        return 1;
    else
        return baseNum * numero(baseNum, exponente - 1);
}

    Console.Write("Ingrese cualquier numero: ");
    int baseNum = int.Parse(Console.ReadLine());

    Console.WriteLine("");
    Console.Write("Ingrese una potencia: ");
    int exponente = int.Parse(Console.ReadLine());

    int resultado = numero(baseNum, exponente);
    Console.WriteLine(baseNum + " elevado a " + exponente + " es igual a: " + resultado);
    Console.WriteLine("");

    return resultado;
