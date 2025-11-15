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
    public partial class FrmArbolJerarquia : Form
    {
        Arbol arbol;

        public FrmArbolJerarquia()
        {
            InitializeComponent();
            arbol = new Arbol("Parque Innovatec");
            tvJerarquia.Nodes.Add(new TreeNode(arbol.Raiz.Nombre) { Name = arbol.Raiz.Nombre });
        }

        private void RecorrerVisual(Nodo nodo, int nivel)
        {
            lbRecorrido.Items.Add(new string('-', nivel) + nodo.Nombre);
            foreach (var hijo in nodo.Hijos)
            {
                RecorrerVisual(hijo, nivel + 1);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string padre = tbArbolP.Text.Trim();
            string hijo = tbArbolH.Text.Trim();

            if (string.IsNullOrWhiteSpace(padre) || string.IsNullOrWhiteSpace(hijo))
            {
                lblEstadoArbol.Text = "Ingrese padre e hijo.";
                return;
            }

            bool ok = arbol.Insertar(padre, hijo);
            if (ok)
            {
                var tvPadre = tvJerarquia.Nodes.Find(padre, true);
                if (tvPadre.Length > 0)
                {
                    tvPadre[0].Nodes.Add(new TreeNode(hijo) { Name = hijo });
                    tvPadre[0].Expand();
                }
                lblEstadoArbol.Text = $"Se agregó el hijo '{hijo}' al padre '{padre}'.";

               
            }
            else
            {
                lblEstadoArbol.Text = $"El padre '{padre}' no fue encontrado.";
            } 
            tbArbolH.Clear();
            tbArbolH.Focus();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            lbRecorrido.Items.Clear();
            foreach (var (nombre, nivel) in arbol.RecorridoConNiveles())
                lbRecorrido.Items.Add($"{new string('-', nivel)}{nombre}");
            lblEstadoArbol.Text = "Recorrido mostrado.";
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = arbol.Contar(arbol.Raiz);
            lblEstadoArbol.Text = $"Total de nodos: {total}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = tbArbolH.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                lblEstadoArbol.Text = "Escriba el nombre a buscar en 'Hijo'.";
                return;
            }

            var encontrado = arbol.Buscar(arbol.Raiz, nombre);
            if (encontrado != null)
            {
                var nodos = tvJerarquia.Nodes.Find(nombre, true);
                if (nodos.Length > 0)
                {
                    tvJerarquia.SelectedNode = nodos[0];
                    nodos[0].EnsureVisible();
                }
                lblEstadoArbol.Text = $"Nodo '{nombre}' encontrado y resaltado.";
            }
            else
            {
                lblEstadoArbol.Text = $"Nodo '{nombre}' no existe en la jerarquía.";
            }
        }
    }
}