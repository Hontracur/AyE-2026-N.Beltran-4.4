// Primer Bloque
// Ejercicio A
Console.WriteLine("");
Console.WriteLine("Imprimir los números del 1 al 100 que son múltiplos de 3.");
Console.WriteLine("");
for (int i = 3; i <= 100; i = i + 3)
{
    Console.WriteLine(i);
}

// Ejercicio B
Console.WriteLine();
Console.WriteLine("Ingrese su edad:");
Console.WriteLine("");
int edad = Convert.ToInt32(Console.ReadLine());
if (edad == 18)
{
    Console.WriteLine("");
    Console.WriteLine("Tienes justo 18 años.");
    Console.WriteLine("");
}
else if (edad < 18)
{
    Console.WriteLine("");
    Console.WriteLine("Es menor de edad.");
    Console.WriteLine("");
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Es mayor de edad.");
    Console.WriteLine("");
}

// Ejercicio C
Console.WriteLine("");
Console.WriteLine("Ingrese una palabra:");
Console.Write("Palabra: ");
string palabra = Console.ReadLine();
if (palabra == "")
{
    Console.WriteLine("Entrada inválida. Introduzca una palabra.");
}
else
{
    int letras = palabra.Length;

    Console.WriteLine("La palabra " + palabra + " tiene " + letras + " letras.");
}

// Ejercicio D
Console.WriteLine("");
Console.WriteLine("Adivine la contraseña secreta. Tiene 5 intentos.");
Console.WriteLine("");
string secreto = "secreto123";
int intentosMax = 5;
bool atinado = false;

for (int intento = 1; intento <= intentosMax; intento++)
{
    Console.Write("Intento: " + intento + "/" + intentosMax + ": ");
    string intentoUsuario = Console.ReadLine();

    if (intentoUsuario == secreto)
    {
        Console.WriteLine("");
        Console.WriteLine("¡Correcto! Ha adivinado la contraseña.");
        Console.WriteLine("");
        atinado = true;
        break;
    }
}
Console.WriteLine("Ha agotado los intentos.");

// Ejercicio E
Console.WriteLine("");
Console.WriteLine("Ejercicio e: Ingrese 10 números y mostrar cuál fue el más alto.");
Console.WriteLine("");
int cantidad = 10;
int maximo = 0;

for (int i = 1; i <= cantidad; i++)
{
    Console.Write("Ingrese un número: ");
    int numero1 = int.Parse(Console.ReadLine());
    if (numero1 > maximo)
    {
        maximo = numero1;
    }
}

Console.WriteLine("El número más alto ingresado es: " + maximo);

// Ejercicio F
Console.WriteLine("");
Console.WriteLine("Ingrese su nombre y será saludado:");
Console.Write("Nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola, " + nombre + "!");

// Ejercicio G
Console.WriteLine("");
Console.WriteLine("Ejercicio g: Tabla del 7 del 1 al 10:");
int multiplicando = 7;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(multiplicando * i);
    Console.WriteLine("");
}


// Ejercicio H
Console.WriteLine("");
Console.WriteLine("Del 10 al 1:");
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
    Console.WriteLine("");
}

// Ejercicio I
Console.WriteLine("");
Console.WriteLine("Ingrese un número para determinar si es par o impar:");
int numeroIngresado = int.Parse(Console.ReadLine());
if (numeroIngresado % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}

// Ejercicio J
Console.WriteLine("");
Console.WriteLine("Ingrese una frase y se mostrará la cantidad de vocales:");
string frase = Console.ReadLine();
int contadorVocales = 0;
string vocales = "aeiouAEIOU";

foreach (char c in frase)
{
    if (vocales.IndexOf(c) >= 0)
    {
        contadorVocales++;
    }
}

Console.WriteLine("Cantidad de vocales: " + contadorVocales);

// Ejercicio K
Console.WriteLine("");
Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("Tabla de multiplicar del " + numero + ":");
for (int i = 1; i <= 12; i++)
{
    Console.WriteLine(numero + "x" + i + "=" + numero * i);
    Console.WriteLine("");
}

// Ejercicio L
Console.WriteLine("");
Console.WriteLine("Ingrese números para acumular un total mayor a 100.");
int acumulado = 0;
while (acumulado <= 100)
{
    Console.Write("Ingrese un número: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());
    acumulado += numero2;
    Console.WriteLine("Total acumulado: " + acumulado);
}
Console.WriteLine("Has llegado al numero 100");

// Ejercicio M
Console.WriteLine("");
Console.Write("Ingrese una palabra: ");
string palabra1 = Console.ReadLine();

foreach (char letra in palabra1)
{
    Console.WriteLine(letra);
    Console.WriteLine("");
}

// Ejercicio N
Console.WriteLine("");
Console.Write("Ingrese su edad: ");
int edad1 = int.Parse(Console.ReadLine());

if (edad1 >= 18)
{
    Console.WriteLine("Puede votar y manejar.");
}
else if (edad1 >= 16)
{
    Console.WriteLine("Puede manejar, pero no puede votar.");
}
else
{
    Console.WriteLine("No puede votar ni manejar.");
}

// Ejercicio O
Console.WriteLine("");
Console.WriteLine("Números del 50 al 0 de forma descendente, de cinco en cinco:");
for (int i = 50; i >= 0; i -= 5)
{
    Console.WriteLine(i);
    Console.WriteLine("");
}

// Ejercicio P
Console.WriteLine("");
string contraseña = "";
string confirmacion = "";
Console.Write("Ingrese una contraseña: ");
contraseña = Console.ReadLine();
Console.Write("Confirme la contraseña: ");
confirmacion = Console.ReadLine();
while (contraseña != confirmacion)
{
    Console.WriteLine("Las contraseñas no coinciden. Intente nuevamente.");
    Console.Write("Ingrese una contraseña: ");
    contraseña = Console.ReadLine();

    Console.Write("Confirme la contraseña: ");
    confirmacion = Console.ReadLine();
}
Console.WriteLine("Acceso permitido.");

// Ejercicio Q
Console.WriteLine("");
string nombre1 = "";
Console.Write("Ingrese un nombre: ");
nombre = Console.ReadLine();
while (nombre1.Length <= 10)
{
    Console.WriteLine("Nombre ingresado: " + nombre1);
    Console.Write("Ingrese un nombre: ");
    nombre1 = Console.ReadLine();
}
Console.WriteLine("El nombre tiene más de 10 caracteres. Fin del programa.");

// Ejercicio R
Console.WriteLine("");
Console.Write("Ingrese una oración: ");
string oracion = Console.ReadLine();
int contadorA = 0;
foreach (char letra in oracion)
{
    if (letra == 'a' || letra == 'A')
    {
        contadorA++;
    }
}
Console.WriteLine("La oración tiene " + contadorA + " letras 'a'.");
