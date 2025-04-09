using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;

namespace PryPueblox
{
    public partial class FrmTicket: Form
    {
      
            // Si ClsConexion solo se usa para cargar los combos, podrías mover esa lógica aquí
            // o asegurar que la instancia 'cls' se maneje correctamente (Dispose si es necesario).
            ClsConexion cls = new ClsConexion();

            // La variable _mesa no se usa en el código mostrado, si no la necesitas, elimínala.
            // private string _mesa;

            // La variable numeroMesa de clase no se usa, se obtiene localmente en BtnImprimir_Click. Elimínala.
            // private int numeroMesa;

            // Si FrmAbrirMesa no se usa aquí, elimínala.
            // private FrmAbrirMesa frmAbrirMesa;

            public FrmTicket()
            {
                InitializeComponent();
                // Es buena práctica asignar el número de mesa al crear/mostrar el form, no solo en SetMesa
            }

            private void FrmTicket_Load(object sender, EventArgs e)
            {
                // Cargar todos los ComboBox con los productos
                // Asegúrate que cls.CargarPlatos añade los NOMBRES de los productos
                // y que esos nombres coinciden exactamente con la BD.
                try
                {
                    cls.CargarPlatos(CmbMenu);
                    cls.CargarPlatos(Cmb1);
                    cls.CargarPlatos(Cmb2);
                    cls.CargarPlatos(Cmb3);
                    cls.CargarPlatos(Cmb4);
                    cls.CargarPlatos(Cmb5);
                    cls.CargarPlatos(Cmb6);
                    cls.CargarPlatos(Cmb7);
                    // Es buena idea poner un item vacío o "Seleccione..." al principio
                    // Ejemplo: CmbMenu.Items.Insert(0, "Seleccione Plato..."); CmbMenu.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar platos: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Considera deshabilitar el botón de imprimir si la carga falla
                }
            }

