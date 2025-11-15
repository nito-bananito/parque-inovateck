using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueInnovatec.Modelos
{
    public class Nodo
    {
            public string Nombre { get; set; }
            public List<Nodo> Hijos { get; set; }

            public Nodo(string nombre)
            {
                Nombre = nombre;
                Hijos = new List<Nodo>();
            }

            public void AgregarHijo(Nodo hijo)
            {
                Hijos.Add(hijo);
            }
    }
}
