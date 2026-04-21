// Ejercicio 1: Vocales

string vocales = ("aeiouAEIOU");
string texto = ("Hola que tal");
int contador = 0;
foreach (char T in texto)
{
    foreach (char V in vocales)
    {
        if (T == V)
        {
            contador++;
            Console.WriteLine("La cantidad de vocales son " + contador);
            break;
        }
    }
    
}

// Ejercicio 2: Invertir

string texto1 = ("cantidad");
string fraseinvertida = "";
for (int i = 0; i < texto1.Length; i++)
{
    fraseinvertida = texto1[i] + fraseinvertida;
}
Console.WriteLine("La palabra invertida es" + fraseinvertida);

// Ejercicio 3: Suma de digitos

string texto2 = ("123");
int suma = 0;
foreach (char N in texto2)
{
    if (char.IsDigit(N))
    {
        suma += Convert.ToInt32(N.ToString());
    }
 
}
Console.WriteLine("El numero total es " + suma);

// Ejercicio 4: 

