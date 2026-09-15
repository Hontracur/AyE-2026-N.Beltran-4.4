using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
    {
        public class Nodo
        {
            public int Valor;
            public Nodo Izquierdo;
            public Nodo Derecho;

            public Nodo(int valor)
            {
                Valor = valor;
                Izquierdo = null;
                Derecho = null;
            }
        }

        public class ArbolBinarioBusqueda
        {
            public Nodo Raiz;

            public void Insertar(int valor)
            {
                Raiz = InsertarRecursivo(Raiz, valor);
            }

            private Nodo InsertarRecursivo(Nodo nodo, int valor)
            {
                if (nodo == null)
                    return new Nodo(valor);

                if (valor < nodo.Valor)
                    nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
                else if (valor > nodo.Valor)
                    nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);

                return nodo;
            }
            public int ObtenerMinimo()
            {
            try
            {
                if (Raiz == null)
                {
                    Console.WriteLine("El arbol esta vacio");
                    return 0;
                }

                Nodo actual = Raiz;

                while (actual.Izquierdo != null)
                {
                    actual = actual.Izquierdo;
                }

                    return actual.Valor;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Ocurrio un error.");
                return 0;
            }
            }
            public int ObtenerMaximo()
            {
            try
            {
                if (Raiz == null)
                {
                    Console.WriteLine("El arbol esta vacio");
                    return 0;
                }

                Nodo actual = Raiz;

                while (actual.Derecho != null)
                {
                    actual = actual.Derecho;
                }

                return actual.Valor;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Ocurrio un error.");
                return 0;
            }
        }
            public int ObtenerCantidadNodos()
            {
                return ContarNodos(Raiz);
            }

            private int ContarNodos(Nodo nodo)
            {
                if (nodo == null)
                    return 0;

                return 1
                    + ContarNodos(nodo.Izquierdo)
                    + ContarNodos(nodo.Derecho);
            }
            public int ObtenerAltura()
            {
                return CalcularAltura(Raiz);
            }

            private int CalcularAltura(Nodo nodo)
            {
                if (nodo == null)
                    return 0;

                int alturaIzquierda = CalcularAltura(nodo.Izquierdo);
                int alturaDerecha = CalcularAltura(nodo.Derecho);

                return 1 + Math.Max(alturaIzquierda, alturaDerecha);
            }

            public int ContarHojas()
            {
                return ContarHojasRecursivo(Raiz);
            }

            private int ContarHojasRecursivo(Nodo nodo)
            {
                if (nodo == null)
                    return 0;

                if (nodo.Izquierdo == null && nodo.Derecho == null)
                    return 1;

                return ContarHojasRecursivo(nodo.Izquierdo)
                    + ContarHojasRecursivo(nodo.Derecho);
            }

            public void Eliminar(int valor)
            {
                Raiz = EliminarRecursivo(Raiz, valor);
            }

            private Nodo EliminarRecursivo(Nodo nodo, int valor)
            {
                if (nodo == null)
                    return null;

                if (valor < nodo.Valor)
                {
                    nodo.Izquierdo =
                        EliminarRecursivo(nodo.Izquierdo, valor);
                }
                else if (valor > nodo.Valor)
                {
                    nodo.Derecho =
                        EliminarRecursivo(nodo.Derecho, valor);
                }
                else
                {
                    if (nodo.Izquierdo == null && nodo.Derecho == null)
                        return null;

                    if (nodo.Izquierdo == null)
                        return nodo.Derecho;

                    if (nodo.Derecho == null)
                        return nodo.Izquierdo;

                    Nodo sucesor = nodo.Derecho;

                    while (sucesor.Izquierdo != null)
                    {
                        sucesor = sucesor.Izquierdo;
                    }

                    nodo.Valor = sucesor.Valor;

                    nodo.Derecho =
                        EliminarRecursivo(nodo.Derecho, sucesor.Valor);
                }

                return nodo;
            }

            public bool EsValido()
            {
                return EsValidoRecursivo(
                    Raiz,
                    null,
                    null
                );
            }

            private bool EsValidoRecursivo(
                Nodo nodo,
                int? minimo,
                int? maximo)
            {
                if (nodo == null)
                    return true;

                if (minimo.HasValue && nodo.Valor <= minimo.Value)
                    return false;

                if (maximo.HasValue && nodo.Valor >= maximo.Value)
                    return false;

                bool izquierdoValido =
                    EsValidoRecursivo(
                        nodo.Izquierdo,
                        minimo,
                        nodo.Valor
                    );

                bool derechoValido =
                    EsValidoRecursivo(
                        nodo.Derecho,
                        nodo.Valor,
                        maximo
                    );

                return izquierdoValido && derechoValido;
            }
        }
}


