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

namespace Pantallas_Sistema_Facturación
{
    
    public partial class FrmLogin : Form
    {
        DatosLogin datos = new DatosLogin();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click_1(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            try
            {
                NpgsqlDataReader reader = datos.ValidarUsuario(txtUsuario.Text, txtPassword.Text);

                if (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();
                    string cargo = reader["cargo"].ToString();

                    MessageBox.Show("Bienvenido " + nombre + " (" + cargo + ")",
                                    "Acceso permitido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}