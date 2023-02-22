using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista= new Lista();

            Console.WriteLine("La lista es: ");
            lista.AgregarInicio("Tres");
            lista.AgregarInicio("Dos");
            lista.AgregarInicio("Uno");

            lista.AgregarFinal("Cuatro");

            lista.RecorrerLista();

            Console.WriteLine("Buscar el indice 2: ");
            int indice = lista.Indice("Tres");
            if(indice != -1)
            {
                Console.WriteLine("El nodo 'Tres' se encuentra en el Indice {0}", indice);
            }
            else
            {
                Console.WriteLine("El nodo 'Tres' no se encontro en la lista");
            }

            Console.WriteLine("");
            Console.WriteLine("Buscar el Nodo Dos: ");
            Nodo actual = lista.Buscar("Dos");
            if (actual != null)
            {
                Console.WriteLine(actual.datos);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("");

            Console.WriteLine("Buscador del anterior nodo del 'Dos' ");
            Nodo nodoT = lista.Buscar("Dos");
            lista.NodoPrevio(nodoT);

            Console.WriteLine("");

            Console.WriteLine("Buscador del nodo siguiente del 'Dos' ");
            Nodo nodoS = lista.Buscar("Dos");
            lista.NodoSiguiente(nodoS);

            Console.WriteLine("");

            lista.EliminarNodo("Dos");  
            Console.WriteLine("");
            lista.RecorrerLista();
 
            lista.EliminarNodo("Dos");

            Console.ReadKey();
        }
    }
}
