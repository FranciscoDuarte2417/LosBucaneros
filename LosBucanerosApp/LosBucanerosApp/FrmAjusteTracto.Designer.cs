namespace LosBucanerosApp
{
    partial class FrmAjusteTracto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjusteTracto));
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcriteriobusqueda = new System.Windows.Forms.ComboBox();
            this.txtNoTracto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblnombreoperador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTracto = new System.Windows.Forms.GroupBox();
            this.cmbNomenclatura = new System.Windows.Forms.ComboBox();
            this.pbCamara = new System.Windows.Forms.PictureBox();
            this.txtBuscaOperadores = new System.Windows.Forms.TextBox();
            this.gbGridOperadores = new System.Windows.Forms.GroupBox();
            this.btnlimpiargrid = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbconsultas = new System.Windows.Forms.PictureBox();
            this.pbfotousuario = new System.Windows.Forms.PictureBox();
            this.pbbajas = new System.Windows.Forms.PictureBox();
            this.pbaltas = new System.Windows.Forms.PictureBox();
            this.pbmodificaciones = new System.Windows.Forms.PictureBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcont = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbTracto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).BeginInit();
            this.gbGridOperadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbconsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotousuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(222, 89);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 18);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.TabStop = true;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCancelar_LinkClicked);
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
            // cmbcriteriobusqueda
            // 
            this.cmbcriteriobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcriteriobusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcriteriobusqueda.FormattingEnabled = true;
            this.cmbcriteriobusqueda.Items.AddRange(new object[] {
            "No. Tracto",
            "Estatus"});
            this.cmbcriteriobusqueda.Location = new System.Drawing.Point(10, 31);
            this.cmbcriteriobusqueda.Name = "cmbcriteriobusqueda";
            this.cmbcriteriobusqueda.Size = new System.Drawing.Size(121, 26);
            this.cmbcriteriobusqueda.TabIndex = 18;
            this.cmbcriteriobusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbcriteriobusqueda_SelectedIndexChanged);
            // 
            // txtNoTracto
            // 
            this.txtNoTracto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTracto.Location = new System.Drawing.Point(112, 92);
            this.txtNoTracto.MaxLength = 10;
            this.txtNoTracto.Name = "txtNoTracto";
            this.txtNoTracto.Size = new System.Drawing.Size(191, 24);
            this.txtNoTracto.TabIndex = 2;
            this.txtNoTracto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoTracto.TextChanged += new System.EventHandler(this.txtNoTracto_TextChanged);
            this.txtNoTracto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoTracto_KeyPress);
            this.txtNoTracto.Leave += new System.EventHandler(this.txtNoTracto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Empresa:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Items.AddRange(new object[] {
            "TRANSBORDER",
            "TRANION"});
            this.cmbEmpresa.Location = new System.Drawing.Point(112, 125);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(191, 26);
            this.cmbEmpresa.TabIndex = 3;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.Location = new System.Drawing.Point(203, 168);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(76, 22);
            this.rbInactivo.TabIndex = 5;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.Visible = false;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(112, 165);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(66, 22);
            this.rbActivo.TabIndex = 4;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.Visible = false;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(213, 196);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Registro de Tractos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 26;
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
            // lblnombreoperador
            // 
            this.lblnombreoperador.AutoSize = true;
            this.lblnombreoperador.BackColor = System.Drawing.Color.White;
            this.lblnombreoperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreoperador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnombreoperador.Location = new System.Drawing.Point(5, 59);
            this.lblnombreoperador.Name = "lblnombreoperador";
            this.lblnombreoperador.Size = new System.Drawing.Size(105, 18);
            this.lblnombreoperador.TabIndex = 5;
            this.lblnombreoperador.Text = "Nomenclatura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. Tracto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(5, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estatus:";
            this.label4.Visible = false;
            // 
            // gbTracto
            // 
            this.gbTracto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTracto.Controls.Add(this.cmbNomenclatura);
            this.gbTracto.Controls.Add(this.txtNoTracto);
            this.gbTracto.Controls.Add(this.label1);
            this.gbTracto.Controls.Add(this.cmbEmpresa);
            this.gbTracto.Controls.Add(this.rbInactivo);
            this.gbTracto.Controls.Add(this.rbActivo);
            this.gbTracto.Controls.Add(this.btnGuardar);
            this.gbTracto.Controls.Add(this.pbCamara);
            this.gbTracto.Controls.Add(this.label6);
            this.gbTracto.Controls.Add(this.lblnombreoperador);
            this.gbTracto.Controls.Add(this.label3);
            this.gbTracto.Controls.Add(this.label4);
            this.gbTracto.Enabled = false;
            this.gbTracto.Location = new System.Drawing.Point(7, 104);
            this.gbTracto.Name = "gbTracto";
            this.gbTracto.Size = new System.Drawing.Size(318, 369);
            this.gbTracto.TabIndex = 20;
            this.gbTracto.TabStop = false;
            // 
            // cmbNomenclatura
            // 
            this.cmbNomenclatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomenclatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomenclatura.FormattingEnabled = true;
            this.cmbNomenclatura.Items.AddRange(new object[] {
            "TN",
            "LMA",
            "ION"});
            this.cmbNomenclatura.Location = new System.Drawing.Point(112, 59);
            this.cmbNomenclatura.Name = "cmbNomenclatura";
            this.cmbNomenclatura.Size = new System.Drawing.Size(191, 26);
            this.cmbNomenclatura.TabIndex = 1;
            // 
            // pbCamara
            // 
            this.pbCamara.Location = new System.Drawing.Point(14, 258);
            this.pbCamara.Name = "pbCamara";
            this.pbCamara.Size = new System.Drawing.Size(57, 48);
            this.pbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamara.TabIndex = 14;
            this.pbCamara.TabStop = false;
            this.pbCamara.Visible = false;
            // 
            // txtBuscaOperadores
            // 
            this.txtBuscaOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaOperadores.Location = new System.Drawing.Point(137, 32);
            this.txtBuscaOperadores.Name = "txtBuscaOperadores";
            this.txtBuscaOperadores.Size = new System.Drawing.Size(176, 24);
            this.txtBuscaOperadores.TabIndex = 16;
            this.txtBuscaOperadores.TextChanged += new System.EventHandler(this.txtBuscaOperadores_TextChanged);
            // 
            // gbGridOperadores
            // 
            this.gbGridOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridOperadores.Controls.Add(this.lblcont);
            this.gbGridOperadores.Controls.Add(this.btnlimpiargrid);
            this.gbGridOperadores.Controls.Add(this.label7);
            this.gbGridOperadores.Controls.Add(this.cmbcriteriobusqueda);
            this.gbGridOperadores.Controls.Add(this.txtBuscaOperadores);
            this.gbGridOperadores.Controls.Add(this.dataGridView1);
            this.gbGridOperadores.Controls.Add(this.pbconsultas);
            this.gbGridOperadores.Location = new System.Drawing.Point(331, 104);
            this.gbGridOperadores.Name = "gbGridOperadores";
            this.gbGridOperadores.Size = new System.Drawing.Size(665, 369);
            this.gbGridOperadores.TabIndex = 21;
            this.gbGridOperadores.TabStop = false;
            // 
            // btnlimpiargrid
            // 
            this.btnlimpiargrid.AutoSize = true;
            this.btnlimpiargrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiargrid.Location = new System.Drawing.Point(319, 39);
            this.btnlimpiargrid.Name = "btnlimpiargrid";
            this.btnlimpiargrid.Size = new System.Drawing.Size(49, 15);
            this.btnlimpiargrid.TabIndex = 30;
            this.btnlimpiargrid.TabStop = true;
            this.btnlimpiargrid.Text = "Limpiar";
            this.btnlimpiargrid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlimpiargrid_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(649, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTractos_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTractos_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgvTractos_SelectionChanged);
            // 
            // pbconsultas
            // 
            this.pbconsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbconsultas.Location = new System.Drawing.Point(614, 12);
            this.pbconsultas.Name = "pbconsultas";
            this.pbconsultas.Size = new System.Drawing.Size(45, 45);
            this.pbconsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbconsultas.TabIndex = 8;
            this.pbconsultas.TabStop = false;
            this.pbconsultas.Visible = false;
            // 
            // pbfotousuario
            // 
            this.pbfotousuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbfotousuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbfotousuario.Location = new System.Drawing.Point(899, 25);
            this.pbfotousuario.Name = "pbfotousuario";
            this.pbfotousuario.Size = new System.Drawing.Size(91, 73);
            this.pbfotousuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfotousuario.TabIndex = 29;
            this.pbfotousuario.TabStop = false;
            this.pbfotousuario.Visible = false;
            // 
            // pbbajas
            // 
            this.pbbajas.Location = new System.Drawing.Point(140, 62);
            this.pbbajas.Name = "pbbajas";
            this.pbbajas.Size = new System.Drawing.Size(45, 45);
            this.pbbajas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbajas.TabIndex = 23;
            this.pbbajas.TabStop = false;
            this.pbbajas.Click += new System.EventHandler(this.pbbajas_Click);
            this.pbbajas.MouseLeave += new System.EventHandler(this.pbbajas_MouseLeave);
            this.pbbajas.MouseHover += new System.EventHandler(this.pbbajas_MouseHover);
            // 
            // pbaltas
            // 
            this.pbaltas.Location = new System.Drawing.Point(7, 62);
            this.pbaltas.Name = "pbaltas";
            this.pbaltas.Size = new System.Drawing.Size(45, 45);
            this.pbaltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbaltas.TabIndex = 22;
            this.pbaltas.TabStop = false;
            this.pbaltas.Click += new System.EventHandler(this.pbaltas_Click);
            this.pbaltas.MouseLeave += new System.EventHandler(this.pbaltas_MouseLeave);
            this.pbaltas.MouseHover += new System.EventHandler(this.pbaltas_MouseHover);
            // 
            // pbmodificaciones
            // 
            this.pbmodificaciones.Location = new System.Drawing.Point(72, 62);
            this.pbmodificaciones.Name = "pbmodificaciones";
            this.pbmodificaciones.Size = new System.Drawing.Size(45, 45);
            this.pbmodificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmodificaciones.TabIndex = 24;
            this.pbmodificaciones.TabStop = false;
            this.pbmodificaciones.Click += new System.EventHandler(this.pbmodificaciones_Click);
            this.pbmodificaciones.MouseLeave += new System.EventHandler(this.pbmodificaciones_MouseLeave);
            this.pbmodificaciones.MouseHover += new System.EventHandler(this.pbmodificaciones_MouseHover);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(3, 34);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(21, 20);
            this.lblusuario.TabIndex = 30;
            this.lblusuario.Text = "\"\"";
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Location = new System.Drawing.Point(370, 21);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(38, 13);
            this.lblcont.TabIndex = 31;
            this.lblcont.Text = "lblcont";
            // 
            // FrmAjusteTracto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 484);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbfotousuario);
            this.Controls.Add(this.pbbajas);
            this.Controls.Add(this.pbaltas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbmodificaciones);
            this.Controls.Add(this.gbTracto);
            this.Controls.Add(this.gbGridOperadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjusteTracto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes Tracto";
            this.Load += new System.EventHandler(this.FrmAjusteTracto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbTracto.ResumeLayout(false);
            this.gbTracto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamara)).EndInit();
            this.gbGridOperadores.ResumeLayout(false);
            this.gbGridOperadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbconsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfotousuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.LinkLabel btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcriteriobusqueda;
        private System.Windows.Forms.TextBox txtNoTracto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbCamara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbfotousuario;
        private System.Windows.Forms.PictureBox pbbajas;
        private System.Windows.Forms.PictureBox pbconsultas;
        private System.Windows.Forms.PictureBox pbaltas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.Label lblnombreoperador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbmodificaciones;
        private System.Windows.Forms.GroupBox gbTracto;
        private System.Windows.Forms.TextBox txtBuscaOperadores;
        private System.Windows.Forms.GroupBox gbGridOperadores;
        private System.Windows.Forms.ComboBox cmbNomenclatura;
        private System.Windows.Forms.LinkLabel btnlimpiargrid;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcont;
    }
}