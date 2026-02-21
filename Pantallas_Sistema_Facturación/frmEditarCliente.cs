using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_Facturación
{
    public partial class frmEditarCliente : MaterialSkin.Controls.MaterialForm
    {
        List<Cliente> listaClientes = new List<Cliente>();
        public frmEditarCliente()
        {
            InitializeComponent();

            this.Text = "ACTUALIZAR CLIENTE";




            var materialSkinManager = MaterialSkinManager.Instance;


            materialSkinManager.AddFormToManage(this);


            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();

            nuevoCliente.Nombre = txtNombre.Text;
            nuevoCliente.Documento = txtDocumento.Text;
            nuevoCliente.Direccion = txtDireccion.Text;
            nuevoCliente.Telefono = txtTelefono.Text;
            nuevoCliente.Email = txtEmail.Text;

            listaClientes.Add(nuevoCliente);

            MessageBox.Show("Cliente guardado correctamente");

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
