using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmAdminSeguridad : Form
    {
        Conexion con = new Conexion();
        public frmAdminSeguridad()
        {
            InitializeComponent();
            this.Load += frmAdminSeguridad_Load;
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            NpgsqlConnection cn = con.conectar();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(
                "SELECT id_empleado, nombre FROM empleados", cn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            comboEmpleado.DataSource = dt;
            comboEmpleado.DisplayMember = "nombre";
            comboEmpleado.ValueMember = "id_empleado";

            cn.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // validar antes de ejecutar
            if (comboEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un empleado antes de guardar.");
                return;
            }

            using (var cn = con.conectar())
            using (var cmd = new Npgsql.NpgsqlCommand(
                "INSERT INTO usuarios(id_empleado,usuario,clave) VALUES(@emp,@user,@pass)", cn))
            {
                cmd.Parameters.Add("@emp", NpgsqlTypes.NpgsqlDbType.Integer).Value =
                    Convert.ToInt32(comboEmpleado.SelectedValue);
                cmd.Parameters.AddWithValue("@user", txtUsuario.Text ?? string.Empty);
                cmd.Parameters.AddWithValue("@pass", txtClave.Text ?? string.Empty);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Usuario guardado correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
