using System.Security.Cryptography.X509Certificates;

namespace TPEvaluativo
{
    internal class Program
    {
        struct Personaje
        {
            public int VidaTotal;
            public int VidaActual;
            public string UltimaAccion;

            public Personaje(int vidaTotal, int vidaActual, string ultimaAccion)
            {
                VidaTotal = vidaTotal;
                VidaActual = vidaActual;
                UltimaAccion = ultimaAccion;
            }
        }
        struct volverEnELTiempo
        {
            public int VolverEnELTiempo;
            public volverEnELTiempo(int volverEnELTiempo)
            {
                VolverEnELTiempo = volverEnELTiempo;
            }
        }
        static void Main(string[] args)
        {
            Stack <Personaje> historialdDelPersonaje = new Stack<Personaje>();
            Stack <Personaje> vidaTotal = new Stack<Personaje>(100);
            Stack <Personaje> vidaActual = new Stack<Personaje>(100);
            Stack <Personaje> ultimaAccion = new Stack<Personaje>(100);
            Stack <volverEnELTiempo> volverEnELTiempo = new Stack<volverEnELTiempo>(100);

            vidaActual.Push(new Personaje { VidaActual = 100 });
            vidaTotal.Push(new Personaje { VidaTotal = vidaActual.Peek().VidaActual });
            ultimaAccion.Push(new Personaje { UltimaAccion = "Ultima Accion: " });
            volverEnELTiempo.Push(new volverEnELTiempo { VolverEnELTiempo = vidaActual.Peek().VidaActual });

            Console.WriteLine("Bienvenido al juego :vvvv. Tu personaje tiene 100 puntos de vida.");
            Console.WriteLine("Ingrese cuanto daño quieres recibir: ");
            vidaTotal.Push(new Personaje { VidaTotal = vidaTotal.Peek().VidaTotal - int.Parse(Console.ReadLine()) });

            if (vidaTotal.Peek().VidaActual <= 80)
            {
                Console.WriteLine("Tu personaje ha recibido daño y ahora tiene " + vidaTotal.Peek().VidaActual + " puntos de vida.");
                Console.WriteLine("Ultima accion: Recibio daño");
            }
            else if (volverEnELTiempo.Peek().VolverEnELTiempo >= 81)
            {
                ultimaAccion.Push(new Personaje { UltimaAccion = "Ultima Accion: Borrado" });
                Console.WriteLine("No recibiste daño por lo que vuelves en el tiempo");
                Console.WriteLine("Ultima Accion: " + ultimaAccion.Peek().UltimaAccion);
                ultimaAccion.Pop();
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
