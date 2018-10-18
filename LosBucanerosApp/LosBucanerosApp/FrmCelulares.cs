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
    public partial class FrmCelulares : Form
    {
        string Nombre, Apellido, Permiso;
        public FrmCelulares(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }

        private void FrmCelulares_Load(object sender, EventArgs e)
        {
         
            pbEntradas.Image = LosBucanerosApp.Properties.Resources.almacen;
            pbAsignaciones.Image = LosBucanerosApp.Properties.Resources.entregar;
            pbresposivas.Image = LosBucanerosApp.Properties.Resources.resposiva;
            pbsim.Image = LosBucanerosApp.Properties.Resources.tsim;
        }

        private void pbregistros_MouseHover(object sender, EventArgs e)
        {
            //pbregistros.Image = LosBucanerosApp.Properties.Resources.registros2;
        }

        private void pbregistros_MouseLeave(object sender, EventArgs e)
        {
           // pbregistros.Image = LosBucanerosApp.Properties.Resources.registros;
        }

       

        private void pbEntradas_MouseHover(object sender, EventArgs e)
        {
            pbEntradas.Image = LosBucanerosApp.Properties.Resources.almacen2;
        }

        private void pbEntradas_MouseLeave(object sender, EventArgs e)
        {
            pbEntradas.Image = LosBucanerosApp.Properties.Resources.almacen;
        }

        private void pbAsignaciones_MouseHover(object sender, EventArgs e)
        {
            pbAsignaciones.Image = LosBucanerosApp.Properties.Resources.entregar2;
        }

        private void pbAsignaciones_MouseLeave(object sender, EventArgs e)
        {
            pbAsignaciones.Image = LosBucanerosApp.Properties.Resources.entregar;
        }

        private void pbresposivas_MouseHover(object sender, EventArgs e)
        {
            pbresposivas.Image = LosBucanerosApp.Properties.Resources.responsiva2;
        }

        private void pbresposivas_MouseLeave(object sender, EventArgs e)
        {
            pbresposivas.Image = LosBucanerosApp.Properties.Resources.resposiva;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbEntradas_Click(object sender, EventArgs e)
        {
            FrmAlmacen objmostrar = new FrmAlmacen();
            objmostrar.ShowDialog();
        }

        private void pbsim_MouseHover(object sender, EventArgs e)
        {
            pbsim.Image = LosBucanerosApp.Properties.Resources.tsim2;
        }

        private void pbsim_MouseLeave(object sender, EventArgs e)
        {
            pbsim.Image = LosBucanerosApp.Properties.Resources.tsim;
        }

        private void pbsim_Click(object sender, EventArgs e)
        {
            FrmAsignacionNumerosSIM objmostrar = new FrmAsignacionNumerosSIM();
            objmostrar.ShowDialog();
        }

        private void btnCelulares_Click(object sender, EventArgs e)
        {
            FrmAlmacen objmostrar = new FrmAlmacen();
            objmostrar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAsignacionNumerosSIM objmostrar = new FrmAsignacionNumerosSIM();
            objmostrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmReposiva objmostrar = new FrmReposiva(Nombre, Apellido, Permiso);
            objmostrar.ShowDialog();
        }

        private void pbAsignaciones_Click(object sender, EventArgs e)
        {
            FrmReposiva objmostrar = new FrmReposiva(Nombre,Apellido,Permiso);
            objmostrar.ShowDialog();
        }

        private void pbresposivas_Click(object sender, EventArgs e)
        {

        }
    }
}
