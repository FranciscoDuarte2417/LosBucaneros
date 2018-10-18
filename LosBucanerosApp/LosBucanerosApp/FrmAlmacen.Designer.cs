namespace LosBucanerosApp
{
    partial class FrmAlmacen
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
            this.lblsim = new System.Windows.Forms.Label();
            this.pbSim = new System.Windows.Forms.PictureBox();
            this.pbEquipo = new System.Windows.Forms.PictureBox();
            this.pbLinea = new System.Windows.Forms.PictureBox();
            this.btnCelulares = new System.Windows.Forms.Button();
            this.btnLineas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsim
            // 
            this.lblsim.AutoSize = true;
            this.lblsim.BackColor = System.Drawing.Color.Transparent;
            this.lblsim.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsim.ForeColor = System.Drawing.Color.Black;
            this.lblsim.Location = new System.Drawing.Point(358, 27);
            this.lblsim.Name = "lblsim";
            this.lblsim.Size = new System.Drawing.Size(44, 25);
            this.lblsim.TabIndex = 11;
            this.lblsim.Text = "SIM";
            // 
            // pbSim
            // 
            this.pbSim.Image = global::LosBucanerosApp.Properties.Resources.SIM;
            this.pbSim.Location = new System.Drawing.Point(0, 88);
            this.pbSim.Name = "pbSim";
            this.pbSim.Size = new System.Drawing.Size(42, 44);
            this.pbSim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSim.TabIndex = 10;
            this.pbSim.TabStop = false;
            this.pbSim.Visible = false;
            this.pbSim.Click += new System.EventHandler(this.pbSim_Click);
            // 
            // pbEquipo
            // 
            this.pbEquipo.Image = global::LosBucanerosApp.Properties.Resources.cellp;
            this.pbEquipo.Location = new System.Drawing.Point(12, 54);
            this.pbEquipo.Name = "pbEquipo";
            this.pbEquipo.Size = new System.Drawing.Size(30, 34);
            this.pbEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEquipo.TabIndex = 7;
            this.pbEquipo.TabStop = false;
            this.pbEquipo.Visible = false;
            this.pbEquipo.Click += new System.EventHandler(this.pbEquipo_Click);
            // 
            // pbLinea
            // 
            this.pbLinea.Image = global::LosBucanerosApp.Properties.Resources.linea__2_;
            this.pbLinea.Location = new System.Drawing.Point(0, 74);
            this.pbLinea.Name = "pbLinea";
            this.pbLinea.Size = new System.Drawing.Size(69, 58);
            this.pbLinea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLinea.TabIndex = 6;
            this.pbLinea.TabStop = false;
            this.pbLinea.Visible = false;
            this.pbLinea.Click += new System.EventHandler(this.pbLinea_Click);
            // 
            // btnCelulares
            // 
            this.btnCelulares.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCelulares.Font = new System.Drawing.Font("NewsGoth Lt BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelulares.ForeColor = System.Drawing.Color.White;
            this.btnCelulares.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCelulares.Location = new System.Drawing.Point(63, 6);
            this.btnCelulares.Name = "btnCelulares";
            this.btnCelulares.Size = new System.Drawing.Size(171, 60);
            this.btnCelulares.TabIndex = 12;
            this.btnCelulares.Text = "Equipos";
            this.btnCelulares.UseVisualStyleBackColor = false;
            this.btnCelulares.Click += new System.EventHandler(this.btnCelulares_Click);
            // 
            // btnLineas
            // 
            this.btnLineas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLineas.Font = new System.Drawing.Font("NewsGoth Lt BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineas.ForeColor = System.Drawing.Color.White;
            this.btnLineas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLineas.Location = new System.Drawing.Point(63, 72);
            this.btnLineas.Name = "btnLineas";
            this.btnLineas.Size = new System.Drawing.Size(171, 60);
            this.btnLineas.TabIndex = 13;
            this.btnLineas.Text = "Lineas";
            this.btnLineas.UseVisualStyleBackColor = false;
            this.btnLineas.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Font = new System.Drawing.Font("NewsGoth Lt BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(63, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 60);
            this.button2.TabIndex = 14;
            this.button2.Text = "SIM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(292, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLineas);
            this.Controls.Add(this.btnCelulares);
            this.Controls.Add(this.lblsim);
            this.Controls.Add(this.pbSim);
            this.Controls.Add(this.pbEquipo);
            this.Controls.Add(this.pbLinea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrada / Salida";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlmacen_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAlmacen_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLinea;
        private System.Windows.Forms.PictureBox pbEquipo;
        private System.Windows.Forms.Label lblsim;
        private System.Windows.Forms.PictureBox pbSim;
        private System.Windows.Forms.Button btnCelulares;
        private System.Windows.Forms.Button btnLineas;
        private System.Windows.Forms.Button button2;
    }
}