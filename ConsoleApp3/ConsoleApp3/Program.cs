using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elejir = 0;

            while (elejir != 8)
            {
                Console.WriteLine("1. Consultar en Base de datos");
                Console.WriteLine("2. Agregar en Base de datos");
                Console.WriteLine("3. Actualizar en Base de datos");
                Console.WriteLine("4. Eliminar en Base de datos");
                Console.WriteLine("5. Buscar en el arbol");
                Console.WriteLine("6. Mostrar arbol");
                Console.WriteLine("7. Ordenar");
                Console.WriteLine("8. Salir");
                Console.Write("Elije que es lo que quieres hacer: ");

                elejir = Convert.ToInt32(Console.ReadLine());

                switch (elejir)
                {
                    case 1:
                        Mostrar(CargarLista());
                        break;

                    case 2:
                        Agregar();
                        break;

                    case 3:
                        Actualizar();
                        break;

                    case 4:
                        Eliminar();
                        break;

                    case 5:
                        Buscar();
                        break;

                    case 6:
                        MostrarArbol();
                        break;

                    case 7:
                        List<datos> personajes = CargarLista();

                        OrdenarBurbuja(personajes);

                        Mostrar(personajes);
                        break;

                    case 8:
                        Console.WriteLine("Programa terminado.");
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static List<datos> CargarLista()
        {
            using var db = new AppDbContext();

            return db.deadlock_db.ToList();
        }

        static void Mostrar(List<datos> personajes)
        {
            foreach (datos personaje in personajes)
            {
                Console.WriteLine(personaje.id + " - " + personaje.nombre + " - " + personaje.genero + " - " + personaje.titulo_1 + " - " + personaje.titulo_2 + " - " + personaje.titulo_3);
            }
        }

        static void Agregar()
        {
            using var db = new AppDbContext();

            datos personaje = new datos();

            Console.Write("Nombre: ");
            personaje.nombre = Console.ReadLine();

            Console.Write("Genero: ");
            Console.Write("Masculino // Femenino // No binario");
            personaje.genero = Console.ReadLine();

            Console.Write("Titulo 1: ");
            personaje.titulo_1 = Console.ReadLine();

            Console.Write("Titulo 2: ");
            personaje.titulo_2 = Console.ReadLine();

            Console.Write("Titulo 3: ");
            personaje.titulo_3 = Console.ReadLine();

            db.deadlock_db.Add(personaje);
            db.SaveChanges();

            Console.WriteLine("Personaje agregado.");
        }

        static void Actualizar()
        {
            using var db = new AppDbContext();

            Console.Write("ID del personaje: ");
            int id = Convert.ToInt32(Console.ReadLine());

            datos personaje = db.deadlock_db.Find(id);

            if (personaje != null)
            {
                Console.Write("Nuevo Nombre: ");
                personaje.nombre = Console.ReadLine();

                Console.Write("Nuevo Genero: ");
                personaje.genero = Console.ReadLine();

                Console.Write("Nuevo Titulo 1: ");
                personaje.titulo_1 = Console.ReadLine();

                Console.Write("Nuevo Titulo 2: ");
                personaje.titulo_2 = Console.ReadLine();

                Console.Write("Nuevo Titulo 3: ");
                personaje.titulo_3 = Console.ReadLine();
                db.SaveChanges();

                Console.WriteLine("Personaje actualizado.");
            }
            else
            {
                Console.WriteLine("Personaje no encontrado.");
            }
        }

        static void Eliminar()
        {
            using var db = new AppDbContext();

            Console.Write("ID del personaje: ");
            int id = Convert.ToInt32(Console.ReadLine());

            datos personaje = db.deadlock_db.Find(id);

            if (personaje != null)
            {
                db.deadlock_db.Remove(personaje);
                db.SaveChanges();

                Console.WriteLine("Personaje eliminado.");
            }
            else
            {
                Console.WriteLine("Personaje no encontrado.");
            }
        }

        static ArbolBinario CargarArbol()
        {
            List<datos> personajes = CargarLista();

            ArbolBinario arbol = new ArbolBinario();

            foreach (datos personaje in personajes)
            {
                arbol.Insertar(personaje);
            }

            return arbol;
        }

        static void Buscar()
        {
            ArbolBinario arbol = CargarArbol();

            Console.Write("ID del personaje a buscar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            datos personaje = arbol.Buscar(id);

            if (personaje != null)
            {
                Console.WriteLine(personaje.nombre);
                Console.WriteLine(personaje.genero);
                Console.WriteLine(personaje.titulo_1);
                Console.WriteLine(personaje.titulo_2);
                Console.WriteLine(personaje.titulo_3);
            }
            else
            {
                Console.WriteLine("Personaje no encontrado.");
            }
        }

        static void MostrarArbol()
        {
            ArbolBinario arbol = CargarArbol();

            List<datos> personajes = arbol.RecorridoInOrden();

            Mostrar(personajes);
        }

        static void OrdenarBurbuja(List<datos> personajes)
        {
            for (int i = 0; i < personajes.Count - 1; i++)
            {
                for (int j = 0; j < personajes.Count - 1 - i; j++)
                {
                    string nombreActual = personajes[j].nombre;
                    string nombreSiguiente = personajes[j + 1].nombre;
                    bool intercambiar = false;
                    int posicionLetra = 0;

                    while (posicionLetra < nombreActual.Length && posicionLetra < nombreSiguiente.Length)
                    {
                        if (nombreActual[posicionLetra] > nombreSiguiente[posicionLetra])
                        {
                            intercambiar = true;
                            break;
                        }

                        if (nombreActual[posicionLetra] < nombreSiguiente[posicionLetra])
                        {
                            break;
                        }

                        posicionLetra++;
                    }

                    if (posicionLetra == nombreSiguiente.Length && nombreActual.Length > nombreSiguiente.Length)
                    {
                        intercambiar = true;
                    }

                    if (intercambiar)
                    {
                        datos personaje2 = personajes[j];
                        personajes[j] = personajes[j + 1];
                        personajes[j + 1] = personaje2;
                    }
                }
            }
        }
    }
}