// Cifrado Cesar
string abc = "abcdefghijklmnopqrstuvwxyz";

string funcion()
{
    string mensaje = "";
    bool esValido = false;

    while (!esValido)
    {
        Console.WriteLine("Pon un mensaje");
        mensaje = Console.ReadLine();
        mensaje = mensaje.ToLower();

        bool contieneError = false;

        for(int i = 0; i < mensaje.Length; i++)
        {
            char caracter = mensaje[i];
            bool encontrado = false;
        

        for(int j = 0; j < abc.Length; j++)
        {
                if (caracter == abc[j])
                {
                    encontrado = true;
                    break;
                }
        }
        if (!encontrado)
            {
                contieneError = true;
                break;
            }
        if (contieneError)
            {
                Console.WriteLine("El mensaje contiene caracteres no usados para el Cifrado Cesar");
            }
            else
            {
                esValido = true;
            }
    }
}

string cifrado(string texto, int clave)
{
    return texto;
}
string descifrado(string texto, int clave)
{
    
}