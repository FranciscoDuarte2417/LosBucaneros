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
    public partial class FrmTarjetaSim : Form
    {
        public FrmTarjetaSim()
        {
            InitializeComponent();
        }
        string Nombre, Apellido, Permiso;
        string status;
        string auxiliar;
        string id, sim, compania, estatus, comentarios;

        private void txtsim_Leave(object sender, EventArgs e)
        {
            if (txtsim.TextLength != 19)
            {
                txtsim.BackColor = Color.Red;
            }
            else
            {
                txtsim.BackColor = Color.White;
            }
        }

        private void txtsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        string[] datos;

        private void cmbfiltroestatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfiltroestatus.SelectedIndex==0)
            {
                aux = "";
                CargarGrid();
                pbbajas.Visible = true;
                pbmodificaciones.Visible = true;
            }
            else if (cmbfiltroestatus.SelectedIndex == 1)
            {
                aux = "Activo";
                pbbajas.Visible = true;
                pbmodificaciones.Visible = true;
                CargarGrid();
            }
            else if (cmbfiltroestatus.SelectedIndex == 2)
            {
                aux = "Baja";
                pbbajas.Visible = false;
                pbmodificaciones.Visible = false;
                CargarGrid();
            }
        }

        private void pbaltas_MouseHover(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta2;
        }

        private void pbaltas_MouseLeave(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
        }

        private void dgvEquipos_SelectionChanged(object sender, EventArgs e)
        {
            dgvEquipos.ReadOnly = true;
            limpiarcampos();
            gbSIM.Enabled = false;
            if (dgvEquipos.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvEquipos.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvEquipos.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                sim = Convert.ToString(selectedRow.Cells["Sim"].Value);
                compania = Convert.ToString(selectedRow.Cells["Compania"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                comentarios = Convert.ToString(selectedRow.Cells["Comentarios"].Value);
            }
        }

        ClsTarjetaSim objSim = new ClsTarjetaSim();

        private void pbmodificaciones_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "ALTAS - MODIFICACIONES SIM";
            lbltitulo.ForeColor = Color.Blue;
            MessageBox.Show("Solo podran realizarlo administradores");
            limpiarcampos();
          
            gbSIM.Enabled = true;
            auxiliar = "update";


            int index = cmbCompania.FindString(compania);
            cmbCompania.SelectedIndex = index;

        

            txtsim.Text = sim;
            txtComentarios.Text = comentarios;
           

        }

        private void pbbajas_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "ALTAS - BAJAS SIM";
            lbltitulo.ForeColor = Color.Red;
            MessageBox.Show("Solo podran realizarlo administradores");
            limpiarcampos();

            gbSIM.Enabled = true;
            auxiliar = "baja";


            int index = cmbCompania.FindString(compania);
            cmbCompania.SelectedIndex = index;



            txtsim.Text = sim;
            txtComentarios.Text = comentarios;

            txtsim.Enabled = false;
            cmbCompania.Enabled = true;
            txtComentarios.Enabled = true;
            label16.Text = "Motivos: ";
            

        }

        private void pbbajas_MouseHover(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja2;
        }

        private void pbbajas_MouseLeave(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
        }

        private void FrmTarjetaSim_Load(object sender, EventArgs e)
        {
            
            aux = "";
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
           
            cmbCompania.SelectedIndex = 0;
            cmbfiltroestatus.SelectedIndex = -1;
            cmbcriteriobusqueda.SelectedIndex = -1;

            dgvEquipos.DataSource = null;
            objSim.populateGridSim();
            dgvEquipos.DataSource = objSim.dt;
            dgvEquipos.ClearSelection();
            
        }

        private void pbaltas_Click(object sender, EventArgs e)
        {
            gbSIM.Enabled = true;
            lbltitulo.Text = "ALTAS - TARJETA SIM";
            lbltitulo.ForeColor = Color.Blue;
            auxiliar = "insert";
            txtsim.Enabled = true;
            txtsim.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (auxiliar == "insert")
            {
                if (txtsim.TextLength != 19)
                {
                    MessageBox.Show("Error en SIM");
                }
                else
                {


                    //mandar parametros a la clase
                    objSim.Sim = txtsim.Text;
                    objSim.Compania = cmbCompania.SelectedItem.ToString();
                    objSim.Comentarios = txtComentarios.Text;
                    objSim.Estatus = "Disponible";
                    //llamar metodo de la clase
                    objSim.insertSim();

                    //Verificar si se hizo correctamente con la variable resultado
                    if (objSim.resultado == 1)
                    {
                        
                        MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                        // dgvUsuarios.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objSim.resultado == 0)
                    {
                        MessageBox.Show("Error Al Guardar SIM");
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objSim.resultado == 2)
                    {
                        MessageBox.Show("Error: Ya existe la SIM que desea registrar");
                    }
                }

            }
            else if (auxiliar == "update")
            {
                objSim.Id =Convert.ToInt32(id);
                objSim.Sim = txtsim.Text;
                objSim.Compania = cmbCompania.SelectedItem.ToString();
                objSim.Comentarios = txtComentarios.Text;
                objSim.Estatus = "Disponible";

                //manda llamar el metodo de la clase
                objSim.updateSim();
                //comprobamos si se realizo con exio
                if (objSim.resultado == 1)
                {
                    MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                    dgvEquipos.DataSource = null;
                    CargarGrid();
                    limpiarcampos();
                }
                else if (objSim.resultado == 2)
                {
                    MessageBox.Show("Error: SIM ya existe", "SIM Duplicado");
                    gbSIM.Enabled = false;
                    //error = 1;
                }
                else if (objSim.resultado == 0)
                {
                    MessageBox.Show("Error Al Actualizar SIM", "Error en Actualizacion");
                    //CargarGrid();
                    //  error = 1;
                    gbSIM.Enabled = false;
                    limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Error: 4002, Error Al Actualizar: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");

                }
            }
            else if (auxiliar == "baja")
            {
                if (txtComentarios.Text == "")
                {
                    MessageBox.Show("Es necesario indicar el motivo de la baja");
                    txtComentarios.Focus();
                }
                else
                {


                    DialogResult res = MessageBox.Show("Esta Seguro que desea dar de baja el SIM: " + sim, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        objSim.Id = Convert.ToInt32(id);
                        objSim.Comentarios = txtComentarios.Text;
                        objSim.deleteSim();
                        if (Convert.ToInt32(objSim.resultado) == 1)
                        {
                            MessageBox.Show("SIM dada de baja con exito", "EXITO");
                            CargarGrid();
                            limpiarcampos();
                        }
                        else
                        {
                            MessageBox.Show("Error: 3001  al dar de baja equipo, enviar captura de pantalla a sistemas@losbucaneros.com", "Error Fatal");

                        }

                        //Some task…  
                    }
                    if (res == DialogResult.No)
                    {
                        gbSIM.Enabled = false;
                        limpiarcampos();


                    }
                }
            }
        }

        string aux = "";
        public void CargarGrid()
        {
            // int x=  dgvTractos.NewRowIndex;
            dgvEquipos.DataSource = null;
            if (aux=="")
            {
                objSim.populateGridSimActivos();
            }
            else if (aux=="Activo")
            {
                objSim.populateGridSimAsignados();
            }
            else if (aux == "Baja")
            {
                objSim.populateGridSimBaja();
            }


            dgvEquipos.DataSource = objSim.dt;
            dgvEquipos.ClearSelection();
            aux = "";

        }
        


        public void limpiarcampos()
        {
            cmbCompania.SelectedIndex = 0; 
            txtsim.Text = "";
            txtComentarios.Text = "";
          
        }

        private void dgvEquipos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Sim's: " + dgvEquipos.RowCount;
        }

        private void txtBuscaOperadores_TextChanged(object sender, EventArgs e)
        {
            if (cmbcriteriobusqueda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar un criterio de busqueda valido");
                txtBuscaOperadores.Text = "";
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 0)
            {
                (dgvEquipos.DataSource as DataTable).DefaultView.RowFilter = string.Format("SIM LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvEquipos.DataSource as DataTable).DefaultView.RowFilter = string.Format("COMPANIA LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
        }
    }
}

