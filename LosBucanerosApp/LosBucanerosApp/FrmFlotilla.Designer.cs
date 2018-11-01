namespace LosBucanerosApp
{
    partial class FrmFlotilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlotilla));
            this.label5 = new System.Windows.Forms.Label();
            this.cmbgrupos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstTractos = new System.Windows.Forms.ListBox();
            this.lstBitacora = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleccione un Coordinador";
            // 
            // cmbgrupos
            // 
            this.cmbgrupos.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.cmbgrupos.FormattingEnabled = true;
            this.cmbgrupos.Location = new System.Drawing.Point(185, 12);
            this.cmbgrupos.Name = "cmbgrupos";
            this.cmbgrupos.Size = new System.Drawing.Size(197, 28);
            this.cmbgrupos.TabIndex = 10;
            this.cmbgrupos.SelectionChangeCommitted += new System.EventHandler(this.cmbgrupos_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.lstTractos);
            this.groupBox2.Controls.Add(this.lstBitacora);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 320);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tractos Sin Coordinador";
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
            // lstTractos
            // 
            this.lstTractos.FormattingEnabled = true;
            this.lstTractos.ItemHeight = 20;
            this.lstTractos.Location = new System.Drawing.Point(367, 44);
            this.lstTractos.Name = "lstTractos";
            this.lstTractos.Size = new System.Drawing.Size(265, 264);
            this.lstTractos.TabIndex = 1;
            // 
            // lstBitacora
            // 
            this.lstBitacora.FormattingEnabled = true;
            this.lstBitacora.ItemHeight = 20;
            this.lstBitacora.Location = new System.Drawing.Point(6, 44);
            this.lstBitacora.Name = "lstBitacora";
            this.lstBitacora.Size = new System.Drawing.Size(265, 264);
            this.lstBitacora.TabIndex = 0;
            this.lstBitacora.SelectedIndexChanged += new System.EventHandler(this.lstBitacora_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tractos del Coordinador";
            // 
            // FrmFlotilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbgrupos);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFlotilla";
            this.Text = "Administrar Flotilla";
            this.Load += new System.EventHandler(this.FrmFlotilla_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbgrupos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstTractos;
        private System.Windows.Forms.ListBox lstBitacora;
        private System.Windows.Forms.Label label3;
    }
}