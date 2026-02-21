namespace Pantallas_Sistema_Facturación
{
    partial class frmRolEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.cardRolEmpleados = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblDescripcionRol = new System.Windows.Forms.Label();
            this.txtDescripcionRol = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.cardRolEmpleados.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol De Empleados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cardRolEmpleados
            // 
            this.cardRolEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRolEmpleados.Controls.Add(this.txtDescripcionRol);
            this.cardRolEmpleados.Controls.Add(this.lblDescripcionRol);
            this.cardRolEmpleados.Controls.Add(this.txtNombreRol);
            this.cardRolEmpleados.Controls.Add(this.materialCheckbox1);
            this.cardRolEmpleados.Depth = 0;
            this.cardRolEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRolEmpleados.Location = new System.Drawing.Point(100, 116);
            this.cardRolEmpleados.Margin = new System.Windows.Forms.Padding(14);
            this.cardRolEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRolEmpleados.Name = "cardRolEmpleados";
            this.cardRolEmpleados.Padding = new System.Windows.Forms.Padding(14);
            this.cardRolEmpleados.Size = new System.Drawing.Size(604, 359);
            this.cardRolEmpleados.TabIndex = 1;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(14, 14);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(35, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.AnimateReadOnly = false;
            this.txtNombreRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreRol.HideSelection = true;
            this.txtNombreRol.LeadingIcon = null;
            this.txtNombreRol.Location = new System.Drawing.Point(17, 72);
            this.txtNombreRol.MaxLength = 32767;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.PrefixSuffixText = null;
            this.txtNombreRol.ReadOnly = false;
            this.txtNombreRol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.ShortcutsEnabled = true;
            this.txtNombreRol.Size = new System.Drawing.Size(156, 48);
            this.txtNombreRol.TabIndex = 1;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.Text = "Nombre Rol";
            this.txtNombreRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreRol.TrailingIcon = null;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionRol.Location = new System.Drawing.Point(17, 143);
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(338, 32);
            this.lblDescripcionRol.TabIndex = 2;
            this.lblDescripcionRol.Text = "Descripción detallada Rol";
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.AnimateReadOnly = false;
            this.txtDescripcionRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcionRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcionRol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionRol.Depth = 0;
            this.txtDescripcionRol.HideSelection = true;
            this.txtDescripcionRol.Location = new System.Drawing.Point(14, 188);
            this.txtDescripcionRol.MaxLength = 32767;
            this.txtDescripcionRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.PasswordChar = '\0';
            this.txtDescripcionRol.ReadOnly = false;
            this.txtDescripcionRol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionRol.SelectedText = "";
            this.txtDescripcionRol.SelectionLength = 0;
            this.txtDescripcionRol.SelectionStart = 0;
            this.txtDescripcionRol.ShortcutsEnabled = true;
            this.txtDescripcionRol.Size = new System.Drawing.Size(573, 137);
            this.txtDescripcionRol.TabIndex = 3;
            this.txtDescripcionRol.TabStop = false;
            this.txtDescripcionRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcionRol.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnSalir);
            this.materialCard1.Controls.Add(this.btnActualizar);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 503);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(869, 169);
            this.materialCard1.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(215, 20);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(484, 20);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(158, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 672);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.cardRolEmpleados);
            this.Controls.Add(this.label1);
            this.Name = "frmRolEmpleados";
            this.Text = "Rol Empleados";
            this.cardRolEmpleados.ResumeLayout(false);
            this.cardRolEmpleados.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard cardRolEmpleados;
        private System.Windows.Forms.Label lblDescripcionRol;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreRol;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcionRol;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
    }
}