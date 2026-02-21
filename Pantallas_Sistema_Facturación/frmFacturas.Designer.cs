namespace Pantallas_Sistema_Facturación
{
    partial class frmFacturas
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroFactura = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDescuento = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTotalIva = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbCliente = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbEmplaedo = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.FechaRegistro = new System.Windows.Forms.Label();
            this.cmbEstadoFactura = new MaterialSkin.Controls.MaterialComboBox();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.txtDetalleFactura = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lblDetalleFactura = new System.Windows.Forms.Label();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblEstadoFactura);
            this.materialCard1.Controls.Add(this.cmbEstadoFactura);
            this.materialCard1.Controls.Add(this.FechaRegistro);
            this.materialCard1.Controls.Add(this.dtpFechaRegistro);
            this.materialCard1.Controls.Add(this.txtCliente);
            this.materialCard1.Controls.Add(this.txtEmpleado);
            this.materialCard1.Controls.Add(this.cmbEmplaedo);
            this.materialCard1.Controls.Add(this.cmbCliente);
            this.materialCard1.Controls.Add(this.txtTotalFactura);
            this.materialCard1.Controls.Add(this.txtTotalIva);
            this.materialCard1.Controls.Add(this.txtDescuento);
            this.materialCard1.Controls.Add(this.txtNroFactura);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(51, 120);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(827, 380);
            this.materialCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administracion De Facturas";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.AnimateReadOnly = false;
            this.txtNroFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNroFactura.Depth = 0;
            this.txtNroFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroFactura.HideSelection = true;
            this.txtNroFactura.Hint = "Nro Factura";
            this.txtNroFactura.LeadingIcon = null;
            this.txtNroFactura.Location = new System.Drawing.Point(42, 28);
            this.txtNroFactura.MaxLength = 32767;
            this.txtNroFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.PasswordChar = '\0';
            this.txtNroFactura.PrefixSuffixText = null;
            this.txtNroFactura.ReadOnly = false;
            this.txtNroFactura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNroFactura.SelectedText = "";
            this.txtNroFactura.SelectionLength = 0;
            this.txtNroFactura.SelectionStart = 0;
            this.txtNroFactura.ShortcutsEnabled = true;
            this.txtNroFactura.Size = new System.Drawing.Size(172, 48);
            this.txtNroFactura.TabIndex = 0;
            this.txtNroFactura.TabStop = false;
            this.txtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNroFactura.TrailingIcon = null;
            this.txtNroFactura.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.AnimateReadOnly = false;
            this.txtDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuento.HideSelection = true;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.LeadingIcon = null;
            this.txtDescuento.Location = new System.Drawing.Point(42, 191);
            this.txtDescuento.MaxLength = 32767;
            this.txtDescuento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.PrefixSuffixText = null;
            this.txtDescuento.ReadOnly = false;
            this.txtDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.ShortcutsEnabled = true;
            this.txtDescuento.Size = new System.Drawing.Size(172, 48);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.TabStop = false;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescuento.TrailingIcon = null;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // txtTotalIva
            // 
            this.txtTotalIva.AnimateReadOnly = false;
            this.txtTotalIva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalIva.Depth = 0;
            this.txtTotalIva.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalIva.HideSelection = true;
            this.txtTotalIva.Hint = "Total Iva";
            this.txtTotalIva.LeadingIcon = null;
            this.txtTotalIva.Location = new System.Drawing.Point(42, 245);
            this.txtTotalIva.MaxLength = 32767;
            this.txtTotalIva.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalIva.Name = "txtTotalIva";
            this.txtTotalIva.PasswordChar = '\0';
            this.txtTotalIva.PrefixSuffixText = null;
            this.txtTotalIva.ReadOnly = false;
            this.txtTotalIva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalIva.SelectedText = "";
            this.txtTotalIva.SelectionLength = 0;
            this.txtTotalIva.SelectionStart = 0;
            this.txtTotalIva.ShortcutsEnabled = true;
            this.txtTotalIva.Size = new System.Drawing.Size(172, 48);
            this.txtTotalIva.TabIndex = 4;
            this.txtTotalIva.TabStop = false;
            this.txtTotalIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalIva.TrailingIcon = null;
            this.txtTotalIva.UseSystemPasswordChar = false;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.AnimateReadOnly = false;
            this.txtTotalFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotalFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalFactura.HideSelection = true;
            this.txtTotalFactura.Hint = "Total Factura";
            this.txtTotalFactura.LeadingIcon = null;
            this.txtTotalFactura.Location = new System.Drawing.Point(42, 299);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.PrefixSuffixText = null;
            this.txtTotalFactura.ReadOnly = false;
            this.txtTotalFactura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.ShortcutsEnabled = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(172, 48);
            this.txtTotalFactura.TabIndex = 5;
            this.txtTotalFactura.TabStop = false;
            this.txtTotalFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalFactura.TrailingIcon = null;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoResize = false;
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCliente.Depth = 0;
            this.cmbCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCliente.DropDownHeight = 174;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.DropDownWidth = 121;
            this.cmbCliente.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.ItemHeight = 43;
            this.cmbCliente.Location = new System.Drawing.Point(251, 82);
            this.cmbCliente.MaxDropDownItems = 4;
            this.cmbCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(212, 49);
            this.cmbCliente.StartIndex = 0;
            this.cmbCliente.TabIndex = 6;
            // 
            // cmbEmplaedo
            // 
            this.cmbEmplaedo.AutoResize = false;
            this.cmbEmplaedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmplaedo.Depth = 0;
            this.cmbEmplaedo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmplaedo.DropDownHeight = 174;
            this.cmbEmplaedo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmplaedo.DropDownWidth = 121;
            this.cmbEmplaedo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmplaedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmplaedo.FormattingEnabled = true;
            this.cmbEmplaedo.IntegralHeight = false;
            this.cmbEmplaedo.ItemHeight = 43;
            this.cmbEmplaedo.Location = new System.Drawing.Point(251, 137);
            this.cmbEmplaedo.MaxDropDownItems = 4;
            this.cmbEmplaedo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmplaedo.Name = "cmbEmplaedo";
            this.cmbEmplaedo.Size = new System.Drawing.Size(212, 49);
            this.cmbEmplaedo.StartIndex = 0;
            this.cmbEmplaedo.TabIndex = 7;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.AnimateReadOnly = false;
            this.txtEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmpleado.Depth = 0;
            this.txtEmpleado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpleado.HideSelection = true;
            this.txtEmpleado.Hint = "Empleado";
            this.txtEmpleado.LeadingIcon = null;
            this.txtEmpleado.Location = new System.Drawing.Point(42, 136);
            this.txtEmpleado.MaxLength = 32767;
            this.txtEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.PasswordChar = '\0';
            this.txtEmpleado.PrefixSuffixText = null;
            this.txtEmpleado.ReadOnly = false;
            this.txtEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmpleado.SelectedText = "";
            this.txtEmpleado.SelectionLength = 0;
            this.txtEmpleado.SelectionStart = 0;
            this.txtEmpleado.ShortcutsEnabled = true;
            this.txtEmpleado.Size = new System.Drawing.Size(172, 48);
            this.txtEmpleado.TabIndex = 8;
            this.txtEmpleado.TabStop = false;
            this.txtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpleado.TrailingIcon = null;
            this.txtEmpleado.UseSystemPasswordChar = false;
            // 
            // txtCliente
            // 
            this.txtCliente.AnimateReadOnly = false;
            this.txtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCliente.Depth = 0;
            this.txtCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCliente.HideSelection = true;
            this.txtCliente.Hint = "Cliente";
            this.txtCliente.LeadingIcon = null;
            this.txtCliente.Location = new System.Drawing.Point(42, 82);
            this.txtCliente.MaxLength = 32767;
            this.txtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.PrefixSuffixText = null;
            this.txtCliente.ReadOnly = false;
            this.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.ShortcutsEnabled = true;
            this.txtCliente.Size = new System.Drawing.Size(172, 48);
            this.txtCliente.TabIndex = 9;
            this.txtCliente.TabStop = false;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCliente.TrailingIcon = null;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(595, 108);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaRegistro.TabIndex = 10;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.AutoSize = true;
            this.FechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRegistro.Location = new System.Drawing.Point(589, 57);
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Size = new System.Drawing.Size(217, 36);
            this.FechaRegistro.TabIndex = 11;
            this.FechaRegistro.Text = "Fecha Registro";
            // 
            // cmbEstadoFactura
            // 
            this.cmbEstadoFactura.AutoResize = false;
            this.cmbEstadoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstadoFactura.Depth = 0;
            this.cmbEstadoFactura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstadoFactura.DropDownHeight = 174;
            this.cmbEstadoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFactura.DropDownWidth = 121;
            this.cmbEstadoFactura.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstadoFactura.FormattingEnabled = true;
            this.cmbEstadoFactura.IntegralHeight = false;
            this.cmbEstadoFactura.ItemHeight = 43;
            this.cmbEstadoFactura.Location = new System.Drawing.Point(595, 212);
            this.cmbEstadoFactura.MaxDropDownItems = 4;
            this.cmbEstadoFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstadoFactura.Name = "cmbEstadoFactura";
            this.cmbEstadoFactura.Size = new System.Drawing.Size(200, 49);
            this.cmbEstadoFactura.StartIndex = 0;
            this.cmbEstadoFactura.TabIndex = 12;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFactura.Location = new System.Drawing.Point(589, 161);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(216, 36);
            this.lblEstadoFactura.TabIndex = 13;
            this.lblEstadoFactura.Text = "Estado Factura";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblDetalleFactura);
            this.materialCard2.Controls.Add(this.txtDetalleFactura);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(51, 549);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(827, 278);
            this.materialCard2.TabIndex = 2;
            // 
            // txtDetalleFactura
            // 
            this.txtDetalleFactura.AnimateReadOnly = false;
            this.txtDetalleFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDetalleFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDetalleFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetalleFactura.Depth = 0;
            this.txtDetalleFactura.HideSelection = true;
            this.txtDetalleFactura.Location = new System.Drawing.Point(66, 56);
            this.txtDetalleFactura.MaxLength = 32767;
            this.txtDetalleFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDetalleFactura.Name = "txtDetalleFactura";
            this.txtDetalleFactura.PasswordChar = '\0';
            this.txtDetalleFactura.ReadOnly = false;
            this.txtDetalleFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetalleFactura.SelectedText = "";
            this.txtDetalleFactura.SelectionLength = 0;
            this.txtDetalleFactura.SelectionStart = 0;
            this.txtDetalleFactura.ShortcutsEnabled = true;
            this.txtDetalleFactura.Size = new System.Drawing.Size(729, 168);
            this.txtDetalleFactura.TabIndex = 0;
            this.txtDetalleFactura.TabStop = false;
            this.txtDetalleFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetalleFactura.UseSystemPasswordChar = false;
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.AutoSize = true;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleFactura.Location = new System.Drawing.Point(54, 9);
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(248, 39);
            this.lblDetalleFactura.TabIndex = 1;
            this.lblDetalleFactura.Text = "Detalle Factura";
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(896, 281);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizar.Size = new System.Drawing.Size(109, 36);
            this.btnActualizar.TabIndex = 3;
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
            this.btnSalir.Location = new System.Drawing.Point(896, 650);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(64, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 850);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialCard1);
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion Facturas";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNroFactura;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotalFactura;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotalIva;
        private MaterialSkin.Controls.MaterialTextBox2 txtDescuento;
        private MaterialSkin.Controls.MaterialComboBox cmbEmplaedo;
        private MaterialSkin.Controls.MaterialComboBox cmbCliente;
        private System.Windows.Forms.Label FechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private MaterialSkin.Controls.MaterialTextBox2 txtCliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmpleado;
        private System.Windows.Forms.Label lblEstadoFactura;
        private MaterialSkin.Controls.MaterialComboBox cmbEstadoFactura;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDetalleFactura;
        private System.Windows.Forms.Label lblDetalleFactura;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnSalir;
    }
}