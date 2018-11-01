namespace LosBucanerosApp
{
    partial class FrmRegistroViaje
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
            this.lbltipoviaje = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.cmbTipoFlete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbCentigrados = new System.Windows.Forms.RadioButton();
            this.rbFarenheit = new System.Windows.Forms.RadioButton();
            this.txtRangoTemperaturas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoCarga = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTracto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsello = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGuardarFlete = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbcajas = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtcomentarios = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.chkOperadorPendiente = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbltipoviaje
            // 
            this.lbltipoviaje.AutoSize = true;
            this.lbltipoviaje.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoviaje.Location = new System.Drawing.Point(10, 36);
            this.lbltipoviaje.Name = "lbltipoviaje";
            this.lbltipoviaje.Size = new System.Drawing.Size(86, 20);
            this.lbltipoviaje.TabIndex = 0;
            this.lbltipoviaje.Text = "Tipo de Flete:";
            // 
            // txtFolio
            // 
            this.txtFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFolio.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtFolio.ForeColor = System.Drawing.Color.DarkRed;
            this.txtFolio.Location = new System.Drawing.Point(104, 123);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(194, 25);
            this.txtFolio.TabIndex = 3;
            // 
            // cmbTipoFlete
            // 
            this.cmbTipoFlete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoFlete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipoFlete.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.cmbTipoFlete.FormattingEnabled = true;
            this.cmbTipoFlete.Items.AddRange(new object[] {
            "IMPORTACION",
            "EXPORTACION",
            "NACIONAL"});
            this.cmbTipoFlete.Location = new System.Drawing.Point(104, 33);
            this.cmbTipoFlete.Name = "cmbTipoFlete";
            this.cmbTipoFlete.Size = new System.Drawing.Size(194, 28);
            this.cmbTipoFlete.TabIndex = 1;
            this.cmbTipoFlete.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFlete_SelectedIndexChanged);
            this.cmbTipoFlete.Leave += new System.EventHandler(this.cmbTipoFlete_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folio de Flete:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destino:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOrigen.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtOrigen.ForeColor = System.Drawing.Color.DarkRed;
            this.txtOrigen.Location = new System.Drawing.Point(104, 165);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(194, 25);
            this.txtOrigen.TabIndex = 4;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDestino.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtDestino.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDestino.Location = new System.Drawing.Point(393, 167);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(194, 25);
            this.txtDestino.TabIndex = 5;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProducto.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.txtProducto.Location = new System.Drawing.Point(393, 262);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(194, 25);
            this.txtProducto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 1F);
            this.label2.Location = new System.Drawing.Point(-43, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 10);
            this.label2.TabIndex = 14;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTemperatura.Enabled = false;
            this.txtTemperatura.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtTemperatura.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTemperatura.Location = new System.Drawing.Point(103, 308);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(194, 25);
            this.txtTemperatura.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Temperatura:";
            // 
            // rbCentigrados
            // 
            this.rbCentigrados.AutoSize = true;
            this.rbCentigrados.Enabled = false;
            this.rbCentigrados.Location = new System.Drawing.Point(307, 300);
            this.rbCentigrados.Name = "rbCentigrados";
            this.rbCentigrados.Size = new System.Drawing.Size(36, 17);
            this.rbCentigrados.TabIndex = 11;
            this.rbCentigrados.TabStop = true;
            this.rbCentigrados.Text = "°C";
            this.rbCentigrados.UseVisualStyleBackColor = true;
            // 
            // rbFarenheit
            // 
            this.rbFarenheit.AutoSize = true;
            this.rbFarenheit.Enabled = false;
            this.rbFarenheit.Location = new System.Drawing.Point(307, 323);
            this.rbFarenheit.Name = "rbFarenheit";
            this.rbFarenheit.Size = new System.Drawing.Size(35, 17);
            this.rbFarenheit.TabIndex = 12;
            this.rbFarenheit.TabStop = true;
            this.rbFarenheit.Text = "°F";
            this.rbFarenheit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFarenheit.UseVisualStyleBackColor = true;
            // 
            // txtRangoTemperaturas
            // 
            this.txtRangoTemperaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRangoTemperaturas.Enabled = false;
            this.txtRangoTemperaturas.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtRangoTemperaturas.ForeColor = System.Drawing.Color.DarkRed;
            this.txtRangoTemperaturas.Location = new System.Drawing.Point(423, 308);
            this.txtRangoTemperaturas.Name = "txtRangoTemperaturas";
            this.txtRangoTemperaturas.Size = new System.Drawing.Size(164, 25);
            this.txtRangoTemperaturas.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rango +- :";
            // 
            // cmbTipoCarga
            // 
            this.cmbTipoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCarga.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.cmbTipoCarga.ForeColor = System.Drawing.Color.DarkRed;
            this.cmbTipoCarga.FormattingEnabled = true;
            this.cmbTipoCarga.Items.AddRange(new object[] {
            "REFRIGERADO",
            "SECO"});
            this.cmbTipoCarga.Location = new System.Drawing.Point(104, 259);
            this.cmbTipoCarga.Name = "cmbTipoCarga";
            this.cmbTipoCarga.Size = new System.Drawing.Size(194, 28);
            this.cmbTipoCarga.TabIndex = 8;
            this.cmbTipoCarga.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCarga_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tipo de Carga:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 1F);
            this.label6.Location = new System.Drawing.Point(-43, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(710, 10);
            this.label6.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 1F);
            this.label10.Location = new System.Drawing.Point(-43, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(710, 10);
            this.label10.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Operador:";
            // 
            // txtTracto
            // 
            this.txtTracto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTracto.Enabled = false;
            this.txtTracto.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtTracto.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTracto.Location = new System.Drawing.Point(393, 389);
            this.txtTracto.Name = "txtTracto";
            this.txtTracto.Size = new System.Drawing.Size(194, 25);
            this.txtTracto.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(333, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tracto:";
            // 
            // cmbOperador
            // 
            this.cmbOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOperador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOperador.BackColor = System.Drawing.Color.White;
            this.cmbOperador.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(104, 386);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(194, 28);
            this.cmbOperador.TabIndex = 15;
            this.cmbOperador.SelectedIndexChanged += new System.EventHandler(this.cmbOperador_SelectedIndexChanged);
            this.cmbOperador.Leave += new System.EventHandler(this.cmbOperador_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "ETA:";
            // 
            // dtpHora
            // 
            this.dtpHora.Checked = false;
            this.dtpHora.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(398, 206);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(105, 25);
            this.dtpHora.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.dtpFecha.Location = new System.Drawing.Point(104, 205);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(237, 25);
            this.dtpFecha.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(351, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "a las :";
            // 
            // txtsello
            // 
            this.txtsello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsello.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtsello.ForeColor = System.Drawing.Color.DarkRed;
            this.txtsello.Location = new System.Drawing.Point(104, 432);
            this.txtsello.Name = "txtsello";
            this.txtsello.Size = new System.Drawing.Size(194, 25);
            this.txtsello.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 435);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Sello:";
            // 
            // btnGuardarFlete
            // 
            this.btnGuardarFlete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardarFlete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFlete.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFlete.Location = new System.Drawing.Point(433, 595);
            this.btnGuardarFlete.Name = "btnGuardarFlete";
            this.btnGuardarFlete.Size = new System.Drawing.Size(85, 32);
            this.btnGuardarFlete.TabIndex = 19;
            this.btnGuardarFlete.Text = "Guardar";
            this.btnGuardarFlete.UseVisualStyleBackColor = false;
            this.btnGuardarFlete.Click += new System.EventHandler(this.btnGuardarFlete_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(528, 595);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 32);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 1F);
            this.label16.Location = new System.Drawing.Point(-43, 460);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(710, 10);
            this.label16.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(3, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(193, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Registro de Informacion de fletes:";
            // 
            // cmbcajas
            // 
            this.cmbcajas.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.cmbcajas.FormattingEnabled = true;
            this.cmbcajas.Location = new System.Drawing.Point(104, 82);
            this.cmbcajas.Name = "cmbcajas";
            this.cmbcajas.Size = new System.Drawing.Size(194, 28);
            this.cmbcajas.TabIndex = 2;
            this.cmbcajas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbcajas.Leave += new System.EventHandler(this.cmbcajas_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "Caja:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPlacas.Enabled = false;
            this.txtPlacas.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.txtPlacas.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPlacas.Location = new System.Drawing.Point(393, 85);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(194, 25);
            this.txtPlacas.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(333, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 20);
            this.label19.TabIndex = 43;
            this.label19.Text = "Placas:";
            // 
            // txtcomentarios
            // 
            this.txtcomentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtcomentarios.Location = new System.Drawing.Point(96, 484);
            this.txtcomentarios.Name = "txtcomentarios";
            this.txtcomentarios.Size = new System.Drawing.Size(491, 96);
            this.txtcomentarios.TabIndex = 18;
            this.txtcomentarios.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 470);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 20);
            this.label20.TabIndex = 45;
            this.label20.Text = "Comentarios:";
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 1F);
            this.label21.Location = new System.Drawing.Point(-43, 585);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(710, 10);
            this.label21.TabIndex = 46;
            // 
            // chkOperadorPendiente
            // 
            this.chkOperadorPendiente.AutoSize = true;
            this.chkOperadorPendiente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOperadorPendiente.Location = new System.Drawing.Point(33, 358);
            this.chkOperadorPendiente.Name = "chkOperadorPendiente";
            this.chkOperadorPendiente.Size = new System.Drawing.Size(89, 24);
            this.chkOperadorPendiente.TabIndex = 14;
            this.chkOperadorPendiente.Text = "Pendiente";
            this.chkOperadorPendiente.UseVisualStyleBackColor = true;
            this.chkOperadorPendiente.CheckedChanged += new System.EventHandler(this.chkOperadorPendiente_CheckedChanged);
            // 
            // FrmRegistroViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 630);
            this.Controls.Add(this.chkOperadorPendiente);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtcomentarios);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.cmbcajas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarFlete);
            this.Controls.Add(this.txtsello);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.txtTracto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoCarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRangoTemperaturas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbFarenheit);
            this.Controls.Add(this.rbCentigrados);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoFlete);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.lbltipoviaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmRegistroViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Fletes";
            this.Load += new System.EventHandler(this.FrmRegistroViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipoviaje;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.ComboBox cmbTipoFlete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbCentigrados;
        private System.Windows.Forms.RadioButton rbFarenheit;
        private System.Windows.Forms.TextBox txtRangoTemperaturas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoCarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTracto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtsello;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGuardarFlete;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbcajas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox txtcomentarios;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox chkOperadorPendiente;
    }
}