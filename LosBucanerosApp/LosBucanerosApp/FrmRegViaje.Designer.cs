namespace LosBucanerosApp
{
    partial class FrmRegViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegViaje));
            this.lblusuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.LinkLabel();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gbGridOperadores = new System.Windows.Forms.GroupBox();
            this.lblcont = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbfiltroestatus = new System.Windows.Forms.ComboBox();
            this.txtBuscaOperadores = new System.Windows.Forms.TextBox();
            this.dgvFletes = new System.Windows.Forms.DataGridView();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pbaltas = new System.Windows.Forms.PictureBox();
            this.pbmodificaciones = new System.Windows.Forms.PictureBox();
            this.pbbajas = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gbGridOperadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(5, 27);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(21, 20);
            this.lblusuario.TabIndex = 50;
            this.lblusuario.Text = "\"\"";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(183, 77);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 18);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.TabStop = true;
            this.btnCancelar.Text = "Cancelar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gbGridOperadores
            // 
            this.gbGridOperadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGridOperadores.Controls.Add(this.lblcont);
            this.gbGridOperadores.Controls.Add(this.label10);
            this.gbGridOperadores.Controls.Add(this.cmbfiltroestatus);
            this.gbGridOperadores.Controls.Add(this.txtBuscaOperadores);
            this.gbGridOperadores.Controls.Add(this.dgvFletes);
            this.gbGridOperadores.Location = new System.Drawing.Point(8, 98);
            this.gbGridOperadores.Name = "gbGridOperadores";
            this.gbGridOperadores.Size = new System.Drawing.Size(1067, 595);
            this.gbGridOperadores.TabIndex = 42;
            this.gbGridOperadores.TabStop = false;
            // 
            // lblcont
            // 
            this.lblcont.AutoSize = true;
            this.lblcont.Location = new System.Drawing.Point(514, 20);
            this.lblcont.Name = "lblcont";
            this.lblcont.Size = new System.Drawing.Size(38, 13);
            this.lblcont.TabIndex = 28;
            this.lblcont.Text = "lblcont";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Estatus";
            // 
            // cmbfiltroestatus
            // 
            this.cmbfiltroestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfiltroestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfiltroestatus.FormattingEnabled = true;
            this.cmbfiltroestatus.Items.AddRange(new object[] {
            "Por Iniciar",
            "En Trayecto",
            "Entregado"});
            this.cmbfiltroestatus.Location = new System.Drawing.Point(9, 33);
            this.cmbfiltroestatus.Name = "cmbfiltroestatus";
            this.cmbfiltroestatus.Size = new System.Drawing.Size(135, 26);
            this.cmbfiltroestatus.TabIndex = 26;
            // 
            // txtBuscaOperadores
            // 
            this.txtBuscaOperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaOperadores.Location = new System.Drawing.Point(161, 35);
            this.txtBuscaOperadores.Name = "txtBuscaOperadores";
            this.txtBuscaOperadores.Size = new System.Drawing.Size(176, 24);
            this.txtBuscaOperadores.TabIndex = 16;
            // 
            // dgvFletes
            // 
            this.dgvFletes.AllowUserToAddRows = false;
            this.dgvFletes.AllowUserToDeleteRows = false;
            this.dgvFletes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFletes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFletes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFletes.GridColor = System.Drawing.Color.DarkBlue;
            this.dgvFletes.Location = new System.Drawing.Point(6, 63);
            this.dgvFletes.Name = "dgvFletes";
            this.dgvFletes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFletes.Size = new System.Drawing.Size(1051, 518);
            this.dgvFletes.TabIndex = 0;
            this.dgvFletes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLineas_CellContentClick);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.White;
            this.lbltitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo.Location = new System.Drawing.Point(312, 77);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(229, 24);
            this.lbltitulo.TabIndex = 51;
            this.lbltitulo.Text = "REGISTRO DE FLETE";
            // 
            // pbaltas
            // 
            this.pbaltas.Location = new System.Drawing.Point(8, 50);
            this.pbaltas.Name = "pbaltas";
            this.pbaltas.Size = new System.Drawing.Size(45, 45);
            this.pbaltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbaltas.TabIndex = 43;
            this.pbaltas.TabStop = false;
            this.pbaltas.Click += new System.EventHandler(this.pbaltas_Click);
            this.pbaltas.MouseLeave += new System.EventHandler(this.pbaltas_MouseLeave);
            this.pbaltas.MouseHover += new System.EventHandler(this.pbaltas_MouseHover);
            // 
            // pbmodificaciones
            // 
            this.pbmodificaciones.Location = new System.Drawing.Point(62, 50);
            this.pbmodificaciones.Name = "pbmodificaciones";
            this.pbmodificaciones.Size = new System.Drawing.Size(45, 45);
            this.pbmodificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmodificaciones.TabIndex = 45;
            this.pbmodificaciones.TabStop = false;
            this.pbmodificaciones.Click += new System.EventHandler(this.pbmodificaciones_Click);
            this.pbmodificaciones.MouseLeave += new System.EventHandler(this.pbmodificaciones_MouseLeave);
            this.pbmodificaciones.MouseHover += new System.EventHandler(this.pbmodificaciones_MouseHover);
            // 
            // pbbajas
            // 
            this.pbbajas.Location = new System.Drawing.Point(120, 51);
            this.pbbajas.Name = "pbbajas";
            this.pbbajas.Size = new System.Drawing.Size(45, 45);
            this.pbbajas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbajas.TabIndex = 44;
            this.pbbajas.TabStop = false;
            this.pbbajas.Click += new System.EventHandler(this.pbbajas_Click);
            // 
            // FrmRegViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 712);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pbaltas);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbmodificaciones);
            this.Controls.Add(this.gbGridOperadores);
            this.Controls.Add(this.pbbajas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegViaje";
            this.Text = "Lineas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAjusteLineas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbGridOperadores.ResumeLayout(false);
            this.gbGridOperadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbaltas;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.LinkLabel btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbmodificaciones;
        private System.Windows.Forms.GroupBox gbGridOperadores;
        private System.Windows.Forms.TextBox txtBuscaOperadores;
        private System.Windows.Forms.DataGridView dgvFletes;
        private System.Windows.Forms.PictureBox pbbajas;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbfiltroestatus;
        private System.Windows.Forms.Label lblcont;
    }
}