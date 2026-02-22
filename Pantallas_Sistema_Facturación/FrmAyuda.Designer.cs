namespace Pantallas_Sistema_Facturación
{
    partial class FrmAyuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webayuda = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webayuda)).BeginInit();
            this.SuspendLayout();
            // 
            // webayuda
            // 
            this.webayuda.AllowExternalDrop = true;
            this.webayuda.CreationProperties = null;
            this.webayuda.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webayuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webayuda.Location = new System.Drawing.Point(0, 0);
            this.webayuda.Name = "webayuda";
            this.webayuda.Size = new System.Drawing.Size(800, 450);
            this.webayuda.TabIndex = 0;
            this.webayuda.ZoomFactor = 1D;
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webayuda);
            this.Name = "FrmAyuda";
            this.Text = "FrmAyuda";
            this.Load += new System.EventHandler(this.FrmAyuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webayuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webayuda;
    }
}