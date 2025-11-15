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
            tbOrigen.Focus();
            string origen = tbOrigen.Text;
            string destino = tbDestino.Text;
            int peso = int.Parse(tbPeso.Text);

            grafo.AgregarArista(origen, destino, peso);

            lbConexiones.Items.Add($"Conexión: {origen} ↔ {destino} con peso {peso}");
            lblEstadoGrafo.Text = $"Se agregó conexión entre '{origen}' y '{destino}' con peso {peso}.";
            tbDestino.Clear();
            tbPeso.Clear();
            tbOrigen.Clear();
            tbOrigen.Focus();
        }

        private void btnMostarConexioness_Click(object sender, EventArgs e)
        {
            lbConexiones.Items.Clear();
            var conexiones = grafo.ObtenerConexiones();
            foreach (var v in conexiones)
            {
                foreach (var (destino, peso) in v.Value)
                {
                    lbConexiones.Items.Add($"{v.Key} ↔ {destino} ({peso})");
                }
            }
            lblEstadoGrafo.Text = "Conexiones mostradas.";
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            string inicio = tbOrigen.Text; // usamos el origen como nodo inicial
            var distancias = grafo.Dijkstra(inicio);

            lbRutas.Items.Clear();
            foreach (var kvp in distancias)
            {
                lbRutas.Items.Add($"Desde '{inicio}' hasta '{kvp.Key}': {kvp.Value}");
            }

            lblEstadoGrafo.Text = $"Ruta más corta calculada desde '{inicio}'.";
        }
    }
}