            // Este método parece recibir el número de mesa desde otro form
            public void SetMesa(string mesaNumero) // Cambiado nombre para claridad
            {
                if (int.TryParse(mesaNumero, out int numMesa))
                {
                    LblMesa.Text = $"Mesa: {numMesa}";
                    this.Text = $"Ticket - Mesa {numMesa}"; // Título más descriptivo
                }
                else
                {
                    LblMesa.Text = "Mesa: Error";
                    this.Text = "Ticket - Error";
                    MessageBox.Show($"El número de mesa '{mesaNumero}' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Quizás deshabilitar el botón de imprimir
                }
                // _mesa = mesaNumero; // Elimina si _mesa no se usa
            }

            private void BtnImprimir_Click(object sender, EventArgs e)
            {
                // 1. Validar que se haya seleccionado una mesa válida
                if (!int.TryParse(LblMesa.Text.Replace("Mesa: ", ""), out int numeroMesa) || numeroMesa <= 0)
                {
                    MessageBox.Show("Número de mesa inválido. No se puede generar el ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar que se haya seleccionado un método de pago
                string metodoPago = ObtenerMetodoPago();
                if (metodoPago == "Sin especificar")
                {
                    MessageBox.Show("Por favor, seleccione un método de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 3. Recolectar los controles
                ComboBox[] cmbPlatos = { CmbMenu, Cmb1, Cmb2, Cmb3, Cmb4, Cmb5, Cmb6, Cmb7 };
                NumericUpDown[] numCantidades = { NumCantidad, N1, N2, N3, N4, N5, N6, N7 };

                // 4. Validar que al menos haya un producto seleccionado con cantidad > 0 (Opcional pero recomendado)
                bool hayItems = false;
                for (int i = 0; i < cmbPlatos.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(cmbPlatos[i].GetItemText(cmbPlatos[i].SelectedItem)) && numCantidades[i].Value > 0)
                    {
                        hayItems = true;
                        break;
                    }
                }
                if (!hayItems)
                {
                    MessageBox.Show("No se ha seleccionado ningún producto o cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 5. Intentar generar e imprimir el ticket
                try
                {
                    // Deshabilitar botón para evitar doble click mientras procesa (opcional)
                    BtnImprimir.Enabled = false;

                    TicketPrinter ticketPrinter = new TicketPrinter();
                    ticketPrinter.GenerarTicket(numeroMesa, metodoPago, cmbPlatos, numCantidades);

                    // 6. Éxito - Cerrar este formulario (o limpiarlo para nueva orden en la misma mesa)
                    MessageBox.Show("Ticket enviado a la impresora.", "Impresión Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerrar DESPUÉS de que la impresión se mandó con éxito
                }
                catch (Exception ex)
                {
                    // Captura cualquier error inesperado durante la generación/impresión
                    MessageBox.Show($"Ocurrió un error inesperado al generar el ticket: {ex.Message}", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Habilitar el botón nuevamente si hubo error
                    BtnImprimir.Enabled = true;
                }
            }

            private void BtnVolver_Click(object sender, EventArgs e)
            {
                // Considera preguntar si está seguro si hay datos cargados
                // DialogResult dr = MessageBox.Show("¿Seguro que quieres volver? Se perderán los datos no guardados.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // if (dr == DialogResult.Yes)
                // {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Close();
                // }
            }

            private string ObtenerMetodoPago()
            {
                if (RdtEfectivo.Checked) return "Efectivo";
                if (RdtTransfe.Checked) return "Transferencia"; // Cuidado con la tilde si la usas en la comparación
                if (RdtDebito.Checked) return "Débito";       // Cuidado con la tilde
                return "Sin especificar";
            }


            private void BtnMas_Click(object sender, EventArgs e)
        {
            LblC1.Show();
            Cmb1.Show();
            B1.Show();
            B2.Show();
            N1.Show();

        }

        private void B2_Click(object sender, EventArgs e)
        {
            LblC1.Hide();
            Cmb1.Hide();
            B1.Hide();
            B2.Hide();
            N1.Hide();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            LblC2.Show();
            Cmb2.Show();
            B3.Show();
            B4.Show();
            N2.Show();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            LblC2.Hide();
            Cmb2.Hide();
            B3.Hide();
            B4.Hide();
            N2.Hide();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            LblC3.Show();
            Cmb3.Show();
            B5.Show();
            B6.Show();
            N3.Show();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            LblC4.Show();
            Cmb4.Show();
            B7.Show();
            B8.Show();
            N4.Show();
        }

        private void B6_Click(object sender, EventArgs e)
        {
            LblC3.Hide();
            Cmb3.Hide();
            B5.Hide();
            B6.Hide();
            N3.Hide();
        }

        private void B8_Click(object sender, EventArgs e)
        {
            LblC4.Hide();
            Cmb4.Hide();
            B7.Hide();
            B8.Hide();
            N4.Hide();
        }

        private void B7_Click(object sender, EventArgs e)
        {
            LblC5.Show();
            Cmb5.Show();
            B11.Show();
            B10.Show();
            N5.Show();
        }

        private void B10_Click(object sender, EventArgs e)
        {
            LblC6.Show();
            Cmb6.Show();
            B12.Show();
            B13.Show();
            N6.Show();
        }

        private void B11_Click(object sender, EventArgs e)
        {
            LblC5.Hide();
            Cmb5.Hide();
            B11.Hide();
            B10.Hide();
            N5.Hide();
        }

        private void B12_Click(object sender, EventArgs e)
        {
            LblC7.Show();
            Cmb7.Show();
         
            B15.Show();
            N7.Show();
        }

        private void B13_Click(object sender, EventArgs e)
        {
            LblC6.Hide();
            Cmb6.Hide();
            B12.Hide();
            B13.Hide();
            N6.Hide();
        }

        private void B14_Click(object sender, EventArgs e)
        {
          
        }

        private void B15_Click(object sender, EventArgs e)
        {
            LblC7.Hide();
            Cmb7.Hide();
         
            B15.Hide();
            N7.Hide();
        }
        private void CmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Npersonas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void N7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblC7_Click(object sender, EventArgs e)
        {

        }

        private void N6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblC6_Click(object sender, EventArgs e)
        {

        }

        private void N5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblC5_Click(object sender, EventArgs e)
        {

        }

        private void N4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblC4_Click(object sender, EventArgs e)
        {

        }

        private void N3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblC3_Click(object sender, EventArgs e)
        {

        }

        private void N2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblC2_Click(object sender, EventArgs e)
        {

        }

        private void N1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblC1_Click(object sender, EventArgs e)
        {

        }



 

        private void NumCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Gb_Enter(object sender, EventArgs e)
        {

        }

        private void LblCantidad_Click(object sender, EventArgs e)
        {

        }

  

    }
}
