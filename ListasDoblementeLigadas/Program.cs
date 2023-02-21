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

            lista.RecorrerLista();

            Console.WriteLine("Buscar el indice 1: ");
            int indice = lista.Indice("Uno");
            if(indice != -1)
            {
                Console.WriteLine("El nodo 'Uno' se encuentra en el Indice {0}", indice);
            }
            else
            {
                Console.WriteLine("El nodo 'Uno' no se encontro en la lista");
            }



            lista.EliminarNodo("Dos");
            Console.WriteLine("");
            lista.RecorrerLista();
 
            lista.EliminarNodo("Dos");

            Console.ReadKey();
        }
    }
}
