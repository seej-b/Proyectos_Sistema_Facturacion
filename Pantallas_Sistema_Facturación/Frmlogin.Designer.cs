namespace Pantallas_Sistema_Facturación
{
    partial class Frmlogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtpasword = new MaterialSkin.Controls.MaterialTextBox();
            this.btnValidar = new MaterialSkin.Controls.MaterialButton();
            this.BtnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.perfil;
            this.pictureBox1.Location = new System.Drawing.Point(30, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.Location = new System.Drawing.Point(311, 18);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "VALIDAR USUARIO";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AnimateReadOnly = false;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUsuario.Hint = "Usuario";
            this.TxtUsuario.LeadingIcon = null;
            this.TxtUsuario.Location = new System.Drawing.Point(286, 69);
            this.TxtUsuario.MaxLength = 50;
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUsuario.Multiline = false;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(173, 50);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.Text = "";
            this.TxtUsuario.TrailingIcon = null;
            // 
            // txtpasword
            // 
            this.txtpasword.AnimateReadOnly = false;
            this.txtpasword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpasword.Depth = 0;
            this.txtpasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpasword.Hint = "Password";
            this.txtpasword.LeadingIcon = null;
            this.txtpasword.Location = new System.Drawing.Point(286, 125);
            this.txtpasword.MaxLength = 50;
            this.txtpasword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpasword.Multiline = false;
            this.txtpasword.Name = "txtpasword";
            this.txtpasword.Password = true;
            this.txtpasword.Size = new System.Drawing.Size(173, 50);
            this.txtpasword.TabIndex = 3;
            this.txtpasword.Text = "";
            this.txtpasword.TrailingIcon = null;
            // 
            // btnValidar
            // 
            this.btnValidar.AutoSize = false;
            this.btnValidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnValidar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnValidar.Depth = 0;
            this.btnValidar.HighEmphasis = true;
            this.btnValidar.Icon = null;
            this.btnValidar.Location = new System.Drawing.Point(286, 199);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnValidar.Size = new System.Drawing.Size(75, 36);
            this.btnValidar.TabIndex = 4;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnValidar.UseAccentColor = false;
            this.btnValidar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = false;
            this.BtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnCancelar.Depth = 0;
            this.BtnCancelar.HighEmphasis = true;
            this.BtnCancelar.Icon = null;
            this.BtnCancelar.Location = new System.Drawing.Point(384, 199);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCancelar.Size = new System.Drawing.Size(75, 36);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnCancelar.UseAccentColor = false;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtpasword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmlogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialTextBox TxtUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtpasword;
        private MaterialSkin.Controls.MaterialButton btnValidar;
        private MaterialSkin.Controls.MaterialButton BtnCancelar;
    }
}

