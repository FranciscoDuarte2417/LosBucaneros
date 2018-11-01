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
          
        }
        public void VisibilidadExportacioNacional()
        {
            txtsello.Enabled = true;
            cmbOperador.Enabled = true;
            txtTracto.Enabled = true;
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
        public void insertarFlete()
        {
            objFletes.Caja = Convert.ToInt32(cmbcajas.SelectedValue);
            objFletes.FolioViaje = txtFolio.Text;
            objFletes.Origen = txtOrigen.Text;
            objFletes.Destino = txtDestino.Text;
            objFletes.Fechacita = dtpFecha.Value.ToShortDateString();
            objFletes.HoraCita = dtpHora.Value.ToShortTimeString();
            objFletes.TipoCarga = cmbTipoCarga.Text;
            objFletes.Producto = txtProducto.Text;
         
            if (cmbTipoCarga.Text== "SECO")
            {
                objFletes.TemperaturaProgramada = "NA";
                objFletes.TipoTemperatura = "NA";
                objFletes.RangoTemperatura = "NA";
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

            if (cmbTipoFlete.Text=="IMPORTACION")
            {
                objFletes.EstatusBucaneros = "PENDIENTE";
                objFletes.EstatusCliente = "PENDINTE";
                
            }
            objFletes.FechaSalida = "PENDIENTE";
            objFletes.HoraSalida = "PENDIENTE";
            objFletes.FechaLlegada = "PENDIENTE";
            objFletes.HoraLlegada = "PENDIENTE";
            objFletes.FechaDescarga = "PENDIENTE";
            objFletes.HoraDescarga = "PENDIENTE";

            objFletes.FechaCreacion = DateTime.Now.ToShortDateString();
            objFletes.HoraCreacion = DateTime.Now.ToShortTimeString();
            objFletes.Usuario = Nombre + " "+ Apellido;

            objFletes.insertarFlete();









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

            }
            else
            {
                cmbOperador.Enabled = true;
                txtsello.Enabled = true;

            }
        }
    }
}
