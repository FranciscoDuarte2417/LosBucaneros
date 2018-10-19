namespace LosBucanerosApp
{
    partial class FrmAmazonPhoto
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnsubir = new System.Windows.Forms.Button();
            this.Archivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(12, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(93, 14);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(364, 20);
            this.txtpath.TabIndex = 1;
            // 
            // btnsubir
            // 
            this.btnsubir.Location = new System.Drawing.Point(382, 62);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(75, 23);
            this.btnsubir.TabIndex = 2;
            this.btnsubir.Text = "Subir";
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // Archivo
            // 
            this.Archivo.FileName = "openFileDialog1";
            // 
            // FrmAmazonPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 97);
            this.Controls.Add(this.btnsubir);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnbuscar);
            this.Name = "FrmAmazonPhoto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir foto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnsubir;
        private System.Windows.Forms.OpenFileDialog Archivo;
    }
}