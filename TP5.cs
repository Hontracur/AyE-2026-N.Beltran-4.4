// Ejercicio 1
Console.WriteLine("Ejercicio 1");
Console.WriteLine("ingrese una contraseña");
string contraseña = "1990";
string contraseñaingresada = Console.ReadLine();
while (contraseñaingresada != contraseña)
{
    Console.WriteLine("inténtenlo de nuevo");
    contraseñaingresada = Console.ReadLine();
}
Console.WriteLine("contraseña correcta");

// Ejercicio 2
Console.WriteLine("Ejercicio 2");
int contador = 5;
while (contador >= 1)
{
    Console.WriteLine(contador);
    contador--;
}

Console.WriteLine("¡Listo para despegar!");
Console.WriteLine("¡Despegue!");

// Ejercicio 3
Console.WriteLine("Ejercicio 3");
Console.WriteLine("Adivina el número secreto entre 1 y 10");
int numerores = Convert.ToInt32(Console.ReadLine());
while (numerores != 7)
{
    Console.WriteLine("ingrese otro numero");
    numerores = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("¡Felicidades! Adivinaste el número.");

// Ejercicio 4
Console.WriteLine("Ejercicio 4");
int suma = 0;
Console.WriteLine("Ingrese números para sumar (0 para finalizar):");
int numero = Convert.ToInt32(Console.ReadLine());
while (numero != 0)
{
    suma += numero;
    Console.WriteLine("Ingrese otro número (0 para finalizar):");
    numero = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("La suma total es:" + suma);