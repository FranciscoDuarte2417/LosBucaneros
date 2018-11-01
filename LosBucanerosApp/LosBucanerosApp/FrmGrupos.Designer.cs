namespace LosBucanerosApp
{
    partial class FrmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombregrupo = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbgrupos = new System.Windows.Forms.ComboBox();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBitacora = new System.Windows.Forms.ListBox();
            this.lstTractos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcomentario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Controls.Add(this.txtnombregrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnombregrupo
            // 
            this.txtnombregrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombregrupo.Location = new System.Drawing.Point(85, 24);
            this.txtnombregrupo.MaxLength = 25;
            this.txtnombregrupo.Name = "txtnombregrupo";
            this.txtnombregrupo.Size = new System.Drawing.Size(186, 25);
            this.txtnombregrupo.TabIndex = 1;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(86, 102);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(82, 34);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lstTractos);
            this.groupBox2.Controls.Add(this.lstBitacora);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Grupo";
            // 
            // cmbgrupos
            // 
            this.cmbgrupos.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.cmbgrupos.FormattingEnabled = true;
            this.cmbgrupos.Location = new System.Drawing.Point(151, 165);
            this.cmbgrupos.Name = "cmbgrupos";
            this.cmbgrupos.Size = new System.Drawing.Size(197, 28);
            this.cmbgrupos.TabIndex = 2;
            this.cmbgrupos.SelectedIndexChanged += new System.EventHandler(this.cmbgrupos_SelectedIndexChanged);
            this.cmbgrupos.SelectionChangeCommitted += new System.EventHandler(this.cmbgrupos_SelectionChangeCommitted);
            // 
            // txtcomentario
            // 
            this.txtcomentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcomentario.Location = new System.Drawing.Point(85, 55);
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.Size = new System.Drawing.Size(186, 41);
            this.txtcomentario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comentario";
            // 
            // lstBitacora
            // 
            this.lstBitacora.FormattingEnabled = true;
            this.lstBitacora.ItemHeight = 20;
            this.lstBitacora.Location = new System.Drawing.Point(6, 44);
            this.lstBitacora.Name = "lstBitacora";
            this.lstBitacora.Size = new System.Drawing.Size(265, 264);
            this.lstBitacora.TabIndex = 0;
            // 
            // lstTractos
            // 
            this.lstTractos.FormattingEnabled = true;
            this.lstTractos.ItemHeight = 20;
            this.lstTractos.Location = new System.Drawing.Point(367, 44);
            this.lstTractos.Name = "lstTractos";
            this.lstTractos.Size = new System.Drawing.Size(265, 264);
            this.lstTractos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(277, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(277, 188);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 37);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = ">";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-236, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tractos en Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tractos sin Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label5.Location = new System.Drawing.Point(18, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccione un Grupo";
            // 
            // FrmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(661, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbgrupos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de grupos";
            this.Load += new System.EventHandler(this.FrmGrupos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtnombregrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbgrupos;
        private System.Windows.Forms.TextBox txtcomentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstTractos;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}