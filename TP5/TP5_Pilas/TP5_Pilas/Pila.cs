using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Pilas
{
    internal class Pila
    {
        public Nodo tope { get; set; }
        public void apilar(Nodo nodo)
        {
            if (tope == null)
            {
                tope = nodo;
            } else
            {
                Nodo aux = tope;
                tope = nodo;
                tope.siguiente = aux;
            }
        }
        public void desapilar()
        {
            if (tope != null)
            {
                tope = tope.siguiente;
            }
        }

        public Nodo obtenerTope()
        {
            return tope;
        }
    }
}
