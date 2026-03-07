using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmEmpleados : Form
    {
        Conexion con = new Conexion();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDatos_Click(object sender, EventArgs e)
        {

        }

        private void ComboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            ComboRol.Items.Add("Administrador");
            ComboRol.Items.Add("Vendedor");
            ComboRol.Items.Add("Cajero");
            ComboRol.Items.Add("Supervisor");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection cn = con.conectar();

            NpgsqlCommand cmd = new NpgsqlCommand(
            "INSERT INTO empleados(nombre, documento, direccion, telefono, email, cargo, fecha_ingreso, fecha_retiro, datos_adicionales) VALUES(@nom,@doc,@dir,@tel,@mail,@car,@ing,@ret,@datos)", cn);

            cmd.Parameters.AddWithValue("@nom", txtNombreEmpleado.Text);
            cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);
            cmd.Parameters.AddWithValue("@dir", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@car", ComboRol.Text);
            cmd.Parameters.AddWithValue("@ing", DateIngreso.Value);
            cmd.Parameters.AddWithValue("@ret", DateRetiro.Value);
            cmd.Parameters.AddWithValue("@datos", txtDatos.Text);


            cmd.ExecuteNonQuery();

            MessageBox.Show("Empleado guardado correctamente");

            cn.Close();

        }
    }
}
