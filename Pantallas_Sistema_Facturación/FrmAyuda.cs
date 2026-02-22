using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Pantallas_Sistema_Facturación
{
    public partial class FrmAyuda: Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private async void FrmAyuda_Load(object sender, EventArgs e)
        {

            await webayuda.EnsureCoreWebView2Async(null);
            webayuda.CoreWebView2.Navigate("https://learn.microsoft.com/es-es/docs/");

        }
    }
}
