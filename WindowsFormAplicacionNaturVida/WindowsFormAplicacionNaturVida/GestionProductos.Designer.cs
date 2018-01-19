namespace WindowsFormAplicacionNaturVida
{
    partial class frmGestionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionProductos));
            this.lblGestionProductos = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.dgbConsultaProducto = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtDescripcion1 = new System.Windows.Forms.TextBox();
            this.lblDescripcion1 = new System.Windows.Forms.Label();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.btnConsultar1 = new System.Windows.Forms.Button();
            this.cbxProducto1 = new System.Windows.Forms.ComboBox();
            this.lblProducto1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxProducto2 = new System.Windows.Forms.ComboBox();
            this.lblProducto2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaProducto)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionProductos
            // 
            this.lblGestionProductos.AutoSize = true;
            this.lblGestionProductos.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProductos.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblGestionProductos.Location = new System.Drawing.Point(70, 28);
            this.lblGestionProductos.Name = "lblGestionProductos";
            this.lblGestionProductos.Size = new System.Drawing.Size(305, 31);
            this.lblGestionProductos.TabIndex = 0;
            this.lblGestionProductos.Text = "Gestión de Productos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 357);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.lblCantidad);
            this.tabPage1.Controls.Add(this.txtValor);
            this.tabPage1.Controls.Add(this.lblValor);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.lblDescripcion);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(238, 216);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(121, 216);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(121, 170);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(238, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCantidad.Location = new System.Drawing.Point(32, 169);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(121, 125);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(238, 20);
            this.txtValor.TabIndex = 6;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValor.Location = new System.Drawing.Point(44, 126);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(48, 19);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "Valor:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 76);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(238, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(88, 19);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(121, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(238, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCodigo.Location = new System.Drawing.Point(44, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboProducto);
            this.tabPage2.Controls.Add(this.dgbConsultaProducto);
            this.tabPage2.Controls.Add(this.btnConsultar);
            this.tabPage2.Controls.Add(this.lblProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(129, 30);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(230, 21);
            this.cboProducto.TabIndex = 12;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // dgbConsultaProducto
            // 
            this.dgbConsultaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbConsultaProducto.Location = new System.Drawing.Point(24, 127);
            this.dgbConsultaProducto.Name = "dgbConsultaProducto";
            this.dgbConsultaProducto.Size = new System.Drawing.Size(368, 150);
            this.dgbConsultaProducto.TabIndex = 11;
            this.dgbConsultaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbConsultaProducto_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(159, 80);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 30);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProducto.Location = new System.Drawing.Point(20, 29);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(77, 19);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCantidad1);
            this.tabPage3.Controls.Add(this.lblCantidad1);
            this.tabPage3.Controls.Add(this.btnGuardar1);
            this.tabPage3.Controls.Add(this.txtValor1);
            this.tabPage3.Controls.Add(this.lblValor1);
            this.tabPage3.Controls.Add(this.txtDescripcion1);
            this.tabPage3.Controls.Add(this.lblDescripcion1);
            this.tabPage3.Controls.Add(this.txtCodigo1);
            this.tabPage3.Controls.Add(this.lblCodigo1);
            this.tabPage3.Controls.Add(this.btnConsultar1);
            this.tabPage3.Controls.Add(this.cbxProducto1);
            this.tabPage3.Controls.Add(this.lblProducto1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(413, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar Producto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(121, 239);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(74, 20);
            this.txtCantidad1.TabIndex = 23;
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCantidad1.Location = new System.Drawing.Point(37, 240);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad1.TabIndex = 22;
            this.lblCantidad1.Text = "Cantidad:";
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(166, 275);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar1.TabIndex = 21;
            this.btnGuardar1.Text = "Guardar Cambios";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(121, 201);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(238, 20);
            this.txtValor1.TabIndex = 20;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValor1.Location = new System.Drawing.Point(62, 200);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(48, 19);
            this.lblValor1.TabIndex = 19;
            this.lblValor1.Text = "Valor:";
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Location = new System.Drawing.Point(121, 159);
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(238, 20);
            this.txtDescripcion1.TabIndex = 18;
            // 
            // lblDescripcion1
            // 
            this.lblDescripcion1.AutoSize = true;
            this.lblDescripcion1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDescripcion1.Location = new System.Drawing.Point(18, 158);
            this.lblDescripcion1.Name = "lblDescripcion1";
            this.lblDescripcion1.Size = new System.Drawing.Size(92, 19);
            this.lblDescripcion1.TabIndex = 17;
            this.lblDescripcion1.Text = "Descripción:";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(121, 115);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(238, 20);
            this.txtCodigo1.TabIndex = 16;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCodigo1.Location = new System.Drawing.Point(50, 114);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(60, 19);
            this.lblCodigo1.TabIndex = 15;
            this.lblCodigo1.Text = "Código:";
            // 
            // btnConsultar1
            // 
            this.btnConsultar1.Location = new System.Drawing.Point(181, 65);
            this.btnConsultar1.Name = "btnConsultar1";
            this.btnConsultar1.Size = new System.Drawing.Size(91, 30);
            this.btnConsultar1.TabIndex = 14;
            this.btnConsultar1.Text = "Consultar";
            this.btnConsultar1.UseVisualStyleBackColor = true;
            this.btnConsultar1.Click += new System.EventHandler(this.btnConsultar1_Click);
            // 
            // cbxProducto1
            // 
            this.cbxProducto1.FormattingEnabled = true;
            this.cbxProducto1.Location = new System.Drawing.Point(129, 20);
            this.cbxProducto1.Name = "cbxProducto1";
            this.cbxProducto1.Size = new System.Drawing.Size(230, 21);
            this.cbxProducto1.TabIndex = 13;
            this.cbxProducto1.SelectedIndexChanged += new System.EventHandler(this.cbxProducto1_SelectedIndexChanged);
            // 
            // lblProducto1
            // 
            this.lblProducto1.AutoSize = true;
            this.lblProducto1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProducto1.Location = new System.Drawing.Point(33, 20);
            this.lblProducto1.Name = "lblProducto1";
            this.lblProducto1.Size = new System.Drawing.Size(77, 19);
            this.lblProducto1.TabIndex = 2;
            this.lblProducto1.Text = "Producto:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnEliminar);
            this.tabPage4.Controls.Add(this.cbxProducto2);
            this.tabPage4.Controls.Add(this.lblProducto2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(413, 331);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Producto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(168, 83);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxProducto2
            // 
            this.cbxProducto2.FormattingEnabled = true;
            this.cbxProducto2.Location = new System.Drawing.Point(129, 30);
            this.cbxProducto2.Name = "cbxProducto2";
            this.cbxProducto2.Size = new System.Drawing.Size(230, 21);
            this.cbxProducto2.TabIndex = 14;
            this.cbxProducto2.SelectedIndexChanged += new System.EventHandler(this.cbxProducto2_SelectedIndexChanged);
            // 
            // lblProducto2
            // 
            this.lblProducto2.AutoSize = true;
            this.lblProducto2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblProducto2.Location = new System.Drawing.Point(33, 32);
            this.lblProducto2.Name = "lblProducto2";
            this.lblProducto2.Size = new System.Drawing.Size(77, 19);
            this.lblProducto2.TabIndex = 3;
            this.lblProducto2.Text = "Producto:";
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblGestionProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionProductos";
            this.Text = "Productos Naturvida";
            this.Load += new System.EventHandler(this.frmGestionProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaProducto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionProductos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgbConsultaProducto;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtDescripcion1;
        private System.Windows.Forms.Label lblDescripcion1;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnConsultar1;
        private System.Windows.Forms.ComboBox cbxProducto1;
        private System.Windows.Forms.Label lblProducto1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxProducto2;
        private System.Windows.Forms.Label lblProducto2;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.Label lblCantidad1;
    }
}