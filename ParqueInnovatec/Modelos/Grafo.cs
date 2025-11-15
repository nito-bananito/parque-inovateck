using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueInnovatec.Modelos
{
    public class Grafo
    {
        private readonly Dictionary<string, List<(string destino, int peso)>> _ady;

        public Grafo()
        {
            _ady = new Dictionary<string, List<(string, int)>>();
        }

        public void AgregarVertice(string v)
        {
            if (!_ady.ContainsKey(v)) _ady[v] = new List<(string, int)>();
        }

        public void AgregarArista(string origen, string destino, int peso)
        {
            AgregarVertice(origen);
            AgregarVertice(destino);
            _ady[origen].Add((destino, peso));
            _ady[destino].Add((origen, peso));
        }

        public Dictionary<string, List<(string destino, int peso)>> ObtenerConexiones() => _ady;

        public bool EsConexo()
        {
            if (_ady.Count == 0) return true;
            var start = _ady.Keys.First();
            var visit = new HashSet<string>();
            var q = new Queue<string>();
            visit.Add(start);
            q.Enqueue(start);

            while (q.Count > 0)
            {
                var u = q.Dequeue();
                foreach (var (v, _) in _ady[u])
                {
                    if (!visit.Contains(v))
                    {
                        visit.Add(v);
                        q.Enqueue(v);
                    }
                }
            }
            return visit.Count == _ady.Count;
        }

        public (Dictionary<string, int> dist, Dictionary<string, string> prev) Dijkstra(string inicio)
        {
            var dist = _ady.Keys.ToDictionary(v => v, v => int.MaxValue);
            var prev = _ady.Keys.ToDictionary(v => v, v => (string)null);
            var vis = new HashSet<string>();
            if (!_ady.ContainsKey(inicio)) return (dist, prev);

            while (vis.Count < _ady.Count)
            {
                var u = dist
                    .Where(kv => !vis.Contains(kv.Key))
                    .OrderBy(kv => kv.Value)
                    .FirstOrDefault().Key;
                if (u == null) break;
                vis.Add(u);

                foreach (var (v, peso) in _ady[u])
                {
                    if (dist[u] != int.MaxValue && dist[u] + peso < dist[v])
                    {
                        dist[v] = dist[u] + peso;
                        prev[v] = u;
                    }
                }
            }
            return (dist, prev);
        }

        public List<string> ReconstruirRuta(string inicio, string destino, Dictionary<string, string> prev)
        {
            var ruta = new List<string>();
            if (!_ady.ContainsKey(inicio) || !_ady.ContainsKey(destino)) return ruta;

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
