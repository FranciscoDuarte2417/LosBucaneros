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
    public partial class FrmAjustes : Form
    {
        string Nombre, Apellido, Permiso;
        public FrmAjustes(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }

      

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (Permiso!= "Admin")
            {//solo pueden entrar usuarios con permiso de administrador
                MessageBox.Show("No Cuenta Con Permiso de Administrador","Error de Autorizacion");
                this.Close();
                
            }
            else
            {
                PbUsuarios.Image = LosBucanerosApp.Properties.Resources.user;
                lblusuario.Text = "Bienvenido: " + Nombre + " " + Apellido;
                pbtracto.Image = LosBucanerosApp.Properties.Resources.tracto;
                pbCoordinadores.Image = LosBucanerosApp.Properties.Resources.jefe2;
                pbOperador.Image = LosBucanerosApp.Properties.Resources.Operadores;
                pbAdministrativos.Image = LosBucanerosApp.Properties.Resources.administrativo;
                
                
            }
          

        }

        private void PbUsuarios_MouseHover(object sender, EventArgs e)
        {
            PbUsuarios.Image = LosBucanerosApp.Properties.Resources.user2;
        }

        private void PbUsuarios_Click(object sender, EventArgs e)
        {
            FrmAjusteUsuarios objmostrar = new FrmAjusteUsuarios(Nombre,Apellido,Permiso);
            objmostrar.Show();
           // this.Close();
        }

        private void pbtracto_MouseHover(object sender, EventArgs e)
        {
            pbtracto.Image = LosBucanerosApp.Properties.Resources.tracto2;
        }

        private void pbtracto_MouseLeave(object sender, EventArgs e)
        {
            pbtracto.Image = LosBucanerosApp.Properties.Resources.tracto;
        }

        private void pbtracto_Click(object sender, EventArgs e)
        {
            FrmAjusteTracto objmostrar = new FrmAjusteTracto(Nombre,Apellido,Permiso);
            objmostrar.Show();
        }

        private void pbCoordinadores_MouseHover(object sender, EventArgs e)
        {
            pbCoordinadores.Image = LosBucanerosApp.Properties.Resources.jefe;
        }

        private void pbCoordinadores_MouseLeave(object sender, EventArgs e)
        {
            pbCoordinadores.Image = LosBucanerosApp.Properties.Resources.jefe2;
        }

        private void pbCoordinadores_Click(object sender, EventArgs e)
        {
            FrmAjusteCoordinador objmostrar = new FrmAjusteCoordinador(Nombre,Apellido,Permiso);
            objmostrar.Show();
        }

        private void pbOperador_MouseHover(object sender, EventArgs e)
        {
            pbOperador.Image = LosBucanerosApp.Properties.Resources.Operadores2;
        }

        private void pbOperador_MouseLeave(object sender, EventArgs e)
        {
            pbOperador.Image = LosBucanerosApp.Properties.Resources.Operadores;
        }

        private void pbOperador_Click(object sender, EventArgs e)
        {
            FrmAjustesOperadores objmostrar = new FrmAjustesOperadores(Nombre,Apellido,Permiso);
            objmostrar.Show();
        }

        private void pbAdministrativos_MouseHover(object sender, EventArgs e)
        {
            pbAdministrativos.Image = LosBucanerosApp.Properties.Resources.administrativo2;
        }

        private void pbAdministrativos_MouseLeave(object sender, EventArgs e)
        {
            pbAdministrativos.Image = LosBucanerosApp.Properties.Resources.administrativo;
        }

        private void pbAdministrativos_Click(object sender, EventArgs e)
        {
            FrmAjustesAdministrativos objmostrar = new FrmAjustesAdministrativos(Nombre,Apellido,Permiso);
            objmostrar.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmAjusteUsuarios objmostrar = new FrmAjusteUsuarios(Nombre, Apellido, Permiso);
            objmostrar.Show();
            // this.Close();
        }

        private void btnTractos_Click(object sender, EventArgs e)
        {
            FrmAjusteTracto objmostrar = new FrmAjusteTracto(Nombre, Apellido, Permiso);
            objmostrar.Show();
        }

        private void btnCoordinador_Click(object sender, EventArgs e)
        {
            FrmAjusteCoordinador objmostrar = new FrmAjusteCoordinador(Nombre, Apellido, Permiso);
            objmostrar.Show();
        }

        private void btnOperadores_Click(object sender, EventArgs e)
        {
            FrmAjustesOperadores objmostrar = new FrmAjustesOperadores(Nombre, Apellido, Permiso);
            objmostrar.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            FrmAjustesAdministrativos objmostrar = new FrmAjustesAdministrativos(Nombre, Apellido, Permiso);
            objmostrar.Show();
        }

        private void PbUsuarios_MouseLeave(object sender, EventArgs e)
        {
            PbUsuarios.Image = LosBucanerosApp.Properties.Resources.user;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
