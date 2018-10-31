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
            txtsello.Enabled = false;
            cmbOperador.Enabled = false;
            txtTracto.Enabled = false;
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

            }
            else
            {
                cmbOperador.BackColor = Color.Red;

            }
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
