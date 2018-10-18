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
    public partial class FrmRegistros : Form
    {
        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            pbOperadores.Image = LosBucanerosApp.Properties.Resources.Operadores;
            pbjefe.Image = LosBucanerosApp.Properties.Resources.jefe;
           // pbusuarios.Image = LosBucanerosApp.Properties.Resources.user;
            pbtracto.Image = LosBucanerosApp.Properties.Resources.tracto;
        }

        private void pbOperadores_MouseHover(object sender, EventArgs e)
        {
            pbOperadores.Image = LosBucanerosApp.Properties.Resources.Operadores2;

        }

        private void pbOperadores_MouseLeave(object sender, EventArgs e)
        {
            pbOperadores.Image = LosBucanerosApp.Properties.Resources.Operadores;
        }

        private void pbtracto_MouseHover(object sender, EventArgs e)
        {
            pbtracto.Image = LosBucanerosApp.Properties.Resources.tracto2;
        }

        private void pbtracto_MouseLeave(object sender, EventArgs e)
        {
            pbtracto.Image = LosBucanerosApp.Properties.Resources.tracto;
        }

        private void pbjefe_MouseLeave(object sender, EventArgs e)
        {
            pbjefe.Image = LosBucanerosApp.Properties.Resources.jefe;
        }

        private void pbjefe_MouseHover(object sender, EventArgs e)
        {
            pbjefe.Image = LosBucanerosApp.Properties.Resources.jefe2;
        }

        private void pbOperadores_Click(object sender, EventArgs e)
        {
            FrmFormularioReg objmostrar = new FrmFormularioReg();
            objmostrar.Show();
        }
    }
}
