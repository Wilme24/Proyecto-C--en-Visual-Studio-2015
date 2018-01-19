namespace WindowsFormAplicacionNaturVida
{
    partial class frmGestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionClientes));
            this.lblGestionProductos = new System.Windows.Forms.Label();
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.cboTipoID = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblTipoID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dgbConsultaCliente = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtIdentificacion1 = new System.Windows.Forms.TextBox();
            this.lblIdentificacion1 = new System.Windows.Forms.Label();
            this.txtCorreo1 = new System.Windows.Forms.TextBox();
            this.lblCorreo1 = new System.Windows.Forms.Label();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion1 = new System.Windows.Forms.TextBox();
            this.lblDireccion1 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.btnConsultar1 = new System.Windows.Forms.Button();
            this.cboCliente1 = new System.Windows.Forms.ComboBox();
            this.lblCliente1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboCliente2 = new System.Windows.Forms.ComboBox();
            this.lblCliente2 = new System.Windows.Forms.Label();
            this.tabControlClientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaCliente)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionProductos
            // 
            this.lblGestionProductos.AutoSize = true;
            this.lblGestionProductos.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProductos.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblGestionProductos.Location = new System.Drawing.Point(79, 29);
            this.lblGestionProductos.Name = "lblGestionProductos";
            this.lblGestionProductos.Size = new System.Drawing.Size(276, 31);
            this.lblGestionProductos.TabIndex = 1;
            this.lblGestionProductos.Text = "Gestión de Clientes";
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPage1);
            this.tabControlClientes.Controls.Add(this.tabPage2);
            this.tabControlClientes.Controls.Add(this.tabPage3);
            this.tabControlClientes.Controls.Add(this.tabPage4);
            this.tabControlClientes.Location = new System.Drawing.Point(12, 71);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(421, 386);
            this.tabControlClientes.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCorreo);
            this.tabPage1.Controls.Add(this.lblCorreo);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.lblTeléfono);
            this.tabPage1.Controls.Add(this.cboTipoID);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.lblDirección);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.txtIdentificacion);
            this.tabPage1.Controls.Add(this.lblIdentificacion);
            this.tabPage1.Controls.Add(this.lblTipoID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(121, 250);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(238, 20);
            this.txtCorreo.TabIndex = 17;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCorreo.Location = new System.Drawing.Point(28, 249);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 19);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 209);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(117, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTeléfono.Location = new System.Drawing.Point(28, 208);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(72, 19);
            this.lblTeléfono.TabIndex = 14;
            this.lblTeléfono.Text = "Teléfono:";
            // 
            // cboTipoID
            // 
            this.cboTipoID.FormattingEnabled = true;
            this.cboTipoID.Location = new System.Drawing.Point(121, 35);
            this.cboTipoID.Name = "cboTipoID";
            this.cboTipoID.Size = new System.Drawing.Size(44, 21);
            this.cboTipoID.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(231, 311);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(121, 311);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(121, 170);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(238, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDirección.Location = new System.Drawing.Point(32, 169);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(77, 19);
            this.lblDirección.TabIndex = 7;
            this.lblDirección.Text = "Dirección:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 125);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNombre.Location = new System.Drawing.Point(44, 126);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(121, 76);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(117, 20);
            this.txtIdentificacion.TabIndex = 4;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIdentificacion.Location = new System.Drawing.Point(16, 75);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(101, 19);
            this.lblIdentificacion.TabIndex = 3;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // lblTipoID
            // 
            this.lblTipoID.AutoSize = true;
            this.lblTipoID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTipoID.Location = new System.Drawing.Point(44, 34);
            this.lblTipoID.Name = "lblTipoID";
            this.lblTipoID.Size = new System.Drawing.Size(61, 19);
            this.lblTipoID.TabIndex = 0;
            this.lblTipoID.Text = "Tipo ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboCliente);
            this.tabPage2.Controls.Add(this.dgbConsultaCliente);
            this.tabPage2.Controls.Add(this.btnConsultar);
            this.tabPage2.Controls.Add(this.lblCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(129, 30);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(230, 21);
            this.cboCliente.TabIndex = 12;
            // 
            // dgbConsultaCliente
            // 
            this.dgbConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbConsultaCliente.Location = new System.Drawing.Point(24, 127);
            this.dgbConsultaCliente.Name = "dgbConsultaCliente";
            this.dgbConsultaCliente.Size = new System.Drawing.Size(368, 150);
            this.dgbConsultaCliente.TabIndex = 11;
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
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCliente.Location = new System.Drawing.Point(20, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 19);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtIdentificacion1);
            this.tabPage3.Controls.Add(this.lblIdentificacion1);
            this.tabPage3.Controls.Add(this.txtCorreo1);
            this.tabPage3.Controls.Add(this.lblCorreo1);
            this.tabPage3.Controls.Add(this.btnGuardar1);
            this.tabPage3.Controls.Add(this.txtTelefono1);
            this.tabPage3.Controls.Add(this.lblTelefono);
            this.tabPage3.Controls.Add(this.txtDireccion1);
            this.tabPage3.Controls.Add(this.lblDireccion1);
            this.tabPage3.Controls.Add(this.txtNombre1);
            this.tabPage3.Controls.Add(this.lblNombre1);
            this.tabPage3.Controls.Add(this.btnConsultar1);
            this.tabPage3.Controls.Add(this.cboCliente1);
            this.tabPage3.Controls.Add(this.lblCliente1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(413, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtIdentificacion1
            // 
            this.txtIdentificacion1.Location = new System.Drawing.Point(142, 135);
            this.txtIdentificacion1.Name = "txtIdentificacion1";
            this.txtIdentificacion1.Size = new System.Drawing.Size(130, 20);
            this.txtIdentificacion1.TabIndex = 25;
            // 
            // lblIdentificacion1
            // 
            this.lblIdentificacion1.AutoSize = true;
            this.lblIdentificacion1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIdentificacion1.Location = new System.Drawing.Point(26, 136);
            this.lblIdentificacion1.Name = "lblIdentificacion1";
            this.lblIdentificacion1.Size = new System.Drawing.Size(105, 19);
            this.lblIdentificacion1.TabIndex = 24;
            this.lblIdentificacion1.Text = "Identificación:";
            // 
            // txtCorreo1
            // 
            this.txtCorreo1.Location = new System.Drawing.Point(142, 270);
            this.txtCorreo1.Name = "txtCorreo1";
            this.txtCorreo1.Size = new System.Drawing.Size(238, 20);
            this.txtCorreo1.TabIndex = 23;
            // 
            // lblCorreo1
            // 
            this.lblCorreo1.AutoSize = true;
            this.lblCorreo1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCorreo1.Location = new System.Drawing.Point(72, 271);
            this.lblCorreo1.Name = "lblCorreo1";
            this.lblCorreo1.Size = new System.Drawing.Size(59, 19);
            this.lblCorreo1.TabIndex = 22;
            this.lblCorreo1.Text = "Correo:";
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(152, 309);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar1.TabIndex = 21;
            this.btnGuardar1.Text = "Guardar Cambios";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(142, 237);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(130, 20);
            this.txtTelefono1.TabIndex = 20;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTelefono.Location = new System.Drawing.Point(59, 238);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(72, 19);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtDireccion1
            // 
            this.txtDireccion1.Location = new System.Drawing.Point(142, 203);
            this.txtDireccion1.Name = "txtDireccion1";
            this.txtDireccion1.Size = new System.Drawing.Size(238, 20);
            this.txtDireccion1.TabIndex = 18;
            // 
            // lblDireccion1
            // 
            this.lblDireccion1.AutoSize = true;
            this.lblDireccion1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDireccion1.Location = new System.Drawing.Point(54, 202);
            this.lblDireccion1.Name = "lblDireccion1";
            this.lblDireccion1.Size = new System.Drawing.Size(77, 19);
            this.lblDireccion1.TabIndex = 17;
            this.lblDireccion1.Text = "Dirección:";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(142, 168);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(238, 20);
            this.txtNombre1.TabIndex = 16;
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNombre1.Location = new System.Drawing.Point(62, 167);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(69, 19);
            this.lblNombre1.TabIndex = 15;
            this.lblNombre1.Text = "Nombre:";
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
            // cboCliente1
            // 
            this.cboCliente1.FormattingEnabled = true;
            this.cboCliente1.Location = new System.Drawing.Point(129, 20);
            this.cboCliente1.Name = "cboCliente1";
            this.cboCliente1.Size = new System.Drawing.Size(230, 21);
            this.cboCliente1.TabIndex = 13;
            // 
            // lblCliente1
            // 
            this.lblCliente1.AutoSize = true;
            this.lblCliente1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCliente1.Location = new System.Drawing.Point(33, 20);
            this.lblCliente1.Name = "lblCliente1";
            this.lblCliente1.Size = new System.Drawing.Size(60, 19);
            this.lblCliente1.TabIndex = 2;
            this.lblCliente1.Text = "Cliente:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnEliminar);
            this.tabPage4.Controls.Add(this.cboCliente2);
            this.tabPage4.Controls.Add(this.lblCliente2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(413, 360);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Cliente";
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
            // cboCliente2
            // 
            this.cboCliente2.FormattingEnabled = true;
            this.cboCliente2.Location = new System.Drawing.Point(129, 30);
            this.cboCliente2.Name = "cboCliente2";
            this.cboCliente2.Size = new System.Drawing.Size(230, 21);
            this.cboCliente2.TabIndex = 14;
            // 
            // lblCliente2
            // 
            this.lblCliente2.AutoSize = true;
            this.lblCliente2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCliente2.Location = new System.Drawing.Point(33, 32);
            this.lblCliente2.Name = "lblCliente2";
            this.lblCliente2.Size = new System.Drawing.Size(60, 19);
            this.lblCliente2.TabIndex = 3;
            this.lblCliente2.Text = "Cliente:";
            // 
            // frmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 465);
            this.Controls.Add(this.tabControlClientes);
            this.Controls.Add(this.lblGestionProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionClientes";
            this.Text = "Gestion Clientes";
            this.Load += new System.EventHandler(this.frmGestionClientes_Load);
            this.tabControlClientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbConsultaCliente)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionProductos;
        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblTipoID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.DataGridView dgbConsultaCliente;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCorreo1;
        private System.Windows.Forms.Label lblCorreo1;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion1;
        private System.Windows.Forms.Label lblDireccion1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Button btnConsultar1;
        private System.Windows.Forms.ComboBox cboCliente1;
        private System.Windows.Forms.Label lblCliente1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cboCliente2;
        private System.Windows.Forms.Label lblCliente2;
        private System.Windows.Forms.ComboBox cboTipoID;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtIdentificacion1;
        private System.Windows.Forms.Label lblIdentificacion1;
    }
}