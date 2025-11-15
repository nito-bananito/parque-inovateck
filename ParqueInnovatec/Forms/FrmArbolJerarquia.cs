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
            string padre = tbArbolP.Text;
            string hijo = tbArbolH.Text;

            Nodo nodoPadre = arbol.Buscar(arbol.Raiz, padre);
            if (nodoPadre != null)
            {
                Nodo nuevo = new Nodo(hijo);
                nodoPadre.AgregarHijo(nuevo);

                TreeNode[] encontrados = tvJerarquia.Nodes.Find(padre, true);
                if (encontrados.Length > 0)
                    encontrados[0].Nodes.Add(new TreeNode(hijo) { Name = hijo });

                lblEstadoArbol.Text = $"Se agregó el hijo '{hijo}' al padre '{padre}'.";
            }
            else
            {
                lblEstadoArbol.Text = $"El padre '{padre}' no fue encontrado.";
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            lbRecorrido.Items.Clear();
            RecorrerVisual(arbol.Raiz, 0);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = arbol.Contar(arbol.Raiz);
            lblEstadoArbol.Text = $"Total de nodos en el árbol: {total}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = tbArbolH.Text;
            Nodo encontrado = arbol.Buscar(arbol.Raiz, nombre);

            if (encontrado != null)
                lblEstadoArbol.Text = $"Nodo '{nombre}' encontrado en la jerarquía.";
            else
                lblEstadoArbol.Text = $"Nodo '{nombre}' no existe en la jerarquía.";
        }
    }
}
