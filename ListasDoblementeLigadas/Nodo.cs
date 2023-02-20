using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public int datos;
        public Nodo previo;
        public Nodo siguiente;

        public Nodo(int d)
        {
            datos = d;
            previo = null;
            siguiente = null;   
        }
    }
}
