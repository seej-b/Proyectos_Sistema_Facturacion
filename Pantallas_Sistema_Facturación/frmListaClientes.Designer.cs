namespace Pantallas_Sistema_Facturación
{
    partial class frmListaClientes
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BtnEditar = new MaterialSkin.Controls.MaterialButton();
            this.BtnEliminar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(314, 30);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(207, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRACION CLIENTES";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.SystemColors.Control;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(317, 97);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(75, 29);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Buscar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = false;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.HighEmphasis = true;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(622, 153);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevo.Size = new System.Drawing.Size(75, 20);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevo.UseAccentColor = false;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = false;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(596, 338);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.AnimateReadOnly = false;
            this.txtBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarCliente.HideSelection = true;
            this.txtBuscarCliente.Hint = "Buscar por cliente";
            this.txtBuscarCliente.LeadingIcon = null;
            this.txtBuscarCliente.Location = new System.Drawing.Point(35, 97);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarCliente.MaxLength = 32767;
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.PrefixSuffixText = null;
            this.txtBuscarCliente.ReadOnly = false;
            this.txtBuscarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.SelectionLength = 0;
            this.txtBuscarCliente.SelectionStart = 0;
            this.txtBuscarCliente.ShortcutsEnabled = true;
            this.txtBuscarCliente.Size = new System.Drawing.Size(202, 48);
            this.txtBuscarCliente.TabIndex = 5;
            this.txtBuscarCliente.TabStop = false;
            this.txtBuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarCliente.TrailingIcon = null;
            this.txtBuscarCliente.UseSystemPasswordChar = false;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(35, 152);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(669, 167);
            this.dgvClientes.TabIndex = 6;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(185, 152);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(113, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.Tag = "";
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(297, 152);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(113, 20);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(409, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEditar
            // 
            this.BtnEditar.AutoSize = false;
            this.BtnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnEditar.Depth = 0;
            this.BtnEditar.HighEmphasis = true;
            this.BtnEditar.Icon = null;
            this.BtnEditar.Location = new System.Drawing.Point(537, 153);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEditar.Size = new System.Drawing.Size(75, 20);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnEditar.UseAccentColor = false;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = false;
            this.BtnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnEliminar.Depth = 0;
            this.BtnEliminar.HighEmphasis = true;
            this.BtnEliminar.Icon = null;
            this.BtnEliminar.Location = new System.Drawing.Point(575, 125);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEliminar.Size = new System.Drawing.Size(75, 20);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnEliminar.UseAccentColor = false;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 419);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btnNuevo;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private MaterialSkin.Controls.MaterialButton BtnEditar;
        private MaterialSkin.Controls.MaterialButton BtnEliminar;
    }
}