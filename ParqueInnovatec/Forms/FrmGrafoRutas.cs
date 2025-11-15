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
            string distanciaTex = tbDistancia.Text.Trim();

            // Validación: campos vacíos
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino) || string.IsNullOrWhiteSpace(distanciaTex))
            {
                lblEstadoGrafo.Text = "Debe ingresar origen, destino y distancia.";
                return;
            }

            if (!int.TryParse(tbDistancia.Text.Trim(), out int distancia))
            {
                lblEstadoGrafo.Text = "distancia inválido.";
                return;
            }
            if (string.IsNullOrWhiteSpace(origen) || string.IsNullOrWhiteSpace(destino))
            {
                lblEstadoGrafo.Text = "Ingrese origen y destino.";
                return;
            }

            grafo.AgregarArista(origen, destino, distancia);
            lbConexiones.Items.Add($"Conexión: {origen} ↔ {destino} (distancia {distancia})");
            lblEstadoGrafo.Text = $"Se agregó conexión entre '{origen}' y '{destino}' con distancia {distancia}.";

            tbDistancia.Clear();
            tbDestino.Clear();
            tbOrigen.Clear();
            tbOrigen.Focus();
        }

        private void btnMostarConexioness_Click(object sender, EventArgs e)
        {
            lbConexiones.Items.Clear();
            foreach (var kv in grafo.ObtenerConexiones())
                foreach (var (destino, distancia) in kv.Value)
                    lbConexiones.Items.Add($"{kv.Key} ↔ {destino} ({distancia})");
            lblEstadoGrafo.Text = "Conexiones mostradas.";
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            if (lbConexiones.SelectedItems.Count < 1)
            {
                lblEstadoGrafo.Text = "Seleccione al menos una conexión.";
                return;
            }

            // Tomamos el primer nodo de la primera conexión seleccionada
            string inicio = lbConexiones.SelectedItems[0].ToString().Split('↔')[0].Trim();
            string destino = lbConexiones.SelectedItems[0].ToString().Split('↔')[1].Split('(')[0].Trim();

            var (dist, prev) = grafo.Dijkstra(inicio);
            lbRutas.Items.Clear();

            if (!dist.ContainsKey(destino) || dist[destino] == int.MaxValue)
            {
                lblEstadoGrafo.Text = $"No hay ruta de '{inicio}' a '{destino}'.";
                return;
            }

            var ruta = grafo.ReconstruirRuta(inicio, destino, prev);
            lbRutas.Items.Add($"Distancia mínima: {dist[destino]}");
            lbRutas.Items.Add("Ruta:");
            foreach (var v in ruta) lbRutas.Items.Add($" - {v}");

            lblEstadoGrafo.Text = $"Ruta más corta calculada de '{inicio}' a '{destino}'.";
        } 
        private void btnValidarConexion_Click(object sender, EventArgs e)
        {
            if (grafo.EsConexo())
            {
                lblEstadoGrafo.Text = "El grafo es conexo: todos los nodos están conectados.";
            }
            else
            {
                lblEstadoGrafo.Text = "El grafo NO es conexo: existen nodos aislados.";
            }
        }

        private void lbConexiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbConexiones.SelectedItem == null) return;

            // Ejemplo de formato: "Conexión: A ↔ B (distancia 5)"
            string fila = lbConexiones.SelectedItem.ToString();

            try
            {
                // Quitamos la palabra "Conexión:" si existe
                fila = fila.Replace("Conexión:", "").Trim();

                // Separar origen y destino
                string[] partes = fila.Split('↔');
                string origen = partes[0].Trim();
                string resto = partes[1].Trim();

                // Separar destino y distancia
                string destino = resto.Split('(')[0].Trim();
                string distanciaTexto = resto.Split('(')[1].Replace("distancia", "").Replace(")", "").Trim();

                // Asignar a los TextBox
                tbOrigen.Text = origen;
                tbDestino.Text = destino;
                tbDistancia.Text = distanciaTexto;
            }
            catch
            {
                lblEstadoGrafo.Text = "Error al procesar la fila seleccionada.";
            }
        }
    }
}
