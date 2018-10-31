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

        private void FrmRegistroViaje_Load(object sender, EventArgs e)
        {

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

    }
}
