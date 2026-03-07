namespace Pantallas_Sistema_Facturación
{
    partial class frmEmpleados
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
            this.cardEmpleados = new MaterialSkin.Controls.MaterialCard();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.txtDatos = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.DateRetiro = new System.Windows.Forms.DateTimePicker();
            this.DateIngreso = new System.Windows.Forms.DateTimePicker();
            this.ComboRol = new MaterialSkin.Controls.MaterialComboBox();
            this.lblDatosAdicionales = new System.Windows.Forms.Label();
            this.lblFechaRetiro = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblRolEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblAdministracionDeEmpleados = new System.Windows.Forms.Label();
            this.cardEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardEmpleados
            // 
            this.cardEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardEmpleados.Controls.Add(this.btnSalir);
            this.cardEmpleados.Controls.Add(this.btnActualizar);
            this.cardEmpleados.Controls.Add(this.txtDatos);
            this.cardEmpleados.Controls.Add(this.DateRetiro);
            this.cardEmpleados.Controls.Add(this.DateIngreso);
            this.cardEmpleados.Controls.Add(this.ComboRol);
            this.cardEmpleados.Controls.Add(this.lblDatosAdicionales);
            this.cardEmpleados.Controls.Add(this.lblFechaRetiro);
            this.cardEmpleados.Controls.Add(this.lblFechaIngreso);
            this.cardEmpleados.Controls.Add(this.lblRolEmpleado);
            this.cardEmpleados.Controls.Add(this.txtNombreEmpleado);
            this.cardEmpleados.Controls.Add(this.txtDireccion);
            this.cardEmpleados.Controls.Add(this.txtTelefono);
            this.cardEmpleados.Controls.Add(this.txtEmail);
            this.cardEmpleados.Controls.Add(this.txtDocumento);
            this.cardEmpleados.Controls.Add(this.materialCheckbox1);
            this.cardEmpleados.Depth = 0;
            this.cardEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardEmpleados.Location = new System.Drawing.Point(68, 100);
            this.cardEmpleados.Margin = new System.Windows.Forms.Padding(14);
            this.cardEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardEmpleados.Name = "cardEmpleados";
            this.cardEmpleados.Padding = new System.Windows.Forms.Padding(14);
            this.cardEmpleados.Size = new System.Drawing.Size(783, 471);
            this.cardEmpleados.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(614, 391);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(64, 36);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(137, 391);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizar.UseAccentColor = false;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.AnimateReadOnly = false;
            this.txtDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDatos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDatos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatos.Depth = 0;
            this.txtDatos.HideSelection = true;
            this.txtDatos.Location = new System.Drawing.Point(506, 266);
            this.txtDatos.MaxLength = 32767;
            this.txtDatos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.PasswordChar = '\0';
            this.txtDatos.ReadOnly = false;
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatos.SelectedText = "";
            this.txtDatos.SelectionLength = 0;
            this.txtDatos.SelectionStart = 0;
            this.txtDatos.ShortcutsEnabled = true;
            this.txtDatos.Size = new System.Drawing.Size(250, 100);
            this.txtDatos.TabIndex = 13;
            this.txtDatos.TabStop = false;
            this.txtDatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDatos.UseSystemPasswordChar = false;
            this.txtDatos.Click += new System.EventHandler(this.txtDatos_Click);
            // 
            // DateRetiro
            // 
            this.DateRetiro.Location = new System.Drawing.Point(556, 173);
            this.DateRetiro.Name = "DateRetiro";
            this.DateRetiro.Size = new System.Drawing.Size(200, 22);
            this.DateRetiro.TabIndex = 12;
            // 
            // DateIngreso
            // 
            this.DateIngreso.Location = new System.Drawing.Point(556, 122);
            this.DateIngreso.Name = "DateIngreso";
            this.DateIngreso.Size = new System.Drawing.Size(200, 22);
            this.DateIngreso.TabIndex = 11;
            // 
            // ComboRol
            // 
            this.ComboRol.AutoResize = false;
            this.ComboRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboRol.Depth = 0;
            this.ComboRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboRol.DropDownHeight = 174;
            this.ComboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRol.DropDownWidth = 121;
            this.ComboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboRol.FormattingEnabled = true;
            this.ComboRol.IntegralHeight = false;
            this.ComboRol.ItemHeight = 43;
            this.ComboRol.Location = new System.Drawing.Point(556, 50);
            this.ComboRol.MaxDropDownItems = 4;
            this.ComboRol.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboRol.Name = "ComboRol";
            this.ComboRol.Size = new System.Drawing.Size(162, 49);
            this.ComboRol.StartIndex = 0;
            this.ComboRol.TabIndex = 10;
            this.ComboRol.SelectedIndexChanged += new System.EventHandler(this.ComboRol_SelectedIndexChanged);
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(413, 227);
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(169, 25);
            this.lblDatosAdicionales.TabIndex = 9;
            this.lblDatosAdicionales.Text = "Datos Adicionales";
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRetiro.Location = new System.Drawing.Point(413, 173);
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(84, 25);
            this.lblFechaRetiro.TabIndex = 8;
            this.lblFechaRetiro.Text = "F. Retiro";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(413, 119);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(99, 25);
            this.lblFechaIngreso.TabIndex = 7;
            this.lblFechaIngreso.Text = "F. Ingreso";
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolEmpleado.Location = new System.Drawing.Point(413, 65);
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(133, 25);
            this.lblRolEmpleado.TabIndex = 6;
            this.lblRolEmpleado.Text = "Rol Empleado";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AnimateReadOnly = false;
            this.txtNombreEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.HideSelection = true;
            this.txtNombreEmpleado.Hint = "Nombre Empleado";
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(81, 65);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.PrefixSuffixText = null;
            this.txtNombreEmpleado.ReadOnly = false;
            this.txtNombreEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.ShortcutsEnabled = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(250, 48);
            this.txtNombreEmpleado.TabIndex = 5;
            this.txtNombreEmpleado.TabStop = false;
            this.txtNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpleado.TrailingIcon = null;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.HideSelection = true;
            this.txtDireccion.Hint = "Direccion";
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(81, 173);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PrefixSuffixText = null;
            this.txtDireccion.ReadOnly = false;
            this.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(250, 48);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.TrailingIcon = null;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(81, 227);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PrefixSuffixText = null;
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(250, 48);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(81, 281);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(250, 48);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.AnimateReadOnly = false;
            this.txtDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.HideSelection = true;
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.LeadingIcon = null;
            this.txtDocumento.Location = new System.Drawing.Point(81, 119);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.PrefixSuffixText = null;
            this.txtDocumento.ReadOnly = false;
            this.txtDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.Size = new System.Drawing.Size(250, 48);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumento.TrailingIcon = null;
            this.txtDocumento.UseSystemPasswordChar = false;
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
            // lblAdministracionDeEmpleados
            // 
            this.lblAdministracionDeEmpleados.AutoSize = true;
            this.lblAdministracionDeEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministracionDeEmpleados.Location = new System.Drawing.Point(209, 22);
            this.lblAdministracionDeEmpleados.Name = "lblAdministracionDeEmpleados";
            this.lblAdministracionDeEmpleados.Size = new System.Drawing.Size(556, 46);
            this.lblAdministracionDeEmpleados.TabIndex = 1;
            this.lblAdministracionDeEmpleados.Text = "Administracion De Empleados";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 666);
            this.Controls.Add(this.lblAdministracionDeEmpleados);
            this.Controls.Add(this.cardEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.cardEmpleados.ResumeLayout(false);
            this.cardEmpleados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardEmpleados;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccion;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtDocumento;
        private System.Windows.Forms.Label lblDatosAdicionales;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblRolEmpleado;
        private MaterialSkin.Controls.MaterialComboBox ComboRol;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDatos;
        private System.Windows.Forms.DateTimePicker DateRetiro;
        private System.Windows.Forms.DateTimePicker DateIngreso;
        private System.Windows.Forms.Label lblAdministracionDeEmpleados;
    }
}