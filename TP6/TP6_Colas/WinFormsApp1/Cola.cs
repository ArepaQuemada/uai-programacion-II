using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cola
    {
        public Nodo inicio;
        public void Encolar(Nodo nodo)
        {
            if (inicio == null)
            {
                inicio = nodo;
            }
            else
            {
                Nodo aux = EncontrarFinal(inicio);
                aux.siguiente = nodo;
            }
        }

        private Nodo EncontrarFinal(Nodo nodo)
        {
            if (nodo.siguiente != null)
            {
                return EncontrarFinal(nodo.siguiente);
            }
            return nodo;
        }

        public void Desencolar ()
        {
            if (inicio != null)
            {
                inicio = inicio.siguiente;
            }
        }

        public Nodo  Inicio
        {   
            get { return inicio; }
        }
    }
}
