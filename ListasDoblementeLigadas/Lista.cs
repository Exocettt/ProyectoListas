using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        public Nodo arriba;
        public Nodo abajo;

        public Lista()
        {
            arriba = null;
            abajo = null;
        }

        public bool ValidaVacio()
        {
            return arriba == null;
        }

        public void vaciarLista()
        {
            arriba = null;
            abajo = null;
        }

        public int Indice(String datos)
        {
            int Indice = 0;
            Nodo actual = arriba;
            while (actual != null)
            {
                if (actual.datos == datos)
                {
                    return Indice;
                }
                actual = actual.siguiente;
                Indice++;
            }
            return -1;
        }

        public Nodo Buscar(string datos)
        {
            Nodo actual = arriba;

            while (actual != null)
            {
                if(actual.datos == datos)
                {
                    return actual;
                }
                actual = actual.siguiente;
            }

            return null;
        }

        public void NodoPrevio(Nodo nodo)
        {
            if (nodo == null || nodo.previo == null)
            {
                Console.WriteLine("El nodo no tiene nodo anterior");
            }
            else
            {
                Console.WriteLine("El nodo anterior es: " + nodo.previo.datos);
            }
        }

        public void NodoSiguiente(Nodo nodo)
        {
            if (nodo == null || nodo.siguiente == null)
            {
                Console.WriteLine("El nodo no tiene nodo siguiente");
            }
            else
            {
                Console.WriteLine("El nodo siguiente es: " + nodo.siguiente.datos);
            }
        }

        public void RecorrerLista()
        {
            Nodo actual = arriba;
            while(actual != null)
            {
                Console.WriteLine(actual.datos + " ");
                actual = actual.siguiente;
            }
            Console.WriteLine();
        }

        public void AgregarInicio(string datos)
        {
            Nodo nuevoNodo = new Nodo(datos);
            if (arriba == null)
            {
                arriba = nuevoNodo;
                abajo = nuevoNodo;
            }
            else
            {
                nuevoNodo.siguiente = arriba;
                arriba.previo = nuevoNodo;
                arriba = nuevoNodo;
            }
        }

        public void AgregarFinal(string datos)
        {
            Nodo nuevoNodo = new Nodo(datos);

            if(arriba == null)
            {
                arriba = nuevoNodo;
                abajo = nuevoNodo;
            }
            else
            {
                nuevoNodo.previo = abajo;
                abajo.siguiente = nuevoNodo;
                abajo = nuevoNodo;
            }
        }

        public void EliminarNodo(string datos)
        {
            if (ValidaVacio())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            Nodo actual = arriba;

            while (actual != null && actual.datos != datos)
            {
                actual = actual.siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("El nodo {0} no se encontró en la lista", datos);
                return;
            }

            if (actual.previo == null)
            {
                arriba = actual.siguiente;
            }
            else
            {
                actual.previo.siguiente = actual.siguiente;
            }

            if (actual.siguiente == null)
            {
                abajo = actual.previo;
            }
            else
            {
                actual.siguiente.previo = actual.previo;
            }
        }

    }
}
