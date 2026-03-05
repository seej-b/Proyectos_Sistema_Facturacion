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
        public frmProductos()
        {
            InitializeComponent();
        }

        void ListarProductos()
        {
            Conexion con = new Conexion();

            string sql = "SELECT * FROM Productos";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con.conectar());

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvProductos.DataSource = dt;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }














    }
}
