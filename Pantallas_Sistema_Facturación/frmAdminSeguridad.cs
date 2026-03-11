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
        DatosSeguridad datos = new DatosSeguridad();
        public frmAdminSeguridad()
        {
            InitializeComponent();
            this.Load += frmAdminSeguridad_Load;
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            comboEmpleado.DataSource = datos.ListarEmpleados();
            comboEmpleado.DisplayMember = "nombre";
            comboEmpleado.ValueMember = "id_empleado";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (comboEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un empleado antes de guardar.");
                return;
            }

            datos.InsertarUsuario(
                Convert.ToInt32(comboEmpleado.SelectedValue),
                txtUsuario.Text,
                txtClave.Text
            );

            MessageBox.Show("Usuario guardado correctamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
