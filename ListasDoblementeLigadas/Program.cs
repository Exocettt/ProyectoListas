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

            lista.AgregarInicio("Uno");
            lista.AgregarInicio("Dos");
            lista.AgregarInicio("Tres");

            lista.RecorrerLista();

        }
    }
}
