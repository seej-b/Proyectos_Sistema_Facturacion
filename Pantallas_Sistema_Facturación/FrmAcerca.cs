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
    public partial class FrmAcerca: Form
    {
        public FrmAcerca()
        {
            InitializeComponent();
        }

        private void FrmAcerca_Load(object sender, EventArgs e)
        {

       lblinfo.Text =
      "SISTEMA DE FACTURACIÓN ELECTRÓNICA\n\n" +
      "Versión: 1.0.0\n" +
      "Tipo: Aplicación de Escritorio\n" +
      "Tecnología: Windows Forms – C#\n\n" +
      "Descripción:\n" +
      "Sistema desarrollado para la gestión de facturación electrónica, " +
      "permitiendo administrar procesos de venta y control documental.\n\n" +
      "Tecnologías Implementadas:\n" +
      "• C#\n" +
      "• .NET Windows Forms\n" +
      "• MaterialSkin\n" +
      "• WebView2\n\n" +
      "Desarrollado por:\n" +
      "Simón Blandón Villa - Keduin Sebastián Jiménez\n" +
      "Tecnología en Desarrollo de Software\n\n" +
      "© 2026 – Todos los derechos reservados";

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
