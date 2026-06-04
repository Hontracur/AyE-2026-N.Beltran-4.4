
// Programa 6: Buscador de tesoros

int[,] matriz = new int[10, 10];
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        matriz[i, j] = 0;
    }
}
for (int i = 0; i < 10; i++)
{
    int x = random.Next(0, 10);
    int y = random.Next(0, 10);
    if (matriz[x, y] == 0)
    {
        matriz[x, y] = 1;
    }
    else
    {
        i--;
    }
}
int intentos = 5;
int tesorosEncontrados = 0;

Console.WriteLine("");
Console.WriteLine("Bienvenido al buscador de tesoros, tienes 5 intentos para encontrar los 3 tesoros escondidos");
Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

while (intentos > 0 && tesorosEncontrados < 3)
{
    Console.WriteLine("");
    Console.WriteLine("Ingresa las coordenadas para buscar un tesoro (por ej: 1 2... sin comas, solo deja un espacio): ");
    string[] input = Console.ReadLine().Split(' ');
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    if (matriz[x, y] == 1)
    {
        Console.WriteLine("¡Encontraste un tesoro!");
        tesorosEncontrados++;
        intentos = 5;
        matriz[x, y] = 0;
    }
    else
    {
        Console.WriteLine("No encontraste nada.");
        intentos--;
        Console.WriteLine("Te quedan: " + intentos + " intentos.");
    }
}
if (tesorosEncontrados == 1)
{
    Console.WriteLine("Cantidad que encontraste " + tesorosEncontrados + " tesoro.");
}
else
{
    Console.WriteLine("Cantidad que encontraste " + tesorosEncontrados + " tesoros.");
}