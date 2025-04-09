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
    public partial class FrmCargarPlato: Form
    {
        public FrmCargarPlato()
        {
            InitializeComponent();
        }
        ClsConexion c = new ClsConexion();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
   
            try
            {
                String nombre = TxtNombre.Text;
                Decimal Precio = Convert.ToDecimal(TxtPrecio.Text);
                Int32 Categoria = CmbCategoria.SelectedIndex + 1;
                c.AgregarPlatos(nombre, Precio, Categoria);
                c.Listar(Grlm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar el plato: \"{ex.Message}\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
         FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCargarPlato_Load(object sender, EventArgs e)
        {
            c.CargarCategorias(CmbCategoria);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
