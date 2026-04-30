// Ejercicio 1
try
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio 1:");
    Console.WriteLine("");

    int num;
    int unidades;
    int decenas;

    Console.WriteLine("Ingrese un numero");
    num = int.Parse(Console.ReadLine());

    if (num < 99 || num > -99)
    {
        decenas = num / 10;
        unidades = num % 10;
    }
}
catch (InvalidCastException)
{
    Console.WriteLine("ERROR: El valor que acabas de ingresar no es valido");
}
catch (OverflowException)
{
    Console.WriteLine("ERROR: Acabaste de llegar al limite de un int");
}