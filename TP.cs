Console.WriteLine("Ingrese un numero no negativo");
int intento = 3;
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0)
{
    intento = 3;
    Console.WriteLine("El numero que a puesto es negativo");
    Console.WriteLine("Te quedan " + intento + " intentos, si llegas a 0 se terminara");
    x = int.Parse(Console.ReadLine());
    if (x < 0) {
        intento = intento - 1;
        Console.WriteLine("El numero que a puesto es negativo");
        Console.WriteLine("Te quedan " + intento + " intentos");
        x = int.Parse(Console.ReadLine());
        if (x < 0)
        {
            intento = intento - 1;
            Console.WriteLine("El numero que a puesto es negativo");
            Console.WriteLine("Te quedan " + intento + " intentos");
            x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("El numero que a puesto es negativo");
                Console.WriteLine("Te quedaste sin intentos, Presiona cualquier boton para terminar");
                Console.ReadLine();
            }
        }
    } 
}
int factorial = 1;
for (int i = 1; i <= x; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);