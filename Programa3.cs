// Programa 3: Ahorcado

try
{
    Console.WriteLine("");
    Console.WriteLine("Programa 3: Ahorcado");
    Console.WriteLine("");
    Console.WriteLine("Ingrese una letra");
    
    string[] palabras = { "programacion", "balatro", "computacion"};
    Random random = new Random();
    
    for (int i = 0; i < palabras.Length; i++)
    {
        int indice = random.Next(palabras.Length);
        string palabraSecreta = palabras[indice];
        char[] palabraAdivinada = new char[palabraSecreta.Length];
        
        for (int j = 0; j < palabraAdivinada.Length; j++)
        {
            palabraAdivinada[j] = '_';
        }
        
        int intentosRestantes = 7;
        bool juegoTerminado = false;
        
        while (juegoTerminado == false)
        {
            Console.WriteLine("Palabra: " + new string(palabraAdivinada));
            Console.WriteLine("Intentos restantes:" + intentosRestantes);
            Console.Write("Ingresa una letra: ");
            char letra = Console.ReadLine()[0];
            
            if (palabraSecreta.Contains(letra) && juegoTerminado == false)
            {
                for (int k = 0; k < palabraSecreta.Length; k++)
                {
                    if (palabraSecreta[k] == letra)
                    {
                        palabraAdivinada[k] = letra;
                    }
                }
            }
            else
            {
                intentosRestantes--;
            }
            if (new string(palabraAdivinada) == palabraSecreta)
            {
                Console.WriteLine("¡Felicidades! Has adivinado la palabra: " + palabraSecreta);
                juegoTerminado = true;
            }
            else if (intentosRestantes == 0)
            {
                Console.WriteLine("Perdiste, La palabra era: " + palabraSecreta);
                juegoTerminado = true;
            }
        }
    }
}
catch (System.IndexOutOfRangeException)
{
    Console.WriteLine("Error: Se ha ingresado un valor no válido");
}
