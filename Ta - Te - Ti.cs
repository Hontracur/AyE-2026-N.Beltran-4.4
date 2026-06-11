// Programa 7: Ta-Te-Ti
int[,] tablero = new int[3, 3];

void MostrarTablero()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(tablero[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void Jugar()
{
    int jugador = 1;
    while (true)
    {
        Console.WriteLine("Turno del jugador " + jugador);
        Console.Write("Ingrese fila (0-2)-(y): ");
        int fila = int.Parse(Console.ReadLine());
        Console.Write("Ingrese columna (0-2)-(x): ");
        int columna = int.Parse(Console.ReadLine());
        if (tablero[fila, columna] == 0)
        {
            tablero[fila, columna] = jugador;
            MostrarTablero();
            if (VerificarGanador(jugador))
            {
                Console.WriteLine("¡Jugador " + jugador + " gana!");
                break;
            }
            jugador = jugador == 1 ? 2 : 1;
        }
        else
        {
            Console.WriteLine("Esa posición ya está ocupada. Intente de nuevo.");
        }
    }
}

bool VerificarGanador(int jugador)
{
    for (int i = 0; i < 3; i++)
    {
        if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador)
            return true;
    }
    for (int j = 0; j < 3; j++)
    {
        if (tablero[0, j] == jugador && tablero[1, j] == jugador && tablero[2, j] == jugador)
            return true;
    }
    if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador)
        return true;
    if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador)
        return true;
    return false;
}

MostrarTablero();
Jugar();
VerificarGanador(1);