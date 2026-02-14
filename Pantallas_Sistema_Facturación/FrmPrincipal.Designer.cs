namespace Pantallas_Sistema_Facturación
{
    partial class FrmPrincipal
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.tablas = new System.Windows.Forms.TabPage();
            this.facturación = new System.Windows.Forms.TabPage();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btninformes = new System.Windows.Forms.Button();
            this.btnfacturas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.btnroles = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnacerca = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            this.tablas.SuspendLayout();
            this.facturación.SuspendLayout();
            this.Seguridad.SuspendLayout();
            this.Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPrincipal.Location = new System.Drawing.Point(-1, 60);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1203, 597);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbpMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 597);
            this.panel1.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.tablas);
            this.TbpMenu.Controls.Add(this.facturación);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.Acerca);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Multiline = true;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(200, 597);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Principal.Controls.Add(this.BtnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 40);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 553);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // tablas
            // 
            this.tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tablas.Controls.Add(this.btncategorias);
            this.tablas.Controls.Add(this.btnproductos);
            this.tablas.Controls.Add(this.btnclientes);
            this.tablas.Controls.Add(this.pictureBox2);
            this.tablas.Location = new System.Drawing.Point(4, 40);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(3);
            this.tablas.Size = new System.Drawing.Size(192, 553);
            this.tablas.TabIndex = 1;
            this.tablas.Text = "Admin Tablas";
            // 
            // facturación
            // 
            this.facturación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.facturación.Controls.Add(this.btninformes);
            this.facturación.Controls.Add(this.btnfacturas);
            this.facturación.Controls.Add(this.pictureBox3);
            this.facturación.Location = new System.Drawing.Point(4, 40);
            this.facturación.Name = "facturación";
            this.facturación.Size = new System.Drawing.Size(192, 553);
            this.facturación.TabIndex = 2;
            this.facturación.Text = "Facturación";
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Seguridad.Controls.Add(this.btnseguridad);
            this.Seguridad.Controls.Add(this.btnroles);
            this.Seguridad.Controls.Add(this.btnempleados);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Location = new System.Drawing.Point(4, 40);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 553);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Acerca.Controls.Add(this.btnacerca);
            this.Acerca.Controls.Add(this.btnayuda);
            this.Acerca.Controls.Add(this.pictureBox5);
            this.Acerca.Location = new System.Drawing.Point(4, 40);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 553);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Acerca";
            // 
            // TabOpcionesMenu
            // 
            this.TabOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.TabOpcionesMenu.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabOpcionesMenu.Depth = 0;
            this.TabOpcionesMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabOpcionesMenu.Location = new System.Drawing.Point(313, 26);
            this.TabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpcionesMenu.Name = "TabOpcionesMenu";
            this.TabOpcionesMenu.Size = new System.Drawing.Size(837, 28);
            this.TabOpcionesMenu.TabIndex = 1;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalir.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.logout;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(6, 103);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(180, 42);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.factura;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btncategorias
            // 
            this.btncategorias.FlatAppearance.BorderSize = 0;
            this.btncategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncategorias.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Categorias;
            this.btncategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Location = new System.Drawing.Point(6, 238);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(180, 42);
            this.btncategorias.TabIndex = 4;
            this.btncategorias.Text = "Categorías";
            this.btncategorias.UseVisualStyleBackColor = true;
            // 
            // btnproductos
            // 
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnproductos.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Productos;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(6, 172);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(180, 42);
            this.btnproductos.TabIndex = 3;
            this.btnproductos.Text = "Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclientes.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Clientes;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(6, 104);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(180, 42);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.factura;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btninformes
            // 
            this.btninformes.FlatAppearance.BorderSize = 0;
            this.btninformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btninformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformes.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btninformes.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Informes;
            this.btninformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformes.Location = new System.Drawing.Point(9, 167);
            this.btninformes.Name = "btninformes";
            this.btninformes.Size = new System.Drawing.Size(180, 42);
            this.btninformes.TabIndex = 4;
            this.btninformes.Text = "Informes";
            this.btninformes.UseVisualStyleBackColor = true;
            // 
            // btnfacturas
            // 
            this.btnfacturas.FlatAppearance.BorderSize = 0;
            this.btnfacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturas.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfacturas.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Facturas;
            this.btnfacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacturas.Location = new System.Drawing.Point(9, 103);
            this.btnfacturas.Name = "btnfacturas";
            this.btnfacturas.Size = new System.Drawing.Size(180, 42);
            this.btnfacturas.TabIndex = 3;
            this.btnfacturas.Text = "Facturas";
            this.btnfacturas.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.factura;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // btnseguridad
            // 
            this.btnseguridad.FlatAppearance.BorderSize = 0;
            this.btnseguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseguridad.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseguridad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnseguridad.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Seguridad;
            this.btnseguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseguridad.Location = new System.Drawing.Point(7, 226);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Size = new System.Drawing.Size(180, 42);
            this.btnseguridad.TabIndex = 6;
            this.btnseguridad.Text = "Seguridad";
            this.btnseguridad.UseVisualStyleBackColor = true;
            // 
            // btnroles
            // 
            this.btnroles.FlatAppearance.BorderSize = 0;
            this.btnroles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroles.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnroles.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Roles;
            this.btnroles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroles.Location = new System.Drawing.Point(7, 163);
            this.btnroles.Name = "btnroles";
            this.btnroles.Size = new System.Drawing.Size(180, 42);
            this.btnroles.TabIndex = 5;
            this.btnroles.Text = "Roles";
            this.btnroles.UseVisualStyleBackColor = true;
            // 
            // btnempleados
            // 
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnempleados.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Empleados;
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(7, 102);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(180, 42);
            this.btnempleados.TabIndex = 4;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.factura;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(197, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // btnacerca
            // 
            this.btnacerca.FlatAppearance.BorderSize = 0;
            this.btnacerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnacerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacerca.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacerca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnacerca.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.Acerca_de;
            this.btnacerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacerca.Location = new System.Drawing.Point(7, 165);
            this.btnacerca.Name = "btnacerca";
            this.btnacerca.Size = new System.Drawing.Size(180, 42);
            this.btnacerca.TabIndex = 6;
            this.btnacerca.Text = "Acerca de...";
            this.btnacerca.UseVisualStyleBackColor = true;
            // 
            // btnayuda
            // 
            this.btnayuda.FlatAppearance.BorderSize = 0;
            this.btnayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnayuda.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.ayuda;
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(7, 103);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(180, 42);
            this.btnayuda.TabIndex = 5;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pantallas_Sistema_Facturación.Properties.Resources.factura;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(197, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.TabOpcionesMenu);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "FrmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.pnlPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.tablas.ResumeLayout(false);
            this.facturación.ResumeLayout(false);
            this.Seguridad.ResumeLayout(false);
            this.Acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.TabPage facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcionesMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnfacturas;
        private System.Windows.Forms.Button btninformes;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnseguridad;
        private System.Windows.Forms.Button btnroles;
        private System.Windows.Forms.Button btnacerca;
        private System.Windows.Forms.Button btnayuda;
    }
}