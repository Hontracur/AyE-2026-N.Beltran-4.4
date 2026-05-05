// Ejercicio 1
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

// Ejercicio 2
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

// Ejercicio 3
Console.WriteLine("");
Console.WriteLine("Ejercicio 3");
Console.WriteLine("");
Console.WriteLine("Adivina el número secreto entre 1 y 10");
int numerores = Convert.ToInt32(Console.ReadLine());
while ( numerores != 7)
{
    Console.WriteLine("ingrese otro numero");
    numerores = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("¡Felicidades! Adivinaste el número.");

// Ejercicio 4
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
Console.WriteLine("La suma total es:"+ sumatoria);
