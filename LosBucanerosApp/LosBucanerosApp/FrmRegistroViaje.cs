using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmRegistroViaje : Form
    {
        public FrmRegistroViaje(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }
        ClsOperadores objClsOperadores = new ClsOperadores();
        ClsTractos objClsTractos = new ClsTractos();
        ClsCajas objcajas = new ClsCajas();
        ClsFletes objFletes = new ClsFletes();

        string Nombre, Apellido, Permiso;
        private void FrmRegistroViaje_Load(object sender, EventArgs e)
        {
            CargarOperador();
            CargarCajas();
        }
        string tipo;
        private void cmbTipoFlete_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmbTipoFlete.SelectedIndex == 0)
            {
                tipo = "importacion";
                VisibilidadImportacion();
               
            }
           
            else if (cmbTipoFlete.SelectedIndex == 1)
            {
                tipo = "exportacion";
                VisibilidadExportacioNacional();

            }
            else if (cmbTipoFlete.SelectedIndex == 2)
            {
                tipo = "nacional";
                VisibilidadExportacioNacional();
            }
        }

        public void VisibilidadImportacion()
        {
            txtsello.Enabled = true;
            cmbOperador.Enabled = true;
            txtTracto.Enabled = true;
            chkOperadorPendiente.Enabled = true;

        }
        public void VisibilidadExportacioNacional()
        {
            txtsello.Enabled = true;
            cmbOperador.Enabled = true;
            txtTracto.Enabled = true;
            chkOperadorPendiente.Checked = false;
            chkOperadorPendiente.Enabled = false;
        }
        public void CargarOperador()
        {
            cmbOperador.DataSource = null;
            objClsOperadores.populateComboOperadores();
            cmbOperador.DataSource = objClsOperadores.dt;
            cmbOperador.ValueMember = "Id";
            cmbOperador.DisplayMember = "Nombre";
            cmbOperador.SelectedIndex = -1;

        }
        public void CargarCajas()
        {
            cmbcajas.DataSource = null;
            objcajas.populateGridCajas();
            cmbcajas.DataSource = objcajas.dt;
            cmbcajas.ValueMember = "IdCaja";
            cmbcajas.DisplayMember = "Caja";
            cmbcajas.SelectedIndex = -1;
            txtPlacas.Text = "";
        }
        public void CargarTractosPorOperador()
        {

            txtTracto.Text = "";
            objClsTractos.Id = Convert.ToInt32(cmbOperador.SelectedValue);
            objClsTractos.CargarTractoPorOperador();
            txtTracto.Text = objClsTractos.Notracto;
            

        }

        private void cmbTipoFlete_Leave(object sender, EventArgs e)
        {
            int index = cmbTipoFlete.FindString(cmbTipoFlete.Text);

            if (index >= 0)
            {
                cmbTipoFlete.SelectedIndex = index;
                cmbTipoFlete.BackColor = Color.White;
              
            }
            else
            {
                cmbTipoFlete.BackColor = Color.Red;

            }
        }

        private void cmbOperador_Leave(object sender, EventArgs e)
        {
            
           
            int index = cmbOperador.FindString(cmbOperador.Text);

            if (index >= 0)
            {
                cmbOperador.SelectedIndex = index;
                cmbOperador.BackColor = Color.White;
                CargarTractosPorOperador();
            }
            else
            {
                cmbOperador.BackColor = Color.Red;

            }
            
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
        }


        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcajas.SelectedIndex != -1)
            {

                DataRow Row = objcajas.dt.Rows[Convert.ToInt32(cmbcajas.SelectedIndex)];
                txtPlacas.Text = Row[2].ToString();
            }
        }

        private void cmbTipoCarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoCarga.SelectedIndex == 0)
            {
                txtRangoTemperaturas.Enabled = true;
                txtTemperatura.Enabled = true;
                txtProducto.Enabled = true;
                rbCentigrados.Enabled = true;
                rbFarenheit.Enabled = true;

            }
            else if(cmbTipoCarga.SelectedIndex ==1)
            {
                txtRangoTemperaturas.Enabled = false;
                txtTemperatura.Enabled = false;
                txtProducto.Enabled = true;
                rbCentigrados.Enabled = false;
                rbFarenheit.Enabled = false;
                txtTemperatura.Text = "";
                txtRangoTemperaturas.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbcajas_Leave(object sender, EventArgs e)
        {
            int index = cmbcajas.FindString(cmbcajas.Text);

            if (index >= 0)
            {
                cmbcajas.SelectedIndex = index;
                cmbcajas.BackColor = Color.White;

            }
            else
            {
                cmbcajas.BackColor = Color.Red;
                txtPlacas.Text = "";

            }
        }

        private void btnGuardarFlete_Click(object sender, EventArgs e)
        {
            insertarFlete();
        }

        private void txtFolio_Leave(object sender, EventArgs e)
        {
           

            if (txtFolio.Text!="" )
            {

                txtFolio.BackColor = Color.White;

            }
            else
            {
                txtFolio.BackColor = Color.Red;

            }
        }

        private void txtOrigen_Leave(object sender, EventArgs e)
        {
            if(txtOrigen.Text != "")
            {

                txtOrigen.BackColor = Color.White;

            }
            else
            {
                txtOrigen.BackColor = Color.Red;

            }
        }

        private void txtDestino_Leave(object sender, EventArgs e)
        {
            if (txtDestino.Text != "")
            {

                txtDestino.BackColor = Color.White;

            }
            else
            {
                txtDestino.BackColor = Color.Red;

            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {

                txtProducto.BackColor = Color.White;

            }
            else
            {
                txtProducto.BackColor = Color.Red;

            }
        }

        private void txtTemperatura_Leave(object sender, EventArgs e)
        {

            if (cmbTipoCarga.Text=="REFRIGERADO")
            {

           
            if (txtTemperatura.Text != "")
            {

                txtTemperatura.BackColor = Color.White;

            }
            else
            {
                txtTemperatura.BackColor = Color.Red;

            }
            }
        }

        private void txtRangoTemperaturas_Leave(object sender, EventArgs e)
        {

            if (cmbTipoCarga.Text == "REFRIGERADO")
            {
                if (txtRangoTemperaturas.Text != "")
                {

                    txtRangoTemperaturas.BackColor = Color.White;

                }
                else
                {
                    txtRangoTemperaturas.BackColor = Color.Red;

                }
            }
        }

        private void cmbTipoCarga_Leave(object sender, EventArgs e)
        {
            int index = cmbTipoCarga.FindString(cmbTipoCarga.Text);

            if (index >= 0)
            {
                cmbTipoCarga.SelectedIndex = index;
                cmbTipoCarga.BackColor = Color.White;

            }
            else
            {
                cmbTipoCarga.BackColor = Color.Red;
              

            }
        }

        private void txtTracto_Leave(object sender, EventArgs e)
        {
            


                if (txtTracto.Text != "")
                {

                    txtTracto.BackColor = Color.White;

                }
                else
                {
                    txtTracto.BackColor = Color.Red;

                }
            

        }

        private void txtsello_Leave(object sender, EventArgs e)
        {
            


                if (txtsello.Text != "")
                {

                    txtsello.BackColor = Color.White;

                }
                else
                {
                    txtsello.BackColor = Color.Red;

                }
            
        }

        private void txtPlacas_TextChanged(object sender, EventArgs e)
        {
            txtPlacas.BackColor = Color.White;
        }

        private void cmbTipoFlete_TextChanged(object sender, EventArgs e)
        {
            cmbTipoFlete.BackColor = Color.White;
        }

        private void cmbcajas_TextChanged(object sender, EventArgs e)
        {
            cmbcajas.BackColor = Color.White;
        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {
            txtFolio.BackColor = Color.White;
        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {
            txtOrigen.BackColor = Color.White;
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            txtDestino.BackColor = Color.White;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            txtProducto.BackColor = Color.White;
        }

        private void txtsello_TextChanged(object sender, EventArgs e)
        {
            txtsello.BackColor = Color.White;
        }

        string[] almacena;
        public void insertarFlete()
        {
            objFletes.Caja = Convert.ToInt32(cmbcajas.SelectedValue); // almacena[0]= cmbcajas.SelectedValue.ToString();//
            objFletes.FolioViaje = txtFolio.Text;                     // almacena[1] = cmbcajas.SelectedValue.ToString();// 
            objFletes.Origen = txtOrigen.Text;                       //  almacena[2] = cmbcajas.SelectedValue.ToString();//
            objFletes.Destino = txtDestino.Text;                     //  almacena[3] = cmbcajas.SelectedValue.ToString();//
            objFletes.Fechacita = dtpFecha.Value.ToShortDateString(); // almacena[4] = cmbcajas.SelectedValue.ToString();//
            objFletes.HoraCita = dtpHora.Value.ToShortTimeString();    //almacena[5] = cmbcajas.SelectedValue.ToString();//

            objFletes.TipoCarga = cmbTipoCarga.Text;                  // almacena[6] = cmbcajas.SelectedValue.ToString();//
            objFletes.Producto = txtProducto.Text;                    // almacena[7] = cmbcajas.SelectedValue.ToString();//
            objFletes.Cliente = Convert.ToInt32(cmbClientes.Text);    // almacena[8] = cmbcajas.SelectedValue.ToString();//

            if (cmbTipoCarga.Text == "SECO")
            {
                objFletes.TemperaturaProgramada = "NA";              // almacena[9] = cmbcajas.SelectedValue.ToString();//
                objFletes.TipoTemperatura = "NA";                    // almacena[10] = cmbcajas.SelectedValue.ToString();//
                objFletes.RangoTemperatura = "NA";                  //  almacena[11] = cmbcajas.SelectedValue.ToString();//
            }
            else if (cmbTipoCarga.Text == "REFRIGERADO")
            {

                if (rbCentigrados.Checked)
                {
                    objFletes.TipoTemperatura = "C";
                }
                else if (rbFarenheit.Checked)
                {
                    objFletes.TipoTemperatura = "F";
                }
                objFletes.TemperaturaProgramada = txtTemperatura.Text;
                objFletes.RangoTemperatura = txtRangoTemperaturas.Text;

            }

            if (chkOperadorPendiente.Checked)
            {
                objFletes.Operador = 0;
                objFletes.Sellos = "PENDIENTE";
            }
            else
            {
                objFletes.Operador = Convert.ToInt32(cmbOperador.SelectedValue);
                objFletes.Sellos = txtsello.Text;
            }

            objFletes.Comentarios = txtcomentarios.Text;

            
                objFletes.EstatusBucaneros = "PENDIENTE";
                objFletes.EstatusCliente = "PENDINTE";

            
            objFletes.FechaSalida = "PENDIENTE";
            objFletes.HoraSalida = "PENDIENTE";
            objFletes.FechaLlegada = "PENDIENTE";
            objFletes.HoraLlegada = "PENDIENTE";
            objFletes.FechaDescarga = "PENDIENTE";
            objFletes.HoraDescarga = "PENDIENTE";

            objFletes.FechaCreacion = DateTime.Now.ToShortDateString();
            objFletes.HoraCreacion = DateTime.Now.ToShortTimeString();
            objFletes.Usuario = Nombre + " " + Apellido;

            objFletes.DireccionCarga = txtDirecionCarga.Text;
            objFletes.DireccionDescarga = txtDireccionDescarga.Text;


            if (cmbTipoCarga.Text == "REFRIGERADO")
            {
                if (txtTemperatura.BackColor == Color.Red || txtTemperatura.Text == "" || txtRangoTemperaturas.BackColor == Color.Red || txtRangoTemperaturas.Text == "" || (rbCentigrados.Checked=false && rbFarenheit.Checked==false))
                {
                    MessageBox.Show("Error en Temperaturas");
                }
                else
                {

                    if (cmbTipoFlete.BackColor == Color.Red || cmbTipoFlete.Text == "" ||
                       cmbcajas.BackColor == Color.Red || cmbcajas.Text == "" ||
                       txtFolio.BackColor == Color.Red || txtFolio.Text == "" ||
                        cmbClientes.BackColor == Color.Red || cmbClientes.Text == "" ||
                       txtOrigen.BackColor == Color.Red || txtOrigen.Text == "" ||
                       txtDestino.BackColor == Color.Red || txtDestino.Text == "" ||
                       cmbTipoCarga.BackColor == Color.Red || cmbTipoCarga.Text == "" ||
                       cmbcajas.BackColor == Color.Red || cmbcajas.Text == "" ||
                       txtProducto.BackColor == Color.Red || txtProducto.Text == "")
                    {

                        MessageBox.Show("Campos Necesarios");

                    }
                    else
                    {

                        if (chkOperadorPendiente.Checked == false)
                        {
                            if (cmbOperador.BackColor == Color.Red || cmbOperador.Text == "" || txtsello.BackColor == Color.Red || txtsello.Text == "")
                            {

                                MessageBox.Show("Campos Necesarios");
                            }
                            else
                            {

                                if (chkRepartos.Checked)
                                {
                                    if (dataGridView1.RowCount > 0)
                                    {
                                        //haz el primero nada mas
                                        objFletes.Reparto = "SI";
                                        objFletes.NoReparto = 0;
                                        objFletes.insertarFlete();
                                        if (objFletes.Resultado == 1)
                                        {

                                            MessageBox.Show("Flete Almacenado Con Exito");
                                            LimpiarCampos();


                                        }
                                        else
                                        {
                                            MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                        }

                                        for (int i = 0; i < dataGridView1.RowCount; i++)
                                        {
                                            objFletes.NoReparto =Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                                            objFletes.Destino = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                            objFletes.DireccionDescarga = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                            objFletes.Fechacita = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                            objFletes.HoraCita = dataGridView1.Rows[i].Cells[4].Value.ToString();
                                            objFletes.insertarFlete();
                                           
                                        

                                    }
                                        if (objFletes.Resultado == 1)
                                        {

                                            MessageBox.Show("Flete Almacenado Con Exito");
                                            LimpiarCampos();


                                        }
                                        else
                                        {
                                            MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                        }
                                    }

                                }
                                else
                                {

                                    objFletes.Reparto = "NO";
                                    objFletes.NoReparto = 0;
                                    objFletes.insertarFlete();



                                    if (objFletes.Resultado == 1)
                                {
                                  
                                    MessageBox.Show("Flete Almacenado Con Exito");
                                    LimpiarCampos();

                                   
                                }
                                else
                                {
                                    MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                }
                                }

                            }
                        }
                        else
                        {



                            if (chkRepartos.Checked)
                            {
                                if (dataGridView1.RowCount > 0)
                                {
                                    //haz el primero nada mas
                                    objFletes.Reparto = "SI";
                                    objFletes.NoReparto = 0;
                                    objFletes.insertarFlete();
                                    if (objFletes.Resultado == 1)
                                    {

                                        MessageBox.Show("Flete Almacenado Con Exito");
                                        LimpiarCampos();


                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                    }

                                    for (int i = 0; i < dataGridView1.RowCount; i++)
                                    {
                                        objFletes.NoReparto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                                        objFletes.Destino = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                        objFletes.DireccionDescarga = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                        objFletes.Fechacita = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                        objFletes.HoraCita = dataGridView1.Rows[i].Cells[4].Value.ToString();
                                        objFletes.insertarFlete();
                                        


                                    }
                                    if (objFletes.Resultado == 1)
                                    {

                                        MessageBox.Show("Flete Almacenado Con Exito");
                                        LimpiarCampos();


                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                    }
                                }

                            }
                            else
                            {

                                objFletes.Reparto = "NO";
                                objFletes.NoReparto = 0;
                                objFletes.insertarFlete();



                                if (objFletes.Resultado == 1)
                                {

                                    MessageBox.Show("Flete Almacenado Con Exito");
                                    LimpiarCampos();


                                }
                                else
                                {
                                    MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                }
                            }

                        }

                        //  
                    }



                }

            }
            else
            {

            if (cmbTipoFlete.BackColor==Color.Red||cmbTipoFlete.Text==""||
               cmbcajas.BackColor == Color.Red|| cmbcajas.Text == "" ||
               txtFolio.BackColor == Color.Red || txtFolio.Text == "" ||
               txtOrigen.BackColor == Color.Red || txtOrigen.Text == "" ||
               txtDestino.BackColor == Color.Red || txtDestino.Text==""||
               cmbTipoCarga.BackColor == Color.Red || cmbTipoCarga.Text == "" ||
               cmbcajas.BackColor == Color.Red || cmbcajas.Text == "" ||
               txtProducto.BackColor == Color.Red || txtProducto.Text == "" )
            {
                
                MessageBox.Show("Campos Necesarios");

            }
            else
            {

                    if (chkOperadorPendiente.Checked==false)
                    {
                        if (cmbOperador.BackColor == Color.Red || cmbOperador.Text == "" || txtsello.BackColor == Color.Red || txtsello.Text=="")
                        {
                            MessageBox.Show("Campos Necesarios");
                        }
                        else
                        {
                            if (chkRepartos.Checked)
                            {
                                if (dataGridView1.RowCount > 0)
                                {
                                    //haz el primero nada mas
                                    objFletes.Reparto = "SI";
                                    objFletes.NoReparto = 0;
                                    objFletes.insertarFlete();
                                    if (objFletes.Resultado == 1)
                                    {

                                        MessageBox.Show("Flete Almacenado Con Exito");
                                        LimpiarCampos();


                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                    }

                                    for (int i = 0; i < dataGridView1.RowCount; i++)
                                    {
                                        objFletes.NoReparto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                                        objFletes.Destino = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                        objFletes.DireccionDescarga = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                        objFletes.Fechacita = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                        objFletes.HoraCita = dataGridView1.Rows[i].Cells[4].Value.ToString();
                                        objFletes.insertarFlete();
                                        


                                    }
                                    if (objFletes.Resultado == 1)
                                    {

                                        MessageBox.Show("Flete Almacenado Con Exito");
                                        LimpiarCampos();


                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                    }
                                }

                            }
                            else
                            {
                                objFletes.Reparto = "NO";
                                objFletes.NoReparto = 0;

                                objFletes.insertarFlete();



                                if (objFletes.Resultado == 1)
                                {

                                    MessageBox.Show("Flete Almacenado Con Exito");
                                    LimpiarCampos();


                                }
                                else
                                {
                                    MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (chkRepartos.Checked)
                        {
                            if (dataGridView1.RowCount > 0)
                            {
                                //haz el primero nada mas
                                objFletes.Reparto = "SI";
                                objFletes.NoReparto = 0;
                                objFletes.insertarFlete();
                                if (objFletes.Resultado == 1)
                                {

                                    MessageBox.Show("Flete Almacenado Con Exito");
                                    LimpiarCampos();


                                }
                                else
                                {
                                    MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                }

                                for (int i = 0; i < dataGridView1.RowCount; i++)
                                {
                                    objFletes.NoReparto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                                    objFletes.Destino = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                    objFletes.DireccionDescarga = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                    objFletes.Fechacita = dataGridView1.Rows[i].Cells[3].Value.ToString();
                                    objFletes.HoraCita = dataGridView1.Rows[i].Cells[4].Value.ToString();
                                    objFletes.insertarFlete();
                                   


                                }
                                if (objFletes.Resultado == 1)
                                {

                                    MessageBox.Show("Flete Almacenado Con Exito");
                                    LimpiarCampos();


                                }
                                else
                                {
                                    MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                                }

                            }

                        }
                        else
                        {

                            objFletes.Reparto = "NO";
                            objFletes.NoReparto = 0;
                            objFletes.insertarFlete();



                            if (objFletes.Resultado == 1)
                            {

                                MessageBox.Show("Flete Almacenado Con Exito");
                                LimpiarCampos();


                            }
                            else
                            {
                                MessageBox.Show("Error Al Almacenar, Contactar a Sistemas");
                            }
                        }
                    }
                   
              //  objFletes.insertarFlete();
            }

               

            }








        }
        public void insertarFleteReparto()
        {


        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRangoTemperaturas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {
            txtTemperatura.BackColor = Color.White;
        }

        private void txtTracto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRangoTemperaturas_TextChanged(object sender, EventArgs e)
        {
            txtRangoTemperaturas.BackColor = Color.White;
        }

        private void chkRepartos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRepartos.Checked)
            {
                this.Width = 1120;
                this.Height = 765;
                this.Location = new Point(this.Location.X - 200, this.Location.Y);
                
            }
            else
            {
                this.Width = 634;
                this.Height = 765;
                this.Location = new Point(this.Location.X + 200, this.Location.Y);
                LimpiarCamposRepartos();

            }
        }

        public void LimpiarCampos()
        {
            cmbTipoFlete.SelectedIndex = -1;
            cmbcajas.SelectedIndex = -1;
            txtPlacas.Text = "";
            txtFolio.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            cmbTipoCarga.SelectedIndex = -1;
            txtProducto.Text = "";
            txtTemperatura.Text = "";
            txtRangoTemperaturas.Text = "";
            rbCentigrados.Checked = false;
            rbFarenheit.Checked = false;
            txtRangoTemperaturas.Text = "";
            chkOperadorPendiente.Checked = false;
            cmbOperador.SelectedIndex = -1;
            txtTracto.Text = "";
            txtsello.Text = "";
            txtcomentarios.Text = "";
        }

        private void lnkrepartos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (chkRepartos.Checked)
            {
                this.Width = 1120;
                this.Height = 765;
            }
            else
            {
                MessageBox.Show("No Existen Repartos");
            }
            

        }

        private void btnAgregarRepartos_Click(object sender, EventArgs e)
        {
            if (txtdestinoreparto.Text=="" ||txtdirecciondescargareparto.Text=="" || txtdestinoreparto.BackColor==Color.Red || txtdirecciondescargareparto.BackColor==Color.Red)
            {
                MessageBox.Show("Campos Necesarios");
            }
            else
            {

           
            int numeroreparto = dataGridView1.RowCount + 1; ;
            string destino = txtdestinoreparto.Text;
            string direccion = txtdirecciondescargareparto.Text;
            string fechaChita = dtfechareparto.Value.ToShortDateString();
            string HoraChita = dtHoraReparto.Value.ToShortTimeString();
            string[] row = {numeroreparto.ToString(),destino,direccion,fechaChita,HoraChita};
            dataGridView1.Rows.Add(row);

                txtdestinoreparto.Text = "";
                txtdirecciondescargareparto.Text = "";

                txtdestinoreparto.Focus();
            }


        }

        private void btnEliminarRenglon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                if (dataGridView1.CurrentRow.Index>=0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Seleccione el reparto que desea eliminar");
                }
               
            }
           
        }

        private void txtdestinoreparto_Leave(object sender, EventArgs e)
        {
            if (txtdestinoreparto.Text != "")
            {

                txtdestinoreparto.BackColor = Color.White;

            }
            else
            {
                txtdestinoreparto.BackColor = Color.Red;

            }
        }

        private void txtdirecciondescargareparto_Leave(object sender, EventArgs e)
        {
            if (txtdirecciondescargareparto.Text != "")
            {

                txtdirecciondescargareparto.BackColor = Color.White;

            }
            else
            {
                txtdirecciondescargareparto.BackColor = Color.Red;

            }
        }

        private void txtdestinoreparto_TextChanged(object sender, EventArgs e)
        {
            txtdestinoreparto.BackColor = Color.White;
        }

        private void txtdirecciondescargareparto_TextChanged(object sender, EventArgs e)
        {
            txtdirecciondescargareparto.BackColor = Color.White;
        }

        public void LimpiarCamposRepartos()
        {
         
        }

        private void chkOperadorPendiente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOperadorPendiente.Checked==true)
            {
                cmbOperador.Text = "";
                txtTracto.Text = "";
                txtsello.Text = "";

                cmbOperador.Enabled = false;
                txtTracto.Enabled = false;
                txtsello.Enabled = false;

                cmbOperador.BackColor = Color.White;
                txtTracto.BackColor = Color.White;
                txtsello.BackColor = Color.White;

            }
            else
            {
                cmbOperador.Enabled = true;
                txtsello.Enabled = true;

            }
        }
    }
}
