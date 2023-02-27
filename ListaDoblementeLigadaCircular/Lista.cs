using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ListaDoblementeLigadaCircular.Nodo;

namespace ListaDoblementeLigadaCircular
{
    internal class Lista
    {
        public class DoublyLinkedList<T>
        {
            private ListaDobleCircular<T> sig;
            private ListaDobleCircular<T> ant;

            public int Count { get; private set; }

            public void Agregar(T datos)
            {
                var newNode = new ListaDobleCircular<T>(datos);

                if (Count == 0)
                {
                    sig = newNode;
                    ant = newNode;
                    sig.siguiente = ant;
                    ant.anterior = sig;
                }
                else
                {
                    newNode.siguiente = sig;
                    sig.anterior = newNode;
                    sig = newNode;
                    sig.anterior = ant;
                    ant.siguiente = sig;
                }

                Count++;
            }
            public void AgregarFinal(T datos)
            {
                var newNode = new ListaDobleCircular<T>(datos);

                if (Count == 0)
                {
                    sig = newNode;
                    ant = newNode;
                    sig.siguiente = ant;
                    ant.anterior = sig;
                }
                else
                {
                    newNode.anterior = ant;
                    ant.siguiente = newNode;
                    ant = newNode;
                    sig.anterior = ant;
                    ant.siguiente = sig;
                }

                Count++;
            }


            public void EliminarInicio()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("La lista esta vacia.");
                }

                if (Count == 1)
                {
                    sig = null;
                    ant = null;
                }
                else
                {
                    sig = sig.siguiente;
                    sig.anterior = ant;
                    ant.siguiente = sig;
                }

                Count--;
            }

            public void EliminarFinal()
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("La lista esta vacia.");
                }

                if (Count == 1)
                {
                    sig = null;
                    ant = null;
                }
                else
                {
                    ant = ant.anterior;
                    ant.siguiente = sig;
                    sig.anterior = ant;
                }

                Count--;
            }

            public DoublyLinkedListNode<T> EncontrarNodo(T datos)
            {
                if (Count == 0)
                {
                    return null;
                }

                var currentNode = sig;

                do
                {
                    if (currentNode.Datos.Equals(datos))
                    {
                        datos = currentNode.Datos;
                        Console.WriteLine(datos);
                    }

                    currentNode = currentNode.siguiente;
                }
                while (currentNode != sig);

                return null;
            }

            public void Recorrer()
            {
                if (Count == 0)
                {
                    Console.WriteLine("La lista esta vacia.");
                    return;
                }

                var currentNode = sig;

                do
                {
                    Console.WriteLine(currentNode.Datos);
                    currentNode = currentNode.siguiente;
                } while (currentNode != sig);
            }
        }

    }
}
