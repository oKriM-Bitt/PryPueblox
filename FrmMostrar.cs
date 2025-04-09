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
    public partial class FrmMostrar: Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }
        ClsConexion c = new ClsConexion();
        private void BtnMostrarSegun_Click(object sender, EventArgs e)
        {
            Grlm1.Show();
            GrlM.Hide();
            c.Listar(Grlm1);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio frmMenu = new FrmInicio();
            frmMenu.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            c.CargarCategorias(CmbCategoria);
        }

        private void CmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grlm1.Hide();
            GrlM.Show();
            int idCategoria;
            if (int.TryParse(CmbCategoria.SelectedValue?.ToString(), out idCategoria))
            {
                c.BuscarPlatosPorCategoria(idCategoria, GrlM);
            }
        }
    }
}
