// TP 11 - Recursividad
// TP 4
void ejercicio1()
{
    Console.WriteLine("TP 4");
    Console.WriteLine("");
    Console.WriteLine("EJERCICIO 1");
    Console.WriteLine("");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}
void ejercicio2()
{
    Console.WriteLine("");
    Console.WriteLine("EJERCICIO 2");
    Console.WriteLine("");
    for (int a = 1; a <= 5; a++)
    {
        Console.WriteLine("¡Hola Mundo!");
    }
}
void ejercicio3()
{
    Console.WriteLine("");
    Console.WriteLine("EJERCICIO 3");
    Console.WriteLine("");
    for (int b = 2; b <= 20; b = b + 2)
    {
        Console.WriteLine(b);
    }
}
void ejercicio4()
{
    Console.WriteLine("");
    Console.WriteLine("EJERCICIO 4");
    Console.WriteLine("");
    for (int c = 7; c <= 70; c = c + 7)
    {
        Console.WriteLine(c);
    }
}
void ejercicio5()
{
    Console.WriteLine("");
    Console.WriteLine("EJERCICIO 5");
    Console.WriteLine("");
    int acum;
    for (int d = 1; d <= 5; d++)
    {
        acum = d;
        acum += d;
        Console.WriteLine(acum);
    }
}

// TP 5
void ejercicio6()
{
    Console.WriteLine("");
    Console.WriteLine("TP 5");
    Console.WriteLine("");
    Console.WriteLine("Ejercicio 1");
    Console.WriteLine("");
    Console.WriteLine("ingrese una contraseña");
    string contraseña = "777";
    string contraseñaingresada = Console.ReadLine();
    while (contraseñaingresada != contraseña)
    {
        Console.WriteLine("inténtenlo de nuevo");
        contraseñaingresada = Console.ReadLine();
    }
    Console.WriteLine("contraseña correcta");
}
void ejercicio7()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio 2");
    Console.WriteLine("");
    int contador = 5;
    while (contador >= 1)
    {
        Console.WriteLine(contador);
        contador--;
    }
    Console.WriteLine("¡Listo para despegar!");
    Console.WriteLine("¡Despegue!");
}
void ejercicio8()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio 3");
    Console.WriteLine("");
    Console.WriteLine("Adivina el número secreto entre 1 y 10");
    int numerores = Convert.ToInt32(Console.ReadLine());
    while (numerores != 7)
    {
        Console.WriteLine("ingrese otro numero");
        numerores = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("¡Felicidades! Adivinaste el número.");
}
void ejercicio9()
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio 4:");
    Console.WriteLine("");
    int sumatoria = 0;
    Console.WriteLine("Ingrese números para sumar (0 para terminar):");
    int numero = Convert.ToInt32(Console.ReadLine());
    while (numero != 0)
    {
        sumatoria += numero;
        Console.WriteLine("Ingrese otro número (0 para terminar):");
        numero = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("La suma total es:" + sumatoria);
}

ejercicio1();
ejercicio2();
ejercicio3();
ejercicio4();
ejercicio5();
ejercicio6();
ejercicio7();
ejercicio8();
ejercicio9();