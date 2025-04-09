using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;
namespace PryPueblox
{
    class TicketPrinter
    {
        #region RUTA
        // --- Configuración ---
        // Ruta a tu base de datos Access.
        // Asegúrate de que esté en la carpeta correcta (normalmente junto al .exe)
        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BdResto.mdb";
        private string NombreTabla = "Producto";
        private string ColumnaNombreProducto = "Nombre"; // Según tu imagen de BD
        private string ColumnaPrecio = "Precio";         // Según tu imagen de BD

        // --- Variables para el Ticket ---
        private string ticketContent; // Almacena el texto del ticket generado
        private static int numeroTicket = 1; // Contador simple para el número de ticket (podría mejorarse)
        #endregion
        /// <summary>
        /// Genera el contenido del ticket y lo manda a imprimir.
        /// </summary>
        #region generarTicket
        public void GenerarTicket(int numeroMesa, string metodoPago, ComboBox[] cmbPlatos, NumericUpDown[] numCantidades)
        {
            if (cmbPlatos.Length != numCantidades.Length)
            {
                MessageBox.Show("Error interno: La cantidad de controles de producto y cantidad no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Usar StringWriter para construir el texto del ticket
            using (StringWriter sw = new StringWriter())
            {
                // --- Encabezado ---
                sw.WriteLine("********** RESTAURANTE PUEBLO GRILL **********");
                sw.WriteLine("              *** TICKET *** ");
                sw.WriteLine($"Número de Ticket: {numeroTicket}");
                sw.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy}    Hora: {DateTime.Now:HH:mm:ss}");
                sw.WriteLine("-------------------------------------------------");
                sw.WriteLine($"MESA: {numeroMesa}");
                sw.WriteLine("-------------------------------------------------");
                // Alineación: Ajusta los números en {X, -N} o {X, N} según necesites
                // -N = Alinear Izquierda, N = Alinear Derecha. El número es el ancho total.
                sw.WriteLine($"{"CANT",-5} | {"PLATO",-20} | {"PRECIO",8} | {"SUBTOTAL",8}");
                sw.WriteLine("-------------------------------------------------");

                decimal totalGeneral = 0;

                // --- Items del Pedido ---
                for (int i = 0; i < cmbPlatos.Length; i++)
                {
                    // Procesar solo si hay un item seleccionado y la cantidad es mayor a 0
                    // Usamos GetItemText para obtener el texto mostrado, es más seguro si usas objetos complejos.
                    // Si solo añades strings, .Text también suele funcionar.
                    string nombrePlatoSeleccionado = cmbPlatos[i].GetItemText(cmbPlatos[i].SelectedItem);
                    int cantidad = (int)numCantidades[i].Value;

                    if (!string.IsNullOrWhiteSpace(nombrePlatoSeleccionado) && cantidad > 0)
                    {
                        // Obtener el precio unitario desde la base de datos
                        decimal precioUnitario = ObtenerPrecio(nombrePlatoSeleccionado);
                        decimal subtotal = 0;
                        string precioFormateado;
                        string subtotalFormateado;

                        // --- ¡IMPORTANTE! Manejo si no se encontró el precio ---
                        if (precioUnitario <= 0)
                        {
                            // AVISO: Precio no encontrado o inválido para este plato.
                            // Igualmente lo mostraremos en el ticket para que no "desaparezca"
                            Console.WriteLine($"Advertencia: Precio no encontrado o inválido para '{nombrePlatoSeleccionado}'.");
                            // Mostramos "N/A" (No Aplica) o 0.00 en el ticket
                            precioFormateado = $"{"N/A",8}"; // O $"${0.00,8:F2}"
                            subtotalFormateado = $"{"N/A",8}"; // O $"${0.00,8:F2}"
                            // No sumamos al total general si no hay precio.
                        }
                        else
                        {
                            // Precio encontrado, calcular subtotal y formatear
                            subtotal = precioUnitario * cantidad;
                            precioFormateado = $"${precioUnitario,8:F2}";
                            subtotalFormateado = $"${subtotal,8:F2}";
                            totalGeneral += subtotal; // Sumar al total general
                        }

                        // Añadir la línea del item al ticket (incluso si el precio es N/A)
                        sw.WriteLine($"{cantidad,-5} | {Truncate(nombrePlatoSeleccionado, 20),-20} | {precioFormateado} | {subtotalFormateado}");
                    }
                }

                // --- Totales y Pie de Ticket ---
                sw.WriteLine("-------------------------------------------------");

                decimal aumento = 0;
                // Aplicar recargo por débito si es necesario
                if (metodoPago == "Débito" && totalGeneral > 0) // Solo aplicar si hay un total
                {
                    aumento = totalGeneral * 0.10m; // Calcula el 10% de aumento
                    sw.WriteLine($"Subtotal: ${totalGeneral,37:F2}"); // Alineado a la derecha
                    sw.WriteLine($"Aumento por débito (10%): ${aumento,20:F2}"); // Alineado
                }

                decimal totalConAumento = totalGeneral + aumento;

                sw.WriteLine("-------------------------------------------------");
                sw.WriteLine($"TOTAL A PAGAR: ${totalConAumento,29:F2}"); // Alineado
                sw.WriteLine("-------------------------------------------------");
                sw.WriteLine($"Método de pago: {metodoPago}");
                sw.WriteLine("          ¡Gracias por su compra!");
                sw.WriteLine(""); // Línea extra

                // Guardar el contenido generado
                ticketContent = sw.ToString();

            } // StringWriter se cierra aquí

            numeroTicket++; // Incrementar para el próximo ticket

            // Enviar a la impresora
            PrintTicket();
        }
        #endregion

        /// <summary>
        /// Busca el precio de un producto en la BD por su nombre.
        /// </summary>
        /// <returns>Precio del producto como decimal, o 0.00m si no se encuentra o hay error.</returns>
        #region obtenerPrecio

        private decimal ObtenerPrecio(string nombrePlatoBuscado)
        {
            decimal precio = 0.00m;
            // Consulta parametrizada para evitar inyección SQL
            string sql = $"SELECT [{ColumnaPrecio}] FROM [{NombreTabla}] WHERE [{ColumnaNombreProducto}] = ?";

            using (OleDbConnection conn = new OleDbConnection(CadenaConexion))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                // Añadir parámetro de forma segura
                // OleDbType.VarWChar es usualmente adecuado para texto en Access
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = nombrePlatoBuscado;

                try
                {
                    conn.Open();
                    object resultado = cmd.ExecuteScalar(); // Obtiene solo el primer valor

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        // Intenta convertir el resultado a decimal.
                        // Considera CultureInfo si tu sistema usa comas como separador decimal y Access usa puntos.
                        if (!decimal.TryParse(resultado.ToString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out precio))
                        {
                            // Error de conversión: El precio en la BD no es un número válido
                            Console.WriteLine($"Error: El precio para '{nombrePlatoBuscado}' en la BD no es numérico ('{resultado}').");
                            precio = 0.00m; // Asegura devolver 0 si falla la conversión
                        }
                        // Si TryParse fue exitoso, 'precio' ya tiene el valor correcto.
                        // Asegurarse que no sea negativo si eso no tiene sentido en tu lógica
                        if (precio < 0)
                        {
                            Console.WriteLine($"Advertencia: El precio para '{nombrePlatoBuscado}' es negativo (${precio}). Se tratará como 0.");
                            precio = 0.00m;
                        }
                    }
                    else
                    {
                        // No se encontró el producto o el precio es DBNull.Value
                        // Console.WriteLine($"Advertencia: Producto '{nombrePlatoBuscado}' no encontrado o sin precio en '{NombreTabla}'.");
                        // Ya devolvemos 0.00m por defecto, no es necesario hacer nada extra aquí.
                    }
                }
                catch (OleDbException dbEx)
                {
                    MessageBox.Show($"Error de Base de Datos al buscar precio para '{nombrePlatoBuscado}': {dbEx.Message}", "Error DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    precio = 0.00m;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado al obtener precio para '{nombrePlatoBuscado}': {ex.Message}", "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    precio = 0.00m;
                }
            } // La conexión se cierra automáticamente aquí
            return precio;
        }
        #endregion
        /// <summary>
        /// Inicia el proceso de impresión.
        /// </summary>
        #region print )(IMPRIMIR)

