using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryPueblox
{
    class ClsConexion
    {
        #region Conexion
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BdResto.mdb";
        private string Tabla = "Producto";
        #endregion

        #region Platos
        public void AgregarPlatos(string nombre, decimal precio, int idCategoria)
        {
            try
            {
                using (OleDbConnection Conexion = new OleDbConnection(CadenaConexion))
                {
                    Conexion.Open();
                    string query = "INSERT INTO Plato (Nombre, Precio, IdCategoria) VALUES (?, ?, ?)";
                    using (OleDbCommand Comando = new OleDbCommand(query, Conexion))
                    {
                        Comando.Parameters.AddWithValue("?", nombre);
                        Comando.Parameters.AddWithValue("?", precio);
                        Comando.Parameters.AddWithValue("?", idCategoria);
                        int filasAfectadas = Comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Plato agregado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el plato.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void CargarPlatos(ComboBox cmb)
        {
            try
            {
                using (OleDbConnection Conexion = new OleDbConnection(CadenaConexion))
                {
                    Conexion.Open();
                    string query = "SELECT IdPlato, Nombre FROM Producto";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, Conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmb.DataSource = dt;
                        cmb.DisplayMember = "Nombre";
                        cmb.ValueMember = "IdPlato";
                        cmb.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Plato: " + ex.Message);
            }
        }
        public void BuscarPlatosPorCategoria(int idCategoria, DataGridView grlm)
        {
            try
            {
                using (OleDbConnection Conexion = new OleDbConnection(CadenaConexion))
                {
                    Conexion.Open();
                    string query = "SELECT IdPlato, Nombre, Precio FROM Producto WHERE IdCategoria = ?";
                    using (OleDbCommand Comando = new OleDbCommand(query, Conexion))
                    {
                        Comando.Parameters.AddWithValue("?", idCategoria);
                        using (OleDbDataReader Dr = Comando.ExecuteReader())
                        {
                            grlm.Rows.Clear();
                            while (Dr.Read())
                            {
                                grlm.Rows.Add(Dr["IdPlato"], Dr["Nombre"], Dr["Precio"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar platos: " + ex.Message);
            }
        }
        #endregion
        #region CMB Listar

        public void CargarCategorias(ComboBox cmb)
        {
            try
            {
                using (OleDbConnection Conexion = new OleDbConnection(CadenaConexion))
                {
                    Conexion.Open();
                    string query = "SELECT IdCategoria, Nombre FROM Categoria";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, Conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmb.DataSource = dt;
                        cmb.DisplayMember = "Nombre";
                        cmb.ValueMember = "IdCategoria";
                        cmb.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        public void Listar(DataGridView grlm)
        {
            try
            {
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                Adaptador = new OleDbDataAdapter(Comando);
                DataSet DS = new DataSet();
                Adaptador.Fill(DS);
                grlm.DataSource = DS.Tables[0];
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }
        #endregion
        
    }
}
