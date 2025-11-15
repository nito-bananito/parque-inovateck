using ParqueInnovatec.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueInnovatec.Forms
{
    public partial class FrmGrafoRutas : Form
    {
        Grafo grafo;

        public FrmGrafoRutas()
        {
            InitializeComponent();
            grafo = new Grafo();
        }
        private void btnAgregarConexiones_Click(object sender, EventArgs e)
        {
            string origen = tbOrigen.Text.Trim();
            string destino = tbDestino.Text.Trim();
            string pesoText = tbPeso.Text.Trim();

            // Validación: campos vacíos
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino) || string.IsNullOrWhiteSpace(pesoText))
            {
                lblEstadoGrafo.Text = "Debe ingresar origen, destino y peso.";
                return;
            }

            if (!int.TryParse(tbPeso.Text.Trim(), out int peso))
            {
                lblEstadoGrafo.Text = "Peso inválido.";
                return;
            }
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
            {
                lblEstadoGrafo.Text = "Ingrese origen y destino.";
                return;
            }

            grafo.AgregarArista(origen, destino, peso);
            lbConexiones.Items.Add($"Conexión: {origen} ↔ {destino} (peso {peso})");
            lblEstadoGrafo.Text = $"Se agregó conexión entre '{origen}' y '{destino}' con peso {peso}.";
            tbPeso.Clear();
            tbDestino.Clear();
            tbOrigen.Clear();
            tbOrigen.Focus();
        }

        private void btnMostarConexioness_Click(object sender, EventArgs e)
        {
            lbConexiones.Items.Clear();
            foreach (var kv in grafo.ObtenerConexiones())
                foreach (var (destino, peso) in kv.Value)
                    lbConexiones.Items.Add($"{kv.Key} ↔ {destino} ({peso})");
            lblEstadoGrafo.Text = "Conexiones mostradas.";
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            string inicio = tbOrigen.Text.Trim();
            string destino = tbDestino.Text.Trim();
            if (string.IsNullOrWhiteSpace(inicio) || string.IsNullOrWhiteSpace(destino))
            {
                lblEstadoGrafo.Text = "Ingrese inicio y destino de la ruta.";
                return;
            }

            var (dist, prev) = grafo.Dijkstra(inicio);
            lbRutas.Items.Clear();

            if (!dist.ContainsKey(destino) || dist[destino] == int.MaxValue)
            {
                lblEstadoGrafo.Text = $"No hay ruta de '{inicio}' a '{destino}'.";
                return;
            }

            var ruta = grafo.ReconstruirRuta(inicio, destino, prev);
            if (ruta.Count == 0)
            {
                lblEstadoGrafo.Text = $"No se pudo reconstruir la ruta de '{inicio}' a '{destino}'.";
                return;
            }

            lbRutas.Items.Add($"Distancia mínima: {dist[destino]}");
            lbRutas.Items.Add("Ruta:");
            foreach (var v in ruta) lbRutas.Items.Add($" - {v}");

            lblEstadoGrafo.Text = $"Ruta más corta calculada de '{inicio}' a '{destino}'.";
        }

        private void btnValidarConexion_Click(object sender, EventArgs e)
        {

        }
    }
}
