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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (usuario == "" || password == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }
            //  usuario
            if (usuario == "admin" && password == "123")
            {
                MessageBox.Show("Bienvenido");

                // abrir menú
                FrmPrincipal menu = new FrmPrincipal();
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}