using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmListaClientes : Form
    {
        Conexion cn = new Conexion();
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            EstiloTabla();
        }

        void EstiloTabla()
        {
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.BackgroundColor = Color.White;

            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvClientes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvClientes.DefaultCellStyle.ForeColor = Color.Black;
            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;

            dgvClientes.RowTemplate.Height = 30;


            dgvClientes.Columns["id_cliente"].HeaderText = "ID";
            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["telefono"].HeaderText = "Teléfono";
            dgvClientes.Columns["direccion"].HeaderText = "Dirección";
            dgvClientes.Columns["email"].HeaderText = "Correo";


            dgvClientes.Columns["id_cliente"].Visible = false;
        }

        private void MostrarClientes()
        {
            NpgsqlConnection conexion = cn.conectar();

            string query = "SELECT * FROM clientes";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvClientes.DataSource = dt;

            conexion.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexion = cn.conectar();

                string query = "INSERT INTO Clientes (nombre, telefono, direccion, email) VALUES (@nombre, @telefono, @direccion, @email)";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente agregado correctamente");

                conexion.Close();

                MostrarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        int idClienteSeleccionado;

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                idClienteSeleccionado = Convert.ToInt32(fila.Cells["id_cliente"].Value);

                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
                txtEmail.Text = fila.Cells["email"].Value.ToString();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexion = cn.conectar();

                string query = "UPDATE Clientes SET nombre=@nombre, telefono=@telefono, direccion=@direccion, email=@email WHERE id_cliente=@id";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id", idClienteSeleccionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente actualizado correctamente");

                conexion.Close();

                MostrarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Seguro que deseas eliminar este cliente?",
       "Confirmar eliminación",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    NpgsqlConnection conexion = cn.conectar();

                    string query = "DELETE FROM Clientes WHERE id_cliente=@id";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", idClienteSeleccionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente eliminado correctamente");

                    conexion.Close();

                    MostrarClientes();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexion = cn.conectar();

                string consulta = "SELECT id_cliente, nombre, telefono, direccion, email FROM Clientes WHERE nombre ILIKE @buscar";

                NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@buscar", "%" + txtBuscarCliente.Text + "%");

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvClientes.DataSource = tabla;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
