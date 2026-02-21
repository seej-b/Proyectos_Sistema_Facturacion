namespace Pantallas_Sistema_Facturación
{
    partial class frmInformes
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
            this.cardFiltrosInforme = new MaterialSkin.Controls.MaterialCard();
            this.lblInforme = new System.Windows.Forms.Label();
            this.cmbTipoInforme = new MaterialSkin.Controls.MaterialComboBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.cmbOrdenarPor = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.rbDetalle = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAnual = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenrarInforme = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.cardResultadoInforme = new MaterialSkin.Controls.MaterialCard();
            this.dgvInforme = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cardFiltrosInforme.SuspendLayout();
            this.cardResultadoInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFiltrosInforme
            // 
            this.cardFiltrosInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardFiltrosInforme.Controls.Add(this.rbAnual);
            this.cardFiltrosInforme.Controls.Add(this.rbMes);
            this.cardFiltrosInforme.Controls.Add(this.btnSalir);
            this.cardFiltrosInforme.Controls.Add(this.rbDetalle);
            this.cardFiltrosInforme.Controls.Add(this.btnGenrarInforme);
            this.cardFiltrosInforme.Controls.Add(this.dtpFechaFinal);
            this.cardFiltrosInforme.Controls.Add(this.dtpFechaInicial);
            this.cardFiltrosInforme.Controls.Add(this.lblFechaInicial);
            this.cardFiltrosInforme.Controls.Add(this.lblFechaFinal);
            this.cardFiltrosInforme.Controls.Add(this.cmbOrdenarPor);
            this.cardFiltrosInforme.Controls.Add(this.lblOrdenar);
            this.cardFiltrosInforme.Controls.Add(this.cmbTipoInforme);
            this.cardFiltrosInforme.Controls.Add(this.lblInforme);
            this.cardFiltrosInforme.Depth = 0;
            this.cardFiltrosInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardFiltrosInforme.Location = new System.Drawing.Point(69, 104);
            this.cardFiltrosInforme.Margin = new System.Windows.Forms.Padding(14);
            this.cardFiltrosInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardFiltrosInforme.Name = "cardFiltrosInforme";
            this.cardFiltrosInforme.Padding = new System.Windows.Forms.Padding(14);
            this.cardFiltrosInforme.Size = new System.Drawing.Size(795, 349);
            this.cardFiltrosInforme.TabIndex = 0;
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.Location = new System.Drawing.Point(17, 14);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(179, 25);
            this.lblInforme.TabIndex = 0;
            this.lblInforme.Text = "Seleccione Informe";
            // 
            // cmbTipoInforme
            // 
            this.cmbTipoInforme.AutoResize = false;
            this.cmbTipoInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoInforme.Depth = 0;
            this.cmbTipoInforme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoInforme.DropDownHeight = 174;
            this.cmbTipoInforme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInforme.DropDownWidth = 121;
            this.cmbTipoInforme.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipoInforme.FormattingEnabled = true;
            this.cmbTipoInforme.IntegralHeight = false;
            this.cmbTipoInforme.ItemHeight = 43;
            this.cmbTipoInforme.Location = new System.Drawing.Point(202, 14);
            this.cmbTipoInforme.MaxDropDownItems = 4;
            this.cmbTipoInforme.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoInforme.Name = "cmbTipoInforme";
            this.cmbTipoInforme.Size = new System.Drawing.Size(188, 49);
            this.cmbTipoInforme.StartIndex = 0;
            this.cmbTipoInforme.TabIndex = 1;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(456, 18);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(119, 25);
            this.lblOrdenar.TabIndex = 2;
            this.lblOrdenar.Text = "Ordenar Por";
            // 
            // cmbOrdenarPor
            // 
            this.cmbOrdenarPor.AutoResize = false;
            this.cmbOrdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbOrdenarPor.Depth = 0;
            this.cmbOrdenarPor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbOrdenarPor.DropDownHeight = 174;
            this.cmbOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenarPor.DropDownWidth = 121;
            this.cmbOrdenarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbOrdenarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbOrdenarPor.FormattingEnabled = true;
            this.cmbOrdenarPor.IntegralHeight = false;
            this.cmbOrdenarPor.ItemHeight = 43;
            this.cmbOrdenarPor.Location = new System.Drawing.Point(581, 17);
            this.cmbOrdenarPor.MaxDropDownItems = 4;
            this.cmbOrdenarPor.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbOrdenarPor.Name = "cmbOrdenarPor";
            this.cmbOrdenarPor.Size = new System.Drawing.Size(188, 49);
            this.cmbOrdenarPor.StartIndex = 0;
            this.cmbOrdenarPor.TabIndex = 3;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(151, 106);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(121, 25);
            this.lblFechaFinal.TabIndex = 4;
            this.lblFechaFinal.Text = "Fecha Inicial";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(151, 152);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(114, 25);
            this.lblFechaInicial.TabIndex = 5;
            this.lblFechaInicial.Text = "Fecha Final";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(314, 108);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicial.TabIndex = 6;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(314, 152);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFinal.TabIndex = 7;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // rbDetalle
            // 
            this.rbDetalle.AutoSize = true;
            this.rbDetalle.Depth = 0;
            this.rbDetalle.Location = new System.Drawing.Point(226, 188);
            this.rbDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.rbDetalle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDetalle.Name = "rbDetalle";
            this.rbDetalle.Ripple = true;
            this.rbDetalle.Size = new System.Drawing.Size(84, 37);
            this.rbDetalle.TabIndex = 8;
            this.rbDetalle.TabStop = true;
            this.rbDetalle.Text = "Detalle";
            this.rbDetalle.UseVisualStyleBackColor = true;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Depth = 0;
            this.rbMes.Location = new System.Drawing.Point(384, 188);
            this.rbMes.Margin = new System.Windows.Forms.Padding(0);
            this.rbMes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMes.Name = "rbMes";
            this.rbMes.Ripple = true;
            this.rbMes.Size = new System.Drawing.Size(65, 37);
            this.rbMes.TabIndex = 9;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Mes";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Depth = 0;
            this.rbAnual.Location = new System.Drawing.Point(538, 188);
            this.rbAnual.Margin = new System.Windows.Forms.Padding(0);
            this.rbAnual.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAnual.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Ripple = true;
            this.rbAnual.Size = new System.Drawing.Size(76, 37);
            this.rbAnual.TabIndex = 10;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            // 
            // btnGenrarInforme
            // 
            this.btnGenrarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenrarInforme.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenrarInforme.Depth = 0;
            this.btnGenrarInforme.HighEmphasis = true;
            this.btnGenrarInforme.Icon = null;
            this.btnGenrarInforme.Location = new System.Drawing.Point(156, 284);
            this.btnGenrarInforme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenrarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenrarInforme.Name = "btnGenrarInforme";
            this.btnGenrarInforme.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenrarInforme.Size = new System.Drawing.Size(154, 36);
            this.btnGenrarInforme.TabIndex = 1;
            this.btnGenrarInforme.Text = "Generar Informe";
            this.btnGenrarInforme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenrarInforme.UseAccentColor = false;
            this.btnGenrarInforme.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(495, 284);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(64, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // cardResultadoInforme
            // 
            this.cardResultadoInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardResultadoInforme.Controls.Add(this.dgvInforme);
            this.cardResultadoInforme.Depth = 0;
            this.cardResultadoInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardResultadoInforme.Location = new System.Drawing.Point(69, 503);
            this.cardResultadoInforme.Margin = new System.Windows.Forms.Padding(14);
            this.cardResultadoInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardResultadoInforme.Name = "cardResultadoInforme";
            this.cardResultadoInforme.Padding = new System.Windows.Forms.Padding(14);
            this.cardResultadoInforme.Size = new System.Drawing.Size(795, 260);
            this.cardResultadoInforme.TabIndex = 3;
            // 
            // dgvInforme
            // 
            this.dgvInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInforme.Location = new System.Drawing.Point(14, 14);
            this.dgvInforme.Name = "dgvInforme";
            this.dgvInforme.RowHeadersWidth = 51;
            this.dgvInforme.RowTemplate.Height = 24;
            this.dgvInforme.Size = new System.Drawing.Size(767, 232);
            this.dgvInforme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generador De Informes De Facturacion";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 820);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardResultadoInforme);
            this.Controls.Add(this.cardFiltrosInforme);
            this.Name = "frmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genrador De Informes";
            this.cardFiltrosInforme.ResumeLayout(false);
            this.cardFiltrosInforme.PerformLayout();
            this.cardResultadoInforme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardFiltrosInforme;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoInforme;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblFechaFinal;
        private MaterialSkin.Controls.MaterialComboBox cmbOrdenarPor;
        private System.Windows.Forms.Label lblOrdenar;
        private MaterialSkin.Controls.MaterialRadioButton rbAnual;
        private MaterialSkin.Controls.MaterialRadioButton rbMes;
        private MaterialSkin.Controls.MaterialRadioButton rbDetalle;
        private MaterialSkin.Controls.MaterialButton btnGenrarInforme;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialCard cardResultadoInforme;
        private System.Windows.Forms.DataGridView dgvInforme;
        private System.Windows.Forms.Label label1;
    }
}