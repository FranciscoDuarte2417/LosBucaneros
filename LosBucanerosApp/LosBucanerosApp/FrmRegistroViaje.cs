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
        public FrmRegistroViaje()
        {
            InitializeComponent();
        }
        ClsOperadores objClsOperadores = new ClsOperadores();
        ClsTractos objClsTractos = new ClsTractos();
        private void FrmRegistroViaje_Load(object sender, EventArgs e)
        {
            CargarOperador();
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
            CargarCajas();
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


        ClsCajas objcajas = new ClsCajas();
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
    }
}
