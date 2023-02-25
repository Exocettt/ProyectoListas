using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpleCircular_LaboinetIbarra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista myList = new Lista();
            myList.IniciarNodo("Uno");
            myList.IniciarNodo("Dos");
            myList.IniciarNodo("Tres");
            myList.DespliegueLista();
            Console.WriteLine("");
            Console.WriteLine("Eliminar el segundo Nodo:");
            myList.EliminarNodo("Dos");
            Console.WriteLine("");
            myList.DespliegueLista();
            Console.WriteLine("");
            Console.WriteLine("Buscar el Nodo 'Tres' y el Nodo 'Dos' :");
            myList.BuscarNodo("Tres");
            myList.BuscarNodo("Dos");
            Console.ReadKey();
        }
    }
}
