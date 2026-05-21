// Ejercicio 1
string[] nombres = {"Ana", "Carlos", "Gabriela", "Luis" };
string largo = nombres[0];

for  (int i = 0; i < nombres.Length; i++)
{
    if (nombres[i].Length > largo.Length)
    {
        largo = nombres[i];
    }
}
Console.WriteLine("El nombre mas largo es: " + largo + " con " + largo.Length + " de caracteres.");

// Ejercicio 2
int totalVocales = 0;
string vocales = "aeiouAEIOU";

for (int x = 0; x < nombres.Length; x++)
{
    for (int z = 0; z < nombres[x].Length; z++)
    {
        if (vocales.Contains(nombres[x][z]))
        {
            totalVocales++;
        }
    }
}
Console.WriteLine("El total de vocales son: " + totalVocales);

// Ejercicio 3

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int factor = 3;
int[] resultado = new int[numeros.Length];

for (int i = 0;i < numeros.Length; i++)
{
    resultado[i] = numeros[i] * factor;
}

Console.WriteLine("Lista original: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i] + " ");
}
Console.WriteLine("Lista multiplicada: ");
for (int i = 0; i < resultado.Length; i++)
{
    Console.WriteLine(resultado[i] + " ");
}
Console.WriteLine("");