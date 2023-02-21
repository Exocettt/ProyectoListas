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

        public void ValidaVacio()
        {
           if(arriba==null)
            {
                Console.WriteLine("La lista esta vacia");
            }   
        }

        public void vaciarLista()
        {
            arriba = null;
            abajo = null;
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

        public void AgregarInicio(int datos)
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
        public void EliminarNodo(int datos)
        {
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
