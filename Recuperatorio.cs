namespace ConsoleApp1
{
    internal class Program
    {
        struct mago
        {
            public int vidatotal { get; set; }
            public int vidactual { get; set; }
            public string ultimohechizo{ get; set; }

            public mago(int vidatotal, int vidactual, string ultimohechizo)
            {
                this.vidatotal = vidatotal;
                this.vidactual = vidactual;
                this.ultimohechizo = ultimohechizo;
            }
        }

        static void Main(string[] args)
        {
            Stack<mago> historial = new Stack<mago>();

            historial.Push(new mago(100, 100, "despertar en casa"));
            historial.Push(new mago(100, 100, "equipar baston"));
            historial.Push(new mago(100, 100, "tener mana"));

            Console.WriteLine("Historial del mago");
            foreach (mago p in historial)
            {
                Console.WriteLine($"UltimoHechizo: {p.ultimohechizo} // Vida: {p.vidactual}/{p.vidatotal}");
            }
            Console.WriteLine();

            void golpear()
            {
                mago pActual = historial.Peek();
                pActual.vidactual -= 20;
                pActual.ultimohechizo = "Cañon Estelar";
                historial.Push(pActual);
                Console.WriteLine($"Tu personaje a recibido daño, su vida actual es de: {pActual.vidactual}");
            }

            void volverEnElTiempo()
            {
                mago borrado = historial.Pop();
                Console.WriteLine("Viajaste en el tiempo, se ha borrado el ultimo hechizo que haz usado.");
                Console.WriteLine($"El Ultimo Hechizo borrado fue: {borrado.ultimohechizo}");
            }

            golpear();
            volverEnElTiempo();
        }
    }
}