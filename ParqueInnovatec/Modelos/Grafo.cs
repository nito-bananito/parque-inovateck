using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueInnovatec.Modelos
{
    public class Grafo
    {
        private readonly Dictionary<string, List<(string destino, int distancia)>> ady;

        public Grafo()
        {
            ady = new Dictionary<string, List<(string, int)>>();
        }

        public void AgregarVertice(string v)
        {
            if (!ady.ContainsKey(v)) ady[v] = new List<(string, int)>();
        }

        public void AgregarArista(string origen, string destino, int distancia)
        {
            AgregarVertice(origen);
            AgregarVertice(destino);
            ady[origen].Add((destino, distancia));
            ady[destino].Add((origen, distancia));
        }

        public Dictionary<string, List<(string destino, int peso)>> ObtenerConexiones() => ady;

        public bool EsConexo()
        {
            if (ady.Count == 0) return true;
            var start = ady.Keys.First();
            var visit = new HashSet<string>();
            var q = new Queue<string>();
            visit.Add(start);
            q.Enqueue(start);

            while (q.Count > 0)
            {
                var u = q.Dequeue();
                foreach (var (v, _) in ady[u])
                {
                    if (!visit.Contains(v))
                    {
                        visit.Add(v);
                        q.Enqueue(v);
                    }
                }
            }
            return visit.Count == ady.Count;
        }

        public (Dictionary<string, int> dist, Dictionary<string, string> prev) Dijkstra(string inicio)
        {
            var dist = ady.Keys.ToDictionary(v => v, v => int.MaxValue);
            var prev = ady.Keys.ToDictionary(v => v, v => (string)null);
            var vis = new HashSet<string>();
            if (!ady.ContainsKey(inicio)) return (dist, prev);

            dist[inicio] = 0;

            while (vis.Count < ady.Count)
            {
                var u = dist
                    .Where(kv => !vis.Contains(kv.Key))
                    .OrderBy(kv => kv.Value)
                    .FirstOrDefault().Key;
                if (u == null) break;
                vis.Add(u);

                foreach (var (v, distancia) in ady[u])
                {
                    if (dist[u] + distancia < dist[v])
                    {
                        dist[v] = dist[u] + distancia;
                        prev[v] = u;
                    }

                }
            }
            return (dist, prev);
        }

        public List<string> ReconstruirRuta(string inicio, string destino, Dictionary<string, string> prev)
        {
            var ruta = new List<string>();
            if (!ady.ContainsKey(inicio) || !ady.ContainsKey(destino)) return ruta;

            string actual = destino;
            while (actual != null)
            {
                ruta.Add(actual);
                if (actual == inicio) break;
                actual = prev.ContainsKey(actual) ? prev[actual] : null;
            }
            ruta.Reverse();
            if (ruta.Count == 0 || ruta.First() != inicio) return new List<string>();
            return ruta;
        }
    }
}