        private void PrintTicket()
        {
            if (string.IsNullOrEmpty(ticketContent))
            {
                MessageBox.Show("No hay contenido para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            // Opcional: Especificar impresora (si no, usa la predeterminada)
            // printDoc.PrinterSettings.PrinterName = "NombreTuImpresoraTermica";

            printDoc.PrintPage += PrintPageHandler; // Asigna el método que dibuja

            try
            {
                printDoc.Print(); // Manda a imprimir
            }
            catch (InvalidPrinterException printEx)
            {
                MessageBox.Show($"Error de impresora: {printEx.Message}. Verifica que la impresora esté instalada y disponible.", "Error Impresión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al intentar imprimir: {ex.Message}", "Error Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpia el evento para evitar múltiples suscripciones si se reutiliza la instancia
                printDoc.PrintPage -= PrintPageHandler;
            }
        }

        /// <summary>
        /// Dibuja el contenido del ticket en la página de impresión.
        /// </summary>
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // Fuente monoespaciada para alinear columnas (ajusta tamaño según tu ticketera)
            using (Font font = new Font("Courier New", 9))
            {
                float yPos = 10; // Margen superior
                float leftMargin = 10; // Margen izquierdo
                float lineHeight = font.GetHeight(e.Graphics) + 2; // Espacio entre líneas

                // Usar StringReader para leer el contenido línea por línea
                using (StringReader sr = new StringReader(ticketContent))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Dibujar la línea
                        e.Graphics.DrawString(line, font, Brushes.Black, leftMargin, yPos);
                        // Moverse hacia abajo para la siguiente línea
                        yPos += lineHeight;
                    }
                }
            } // La fuente se libera aquí

            // Indicar que no hay más páginas (para tickets simples)
            e.HasMorePages = false;
        }

        /// <summary>
        /// Función auxiliar para truncar texto.
        /// </summary>
        private string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty; // Devuelve vacío en lugar de null
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
        #endregion
    } // Fin clase TicketPrinter
}
    


