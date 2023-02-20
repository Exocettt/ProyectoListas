using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            Console.WriteLine("La lista es: ");
            lista.Agregar("Uno");
            lista.Agregar("Dos");
            lista.Agregar("Tres");

            lista.AgregarNodoInicio("Cero");

            Console.WriteLine(lista.Recorrer());

            Console.WriteLine("Buscar el indice 2: ");
            Nodo NodoBusquedaIndice = lista.BuscarPorIndice(2);
            if (NodoBusquedaIndice != null)
            {
                Console.WriteLine(NodoBusquedaIndice.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("");
            Console.WriteLine("Buscar el Nodo Uno: ");
            Nodo NodoBusqueda = lista.Buscar("Uno");
            if (NodoBusqueda != null)
            {
                Console.WriteLine(NodoBusqueda.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("");
            Console.WriteLine("Buscar el Nodo anterior al Dos:");
            Nodo NodoBusquedaAnterior = lista.BuscarAnterior("Dos");
            if (NodoBusquedaAnterior != null)
            {
                Console.WriteLine(NodoBusquedaAnterior.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }


            Console.WriteLine("");
            Console.WriteLine("Eliminando el uno");
            lista.BorrarNodo("Uno");
            Console.WriteLine(lista.Recorrer());
            Console.ReadKey();
        }
    }
}
