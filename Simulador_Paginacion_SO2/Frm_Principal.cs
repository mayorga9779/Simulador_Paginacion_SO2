using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Paginacion_SO2
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void miiFifo_Click(object sender, EventArgs e)
        {
            Frm_Algoritmo_Fifo frmFifo = Frm_Algoritmo_Fifo.GetInstancia();
            frmFifo.MdiParent = this;
            frmFifo.Show();
        }
    }
}
