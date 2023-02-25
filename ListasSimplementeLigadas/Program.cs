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
            Nodo nodo = new Nodo();
            Lista lista = new Lista();
            lista.AgregarCircular("A");
            lista.AgregarCircular("B");
            lista.AgregarCircular("C");
            Console.WriteLine("Recorrido de la lista circular:");
            Console.WriteLine(lista.RecorrerCircular());
        }

    }



    }

