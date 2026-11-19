// Primer Bloque
// Ejercicio A
Console.WriteLine("");
Console.WriteLine("Ej: A");
Console.WriteLine("");
Console.WriteLine("Imprimir los números del 1 al 100 que son múltiplos de 3.");
Console.WriteLine("");
for (int i = 3; i <= 100; i = i + 3)
{
    Console.WriteLine(i);
}

// Ejercicio B
Console.WriteLine("");
Console.WriteLine("Ej: B");
Console.WriteLine("");
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
Console.WriteLine("Ej: C");
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
Console.WriteLine("Ej: D");
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
Console.WriteLine("Ej: E");
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
Console.WriteLine("Ej: F");
Console.WriteLine("");
Console.WriteLine("Ingrese su nombre y será saludado:");
Console.Write("Nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola, " + nombre + "!");

// Ejercicio G
Console.WriteLine("");
Console.WriteLine("Ej: G");
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
Console.WriteLine("Ej: H");
Console.WriteLine("");
Console.WriteLine("Del 10 al 1:");
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
    Console.WriteLine("");
}

// Ejercicio I
Console.WriteLine("");
Console.WriteLine("Ej: I");
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
Console.WriteLine("Ej: J");
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
Console.WriteLine("Ej: K");
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
Console.WriteLine("Ej: L");
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
Console.WriteLine("Ej: M");
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
Console.WriteLine("Ej: N");
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
Console.WriteLine("Ej: O");
Console.WriteLine("");
Console.WriteLine("Números del 50 al 0 de forma descendente, de cinco en cinco:");
for (int i = 50; i >= 0; i -= 5)
{
    Console.WriteLine(i);
    Console.WriteLine("");
}

// Ejercicio P
Console.WriteLine("");
Console.WriteLine("Ej: P");
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
Console.WriteLine("Ej: Q");
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
Console.WriteLine("Ej: R");
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

﻿//segundo bloque
//ejercicio a
Console.WriteLine("Juego adivinar numero");
Random r = new Random();
int secreto =r.Next(1, 11);
int num = 0;

while (num != secreto)
{
    Console.Write("Adivina (1-10): ");
    num = int.Parse(Console.ReadLine());

    if (num > secreto)
        Console.WriteLine("Es menor");
    else if (num < secreto)
        Console.WriteLine("Es mayor");
}

Console.WriteLine("Correcto");

//ejercicio b
Console.WriteLine("Divisores");
Console.Write("Numero: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
        Console.WriteLine(i);
}

//ejercicio c
Console.WriteLine("Primos hasta 20");
for (int i = 2; i <= 20; i++)
{
    bool primo = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
            primo = false;
    }

    if (primo)
        Console.WriteLine(i);
}

//ejercicio d
Console.WriteLine("Calculadora");
Console.Write("Numero 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Numero 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Operacion (+ - * /): ");
string op = Console.ReadLine();

if (op == "+")
    Console.WriteLine(a + b);
if (op == "-")
    Console.WriteLine(a - b);
if (op == "*")
    Console.WriteLine(a * b);
if (op == "/")
    Console.WriteLine(a / b);

//ejercicio e
Console.WriteLine("Factorial");
Console.Write("Numero: ");
int e = Convert.ToInt32(Console.ReadLine());

int fact = 1;

for (int i = 1; i <= e; i++)
{
    fact = fact * i;
}

Console.WriteLine(fact);

//ejercicio f
Console.WriteLine("Sistema de turnos");
string nombre;
int turno = 1;

Console.Write("Nombre (fin para salir): ");
nombre = Console.ReadLine();

while (nombre != "fin")
{
    Console.WriteLine("Turno: " + turno);
    turno++;

    Console.Write("Nombre: ");
    nombre = Console.ReadLine();
}

// Tercer bloque
﻿// Ejercicio A
Console.WriteLine("Ejercicio A: Simulación de votación y que termine cuando coloque terminar");
Console.WriteLine("1. Nicolas Maduro");
Console.WriteLine("2. Adolf Hitler");
Console.WriteLine("3. Claudia Sheinbaum");
int votoNicolas = 0;
int votoAdolf = 0;
int votoClaudia = 0;
bool continuarVotando = true;
while (continuarVotando)
{
    Console.WriteLine("Ingrese su voto (1, 2, 3) o 'terminar' para finalizar:");
    string input = Console.ReadLine();
    if (input.ToLower() == "terminar")
    {
        continuarVotando = false;
    }
    else
    {
        switch (input)
        {
            case "1":
                votoNicolas++;
                break;
            case "2":
                votoAdolf++;
                break;
            case "3":
                votoClaudia++;
                break;
            default:
                Console.WriteLine("Voto no válido. Por favor, ingrese 1, 2, 3 o 'terminar'.");
                break;
        }
    }
}
Console.WriteLine("Resultados de la votación:");
Console.WriteLine($"Nicolas Maduro: {votoNicolas} votos");
Console.WriteLine($"Adolf Hitler: {votoAdolf} votos");
Console.WriteLine($"Claudia Sheinbaum: {votoClaudia} votos");

