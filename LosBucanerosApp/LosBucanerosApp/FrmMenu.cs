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
    public partial class FrmMenu : Form
    {
        string Nombre, Apellido, Permiso;
        public FrmMenu(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;

        }
   
        private void FrmMenu_Load(object sender, EventArgs e)
        {
          //  pbCelulares.Image = LosBucanerosApp.Properties.Resources.celulares;
          //  pbajustes.Image = LosBucanerosApp.Properties.Resources.ajustes;
            lblusuario.Text = "Bienvenido: " + Nombre + " " + Apellido;
            timerAlertas.Start();
        }

        private void pbCelulares_MouseHover(object sender, EventArgs e)
        {
           // pbCelulares.Image = LosBucanerosApp.Properties.Resources.celulares2;

        }

        private void pbCelulares_MouseLeave(object sender, EventArgs e)
        {
          //  pbCelulares.Image = LosBucanerosApp.Properties.Resources.celulares;
        }

        private void pbCelulares_Click(object sender, EventArgs e)
        {
            FrmCelulares objmostrar = new FrmCelulares(Nombre,Apellido,Permiso);
            objmostrar.Show();
            //this.Hide();
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objmostrar = new Form1("cambio");
            objmostrar.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbajustes_Click(object sender, EventArgs e)
        {
            FrmAjustes objmostrar = new FrmAjustes(Nombre,Apellido,Permiso);
            objmostrar.Show();

        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCelulares objmostrar = new FrmCelulares(Nombre, Apellido, Permiso);
            objmostrar.Show();
            //this.Hide();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FrmAjustes objmostrar = new FrmAjustes(Nombre, Apellido, Permiso);
            objmostrar.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        bool contTinmer;
        private void timerAlertas_Tick(object sender, EventArgs e)
        {
            if (lblalertas.BackColor==Color.Red)
            {
                lblalertas.BackColor = Color.Blue;
            }
            else
            {
                lblalertas.BackColor = Color.Red;
            }

            
        }

        private void pbajustes_MouseLeave(object sender, EventArgs e)
        {
            //pbajustes.Image = LosBucanerosApp.Properties.Resources.ajustes;
        }

        private void pbajustes_MouseHover(object sender, EventArgs e)
        {
           // pbajustes.Image = LosBucanerosApp.Properties.Resources.ajustes2;
        }
    }
}
