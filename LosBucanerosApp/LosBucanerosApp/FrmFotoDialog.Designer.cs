namespace LosBucanerosApp
{
    partial class FrmFotoDialog
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(13, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(35, 13);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "label1";
            // 
            // pbfoto
            // 
            this.pbfoto.Location = new System.Drawing.Point(9, 28);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(405, 322);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfoto.TabIndex = 0;
            this.pbfoto.TabStop = false;
            // 
            // FrmFotoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 353);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.pbfoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFotoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFotoDialog";
            this.Load += new System.EventHandler(this.FrmFotoDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.Label lblusuario;
    }
}