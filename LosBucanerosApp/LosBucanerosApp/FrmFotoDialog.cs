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
    public partial class FrmFotoDialog : Form
    {
        Image Foto;
        string Nombre, Apellido;
        public FrmFotoDialog(string nombre, string apellido, Image foto)
        {
            InitializeComponent();
            Foto = foto;
            Nombre = nombre;
            Apellido = apellido;
        }

        private void FrmFotoDialog_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "TITULO: " + Nombre + " " + Apellido;
            pbfoto.Image = Foto;
        }
    }
}
