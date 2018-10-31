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
    public partial class FrmAjusteTracto : Form
    {
        string Nombre, Apellido, Permiso;
        string status;
        string auxiliar;
        string id, nomenclatura,tractogeneral, notracto, empresa, estatus;
        string[] datos;
        ClsTractos objTractos = new ClsTractos();
        ClsCajas objcajas = new ClsCajas();
        public FrmAjusteTracto(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }
      
        private void FrmAjusteTracto_Load(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
            pbconsultas.Image = LosBucanerosApp.Properties.Resources.consultas;
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
            lblusuario.Text = "Bienvenido: " + Nombre + " " + Apellido;
            cmbcriteriobusqueda.SelectedIndex = -1;
            comboBox2.SelectedIndex = 0;
            CargarGrid();
        }
        public void CargarGrid()
        {
            if (comboBox2.SelectedIndex == 0)
            {
                // int x=  dgvTractos.NewRowIndex;
                dataGridView1.DataSource = null;
                objTractos.populateGridTrucks();
                dataGridView1.DataSource = objTractos.dt;

                DataGridViewCellStyle style = new DataGridViewCellStyle();

                Font fuente = new Font(dataGridView1.Font, FontStyle.Bold);



                dataGridView1.Columns["Tracto"].DefaultCellStyle.ForeColor = Color.Blue;
                dataGridView1.Columns["Tracto"].DefaultCellStyle.Font = fuente;


                //   dgvTractos.Columns["Estatus"].DefaultCellStyle.ForeColor = Color.Red;
                // dgvTractos.Columns["Estatus"].DefaultCellStyle.Font = fuente;
                dataGridView1.ClearSelection();
            }
            else
            {
                // int x=  dgvTractos.NewRowIndex;
                dataGridView1.DataSource = null;
                objcajas.populateGridCajas();
                dataGridView1.DataSource = objcajas.dt;

                DataGridViewCellStyle style = new DataGridViewCellStyle();

                Font fuente = new Font(dataGridView1.Font, FontStyle.Bold);
                
                dataGridView1.ClearSelection();
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
        private void pbbajas_MouseHover(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja2;
        }
        private void pbbajas_MouseLeave(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
        }
        private void pbmodificaciones_MouseHover(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones2;
        }
        private void pbmodificaciones_MouseLeave(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
        }
        private void pbaltas_Click(object sender, EventArgs e)
        {
            gbTracto.Enabled = true;
            label6.Text = "Registro de Usuarios";
            auxiliar = "insert";
            rbActivo.Checked = true;
            cmbEmpresa.SelectedIndex = 0;
            cmbNomenclatura.SelectedIndex = -1;
            cmbNomenclatura.Enabled = true;
            cmbEmpresa.Enabled = true;
            txtNoTracto.Enabled = true;
            txtplaca.Enabled = true;
            
            txtNoTracto.Text = "";
            status = "";
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            

            txtplaca.Text = "";
            txtcomentario.Text = "";
        }
        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Activo";
        }
        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Inactivo";
        }
        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarcampos();
        }
        private void pbmodificaciones_Click(object sender, EventArgs e)
        {
            limpiarcampos();
            gbTracto.Enabled = true;
            auxiliar = "update";
            cmbNomenclatura.Enabled = true;
            cmbEmpresa.Enabled = true;
            txtNoTracto.Enabled = true;
            txtplaca.Enabled = true;

            txtNoTracto.Text = "";
            status = "";
            rbActivo.Enabled = true;
            rbInactivo.Enabled = true;


            int index = cmbNomenclatura.FindString(nomenclatura);
            cmbNomenclatura.SelectedIndex = index;

            int index2 = cmbEmpresa.FindString(empresa);
            cmbEmpresa.SelectedIndex = index2;

            txtNoTracto.Text = notracto;
            status = estatus;

        }
        private void txtNoTracto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void btnlimpiargrid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmbcriteriobusqueda.SelectedIndex = 1;
            txtBuscaOperadores.Text = "";
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTractos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Font fuente = new Font(dataGridView1.Font, FontStyle.Bold);
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Myrow.Cells[3].Value.ToString() == "Activo")// Or your condition 
                {
                    Myrow.Cells[3].Style.ForeColor = Color.Green;

                    dataGridView1.Columns["Estatus"].DefaultCellStyle.Font = fuente;
                }
                else if (Myrow.Cells[3].Value.ToString() == "Inactivo")
                {
                    Myrow.Cells[3].Style.ForeColor = Color.Red;

                    dataGridView1.Columns["Estatus"].DefaultCellStyle.Font = fuente;
                }

            }
        }
        List<string> ids = new List<string>();
        private void pbbajas_Click(object sender, EventArgs e)
        {
            ids.Clear();
            DataGridViewSelectedRowCollection seleccion = dataGridView1.SelectedRows;
            foreach (DataGridViewRow item in seleccion)
            {
                ids.Add(item.Cells[0].Value.ToString());
            }

            for (int i = 0; i < ids.Count; i++)
            {
                
                limpiarcampos();
                int index = cmbNomenclatura.FindString(nomenclatura);
                cmbNomenclatura.SelectedIndex = index;

                int index2 = cmbEmpresa.FindString(empresa);
                cmbEmpresa.SelectedIndex = index2;

                txtNoTracto.Text = notracto;

                if (estatus == "Activo")
                {
                    rbActivo.Checked = true;
                    status = "Activo";
                }
                else
                {
                    rbInactivo.Checked = true;
                    status = "Inactivo";
                }
                foreach (DataGridViewRow Myrow in dataGridView1.Rows)
                {
                    if (Convert.ToString(Myrow.Cells[0].Value.ToString()) == ids[i])
                    {
                        id = Convert.ToString(Myrow.Cells[0].Value.ToString());
                        tractogeneral = Convert.ToString(Myrow.Cells[1].Value.ToString());
                        empresa = Convert.ToString(Myrow.Cells[2].Value.ToString());
                        estatus = Convert.ToString(Myrow.Cells[3].Value.ToString());
                    }
                    
                }

                DialogResult res = MessageBox.Show("Esta Seguro Que Desea Eliminar El Tracto Camion: " + tractogeneral, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    objTractos.Id = Convert.ToInt32(ids[i]);
                    objTractos.deleteTruck();
                    if (Convert.ToInt32(objTractos.resultado) == 1)
                    {
                        MessageBox.Show("Tracto Camion Eliminado Con Exito", "EXITO");

                        CargarGrid();
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 401 , Error al eliminar tracto camion, enviar captura de pantalla a sistemas@losbucaneros.com", "Error Fatal");

                    }

                    //Some task…  
                }
                if (res == DialogResult.No)
                {
                    //gbUsuarios.Enabled = false;
                    //limpiarcampos();

                }
            }
            
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedIndex < 0 || txtNoTracto.Text == "" || cmbNomenclatura.SelectedIndex < 0 || status == "")
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    if (auxiliar == "insert")
                    {
                        //mandar parametros a la clase
                        objTractos.Nomenclatura = cmbNomenclatura.SelectedItem.ToString(); ;
                        objTractos.Notracto = txtNoTracto.Text;
                        objTractos.Empresa = cmbEmpresa.SelectedItem.ToString();
                        objTractos.Estatus = "Disponible";
                        //llamar metodo de la clase
                        objTractos.insertTruck();

                        //Verificar si se hizo correctamente con la variable resultado
                        if (objTractos.resultado == 1)
                        {

                            MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                            // dgvUsuarios.DataSource = null;
                            CargarGrid();
                            limpiarcampos();
                        }
                        else if (objTractos.resultado == 0)
                        {
                            MessageBox.Show("Error Al Guardar Tracto Camion");
                            CargarGrid();
                            limpiarcampos();
                        }
                        else if (objTractos.resultado == 2)
                        {
                            MessageBox.Show("Error: Ya existe el tractocamineto que desea registrar");
                        }


                    }
                    else if (auxiliar == "update")
                    {
                        if (cmbEmpresa.SelectedIndex < 0 || txtNoTracto.Text == "" || cmbNomenclatura.SelectedIndex < 0 || status == "")
                        {
                            MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
                        }
                        else
                        {
                            //asignar valores a valariables de  clase
                            objTractos.Id = Convert.ToInt32(id);
                            objTractos.Nomenclatura = cmbNomenclatura.SelectedItem.ToString();
                            objTractos.Notracto = txtNoTracto.Text;
                            objTractos.Empresa = cmbEmpresa.SelectedItem.ToString();
                            DialogResult M = MessageBox.Show("Desea guardar el tracto con el mismo estatus?", "Estatus", MessageBoxButtons.YesNo);
                            if (M == System.Windows.Forms.DialogResult.Yes)
                            {

                            }
                            else if (M == System.Windows.Forms.DialogResult.No)
                            {
                                if (status == "Disponible")
                                {
                                    status = "Activo";

                                }
                                else if (status == "Activo")
                                {
                                    status = "Disponible";
                                }
                            }
                            objTractos.Estatus = status;
                            //manda llamar el metodo de la clase
                            objTractos.updateTruck();
                            //comprobamos si se realizo con exio
                            if (objTractos.resultado == 1)
                            {
                                MessageBox.Show("Registro Actualizado Con Exito", "Modificacion Exitosa");
                                //dgvUsuarios.DataSource = null;
                                limpiarcampos();
                                CargarGrid();

                            }
                            else if (objTractos.resultado == 0)
                            {
                                MessageBox.Show("Error Al Actualizar Tracto Camion");
                                CargarGrid();
                                limpiarcampos();
                            }
                            else if (objTractos.resultado == 2)
                            {
                                MessageBox.Show("Error: Ya existe el tractocamineto que desea registrar");
                            }
                        }
                    }
                }
                else
                {
                    if (auxiliar == "insert")
                    {
                        //mandar parametros a la clase
                        objcajas.Nomenclatura = cmbNomenclatura.SelectedItem.ToString(); ;
                        objcajas.Nocaja = txtNoTracto.Text;
                        objcajas.Empresa = cmbEmpresa.SelectedItem.ToString();
                        objcajas.Estatus = "Disponible";
                        objcajas.Placa = txtplaca.Text;
                        objcajas.Comentarios = txtcomentario.Text;
                        //llamar metodo de la clase
                        objcajas.InsertCaja();

                        //Verificar si se hizo correctamente con la variable resultado
                        if (objcajas.resultado == 1)
                        {

                            MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                            // dgvUsuarios.DataSource = null;
                            CargarGrid();
                            limpiarcampos();
                        }
                        else if (objcajas.resultado == 0)
                        {
                            MessageBox.Show("Error Al Guardar Caja");
                            CargarGrid();
                            limpiarcampos();
                        }
                        else if (objTractos.resultado == 2)
                        {
                            MessageBox.Show("Error: Ya existe la caja que desea registrar");
                        }


                    }
                 }
            }
        }
        public void limpiarcampos()
        {
            cmbEmpresa.SelectedIndex = -1;
            cmbNomenclatura.SelectedIndex = -1;
            cmbNomenclatura.Enabled = false;
            cmbEmpresa.Enabled = false;
            txtNoTracto.Enabled = false;
            txtplaca.Enabled = false;
            txtcomentario.Enabled = false;
            txtNoTracto.Text = "";
            status = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            rbActivo.Enabled = false;
            rbInactivo.Enabled = false;
            
            txtplaca.Text = "";
            txtcomentario.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                txtcomentario.Enabled = true;
                label3.Text = "No. Caja";
            }
            else
            {
                txtcomentario.Enabled = false;
                label3.Text = "No. Tracto";
            }
        }

        private void dgvTractos_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            limpiarcampos();
            if (dataGridView1.SelectedCells.Count > 0 && comboBox2.SelectedIndex == 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                tractogeneral = Convert.ToString(selectedRow.Cells["Tracto"].Value);
                empresa = Convert.ToString(selectedRow.Cells["Empresa"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
               
                datos = tractogeneral.Split('-');
                nomenclatura = datos[0];
                notracto = datos[1];
            }
            else if (dataGridView1.SelectedCells.Count > 0 && comboBox2.SelectedIndex == 1)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                objcajas.Id = Convert.ToInt32(selectedRow.Cells["IdCaja"].Value);
                tractogeneral = Convert.ToString(selectedRow.Cells["Caja"].Value);
                objcajas.Empresa = Convert.ToString(selectedRow.Cells["Empresa"].Value);
                objcajas.Estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                objcajas.Comentarios = Convert.ToString(selectedRow.Cells["Comentarios"].Value);

                datos = tractogeneral.Split('-');
                objcajas.Nomenclatura = datos[0];
                objcajas.Nocaja = datos[1];


            }
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
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Tracto LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Estatus LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
        }

        private void txtNoTracto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoTracto_Leave(object sender, EventArgs e)
        {
            string txttracto = cmbNomenclatura.Text + "-" + txtNoTracto.Text;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (txttracto == dataGridView1.Rows[i].Cells["Tracto"].Value.ToString())
                {
                    btnGuardar.Enabled = false;
                    txtNoTracto.ForeColor = Color.Red;
                    MessageBox.Show("El Tracto que intenta registrar ya esta en la base de datos.","Error");
                }
                else
                {
                    btnGuardar.Enabled = true;
                    txtNoTracto.ForeColor = Color.Black;
                }
            }
        }

        private void cmbcriteriobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvTractos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Tractos: " + dataGridView1.RowCount;
        }
    }
}
