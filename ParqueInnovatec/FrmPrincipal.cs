using ParqueInnovatec.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParqueInnovatec
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void jerarquíaOrganizativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmArbolJerarquia().Show();
        }

        private void sistemaDeRutasDelParqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGrafoRutas().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea salir de la aplicación?",
                             "Confirmar salida",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var encerio = MessageBox.Show("Estas seguro?","Confirmar salida",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (encerio == DialogResult.Yes)
                {
                    var pliz = MessageBox.Show("...", "Salir?",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                    if (pliz == DialogResult.Yes)
                    {
                        var dame = MessageBox.Show("Pero me tarde mucho haciendo esto", "salir?",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                        if (dame == DialogResult.Yes)
                        {
                            var una = MessageBox.Show("Solo dame una oportunidad mas", "salir...",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                            if (una == DialogResult.Yes)
                            {
                                var oportunidad = MessageBox.Show("Okey te dejare ir tu ganas", "salir?",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                            }
                            else if (una == DialogResult.No)
                            {
                                return;
                            }
                        }
                        else if (dame == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else if (pliz == DialogResult.No)
                    {
                        return;
                    }
                }
                else if(encerio == DialogResult.No)
                {
                    return;
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
