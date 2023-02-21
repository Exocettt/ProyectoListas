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

    }
}
