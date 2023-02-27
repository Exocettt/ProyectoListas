using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeLigadaCircular
{
    internal class Nodo
    {
        public class ListaDobleCircular<T>
        {
            public T Datos { get; set; }
            public ListaDobleCircular<T> siguiente { get; set; }
            public ListaDobleCircular<T> anterior { get; set; }

            public ListaDobleCircular(T datos)
            {
                Datos = datos;
            }
        }
    }
}
