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
    public partial class frmProductos : Form
    {
        Conexion cn = new Conexion();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            ListarProductos();
            EstiloTabla();
        }

        void EstiloTabla()
        {
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.BackgroundColor = Color.White;

            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvProductos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProductos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvProductos.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;

            dgvProductos.RowTemplate.Height = 30;

            dgvProductos.Columns["id_producto"].HeaderText = "ID";
            dgvProductos.Columns["nombre"].HeaderText = "Producto";
            dgvProductos.Columns["codigo_referencia"].HeaderText = "Referencia";
            dgvProductos.Columns["precio_compra"].HeaderText = "Precio Compra";
            dgvProductos.Columns["precio_venta"].HeaderText = "Precio Venta";
            dgvProductos.Columns["stock"].HeaderText = "Stock";
            dgvProductos.Columns["detalles"].HeaderText = "Detalles";
            dgvProductos.Columns["nombre_categoria"].HeaderText = "Categoría";


            dgvProductos.Columns["id_producto"].Visible = false;


            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells["stock"].Value != null)
                {
                    int stock = Convert.ToInt32(fila.Cells["stock"].Value);

                    if (stock <= 5)
                    {
                        fila.Cells["stock"].Style.ForeColor = Color.Red;
                        fila.Cells["stock"].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                }
            }
        }

        void ListarProductos()
        {
            try
            {
                NpgsqlConnection conexion = cn.conectar();

                string consulta = @"SELECT 
                            p.id_producto,
                            p.nombre,
                            p.codigo_referencia,
                            p.precio_venta,
                            p.precio_compra,
                            p.stock,
                            p.detalles,
                            c.nombre_categoria
                            FROM productos p
                            INNER JOIN categoriaproductos c
                            ON p.id_categoria = c.id_categoria";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(consulta, conexion);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvProductos.DataSource = tabla;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar productos: " + ex.Message);
            }
        }

        public void CargarCategorias()
        {
            try
            {
                NpgsqlConnection conexion = cn.conectar();

                string consulta = "SELECT id_categoria, nombre_categoria FROM categoriaproductos";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(consulta, conexion);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                cmbCategoria.DataSource = tabla;
                cmbCategoria.DisplayMember = "nombre_categoria";
                cmbCategoria.ValueMember = "id_categoria";

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int idProducto = 0;

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);

                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells["nombre"].Value.ToString();
                txtCodigoReferencia.Text = dgvProductos.CurrentRow.Cells["codigo_referencia"].Value.ToString();
                txtPrecioCompra.Text = dgvProductos.CurrentRow.Cells["precio_compra"].Value.ToString();
                txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells["precio_venta"].Value.ToString();
                txtCantidadStock.Text = dgvProductos.CurrentRow.Cells["stock"].Value.ToString();
                txtDetallesProducto.Text = dgvProductos.CurrentRow.Cells["detalles"].Value.ToString();

                cmbCategoria.Text = dgvProductos.CurrentRow.Cells["nombre_categoria"].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexion = cn.conectar();

                string consulta = @"UPDATE productos 
                            SET nombre = @nombre,
                                codigo_referencia = @codigo,
                                precio_compra = @precio_compra,
                                precio_venta = @precio_venta,
                                stock = @stock,
                                detalles = @detalles,
                                id_categoria = @categoria
                            WHERE id_producto = @id";

                NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmd.Parameters.AddWithValue("@codigo", txtCodigoReferencia.Text);
                cmd.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(txtPrecioCompra.Text));
                cmd.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(txtPrecioVenta.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtCantidadStock.Text));
                cmd.Parameters.AddWithValue("@detalles", txtDetallesProducto.Text);
                cmd.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedValue);
                cmd.Parameters.AddWithValue("@id", idProducto);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Producto actualizado correctamente");

                conexion.Close();

                ListarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreProducto.Text == "" || txtCodigoReferencia.Text == "")
                {
                    MessageBox.Show("Debe completar los campos obligatorios");
                    return;
                }

                NpgsqlConnection conexion = cn.conectar();

                string consulta = @"INSERT INTO productos
                            (nombre, codigo_referencia, precio_compra, precio_venta, stock, detalles, id_categoria)
                            VALUES
                            (@nombre, @codigo, @precio_compra, @precio_venta, @stock, @detalles, @categoria)";

                NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmd.Parameters.AddWithValue("@codigo", txtCodigoReferencia.Text);
                cmd.Parameters.AddWithValue("@precio_compra", Convert.ToDecimal(txtPrecioCompra.Text));
                cmd.Parameters.AddWithValue("@precio_venta", Convert.ToDecimal(txtPrecioVenta.Text));
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtCantidadStock.Text));
                cmd.Parameters.AddWithValue("@detalles", txtDetallesProducto.Text);
                cmd.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedValue);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Producto agregado correctamente");

                conexion.Close();

                ListarProductos();

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProducto == 0)
                {
                    MessageBox.Show("Seleccione un producto para eliminar");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    NpgsqlConnection conexion = cn.conectar();

                    string consulta = "DELETE FROM productos WHERE id_producto = @id";

                    NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexion);

                    cmd.Parameters.AddWithValue("@id", idProducto);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto eliminado correctamente");

                    conexion.Close();

                    ListarProductos();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                ListarProductos();
                return;
            }

            try
            {
                NpgsqlConnection conexion = cn.conectar();

                string consulta = @"SELECT 
                        p.id_producto,
                        p.nombre,
                        p.codigo_referencia,
                        p.precio_venta,
                        p.precio_compra,
                        p.stock,
                        p.detalles,
                        c.nombre_categoria
                        FROM productos p
                        INNER JOIN categoriaproductos c
                        ON p.id_categoria = c.id_categoria
                        WHERE 
                        LOWER(p.nombre) LIKE LOWER(@buscar) 
                        OR LOWER(p.codigo_referencia) LIKE LOWER(@buscar)";

                NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@buscar", "%" + txtBuscar.Text + "%");

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dgvProductos.DataSource = tabla;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en búsqueda: " + ex.Message);
            }
        }

        public void Limpiar()
        {
            txtNombreProducto.Clear();
            txtCodigoReferencia.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtCantidadStock.Clear();
            txtDetallesProducto.Clear();

            cmbCategoria.SelectedIndex = 0;

            idProducto = 0;
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
