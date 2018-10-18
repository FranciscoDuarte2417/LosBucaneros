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
    public partial class FrmAjusteLineas : Form
    {
       
        string status = "";
        string auxiliar;
        int error;
        string Nombre, Apellido, Permiso;
        string foto, foto2, idLinea, region, cuentapadre, cuenta, compania, telefono, plancontratado, renta, fechainicio, duracionplan,fechatermino,estatus,comentarios;

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcuentaPAdre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pbmodificaciones_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "MODIFICACIONES - LINEA";
            lbltitulo.ForeColor = Color.Green;
            limpiarcampos();
            pbCamara.Visible = true;
            gbLineas.Enabled = true;
            auxiliar = "update";
          

            int index = cmbCompania.FindString(compania);
            cmbCompania.SelectedIndex = index;
                     

            txtRegion.Text = region;
            txtcuentaPAdre.Text = cuentapadre;
            txtCuenta.Text = cuenta;
            txtTelefono.Text = telefono;

            if (renta.Length==6)
            {
                renta = " " + renta;
            }
          
            txtPlan.Text = plancontratado;
            txtRenta.Text = renta;
            dtpFecha.Value =Convert.ToDateTime(fechainicio);
            txtduracion.Text = duracionplan;
            txtComentarios.Text = comentarios;


        }

        private void gbLineas_Enter(object sender, EventArgs e)
        {

        }

        private void pbbajas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo podran realizarlo administradores");
            lbltitulo.Text = "BAJAS - LINEA";
            lbltitulo.ForeColor = Color.Red;
            limpiarcampos();
            gbLineas.Enabled = true;
            pbCamara.Visible = true;
            gbLineas.Enabled = true;
            auxiliar = "baja";


            int index = cmbCompania.FindString(compania);
            cmbCompania.SelectedIndex = index;


            txtRegion.Text = region;
            txtcuentaPAdre.Text = cuentapadre;
            txtCuenta.Text = cuenta;
            txtTelefono.Text = telefono;

            if (renta.Length == 6)
            {
                renta = "0" + renta;
            }

            txtPlan.Text = plancontratado;
            txtRenta.Text = renta.Substring(1, renta.Length - 1);
            dtpFecha.Value = Convert.ToDateTime(fechainicio);
            txtduracion.Text = duracionplan;
            txtComentarios.Text = comentarios;


            //inhabilitar todo a excepcion del comentarios para que se pueda dar la baja justificada
            txtRegion.Enabled = false;
            txtcuentaPAdre.Enabled = false;
            txtCuenta.Enabled = false;
            cmbCompania.Enabled = false;
            txtTelefono.Enabled = false;
            txtPlan.Enabled = false;
            txtRenta.Enabled = false;
            dtpFecha.Enabled = false;
            txtduracion.Enabled = false;

            txtComentarios.Enabled = true;

        }

        private void pbbajas_MouseHover(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja2;
        }

        private void pbbajas_MouseLeave(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
        }

        private void e(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtduracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.TextLength != 10)
            {
                txtTelefono.BackColor = Color.Red;
            }
            else
            {
                txtTelefono.BackColor = Color.White;
            }
        }

        private void cmbfiltroestatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfiltroestatus.SelectedIndex==0)
            {
                CargarGridDisponibles();
                pbmodificaciones.Visible = true;
                pbbajas.Visible = true;
            }
            else if (cmbfiltroestatus.SelectedIndex == 1)
            {
                CargarGridActivos();
                pbmodificaciones.Visible = false;
                pbbajas.Visible = false;
                
            }
            else if (cmbfiltroestatus.SelectedIndex == 2)
            {
                CargarGridBajas();
                pbmodificaciones.Visible = false;
                pbbajas.Visible = false;
            }
        }

        private void dgvLineas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLineas_SelectionChanged(object sender, EventArgs e)
        {
            dgvLineas.ReadOnly = true;
            limpiarcampos();
            gbLineas.Enabled = false;
            pbbajas.Visible = true;
            pbmodificaciones.Visible = true;
            if (dgvLineas.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvLineas.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvLineas.Rows[selectedrowindex];

                idLinea = Convert.ToString(selectedRow.Cells["Id"].Value);
                region = Convert.ToString(selectedRow.Cells["Region"].Value);
                cuentapadre = Convert.ToString(selectedRow.Cells["CuentaPadre"].Value);
                cuenta = Convert.ToString(selectedRow.Cells["Cuenta"].Value);
                compania = Convert.ToString(selectedRow.Cells["Compania"].Value);
                telefono = Convert.ToString(selectedRow.Cells["Telefono"].Value);
                plancontratado = Convert.ToString(selectedRow.Cells["Plan"].Value);
                renta = Convert.ToString(selectedRow.Cells["Renta"].Value);
                fechainicio = Convert.ToString(selectedRow.Cells["FechaInicio"].Value);
                duracionplan = Convert.ToString(selectedRow.Cells["Duracion"].Value);
                fechatermino = Convert.ToString(selectedRow.Cells["FechaTermino"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                comentarios = Convert.ToString(selectedRow.Cells["Comentarios"].Value);
             




               

            }
        }

        private void txtRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        ClsLineas objlineas = new ClsLineas();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            if (txtTelefono.TextLength!=10 || txtRenta.Text == " " || dtpFecha.Value.ToShortDateString()=="" || txtduracion.Text=="")
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                if (auxiliar == "insert")
                {

                 
                  
                    objlineas.Region = txtRegion.Text;
                    objlineas.Cuentapadre = txtcuentaPAdre.Text;
                    objlineas.Cuenta = txtCuenta.Text;
                    objlineas.Compania = cmbCompania.SelectedItem.ToString();
                    objlineas.Telefono = txtTelefono.Text;
                    objlineas.Plan = txtPlan.Text;
                    string rentaa;
                    string rentaaux1 = txtRenta.Text.Substring(2, 1);

                    if (rentaaux1 == " " || rentaaux1 == "0")
                    {
                        rentaa = txtRenta.Text.Substring(4, txtRenta.TextLength - 4);
                        objlineas.Renta = rentaa;
                    }
                    else
                    {
                        rentaa = txtRenta.Text.Substring(2, txtRenta.TextLength - 2);
                        objlineas.Renta = rentaa;
                    }
                    objlineas.FechaInicio = dtpFecha.Value.ToShortDateString();
                    objlineas.Duracion = txtduracion.Text;
                    objlineas.FechaTermino = dtpFecha.Value.AddMonths(Convert.ToInt32(txtduracion.Text)).ToShortDateString();
                    objlineas.Estatus = "Disponible";
                    objlineas.Comentarios = txtComentarios.Text;

                    objlineas.insertLine();
                    if (objlineas.resultado == 1)
                    {

                        MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                        dgvLineas.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 3010 , Error Al Guardar: Comuniquese con el area de desarrollo ", "Error Fatal");
                    }






                }
                else if (auxiliar == "update")
                {
                    objlineas.Id =Convert.ToInt32( idLinea);
                    objlineas.Region = txtRegion.Text;
                    objlineas.Cuentapadre = txtcuentaPAdre.Text;
                    objlineas.Cuenta = txtCuenta.Text;
                    objlineas.Compania = cmbCompania.SelectedItem.ToString();
                    objlineas.Telefono = txtTelefono.Text;
                    objlineas.Plan = txtPlan.Text;
                    string rentaa;
                    string rentaaux1 = txtRenta.Text.Substring(2, 1);

                    if (rentaaux1 == " " || rentaaux1 == "0")
                    {
                        rentaa = txtRenta.Text.Substring(4, txtRenta.TextLength - 4);
                        objlineas.Renta = rentaa;
                    }
                    else
                    {
                        rentaa = txtRenta.Text.Substring(2, txtRenta.TextLength - 2);
                        objlineas.Renta = rentaa;
                    }
                    objlineas.FechaInicio = dtpFecha.Value.ToShortDateString();
                    objlineas.Duracion = txtduracion.Text;
                    objlineas.FechaTermino = dtpFecha.Value.AddMonths(Convert.ToInt32(txtduracion.Text)).ToShortDateString();
                    DialogResult X = MessageBox.Show("¿La linea conserva su estatus?","Estatus",MessageBoxButtons.YesNo);
                    if (X == System.Windows.Forms.DialogResult.Yes)
                    {
                        objlineas.Estatus = estatus;
                    }
                    else if (X == System.Windows.Forms.DialogResult.No)
                    {
                        if (estatus == "Activo")
                        {
                            X = MessageBox.Show("El Estatus esta actualmente activo, ¿la linea estara disponible?","Estatus",MessageBoxButtons.YesNo);
                            if (X == System.Windows.Forms.DialogResult.Yes)
                            {
                                X = MessageBox.Show("¿Se regreso la tarjeta sim?", "Estatus", MessageBoxButtons.YesNo);
                                if (X == System.Windows.Forms.DialogResult.Yes)
                                {
                                    objlineas.Estatus = "Disponible";
                                }
                                else if (X == System.Windows.Forms.DialogResult.No)
                                {
                                    objlineas.Estatus = "Bajasim";
                                }
                            }
                            else if (X == System.Windows.Forms.DialogResult.No)
                            {
                                objlineas.Estatus = "Baja";
                            }
                        }
                    }
                    X = MessageBox.Show("¿El operador seguira activo?","Operador",MessageBoxButtons.YesNo);
                    if (X == System.Windows.Forms.DialogResult.No)
                    {
                        objlineas.Estatus = objlineas.Estatus + "P";
                    }
                    objlineas.Comentarios = txtComentarios.Text;


                    //manda llamar el metodo de la clase
                    objlineas.updateLine();
                    //comprobamos si se realizo con exio
                    if (objlineas.resultado == 1)
                    {
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvLineas.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objlineas.resultado == 2)
                    {
                        MessageBox.Show("Error: Nombre de Linea ya existe", "Coordinador Duplicado");
                        //error = 1;
                    }
                    else if (objlineas.resultado == 0)
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
                else if (auxiliar == "baja")
                {
                    if (txtComentarios.Text == "")
                    {
                        MessageBox.Show("Es necesario indicar el motivo de la baja");
                        txtComentarios.Focus();
                    }
                    else
                    {


                        DialogResult res = MessageBox.Show("Esta Seguro que desea dar de baja la linea: " + telefono, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.Yes)
                        {
                            objlineas.Id = Convert.ToInt32(idLinea);
                            objlineas.Comentarios = txtComentarios.Text;
                            objlineas.deleteLine();
                            if (Convert.ToInt32(objlineas.resultado) == 1)
                            {
                                MessageBox.Show("Linea dada de baja con exito", "EXITO");
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
                            gbLineas.Enabled = false;
                            limpiarcampos();


                        }
                    }
                }
            }
        }

        Image img;
      
        public FrmAjusteLineas()
        {
            InitializeComponent();
         
        }

        private void FrmAjusteLineas_Load(object sender, EventArgs e)
        {
            CargarGrid();
            cmbcriteriobusqueda.SelectedIndex = -1;
            cmbfiltroestatus.SelectedIndex = -1;
                pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
                pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
                pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
                pbbajas.Visible = false;
                pbmodificaciones.Visible = false;
            
           
        }

        private void pbaltas_MouseHover(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta2;
        }

        private void pbaltas_MouseLeave(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
        }

        private void pbmodificaciones_MouseHover(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
        }

        private void pbmodificaciones_MouseLeave(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones2;
        }

        private void pbaltas_Click(object sender, EventArgs e)
        {

            lbltitulo.Text = "ALTAS - LINEA";
            lbltitulo.ForeColor = Color.Blue;
            auxiliar = "insert";
            gbLineas.Enabled = true;
              txtRegion.Focus();
        }






        public void CargarGrid()
        {
            dgvLineas.DataSource = null;
            objlineas.populateGridLines();
            dgvLineas.DataSource = objlineas.dt;
           
            Font fuente = new Font(dgvLineas.Font, FontStyle.Bold);
            dgvLineas.ClearSelection();

        }
        public void CargarGridDisponibles()
        {
            dgvLineas.DataSource = null;
            objlineas.populateGridLinesDisponibles();
            dgvLineas.DataSource = objlineas.dt;

            Font fuente = new Font(dgvLineas.Font, FontStyle.Bold);
            dgvLineas.ClearSelection();

        }
        public void CargarGridActivos()
        {
            dgvLineas.DataSource = null;
            objlineas.populateGridLinesActivo();
            dgvLineas.DataSource = objlineas.dt;

            Font fuente = new Font(dgvLineas.Font, FontStyle.Bold);
            dgvLineas.ClearSelection();

        }
        public void CargarGridBajas()
        {
            dgvLineas.DataSource = null;
            objlineas.populateGridLinesBaja();
            dgvLineas.DataSource = objlineas.dt;

            Font fuente = new Font(dgvLineas.Font, FontStyle.Bold);
            dgvLineas.ClearSelection();

        }
        public void limpiarcampos()
        {
            gbLineas.Enabled = false;
            pbCamara.Visible = false;
            txtRegion.Text = "";
            txtcuentaPAdre.Text = "";
            txtCuenta.Text = "";
            txtTelefono.Text = "";
            txtPlan.Text = "";
            txtRenta.Text = "";
            cmbCompania.SelectedIndex = -1;
            txtduracion.Text = "";
            txtComentarios.Text = "";
        }

        private void dgvLineas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Lineas: " + dgvLineas.RowCount;
        }

        private void lblcont_Click(object sender, EventArgs e)
        {

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
                (dgvLineas.DataSource as DataTable).DefaultView.RowFilter = string.Format("REGION LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvLineas.DataSource as DataTable).DefaultView.RowFilter = string.Format("TELEFONO LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 2)
            {
                (dgvLineas.DataSource as DataTable).DefaultView.RowFilter = string.Format("PLAN LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 3)
            {
                (dgvLineas.DataSource as DataTable).DefaultView.RowFilter = string.Format("RENTA LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
        }

    }
}
