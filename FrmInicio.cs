using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPueblox
{
    public partial class FrmInicio: Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void revisarPlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar frmConsultarPlatos = new FrmMostrar();
            frmConsultarPlatos.Show();
            this.Hide();
        }

        private void cargarYSeleccionarMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbrirMesa frm = new FrmAbrirMesa();
            frm.Show();
            this.Hide();
        }

        private void cargarPlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargarPlato frmCargarPlatos = new FrmCargarPlato();
            frmCargarPlatos.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
