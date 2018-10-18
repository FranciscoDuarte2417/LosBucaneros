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
    public partial class FrmAlmacen : Form
    {
    

        public FrmAlmacen()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAlmacen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pnEntradas_Click(object sender, EventArgs e)
        {
          
        }

        private void pbSalidas_Click(object sender, EventArgs e)
        {
           
        }

        private void pbLinea_Click(object sender, EventArgs e)
        {
          
         
          
            
               
            
        }

        private void pbEquipo_Click(object sender, EventArgs e)
        {
          
            
         
            
            
        }

        private void pbSim_Click(object sender, EventArgs e)
        {
           


          
        }

        private void lblLinea_Click(object sender, EventArgs e)
        {

        }

        private void btnCelulares_Click(object sender, EventArgs e)
        {

            FrmAjustesAlmacenEquipos objmostrar = new FrmAjustesAlmacenEquipos();
            objmostrar.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAjusteLineas objmostrar = new FrmAjusteLineas();
            objmostrar.ShowDialog();
            this.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTarjetaSim objmostrar = new FrmTarjetaSim();
            objmostrar.ShowDialog();
            this.Close();
        }

        private void FrmAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }
    }
}
