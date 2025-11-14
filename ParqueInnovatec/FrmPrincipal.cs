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
    }
}
