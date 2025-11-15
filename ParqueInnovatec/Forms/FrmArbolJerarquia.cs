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

            private void btnInsertarNodo_Click(object sender, EventArgs e)
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

                    lblEstadoArbol.Text = "Nodo insertado correctamente.";
                }
                else
                {
                    lblEstadoArbol.Text = "Padre no encontrado.";
                }
            }

            private void btnContarNodos_Click(object sender, EventArgs e)
            {
                int total = arbol.Contar(arbol.Raiz);
                lblEstadoArbol.Text = $"Total de nodos: {total}";
            }
        }
}
