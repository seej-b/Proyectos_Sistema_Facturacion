namespace Pantallas_Sistema_Facturación
{
    partial class frmCategoriaProductos
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
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.cardCategoriaProductos = new MaterialSkin.Controls.MaterialCard();
            this.cardCategoriaProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria De Productos";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.AnimateReadOnly = false;
            this.txtNombreCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCategoria.HideSelection = true;
            this.txtNombreCategoria.Hint = "Nombre Categoria";
            this.txtNombreCategoria.LeadingIcon = null;
            this.txtNombreCategoria.Location = new System.Drawing.Point(17, 71);
            this.txtNombreCategoria.MaxLength = 32767;
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.PrefixSuffixText = null;
            this.txtNombreCategoria.ReadOnly = false;
            this.txtNombreCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.ShortcutsEnabled = true;
            this.txtNombreCategoria.Size = new System.Drawing.Size(250, 48);
            this.txtNombreCategoria.TabIndex = 1;
            this.txtNombreCategoria.TabStop = false;
            this.txtNombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCategoria.TrailingIcon = null;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
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
            this.materialCheckbox1.TabIndex = 2;
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.HighEmphasis = true;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(65, 201);
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
            this.btnSalir.Location = new System.Drawing.Point(472, 201);
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
            // cardCategoriaProductos
            // 
            this.cardCategoriaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardCategoriaProductos.Controls.Add(this.txtNombreCategoria);
            this.cardCategoriaProductos.Controls.Add(this.btnActualizar);
            this.cardCategoriaProductos.Controls.Add(this.btnSalir);
            this.cardCategoriaProductos.Controls.Add(this.materialCheckbox1);
            this.cardCategoriaProductos.Depth = 0;
            this.cardCategoriaProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCategoriaProductos.Location = new System.Drawing.Point(99, 93);
            this.cardCategoriaProductos.Margin = new System.Windows.Forms.Padding(14);
            this.cardCategoriaProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCategoriaProductos.Name = "cardCategoriaProductos";
            this.cardCategoriaProductos.Padding = new System.Windows.Forms.Padding(14);
            this.cardCategoriaProductos.Size = new System.Drawing.Size(627, 275);
            this.cardCategoriaProductos.TabIndex = 5;
            // 
            // frmCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardCategoriaProductos);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoriaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria Productos";
            this.cardCategoriaProductos.ResumeLayout(false);
            this.cardCategoriaProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreCategoria;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialButton btnActualizar;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialCard cardCategoriaProductos;
    }
}