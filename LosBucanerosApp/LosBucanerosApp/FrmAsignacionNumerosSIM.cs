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
    public partial class FrmAsignacionNumerosSIM : Form
    {
        int id;
        int idLinea;
        int idSim;
        string estatus;
        string comentarios;

        ClsAsignacionNumerosSIM objasignacionsim = new ClsAsignacionNumerosSIM();
        public FrmAsignacionNumerosSIM()
        {
            InitializeComponent();
        }

        private void FrmAsignacionNumerosSIM_Load(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            CargarComboLineas();
            CargarComboSim();
            CargarGrid();
            cmbSim.SelectedIndex = -1;
            cmbLinea.SelectedIndex = -1;
            cmbcriteriobusqueda.SelectedIndex = 0;
            cmbfiltroestatus.SelectedIndex = 0;
        }

        AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
        public void CargarComboLineas()
        {
            cmbLinea.DataSource = null;
            objasignacionsim.populateComboLineas();
            cmbLinea.DataSource = objasignacionsim.dt;
            cmbLinea.ValueMember = "Id";
            cmbLinea.DisplayMember = "Telefono";


            foreach (DataRow row in objasignacionsim.dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Telefono"]));
            }
            cmbLinea.AutoCompleteCustomSource = coleccion;
            cmbLinea.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLinea.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        public void CargarComboSim()
        {
            cmbSim.DataSource = null;
            objasignacionsim.populateComboSim();
            cmbSim.DataSource = objasignacionsim.dt;
            cmbSim.ValueMember = "Id";
            cmbSim.DisplayMember = "Sim";


            foreach (DataRow row in objasignacionsim.dt.Rows)
            {
                coleccion2.Add(Convert.ToString(row["Sim"]));
            }
            cmbSim.AutoCompleteCustomSource = coleccion;
            cmbSim.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSim.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void pbaltas_Click(object sender, EventArgs e)
        {
            auxiliar = "insert";
            gbSIM.Enabled = true;
            lbltitulo.Text = "ASIGNAR SIM";
            lbltitulo.ForeColor = Color.Blue;
        }

        private void cmbLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string auxcmblinea = "";
        string auxcmblinea2 = "";
        private string auxiliar;

        private void cmbLinea_Leave(object sender, EventArgs e)
        {
            if (cmbLinea.Text.Length != 10)
            {
                cmbLinea.BackColor = Color.Red;
            }
            else
            {
                cmbLinea.BackColor = Color.White;
                for (int i = 0; i < coleccion.Count; i++)
                {
                    if (cmbLinea.Text == coleccion[i])
                    {
                        auxcmblinea = "correcto";
                    }
                }
                if (auxcmblinea == "correcto")
                {

                }
                else
                {
                    cmbLinea.BackColor = Color.Red;
                }
            }
            auxcmblinea = "";
        }

        private void cmbSim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbSim_Leave(object sender, EventArgs e)
        {
            if (cmbSim.Text.Length != 19)
            {
                cmbSim.BackColor = Color.Red;
            }
            else
            {
                cmbSim.BackColor = Color.White;
                for (int i = 0; i < coleccion2.Count; i++)
                {
                    if (cmbSim.Text == coleccion2[i])
                    {
                        auxcmblinea2 = "correcto";
                    }
                }
                if (auxcmblinea2 == "correcto")
                {

                }
                else
                {
                    cmbSim.BackColor = Color.Red;
                }
            }
            auxcmblinea2 = "";
        }

        private void btnagregarTracto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAjusteLineas objmostrar = new FrmAjusteLineas();
            objmostrar.ShowDialog();
            CargarComboLineas();
        }

        private void btnAgregarSim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmTarjetaSim objmostrar = new FrmTarjetaSim();
            objmostrar.ShowDialog();
            CargarComboSim();
        }

        private void pbaltas_MouseHover(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta2;
        }

        private void pbaltas_MouseLeave(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbLinea.Text.Length != 10 || cmbSim.Text.Length != 19 || cmbLinea.BackColor==Color.Red || cmbSim.BackColor == Color.Red)
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                if (auxiliar == "insert")
                {
                    objasignacionsim.IdLinea = Convert.ToInt32(cmbLinea.SelectedValue);
                    objasignacionsim.IdSim = Convert.ToInt32(cmbSim.SelectedValue);
                    objasignacionsim.Estatus = "Disponible";
                    objasignacionsim.Comentarios = txtComentarios.Text;


                    objasignacionsim.insertAsignacion();
                    if (objasignacionsim.resultado == 1)
                    {
                        objasignacionsim.UpdateLineStatus();
                        objasignacionsim.UpdateSimStatus();
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvAsignaciones.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objasignacionsim.resultado == 2)
                    {
                        MessageBox.Show("Error :Asignacion ya existe", "Coordinador Duplicado");
                        //  error = 1;
                        limpiarcampos();
                        //error = 1;
                    }
                    else if (objasignacionsim.resultado == 0)
                    {
                        MessageBox.Show("Error Al Actualizar Linea", "Error en Actualizacion");
                        //CargarGrid();
                        //  error = 1;
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 4002, Error Al Actualizar Linea: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");

                    }



                }
                if (auxiliar == "delete")
                {
                    objasignacionsim.IdLinea = idLinea;
                    objasignacionsim.IdSim = idSim;
                    objasignacionsim.Estatus = "Disponible";
                    objasignacionsim.Comentarios = txtComentarios.Text;


                    objasignacionsim.insertAsignacion();
                    if (objasignacionsim.resultado == 1)
                    {
                        objasignacionsim.UpdateLineStatus();
                        objasignacionsim.UpdateSimStatus();
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvAsignaciones.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objasignacionsim.resultado == 2)
                    {
                        MessageBox.Show("Error :Asignacion ya existe", "Coordinador Duplicado");
                        //  error = 1;
                        limpiarcampos();
                        //error = 1;
                    }
                    else if (objasignacionsim.resultado == 0)
                    {
                        MessageBox.Show("Error Al Actualizar Linea", "Error en Actualizacion");
                        //CargarGrid();
                        //  error = 1;
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 4002, Error Al Actualizar Linea: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");

                    }



                }
            }
            CargarComboLineas();
            CargarComboSim();
        }
        public void CargarGridDisponibles()
        {
            //cuando esta disponible
            dgvAsignaciones.DataSource = null;
            objasignacionsim.populateGridAsignacionesDisponibles();
            dgvAsignaciones.DataSource = objasignacionsim.dt;

            Font fuente = new Font(dgvAsignaciones.Font, FontStyle.Bold);
            dgvAsignaciones.ClearSelection();

        }

        public void CargarGrid()
        {
            //cuando esta disponible
            dgvAsignaciones.DataSource = null;
            objasignacionsim.populateGridAsignaciones();
            dgvAsignaciones.DataSource = objasignacionsim.dt;

            Font fuente = new Font(dgvAsignaciones.Font, FontStyle.Bold);
            dgvAsignaciones.ClearSelection();

        }
        public void CargarGridActivos()
        {
            //cuando esta disponible
            dgvAsignaciones.DataSource = null;
            objasignacionsim.populateGridAsignacionesActivas();
            dgvAsignaciones.DataSource = objasignacionsim.dt;

            Font fuente = new Font(dgvAsignaciones.Font, FontStyle.Bold);
            dgvAsignaciones.ClearSelection();

        }
        public void limpiarcampos()
        {
            gbSIM.Enabled = false;
         
            cmbSim.SelectedIndex = -1;
            cmbLinea.SelectedIndex = -1;
            txtComentarios.Text = "";
           
        }

        private void cmbfiltroestatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfiltroestatus.SelectedIndex==0)
            {
                CargarGridDisponibles();
            }
            else if (cmbfiltroestatus.SelectedIndex==1)
            {
                CargarGridActivos();
            }
        }

        private void dgvAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAsignaciones_SelectionChanged(object sender, EventArgs e)
        {
            limpiarcampos();
            dgvAsignaciones.ReadOnly = true;
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
            if (dgvAsignaciones.SelectedCells.Count>0)
            {
                int selectedrowindex = dgvAsignaciones.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvAsignaciones.Rows[selectedrowindex];

                id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                comentarios = Convert.ToString(selectedRow.Cells["Comentarios"].Value);
            }
        }

        private void pbbajas_Click(object sender, EventArgs e)
        {
            gbSIM.Enabled = false;
            lbltitulo.Text = "Eliminar asignacion";
            // gbUsuarios.Enabled = true;
            limpiarcampos();

            DialogResult res = MessageBox.Show("Esta Seguro Que Desea Eliminar Esta Asignación", " Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                objasignacionsim.Id = id;
                objasignacionsim.deleteasignacion();
                
                if (Convert.ToInt32(objasignacionsim.resultado) == 1)
                {
                    MessageBox.Show("Asignacion eliminada Con Exito", "EXITO");
                    CargarGrid();
                    limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Error: 101 , Error al eliminar Asignacion, enviar captura de pantalla a sistemas@losbucaneros.com", "Error Fatal");

                }

                //Some task…  
            }
            if (res == DialogResult.Cancel)
            {
                gbSIM.Enabled = false;
                limpiarcampos();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvAsignaciones_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Asignaciones: " + dgvAsignaciones.RowCount;
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
                (dgvAsignaciones.DataSource as DataTable).DefaultView.RowFilter = string.Format("SIM LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvAsignaciones.DataSource as DataTable).DefaultView.RowFilter = string.Format("TELEFONO LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            
        }
    }
}
