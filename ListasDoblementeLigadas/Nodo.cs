using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public string datos;
        public Nodo previo;
        public Nodo siguiente;

        public Nodo(string d)
        {
            datos = d;
            previo = null;
            siguiente = null;   
        }
    }
}