// Ejercicio B
Console.WriteLine("Ejercicio B: Mostrar números impares desde 1 hasta el número ingresado");
Console.WriteLine("Ingrese un número:");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero < 1)
{
    Console.WriteLine("No se puede ingresar un número menor que 1.");
}
else
{
    Console.WriteLine($"Números impares desde 1 hasta {numero}:");
    for (int i = 1; i <= numero; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

// Ejercicio C
Console.WriteLine("Ejercicio C: Contar la cantidad de veces que aparece una letra en una palabra");
Console.WriteLine("Ingrese una palabra:");
string palabra = Console.ReadLine();
Console.WriteLine("Ingrese una letra:");
char letra = Console.ReadLine()[0];
int contador = 0;
foreach (char c in palabra)
{
    if (c == letra)
    {
        contador++;
    }
}
Console.WriteLine($"La letra '{letra}' aparece {contador} veces en la palabra '{palabra}'.");

// Ejercicio D
Console.WriteLine("Ejercicio D: Simulación de una cuenta bancaria");
int saldo = 1000;
bool continuar = true;
while (continuar)
{
    Console.WriteLine($"Saldo actual: ${saldo}");
    Console.WriteLine("Seleccione una opción: 1. Depositar dinero 2. Retirar dinero 3. Salir");
    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese la cantidad a depositar:");
            int deposito = Convert.ToInt32(Console.ReadLine());
            saldo += deposito;
            break;
        case "2":
            Console.WriteLine("Ingrese la cantidad a retirar:");
            int retiro = Convert.ToInt32(Console.ReadLine());
            if (retiro > saldo)
            {
                Console.WriteLine("No se puede retirar más de lo que tiene en el saldo.");
            }
            else
            {
                saldo -= retiro;
            }
            break;
        case "3":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione 1, 2 o 3.");
            break;
    }
}

// Ejercicio E

Console.WriteLine("Ejercicio E: ");
int contador2 = 0;
int numeroE = 1;
while (contador < 50)
{
    if ((numeroE % 2 == 0 || numeroE % 5 == 0) && !(numeroE % 2 == 0 && numeroE % 5 == 0))
    {
        Console.WriteLine(numeroE);
        contador++;
    }
    numeroE++;
}

// ejecico F
Console.WriteLine("ejercio F:");
Console.Write("Ingrese una palabra:");
string palabra;
try{
    palabra = Console.ReadLine().ToLower();
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó ninguna palabra:");
    return;
}
for (int i = 0; i < palabra.Length; i++)
{
    char letra = palabra[i];
    if (char.IsLetter(letra))
    {
        int posicion = letra - 'a' + 1;
        Console.Write(posicion + " ");
    }
    else
    {
        Console.WriteLine("No es una letra ");
    }
}

// ejercicio G
Console.WriteLine("");
Console.WriteLine("ejercio g:");
Random random = new Random();
int numeroSecreto = random.Next(1, 100);
int intentos = 0;
int adivinanza = 0;
Console.WriteLine("Adivina el número secreto entre 1 y 100:");
while (adivinanza != numeroSecreto)
{
    try
    {
        adivinanza = Convert.ToInt16(Console.ReadLine());
        intentos++;
        if (adivinanza < numeroSecreto)
        {
            Console.WriteLine("Más grande");
        }
        else if (adivinanza > numeroSecreto)
        {
            Console.WriteLine("Más chico");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, ingresa un número válido.");
        return;
    }
}
Console.WriteLine($"¡Felicidades! Adivinaste el número secreto en {intentos} intentos.");

// ejercicio H
Console.WriteLine("ejercio H:Pedile al usuario una frase y devolvé la misma frase, pero con cada palabra invertida");
Console.Write("Ingrese una frase:");
string frase;
try
{
    frase = Console.ReadLine();
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó ninguna frase:");
    return;
}
foreach (string palabra2 in frase.Split(' '))
{
    char[] caracteres = palabra2.ToCharArray();
    Array.Reverse(caracteres);
    Console.Write(new string(caracteres) + " ");
}

// ejercicio I
Console.WriteLine("ejercio I: Mostrá cuántas veces aparece cada letra en una palabra.");
Console.Write("Ingrese una palabra:");
string palabra3;
try
{
    palabra3 = Console.ReadLine().ToLower();
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó ninguna palabra:");
    return;
}
for (char letra = 'a'; letra <= 'z'; letra++)
{
    int contador = 0;
    foreach (char c in palabra3)
    {
        if (c == letra)
        {
            contador++;
        }
    }
    if (contador > 0)
    {
        Console.WriteLine($"La letra '{letra}' aparece {contador} veces.");
    }
}

// ejercicio J
Console.WriteLine("ejercio J:");
string usuarioCorrecto = "admin";
string contraseñaCorrecta = "password";
int intentos2 = 0;
while (intentos2 < 3)
{
    Console.Write("Ingrese su nombre de usuario:");
    string usuario;
    try
    {
        usuario = Console.ReadLine().ToLower();
    }
    catch (FormatException)
    {
        Console.WriteLine("No se ingresó ningún nombre de usuario:");
        return;
    }
    Console.Write("Ingrese su contraseña:");
    string contraseña;
    try
    {
        contraseña = Console.ReadLine().ToLower();
    }
    catch (FormatException)
    {
        Console.WriteLine("No se ingresó ninguna contraseña:");
        return;
    }
    if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
    {
        Console.WriteLine($"¡Bienvenido, {usuario}!");
        break;
    }
    else
    {
        intentos2++;
        Console.WriteLine("Nombre de usuario o contraseña incorrectos. Intente nuevamente.");
        if (intentos2 == 3)
        {
            Console.WriteLine("Has alcanzado el número máximo de intentos. Acceso bloqueado.");
        }
    }
}

// ejercicio K
Console.WriteLine("ejercio K:");
int numero;
Console.Write("Ingrese un número entre 0 y 100:");
try {
    numero = Convert.ToInt16(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó un número válido:");
    return;
}
if (numero >= 0 && numero <= 25)
{
    Console.WriteLine("El número está en el rango de 0 a 25.");
}
else if (numero > 25 && numero <= 50)
{
    Console.WriteLine("El número está en el rango de 26 a 50.");
}
else if (numero > 50 && numero <= 75)
{
    Console.WriteLine("El número está en el rango de 51 a 75.");
}
else if (numero > 75 && numero <= 100)
{
    Console.WriteLine("El número está en el rango de 76 a 100.");
}
else
{
    Console.WriteLine("El número ingresado está fuera del rango permitido.");
}

// ejercicio L
Console.WriteLine("ejercio L:");
int peso;
Console.Write("Ingrese su peso en kg:");
try
{
    peso = Convert.ToInt16(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó un peso válido:");
    return;
}
Console.Write("Ingrese su altura en metros:");
int altura;
try
{
    altura = Convert.ToInt16(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó una altura válida:");
    return;
}
int imc = peso / (altura * altura);
Console.WriteLine($"Su IMC es: {imc:F2}");
if (imc < 18.5)
{
    Console.WriteLine("Categoría: Bajo peso");
}
else if (imc >= 18.5 && imc < 24.9)
{
    Console.WriteLine("Categoría: Normal");
}
else if (imc >= 25 && imc < 29.9)
{
    Console.WriteLine("Categoría: Sobrepeso");
}
else if (imc >= 30 && imc < 34.9)
{
    Console.WriteLine("Categoría: Obesidad");
}
else
{
    Console.WriteLine("Categoría: Obesidad mórbida");
}

// ejercicio M:
Console.WriteLine("ejercio M:");
Console.Write("Ingrese una palabra:");
string palabra4;
try
{
    palabra4 = Console.ReadLine();
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó ninguna palabra:");
    return;
}
for (int i = 1; i <= palabra4.Length; i++)
{
    Console.WriteLine(palabra4.Substring(0, i));
}

// ejercicio N:
Console.WriteLine("ejercio N:");
string frase2;
try
{
    frase2 = Console.ReadLine().ToLower();
}
catch (FormatException)
{
    Console.WriteLine("No se ingresó ninguna frase:");
    return;
}
string[] vocales = { "a", "e", "i", "o", "u" };
int indiceVocal = 0;
while (frase2.ToLower() != "agusfortnite2008")
{
    string fraseModificada = frase2;
    foreach (string vocal in vocales)
    {
        fraseModificada = fraseModificada.Replace(vocal, vocales[indiceVocal]);
        fraseModificada = fraseModificada.Replace(vocal.ToLower(), vocales[indiceVocal].ToLower());
    }
    Console.WriteLine(fraseModificada);
    indiceVocal = (indiceVocal + 1) % vocales.Length;
    try
    {
        frase2 = Console.ReadLine().ToLower();
    }
    catch (FormatException)
    {
        Console.WriteLine("No se ingresó ninguna frase:");
        return;
    }
}
