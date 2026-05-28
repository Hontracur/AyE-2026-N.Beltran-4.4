//Trabajo Practico N14: Seguimos trabajando con vectores
// Ejercicio 1:
Console.WriteLine("");
Console.WriteLine("Ejercicio 1: ");
Console.WriteLine("");
int[] numeros = new int[5];
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Ingrese un número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Los números ingresados son: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// Ejercicio 2:
Console.WriteLine("");
Console.WriteLine("Ejercicio 2: ");
Console.WriteLine("");
string[] frutas = { "Manzana", "Banana", "Naranja", "Pera", "Uva" };

Console.WriteLine("Ingrese el nombre de la fruta: ");
string frutaBuscada = Console.ReadLine();

int indice = -1;
for (int i = 0; i < frutas.Length; i++)
{
    if (frutas[i] == frutaBuscada)
    {
        indice = i;
        break;
    }
}
if (indice != -1)
{
    Console.WriteLine("La fruta " + frutaBuscada + " se encuentra en la posición " + indice);
}
else
{
    Console.WriteLine("La fruta " + frutaBuscada + " no fue encontrada en la lista.");
}

// Ejercicio 3:
Console.WriteLine("");
Console.WriteLine("Ejercicio 3: ");
Console.WriteLine("");
int[] notas = new int[10];
for (int i = 0;i < 10;i++)
    {
    Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + ": ");
    notas[i] = int.Parse(Console.ReadLine());
}
int suma = 0;
for (int i = 0; i < notas.Length; i++)
{
    suma += notas[i];
}
double promedio = (double)suma / notas.Length;
Console.WriteLine("La suma total de las notas es: " + suma);
Console.WriteLine("El promedio de las notas es: " + promedio);

//Ejercicio 4:
Console.WriteLine("");
Console.WriteLine("Ejercicio 4: ");
Console.WriteLine("");
int[] temperaturas = new int[7];
for (int i = 0; ; i++)
    {
    Console.WriteLine("Ingrese la temperatura del día " + (i + 1) + ": ");
    temperaturas[i] = int.Parse(Console.ReadLine());
    if (i == temperaturas.Length - 1)
    {
        break;
    }
}
int tempMaxima = temperaturas[0];
for (int i = 1; i < temperaturas.Length; i++)
{
    if (temperaturas[i] > tempMaxima)
    {
        tempMaxima = temperaturas[i];
    }
}
int tempMinima = temperaturas[0];
for (int i = 1; i < temperaturas.Length; i++)
{
    if (temperaturas[i] < tempMinima)
    {
        tempMinima = temperaturas[i];
    }
}
Console.WriteLine("La temperatura máxima registrada es: " + tempMaxima);
Console.WriteLine("La temperatura mínima registrada es: " + tempMinima);

// Ejercicio 5:
Console.WriteLine("");
Console.WriteLine("Ejercicio 5: ");
Console.WriteLine("");
Console.WriteLine("Ingrese la cantidad de números a ordenar: ");
int cantidadNumeros = int.Parse(Console.ReadLine());
int[] numerosDesordenados = new int[cantidadNumeros];
for (int i = 0; i < cantidadNumeros; i++)
{
    Console.WriteLine("Ingrese el número " + (i + 1) + ": ");
    numerosDesordenados[i] = int.Parse(Console.ReadLine());
}
Array.Sort(numerosDesordenados); 
Console.WriteLine("Los números ordenados son: ");
for (int i = 0; i < numerosDesordenados.Length; i++)
{
    Console.WriteLine(numerosDesordenados[i]);
}

// Ejercicio 6:
Console.WriteLine("");
Console.WriteLine("Ejercicio 6: ");
Console.WriteLine("");
int[] numerosEnteros = new int[15];
for (int i = 0; i < numerosEnteros.Length; i++)
{
    Console.WriteLine("Ingrese el número entero " + (i + 1) + ": ");
    numerosEnteros[i] = int.Parse(Console.ReadLine());
}
int conteoPares = 0;
int conteoImpares = 0;
for (int i = 0; i < numerosEnteros.Length; i++)
{
    if (numerosEnteros[i] % 2 == 0)
    {
        conteoPares++;
    }
    else
    {
        conteoImpares++;
    }
}

Console.WriteLine("Cantidad de números pares: " + conteoPares);
Console.WriteLine("Cantidad de números impares: " + conteoImpares);