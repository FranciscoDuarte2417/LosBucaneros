namespace LosBucanerosApp
{
    partial class FrmAsignacionNumerosSIM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionNumerosSIM));
            this.cmbfiltroestatus = new System.Windows.Forms.ComboBox();
            this.pbbajas = new System.Windows.Forms.PictureBox();
            this.pbaltas = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblnombreoperador = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.gbSIM = new System.Windows.Forms.GroupBox();
            this.cmbSim = new System.Windows.Forms.ComboBox();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.btnAgregarSim = new System.Windows.Forms.LinkLabel();
            this.btnagregarTracto = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcriteriobusqueda = new System.Windows.Forms.ComboBox();
            this.txtBuscaOperadores = new System.Windows.Forms.TextBox();
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.pbconsultas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbGridOperadores = new System.Windows.Forms.GroupBox();
            this.lblcont = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.LinkLabel();
            this.pbmodificaciones = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).BeginInit();
            this.gbSIM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbconsultas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbGridOperadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbfiltroestatus
            // 
            this.cmbfiltroestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiltroestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfiltroestatus.FormattingEnabled = true;
            this.cmbfiltroestatus.Items.AddRange(new object[] {
            "Disponible",
            "Activo"});
            this.cmbfiltroestatus.Location = new System.Drawing.Point(6, 31);
            this.cmbfiltroestatus.Name = "cmbfiltroestatus";
            this.cmbfiltroestatus.Size = new System.Drawing.Size(114, 26);
            this.cmbfiltroestatus.TabIndex = 24;
            this.cmbfiltroestatus.SelectedIndexChanged += new System.EventHandler(this.cmbfiltroestatus_SelectedIndexChanged);
            // 
            // pbbajas
            // 
            this.pbbajas.Location = new System.Drawing.Point(118, 54);
            this.pbbajas.Name = "pbbajas";
            this.pbbajas.Size = new System.Drawing.Size(45, 45);
            this.pbbajas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbajas.TabIndex = 60;
            this.pbbajas.TabStop = false;
            this.pbbajas.Click += new System.EventHandler(this.pbbajas_Click);
            // 
            // pbaltas
            // 
            this.pbaltas.Location = new System.Drawing.Point(4, 54);
            this.pbaltas.Name = "pbaltas";
            this.pbaltas.Size = new System.Drawing.Size(45, 45);
            this.pbaltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbaltas.TabIndex = 54;
            this.pbaltas.TabStop = false;
            this.pbaltas.Click += new System.EventHandler(this.pbaltas_Click);
            this.pbaltas.MouseLeave += new System.EventHandler(this.pbaltas_MouseLeave);
            this.pbaltas.MouseHover += new System.EventHandler(this.pbaltas_MouseHover);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(206, 274);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblnombreoperador
            // 
            this.lblnombreoperador.AutoSize = true;
            this.lblnombreoperador.BackColor = System.Drawing.Color.White;
            this.lblnombreoperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreoperador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnombreoperador.Location = new System.Drawing.Point(6, 35);
            this.lblnombreoperador.Name = "lblnombreoperador";
            this.lblnombreoperador.Size = new System.Drawing.Size(47, 18);
            this.lblnombreoperador.TabIndex = 5;
            this.lblnombreoperador.Text = "Linea:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.White;
            this.lbltitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(308, 80);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(184, 24);
            this.lbltitulo.TabIndex = 57;
            this.lbltitulo.Text = "SIM ASIGNADOS";
            // 
            // gbSIM
            // 
            this.gbSIM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSIM.Controls.Add(this.cmbSim);
            this.gbSIM.Controls.Add(this.cmbLinea);
            this.gbSIM.Controls.Add(this.btnAgregarSim);
            this.gbSIM.Controls.Add(this.btnagregarTracto);
            this.gbSIM.Controls.Add(this.label17);
            this.gbSIM.Controls.Add(this.label16);
            this.gbSIM.Controls.Add(this.txtComentarios);
            this.gbSIM.Controls.Add(this.label15);
            this.gbSIM.Controls.Add(this.label8);
            this.gbSIM.Controls.Add(this.btnGuardar);
            this.gbSIM.Controls.Add(this.lblnombreoperador);
            this.gbSIM.Enabled = false;
            this.gbSIM.Location = new System.Drawing.Point(3, 100);
            this.gbSIM.Name = "gbSIM";
            this.gbSIM.Size = new System.Drawing.Size(299, 437);
            this.gbSIM.TabIndex = 52;
            this.gbSIM.TabStop = false;
            // 
            // cmbSim
            // 
            this.cmbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSim.FormattingEnabled = true;
            this.cmbSim.Location = new System.Drawing.Point(52, 77);
            this.cmbSim.MaxLength = 19;
            this.cmbSim.Name = "cmbSim";
            this.cmbSim.Size = new System.Drawing.Size(197, 26);
            this.cmbSim.TabIndex = 54;
            this.cmbSim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSim_KeyPress);
            this.cmbSim.Leave += new System.EventHandler(this.cmbSim_Leave);
            // 
            // cmbLinea
            // 
            this.cmbLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(52, 38);
            this.cmbLinea.MaxLength = 10;
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(197, 26);
            this.cmbLinea.TabIndex = 53;
            this.cmbLinea.SelectedIndexChanged += new System.EventHandler(this.cmbLinea_SelectedIndexChanged);
            this.cmbLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLinea_KeyPress);
            this.cmbLinea.Leave += new System.EventHandler(this.cmbLinea_Leave);
            // 
            // btnAgregarSim
            // 
            this.btnAgregarSim.AutoSize = true;
            this.btnAgregarSim.BackColor = System.Drawing.Color.White;
            this.btnAgregarSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSim.Location = new System.Drawing.Point(255, 71);
            this.btnAgregarSim.Name = "btnAgregarSim";
            this.btnAgregarSim.Size = new System.Drawing.Size(27, 29);
            this.btnAgregarSim.TabIndex = 52;
            this.btnAgregarSim.TabStop = true;
            this.btnAgregarSim.Text = "+";
            this.btnAgregarSim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAgregarSim_LinkClicked);
            // 
            // btnagregarTracto
            // 
            this.btnagregarTracto.AutoSize = true;
            this.btnagregarTracto.BackColor = System.Drawing.Color.White;
            this.btnagregarTracto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarTracto.Location = new System.Drawing.Point(255, 33);
            this.btnagregarTracto.Name = "btnagregarTracto";
            this.btnagregarTracto.Size = new System.Drawing.Size(27, 29);
            this.btnagregarTracto.TabIndex = 51;
            this.btnagregarTracto.TabStop = true;
            this.btnagregarTracto.Text = "+";
            this.btnagregarTracto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnagregarTracto_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(6, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 18);
            this.label17.TabIndex = 49;
            this.label17.Text = "SIM:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(9, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 18);
            this.label16.TabIndex = 48;
            this.label16.Text = "Comentarios:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(9, 157);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(272, 101);
            this.txtComentarios.TabIndex = 15;
            this.txtComentarios.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(9, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "Adicional";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(1, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Datos de Asignacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Estatus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(122, 8);
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
            "SIM",
            "TELEFONO"});
            this.cmbcriteriobusqueda.Location = new System.Drawing.Point(125, 31);
            this.cmbcriteriobusqueda.Name = "cmbcriteriobusqueda";
            this.cmbcriteriobusqueda.Size = new System.Drawing.Size(175, 26);
            this.cmbcriteriobusqueda.TabIndex = 18;
            // 
            // txtBuscaOperadores
            // 
            this.txtBuscaOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaOperadores.Location = new System.Drawing.Point(306, 32);
            this.txtBuscaOperadores.Name = "txtBuscaOperadores";
            this.txtBuscaOperadores.Size = new System.Drawing.Size(176, 24);
            this.txtBuscaOperadores.TabIndex = 16;
            this.txtBuscaOperadores.TextChanged += new System.EventHandler(this.txtBuscaOperadores_TextChanged);
            // 
            // dgvAsignaciones
            // 
            this.dgvAsignaciones.AllowUserToAddRows = false;
            this.dgvAsignaciones.AllowUserToDeleteRows = false;
            this.dgvAsignaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaciones.GridColor = System.Drawing.Color.DarkBlue;
            this.dgvAsignaciones.Location = new System.Drawing.Point(6, 63);
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignaciones.Size = new System.Drawing.Size(754, 360);
            this.dgvAsignaciones.TabIndex = 0;
            this.dgvAsignaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignaciones_CellContentClick);
            this.dgvAsignaciones.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAsignaciones_DataBindingComplete);
            this.dgvAsignaciones.SelectionChanged += new System.EventHandler(this.dgvAsignaciones_SelectionChanged);
            // 
            // pbconsultas
            // 
            this.pbconsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbconsultas.Location = new System.Drawing.Point(1023, 59);
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
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // gbGridOperadores
            // 
            this.gbGridOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridOperadores.Controls.Add(this.lblcont);
            this.gbGridOperadores.Controls.Add(this.label1);
            this.gbGridOperadores.Controls.Add(this.cmbfiltroestatus);
            this.gbGridOperadores.Controls.Add(this.label7);
            this.gbGridOperadores.Controls.Add(this.cmbcriteriobusqueda);
            this.gbGridOperadores.Controls.Add(this.txtBuscaOperadores);
            this.gbGridOperadores.Controls.Add(this.dgvAsignaciones);
            this.gbGridOperadores.Location = new System.Drawing.Point(308, 101);
            this.gbGridOperadores.Name = "gbGridOperadores";
            this.gbGridOperadores.Size = new System.Drawing.Size(770, 437);
            this.gbGridOperadores.TabIndex = 53;
            this.gbGridOperadores.TabStop = false;
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Location = new System.Drawing.Point(488, 21);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(38, 13);
            this.lblcont.TabIndex = 26;
            this.lblcont.Text = "lblcont";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(5, 25);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(21, 20);
            this.lblusuario.TabIndex = 59;
            this.lblusuario.Text = "\"\"";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(174, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 18);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.TabStop = true;
            this.btnCancelar.Text = "Cancelar";
            // 
            // pbmodificaciones
            // 
            this.pbmodificaciones.Location = new System.Drawing.Point(63, 54);
            this.pbmodificaciones.Name = "pbmodificaciones";
            this.pbmodificaciones.Size = new System.Drawing.Size(45, 45);
            this.pbmodificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmodificaciones.TabIndex = 55;
            this.pbmodificaciones.TabStop = false;
            // 
            // FrmAsignacionNumerosSIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 551);
            this.Controls.Add(this.pbbajas);
            this.Controls.Add(this.pbaltas);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.gbSIM);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbGridOperadores);
            this.Controls.Add(this.pbconsultas);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbmodificaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAsignacionNumerosSIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignaciones de SIM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAsignacionNumerosSIM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).EndInit();
            this.gbSIM.ResumeLayout(false);
            this.gbSIM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbconsultas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbGridOperadores.ResumeLayout(false);
            this.gbGridOperadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbfiltroestatus;
        private System.Windows.Forms.PictureBox pbbajas;
        private System.Windows.Forms.PictureBox pbaltas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblnombreoperador;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox gbSIM;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txtComentarios;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcriteriobusqueda;
        private System.Windows.Forms.TextBox txtBuscaOperadores;
        private System.Windows.Forms.DataGridView dgvAsignaciones;
        private System.Windows.Forms.PictureBox pbconsultas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbGridOperadores;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.LinkLabel btnCancelar;
        private System.Windows.Forms.PictureBox pbmodificaciones;
        private System.Windows.Forms.LinkLabel btnAgregarSim;
        private System.Windows.Forms.LinkLabel btnagregarTracto;
        private System.Windows.Forms.ComboBox cmbSim;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label lblcont;
    }
}