namespace LosBucanerosApp
{
    partial class FrmAjustesAdministrativos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjustesAdministrativos));
            this.btnCancelar = new System.Windows.Forms.LinkLabel();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbempresa = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombreoperador = new System.Windows.Forms.Label();
            this.pbfotousuario = new System.Windows.Forms.PictureBox();
            this.pbbajas = new System.Windows.Forms.PictureBox();
            this.pbmodificaciones = new System.Windows.Forms.PictureBox();
            this.gbAdministrativos = new System.Windows.Forms.GroupBox();
            this.cmbUce = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnoempleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscaOperadores = new System.Windows.Forms.TextBox();
            this.dgvAdministrativos = new System.Windows.Forms.DataGridView();
            this.pbaltas = new System.Windows.Forms.PictureBox();
            this.gbGridOperadores = new System.Windows.Forms.GroupBox();
            this.btnlimpiartext = new System.Windows.Forms.LinkLabel();
            this.cmbcriteriobusqueda = new System.Windows.Forms.ComboBox();
            this.pbconsultas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotousuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).BeginInit();
            this.gbAdministrativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrativos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).BeginInit();
            this.gbGridOperadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbconsultas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(170, 87);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 18);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.TabStop = true;
            this.btnCancelar.Text = "Cancelar";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.Location = new System.Drawing.Point(228, 275);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(76, 22);
            this.rbInactivo.TabIndex = 10;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(111, 273);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(66, 22);
            this.rbActivo.TabIndex = 9;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(5, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estatus:";
            // 
            // txtapellido2
            // 
            this.txtapellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido2.Location = new System.Drawing.Point(114, 158);
            this.txtapellido2.MaxLength = 30;
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(176, 24);
            this.txtapellido2.TabIndex = 5;
            this.txtapellido2.TextChanged += new System.EventHandler(this.txtapellido2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(2, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Apellido 2:";
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(114, 128);
            this.txtapellido.MaxLength = 30;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(176, 24);
            this.txtapellido.TabIndex = 4;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Apellido:";
            // 
            // cmbempresa
            // 
            this.cmbempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbempresa.FormattingEnabled = true;
            this.cmbempresa.Items.AddRange(new object[] {
            "TRANSBORDER"});
            this.cmbempresa.Location = new System.Drawing.Point(114, 188);
            this.cmbempresa.Name = "cmbempresa";
            this.cmbempresa.Size = new System.Drawing.Size(176, 26);
            this.cmbempresa.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(216, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pbCamara
            // 
            this.pbCamara.Location = new System.Drawing.Point(6, 306);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(57, 48);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamara.TabIndex = 14;
            this.pbCamara.TabStop = false;
            this.pbCamara.Visible = false;
            this.pbCamara.Click += new System.EventHandler(this.pbCamara_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Registro de Administrativos";
            // 
            // txtnombre2
            // 
            this.txtnombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre2.Location = new System.Drawing.Point(114, 98);
            this.txtnombre2.MaxLength = 30;
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(176, 24);
            this.txtnombre2.TabIndex = 3;
            this.txtnombre2.TextChanged += new System.EventHandler(this.txtnombre2_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(114, 69);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(176, 24);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(4, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empresa:";
            // 
            // lblnombreoperador
            // 
            this.lblnombreoperador.AutoSize = true;
            this.lblnombreoperador.BackColor = System.Drawing.Color.White;
            this.lblnombreoperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreoperador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnombreoperador.Location = new System.Drawing.Point(4, 72);
            this.lblnombreoperador.Name = "lblnombreoperador";
            this.lblnombreoperador.Size = new System.Drawing.Size(66, 18);
            this.lblnombreoperador.TabIndex = 5;
            this.lblnombreoperador.Text = "Nombre:";
            // 
            // pbfotousuario
            // 
            this.pbfotousuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbfotousuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbfotousuario.Location = new System.Drawing.Point(905, 29);
            this.pbfotousuario.Name = "pbfotousuario";
            this.pbfotousuario.Size = new System.Drawing.Size(91, 73);
            this.pbfotousuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfotousuario.TabIndex = 39;
            this.pbfotousuario.TabStop = false;
            // 
            // pbbajas
            // 
            this.pbbajas.Location = new System.Drawing.Point(119, 60);
            this.pbbajas.Name = "pbbajas";
            this.pbbajas.Size = new System.Drawing.Size(45, 45);
            this.pbbajas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbajas.TabIndex = 33;
            this.pbbajas.TabStop = false;
            this.pbbajas.Click += new System.EventHandler(this.pbbajas_Click);
            this.pbbajas.MouseLeave += new System.EventHandler(this.pbbajas_MouseLeave);
            this.pbbajas.MouseHover += new System.EventHandler(this.pbbajas_MouseHover);
            // 
            // pbmodificaciones
            // 
            this.pbmodificaciones.Location = new System.Drawing.Point(61, 60);
            this.pbmodificaciones.Name = "pbmodificaciones";
            this.pbmodificaciones.Size = new System.Drawing.Size(45, 45);
            this.pbmodificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmodificaciones.TabIndex = 34;
            this.pbmodificaciones.TabStop = false;
            this.pbmodificaciones.Click += new System.EventHandler(this.pbmodificaciones_Click);
            this.pbmodificaciones.MouseLeave += new System.EventHandler(this.pbmodificaciones_MouseLeave);
            this.pbmodificaciones.MouseHover += new System.EventHandler(this.pbmodificaciones_MouseHover);
            // 
            // gbAdministrativos
            // 
            this.gbAdministrativos.Controls.Add(this.cmbUce);
            this.gbAdministrativos.Controls.Add(this.label10);
            this.gbAdministrativos.Controls.Add(this.txtnoempleado);
            this.gbAdministrativos.Controls.Add(this.label9);
            this.gbAdministrativos.Controls.Add(this.txtpuesto);
            this.gbAdministrativos.Controls.Add(this.label8);
            this.gbAdministrativos.Controls.Add(this.rbInactivo);
            this.gbAdministrativos.Controls.Add(this.rbActivo);
            this.gbAdministrativos.Controls.Add(this.label4);
            this.gbAdministrativos.Controls.Add(this.txtapellido2);
            this.gbAdministrativos.Controls.Add(this.label5);
            this.gbAdministrativos.Controls.Add(this.txtapellido);
            this.gbAdministrativos.Controls.Add(this.label1);
            this.gbAdministrativos.Controls.Add(this.cmbempresa);
            this.gbAdministrativos.Controls.Add(this.btnGuardar);
            this.gbAdministrativos.Controls.Add(this.pbCamara);
            this.gbAdministrativos.Controls.Add(this.label6);
            this.gbAdministrativos.Controls.Add(this.txtnombre2);
            this.gbAdministrativos.Controls.Add(this.txtnombre);
            this.gbAdministrativos.Controls.Add(this.label2);
            this.gbAdministrativos.Controls.Add(this.lblnombreoperador);
            this.gbAdministrativos.Controls.Add(this.label3);
            this.gbAdministrativos.Enabled = false;
            this.gbAdministrativos.Location = new System.Drawing.Point(5, 108);
            this.gbAdministrativos.Name = "gbAdministrativos";
            this.gbAdministrativos.Size = new System.Drawing.Size(332, 380);
            this.gbAdministrativos.TabIndex = 30;
            this.gbAdministrativos.TabStop = false;
            // 
            // cmbUce
            // 
            this.cmbUce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUce.FormattingEnabled = true;
            this.cmbUce.Items.AddRange(new object[] {
            "NOGALES",
            "CULIACAN",
            "MEXICO",
            "MEXICALI",
            "TIJUANA",
            "URUAPAN"});
            this.cmbUce.Location = new System.Drawing.Point(114, 219);
            this.cmbUce.Name = "cmbUce";
            this.cmbUce.Size = new System.Drawing.Size(176, 26);
            this.cmbUce.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(5, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "UCE:";
            // 
            // txtnoempleado
            // 
            this.txtnoempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoempleado.Location = new System.Drawing.Point(114, 41);
            this.txtnoempleado.MaxLength = 10;
            this.txtnoempleado.Name = "txtnoempleado";
            this.txtnoempleado.Size = new System.Drawing.Size(176, 24);
            this.txtnoempleado.TabIndex = 1;
            this.txtnoempleado.TextChanged += new System.EventHandler(this.txtnoempleado_TextChanged);
            this.txtnoempleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnoempleado_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(4, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "No Empleado:";
            // 
            // txtpuesto
            // 
            this.txtpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpuesto.Location = new System.Drawing.Point(114, 250);
            this.txtpuesto.MaxLength = 30;
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(176, 24);
            this.txtpuesto.TabIndex = 8;
            this.txtpuesto.TextChanged += new System.EventHandler(this.txtpuesto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(4, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Puesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre 2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(550, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Buscar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Busqueda Por:";
            // 
            // txtBuscaOperadores
            // 
            this.txtBuscaOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaOperadores.Location = new System.Drawing.Point(197, 32);
            this.txtBuscaOperadores.Name = "txtBuscaOperadores";
            this.txtBuscaOperadores.Size = new System.Drawing.Size(176, 24);
            this.txtBuscaOperadores.TabIndex = 16;
            this.txtBuscaOperadores.TextChanged += new System.EventHandler(this.txtBuscaOperadores_TextChanged);
            // 
            // dgvAdministrativos
            // 
            this.dgvAdministrativos.AllowUserToAddRows = false;
            this.dgvAdministrativos.AllowUserToDeleteRows = false;
            this.dgvAdministrativos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdministrativos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAdministrativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministrativos.Location = new System.Drawing.Point(10, 62);
            this.dgvAdministrativos.Name = "dgvAdministrativos";
            this.dgvAdministrativos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministrativos.Size = new System.Drawing.Size(638, 308);
            this.dgvAdministrativos.TabIndex = 0;
            this.dgvAdministrativos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAdministrativos_DataBindingComplete);
            this.dgvAdministrativos.SelectionChanged += new System.EventHandler(this.dgvAdministrativos_SelectionChanged);
            // 
            // pbaltas
            // 
            this.pbaltas.Location = new System.Drawing.Point(6, 59);
            this.pbaltas.Name = "pbaltas";
            this.pbaltas.Size = new System.Drawing.Size(45, 45);
            this.pbaltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbaltas.TabIndex = 32;
            this.pbaltas.TabStop = false;
            this.pbaltas.Click += new System.EventHandler(this.pbaltas_Click);
            this.pbaltas.MouseLeave += new System.EventHandler(this.pbaltas_MouseLeave);
            this.pbaltas.MouseHover += new System.EventHandler(this.pbaltas_MouseHover);
            // 
            // gbGridOperadores
            // 
            this.gbGridOperadores.Controls.Add(this.lblcont);
            this.gbGridOperadores.Controls.Add(this.btnlimpiartext);
            this.gbGridOperadores.Controls.Add(this.label7);
            this.gbGridOperadores.Controls.Add(this.cmbcriteriobusqueda);
            this.gbGridOperadores.Controls.Add(this.txtBuscaOperadores);
            this.gbGridOperadores.Controls.Add(this.dgvAdministrativos);
            this.gbGridOperadores.Controls.Add(this.pbconsultas);
            this.gbGridOperadores.Location = new System.Drawing.Point(342, 108);
            this.gbGridOperadores.Name = "gbGridOperadores";
            this.gbGridOperadores.Size = new System.Drawing.Size(654, 380);
            this.gbGridOperadores.TabIndex = 31;
            this.gbGridOperadores.TabStop = false;
            this.gbGridOperadores.Enter += new System.EventHandler(this.gbGridOperadores_Enter);
            // 
            // btnlimpiartext
            // 
            this.btnlimpiartext.AutoSize = true;
            this.btnlimpiartext.BackColor = System.Drawing.Color.White;
            this.btnlimpiartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiartext.Location = new System.Drawing.Point(379, 41);
            this.btnlimpiartext.Name = "btnlimpiartext";
            this.btnlimpiartext.Size = new System.Drawing.Size(49, 15);
            this.btnlimpiartext.TabIndex = 41;
            this.btnlimpiartext.TabStop = true;
            this.btnlimpiartext.Text = "Limpiar";
            this.btnlimpiartext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlimpiartext_LinkClicked);
            // 
            // cmbcriteriobusqueda
            // 
            this.cmbcriteriobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcriteriobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcriteriobusqueda.FormattingEnabled = true;
            this.cmbcriteriobusqueda.Items.AddRange(new object[] {
            "Nombre O Apellido",
            "Puesto"});
            this.cmbcriteriobusqueda.Location = new System.Drawing.Point(10, 31);
            this.cmbcriteriobusqueda.Name = "cmbcriteriobusqueda";
            this.cmbcriteriobusqueda.Size = new System.Drawing.Size(181, 26);
            this.cmbcriteriobusqueda.TabIndex = 18;
            // 
            // pbconsultas
            // 
            this.pbconsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbconsultas.Location = new System.Drawing.Point(603, 12);
            this.pbconsultas.Name = "pbconsultas";
            this.pbconsultas.Size = new System.Drawing.Size(45, 45);
            this.pbconsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbconsultas.TabIndex = 8;
            this.pbconsultas.TabStop = false;
            this.pbconsultas.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(6, 33);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(21, 20);
            this.lblusuario.TabIndex = 40;
            this.lblusuario.Text = "\"\"";
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcont.Location = new System.Drawing.Point(425, 16);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(68, 23);
            this.lblcont.TabIndex = 42;
            this.lblcont.Text = "lblcont";
            // 
            // FrmAjustesAdministrativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 493);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbfotousuario);
            this.Controls.Add(this.pbbajas);
            this.Controls.Add(this.pbmodificaciones);
            this.Controls.Add(this.gbAdministrativos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pbaltas);
            this.Controls.Add(this.gbGridOperadores);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjustesAdministrativos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes Administrativos";
            this.Load += new System.EventHandler(this.FrmAjustesAdministrativos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotousuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).EndInit();
            this.gbAdministrativos.ResumeLayout(false);
            this.gbAdministrativos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrativos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).EndInit();
            this.gbGridOperadores.ResumeLayout(false);
            this.gbGridOperadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbconsultas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel btnCancelar;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbempresa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombreoperador;
        private System.Windows.Forms.PictureBox pbfotousuario;
        private System.Windows.Forms.PictureBox pbbajas;
        private System.Windows.Forms.PictureBox pbmodificaciones;
        private System.Windows.Forms.GroupBox gbAdministrativos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscaOperadores;
        private System.Windows.Forms.DataGridView dgvAdministrativos;
        private System.Windows.Forms.PictureBox pbaltas;
        private System.Windows.Forms.GroupBox gbGridOperadores;
        private System.Windows.Forms.ComboBox cmbcriteriobusqueda;
        private System.Windows.Forms.PictureBox pbconsultas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnoempleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel btnlimpiartext;
        private System.Windows.Forms.ComboBox cmbUce;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcont;
    }
}