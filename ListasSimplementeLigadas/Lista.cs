using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    public class Lista : ListaBase
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        public Lista()
        {
            nodoInicial = null;
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == null)
            {
                return true;
            }
            return false;
            //return nodoInicial.Siguiente == null;

        }
        public void VaciarLista()
        {
            nodoInicial.Siguiente = null;
        }
        public string Recorrer()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos += nodoActual.Valor + "\n";
            }
            return datos;
        }
        public void Agregar(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Siguiente = nodoNuevo;
        }

        public void AgregarCircular(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                
            }

            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor);
            nodoNuevo.Anterior = nodoActual;
            nodoActual.Siguiente = nodoNuevo;
            nodoInicial.Anterior = nodoNuevo; // Enlace circular
            nodoNuevo.Siguiente = nodoInicial; // Enlace circular
        }

        // Recorre la lista circular y devuelve un string con los valores de los nodos en la lista
        public string RecorrerCircular()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            do
            {
                nodoActual = nodoActual.Siguiente;
                datos += nodoActual.Valor + "\n";
            } while (nodoActual != nodoInicial);
            return datos;


        }
    }

    public class ListaBase
    {
    }
}






