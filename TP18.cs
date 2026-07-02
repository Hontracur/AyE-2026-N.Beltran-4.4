namespace ConsoleApp2
{
    internal class Program
    {
        // EJERCICIO 1
        public struct ej1
        {
            public int X { get; set; }
            public int Y { get; set; }

            public ej1(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Mostrar()
            {
                Console.WriteLine("(" + X + "," + Y + ")");
            }
        }

        // EJERCICIO 2
        public struct ej2
        {
            public int Ancho { get; set; }
            public int Alto { get; set; }

            public ej2(int ancho, int alto)
            {
                Ancho = ancho;
                Alto = alto;
            }
        }

        //     ¿Por qué el ancho de d1 no cambió a 99?

        //     En C#, los 'struct' son tipos de valor (value types). 
        //     Cuando asignas 'd2 = d1', no estás creando una referencia al mismo objeto, 
        //     sino que estás creando una copia completa e independiente de todos los datos en memoria. 
        //     Por lo tanto, cualquier modificación en las propiedades de 'd2' afecta únicamente 
        //     a esa copia y no altera los valores originales de 'd1'. Si 'Dimensiones' fuera 
        //     una 'class' (tipo de referencia), d1 y d2 apuntarían al mismo objeto y d1 sí habría cambiado.

        // EJERCICIO 3
        public struct ej3
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public double Precio { get; set; }

            public ej3(string nombre, int codigo, double precio)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;
            }
        }

        // EJERCICIO 4:
        public struct ej4
        {
            public string Nombre { get; set; }
            public double[] Notas { get; set; }

            public ej4(string nombre, double[] notas)
            {
                Nombre = nombre;
                Notas = notas;
            }

            public double CalcularPromedio()
            {
                double suma = 0;
                foreach (double nota in Notas)
                {
                    suma += nota;
                }
                return suma / Notas.Length;
            }
        }
    }
}