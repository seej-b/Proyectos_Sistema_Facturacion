namespace Pantallas_Sistema_Facturación
{
    partial class FrmAcerca
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
            this.pnlAcerca = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.pnlAcerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcerca
            // 
            this.pnlAcerca.Controls.Add(this.lblinfo);
            this.pnlAcerca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAcerca.Location = new System.Drawing.Point(0, 0);
            this.pnlAcerca.Name = "pnlAcerca";
            this.pnlAcerca.Size = new System.Drawing.Size(800, 450);
            this.pnlAcerca.TabIndex = 0;
            // 
            // lblinfo
            // 
            this.lblinfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblinfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(0, 0);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Padding = new System.Windows.Forms.Padding(20);
            this.lblinfo.Size = new System.Drawing.Size(800, 450);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // FrmAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAcerca);
            this.Name = "FrmAcerca";
            this.Text = "FrmAcerca";
            this.Load += new System.EventHandler(this.FrmAcerca_Load);
            this.pnlAcerca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcerca;
        private System.Windows.Forms.Label lblinfo;
    }
}