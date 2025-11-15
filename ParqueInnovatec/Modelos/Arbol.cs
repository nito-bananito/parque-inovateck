using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueInnovatec.Modelos
{
    public class Arbol
    {
        public Nodo Raiz { get; }

        public Arbol(string raizNombre)
        {
            Raiz = new Nodo(raizNombre);
        }

        public bool Insertar(string nombrePadre, string nombreHijo)
        {
            var padre = Buscar(Raiz, nombrePadre);
            if (padre == null) return false;
            padre.AgregarHijo(new Nodo(nombreHijo));
            return true;
        }

        public Nodo Buscar(Nodo actual, string nombre)
        {
            if (actual == null) return null;
            if (actual.Nombre == nombre) return actual;

            foreach (var hijo in actual.Hijos)
            {
                var encontrado = Buscar(hijo, nombre);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        public int Contar(Nodo nodo)
        {
            if (nodo == null) return 0;
            int total = 1;
            foreach (var hijo in nodo.Hijos) total += Contar(hijo);
            return total;
        }

        public IEnumerable<(string nombre, int nivel)> RecorridoConNiveles()
        {
            var lista = new List<(string, int)>();
            void DFS(Nodo n, int lvl)
            {
                lista.Add((n.Nombre, lvl));
                foreach (var h in n.Hijos) DFS(h, lvl + 1);
            }
            DFS(Raiz, 0);
            return lista;
        }

        public int NivelDe(string nombre)
        {
            int nivel = -1;
            void DFS(Nodo n, int lvl)
            {
                if (nivel != -1) return;
                if (n.Nombre == nombre) { nivel = lvl; return; }
                foreach (var h in n.Hijos) DFS(h, lvl + 1);
            }
            DFS(Raiz, 0);
            return nivel;
        }
    }
}
