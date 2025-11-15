using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueInnovatec.Modelos
{
    internal class Arbol
    {
        public Nodo Raiz { get; set; }

        public Arbol(string raizNombre)
        {
            Raiz = new Nodo(raizNombre);
        }

        public Nodo Buscar(Nodo actual, string nombre)
        {
            if (actual.Nombre == nombre) return actual;
            foreach (var hijo in actual.Hijos)
            {
                var encontrado = Buscar(hijo, nombre);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        public void Recorrer(Nodo nodo, int nivel = 0)
        {
            Console.WriteLine(new string('-', nivel) + nodo.Nombre);
            foreach (var hijo in nodo.Hijos)
            {
                Recorrer(hijo, nivel + 1);
            }
        }

        public int Contar(Nodo nodo)
        {
            int total = 1;
            foreach (var hijo in nodo.Hijos)
            {
                total += Contar(hijo);
            }
            return total;
        }
    }
}
