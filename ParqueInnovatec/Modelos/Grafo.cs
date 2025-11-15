using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueInnovatec.Modelos
{
    internal class Grafo
    {
        private Dictionary<string, List<(string destino, int peso)>> adyacencia;

        public Grafo()
        {
            adyacencia = new Dictionary<string, List<(string, int)>>();
        }

        public void AgregarVertice(string vertice)
        {
            if (!adyacencia.ContainsKey(vertice))
                adyacencia[vertice] = new List<(string, int)>();
        }

        public void AgregarArista(string origen, string destino, int peso)
        {
            AgregarVertice(origen);
            AgregarVertice(destino);
            adyacencia[origen].Add((destino, peso));
            adyacencia[destino].Add((origen, peso));
        }

        public Dictionary<string, int> Dijkstra(string inicio)
        {
            var dist = adyacencia.Keys.ToDictionary(v => v, v => int.MaxValue);
            dist[inicio] = 0;

            while (visitados.Count < adyacencia.Count)
            {
                var u = dist.Where(x => !visitados.Contains(x.Key))
                            .OrderBy(x => x.Value).First().Key;
                visitados.Add(u);

                foreach (var (vecino, peso) in adyacencia[u])
                {
                    if (dist[u] + peso < dist[vecino])
                        dist[vecino] = dist[u] + peso;
                }
            }
            return dist;
        }

        public Dictionary<string, List<(string destino, int peso)>> ObtenerConexiones()
        {
            return adyacencia;
        }
    }
}
