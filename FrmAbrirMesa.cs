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
    public partial class FrmAbrirMesa : Form
    {


        public FrmAbrirMesa()
        {
            InitializeComponent();
            // Asociar el evento Click a todos los botones de mesas
            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("BtnMesa"))
                {
                    ((Button)control).Click += BtnMesa_Click;
                }
            }
        }


        #region Botones
        private Dictionary<string, int> clickCounts = new Dictionary<string, int>();

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }

        private void BtnMesa2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }

        private void BtnMesa4_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa5_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa6_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa7_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa8_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa9_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa10_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa11_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa12_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa13_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa14_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa15_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa16_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa17_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }

        private void BtnMesa18_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa19_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa20_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa21_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa22_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa23_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa28_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa27_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa26_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa25_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa24_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa29_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa30_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa31_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa32_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa33_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa34_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa35_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa36_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa37_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa38_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa39_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa40_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa41_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa42_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa43_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa44_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa45_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa46_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa47_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa48_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa49_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        private void BtnMesa50_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string buttonKey = clickedButton.Name;

                // Inicializar contador si es la primera vez
                if (!clickCounts.ContainsKey(buttonKey))
                {
                    clickCounts[buttonKey] = 0;
                }

                // Incrementar el contador
                clickCounts[buttonKey]++;

                if (clickCounts[buttonKey] == 1)
                {
                    // Primer clic: Poner el botón en rojo y abrir FrmTicket
                    clickedButton.BackColor = Color.Red;

                    // Obtener el número de la mesa y abrir FrmTicket
                    string mesa = buttonKey.Replace("BtnMesa", "");
                    FrmTicket ticketForm = new FrmTicket();
                    ticketForm.SetMesa(mesa);
                    ticketForm.Show();
                }
                else if (clickCounts[buttonKey] == 2)
                {
                    // Segundo clic: Mostrar MessageBox con Yes/No
                    DialogResult result = MessageBox.Show(
                        "Seleccione una acción:\n\n" +
                        "Sí = Modificar\n" +
                        "No = Liberar",
                        "Acción Requerida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Reiniciar el contador
                    clickCounts[buttonKey] = 0;

                    // Cambiar color y abrir FrmTicket solo si es "Modificar"
                    if (result == DialogResult.Yes)
                    {
                        // Modificar: Mantener el botón en rojo y abrir FrmTicket
                        clickedButton.BackColor = Color.Red;

                        // Obtener el número de la mesa y abrir FrmTicket
                        string mesa = buttonKey.Replace("BtnMesa", "");
                        FrmTicket ticketForm = new FrmTicket();
                        ticketForm.SetMesa(mesa);
                        ticketForm.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Liberar: Poner el botón en verde (no se abre FrmTicket)
                        clickedButton.BackColor = Color.Green;
                    }
                }
            }
        }
        #endregion
        private void FrmAbrirMesa_Load(object sender, EventArgs e)
        {
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio frm = new FrmInicio();
            frm.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnVolver1_Click(object sender, EventArgs e)
        {
            FrmInicio frm = new FrmInicio();
            frm.Show();
            this.Close();
        }
    }
}