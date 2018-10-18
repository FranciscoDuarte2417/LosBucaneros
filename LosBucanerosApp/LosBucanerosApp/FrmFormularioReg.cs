using System;
using System.Linq;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmFormularioReg : Form
    {
        public FrmFormularioReg()
        {
            InitializeComponent();
        }

        private void gbOperadores_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmFormularioReg_Load(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
            pbconsultas.Image = LosBucanerosApp.Properties.Resources.consultas;
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
        }

        private void pbaltas_MouseHover(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta2;
        }

        private void pbaltas_MouseLeave(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
        }

        private void pbbajas_MouseHover(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja2;
        }

        private void pbbajas_MouseLeave(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
        }

        private void pbconsultas_MouseHover(object sender, EventArgs e)
        {
            pbconsultas.Image = LosBucanerosApp.Properties.Resources.consultas2;
        }

        private void pbconsultas_MouseLeave(object sender, EventArgs e)
        {
            pbconsultas.Image = LosBucanerosApp.Properties.Resources.consultas;
        }

        private void pbmodificaciones_MouseHover(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones2;
        }

        private void pbmodificaciones_MouseLeave(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
        }

        private void pbCamara_MouseLeave(object sender, EventArgs e)
        {
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
        }

        private void pbCamara_MouseHover(object sender, EventArgs e)
        {
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara2;
        }

        private void pbaltas_Click(object sender, EventArgs e)
        {
            gbOperadores.Enabled = true;

            //  gbGridOperadores.Enabled = true;
        }

        private void pbbajas_Click(object sender, EventArgs e)
        {
            // gbOperadores.Enabled = true;
            //gbGridOperadores.Enabled = true;
        }

        private void pbconsultas_Click(object sender, EventArgs e)
        {

        }

        private void pbmodificaciones_Click(object sender, EventArgs e)
        {

        }

        private void txtnombreoperador_TextChanged(object sender, EventArgs e)
        {
            txtnombreoperador.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
