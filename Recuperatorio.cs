// Recuperatorio de Funciones y cadena de caracteres.

// EJERCICIO 1

string EJERCICIO1(int hora, int salario = 0, int salario2 = 0)
{

    Console.WriteLine("Ingrese cuantas horas trabajo");
    hora = int.Parse(Console.ReadLine());

    if (hora == 40 || hora < 40)
    {
        salario = 16;
        Console.WriteLine("se le pagara " + salario);
        Console.WriteLine("Total de la hora trabajado: " + hora);

    }
    else {
        salario = 16;
        salario2 = 20;
        Console.WriteLine("se le pagara " + salario);
        Console.WriteLine("y por cada hora sera " + salario2);
        Console.WriteLine("Total de la hora trabajado: " + hora);
    }
}

Console.WriteLine(EJERCICIO1(int.Parse(Console.ReadLine())));

// EJERCICIO 2
void EJERCICIO2()
{
    Console.WriteLine("Ingrese cualquier numero que no sea 0");
    int num = int.Parse(Console.ReadLine());
    int acumulador = 0;
    while (num != 0)
    {
        acumulador = acumulador + num;
        num = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("El total de numeros acumulados: " + acumulador);
}

EJERCICIO2();

void EJERCICIO3()
{
    string vocales = ("aeiouAEIOU");
    string palabra;
    Console.WriteLine("Ingrese cualquier palabra para demostrar cuantos vocales hay");
    palabra = Console.ReadLine();
    int Total = 0;
    foreach ()
    {
        
    }
}

EJERCICIO3();

void EJERCICIO4()
{
    Console.WriteLine("Ingrese una palabra palindromo");
    Console.WriteLine("En caso de que no lo sea, intentelo otra vez.");
    string palabra = Console.ReadLine();

    while (palabra != "Ana" || palabra != "Otto" || palabra != "Reconocer" || palabra != "Oso" || palabra != "Oro" || palabra != "Aibofobia")
    {
        Console.WriteLine("Vuelve intentarlo");
    }
    Console.WriteLine("La palabra es palindromo");
}

EJERCICIO4();