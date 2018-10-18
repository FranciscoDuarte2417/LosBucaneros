using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmAjustesOperadores : Form
    {
        string status;
        string auxiliar;
        int error;
        string Nombre, Apellido, Permiso;
        string foto, foto2, idoperador, numempleado, nombre,nombre2, apellido, apellido2, tracto, empresa,estatus,comentarios,coordinador;
        Image img;
        ClsOperadores objoperadores = new ClsOperadores();

        private void pbaltas_Click(object sender, EventArgs e)
        {
            auxiliar = "insert";
            gbOperadores.Enabled = true;
            label6.Text = "Registro de Operadores";
            txtNoEmpleadoOperador.Focus();
            CargarComboTrucks();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Activo";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Inactivo";
        }

        public FrmAjustesOperadores(string nombre, string apellido, string permiso)
        {
            InitializeComponent(); Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }

        private void FrmAjustesOperadores_Load(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
            pbconsultas.Image = LosBucanerosApp.Properties.Resources.consultas;
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
            lblusuario.Text = "Bienvenido: " + Nombre + " " + Apellido;
            CargarGrid();
            CargarComboTrucks();
            CargarComboCoordinators();

            cmbcriteriobusqueda.SelectedIndex = 0;
        }

        private void pbaltas_MouseHover(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta2;
        }

        private void pbbajas_MouseHover(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja2;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreOperador.Text == "" || txtApellidoOperador.Text == "" || CmbEmpresaOperador.SelectedIndex < 0 || status == "")
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                
                if (auxiliar == "insert")
                {
                    ClsOperadores.existe = 0;
                    if (txtNoEmpleadoOperador.Text=="")
                    {
                        objoperadores.Noempleado = "";
                    }
                    else
                    {
                        objoperadores.Noempleado = txtNoEmpleadoOperador.Text;
                    }
                 
                    objoperadores.Nombre = txtNombreOperador.Text;
                    objoperadores.Nombre2 = txtNombre2Operador.Text;
                    objoperadores.Apellido = txtApellidoOperador.Text;
                    objoperadores.Apellido2 = txtApellido2Operador.Text;
                    if (cmbTractoOperador.SelectedIndex < 0)
                    {
                        objoperadores.Tracto = 0;
                    }
                    else
                    {
                        objoperadores.Tracto = Convert.ToInt32(cmbTractoOperador.SelectedValue);
                    }
                    if (cmbCoordinador.SelectedIndex < 0)
                    {
                        objoperadores.Coordinador = 0;
                    }
                    else
                    {
                        objoperadores.Empresa = CmbEmpresaOperador.SelectedItem.ToString(); 
                    }                    
                    objoperadores.Coordinador = Convert.ToInt32(cmbCoordinador.SelectedValue);
                    objoperadores.Estatus = status;
                    objoperadores.Comentarios = txtComentariosOperador.Text;



                    DialogResult res = MessageBox.Show("Desea tomar una foto al Operador?: ", "Confirmacion de foto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {

                        FrmFoto objmostrarfoto = new FrmFoto(txtNombreOperador.Text + "_" + txtApellidoOperador.Text + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgOperadores");
                        objmostrarfoto.ShowDialog();
                        if (ClsOperadores.existe == 1)
                        {
                            //manda llamar el metodo de la clase
                            objoperadores.Fotonombre = ClsCoordinadores.fotoruta;
                            objoperadores.insertdriver();
                            if (objoperadores.resultado == 1)
                            {

                                MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                dgvOperadores.DataSource = null;
                                CargarGrid();
                                limpiarcampos();
                            }
                            else if (objoperadores.resultado == 2)
                            {
                                MessageBox.Show("Error: Nombre de Operador ya existe", "Usuario Duplicado");
                                error = 1;
                            }
                            else if (objoperadores.resultado == 0)
                            {
                                MessageBox.Show("Error Al Registrar Operador", "Error en Registro");
                                //CargarGrid();
                                error = 1;
                                limpiarcampos();
                            }

                        }
                        else
                        {
                            DialogResult res2 = MessageBox.Show("Desea guardar registro sin foto?: ", "Confirmacion de foto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (res2 == DialogResult.Yes)
                            {
                                objoperadores.Fotonombre = "";
                                objoperadores.insertdriver();
                                if (objoperadores.resultado == 1)
                                {

                                    MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                    dgvOperadores.DataSource = null;
                                    CargarGrid();
                                    limpiarcampos();
                                }
                                else if (objoperadores.resultado == 2)
                                {
                                    MessageBox.Show("Error: Nombre de Operador ya existe", "Usuario Duplicado");
                                    error = 1;
                                }
                                else if (objoperadores.resultado == 0)
                                {
                                    MessageBox.Show("Error Al Registrar Operador", "Error en Registro");
                                    //CargarGrid();
                                    error = 1;
                                    limpiarcampos();
                                }
                            }
                            else if (res2 == DialogResult.No)
                            {

                            }
                        }


                    }
                    else if (res == DialogResult.No)
                    {
                        objoperadores.Fotonombre = "";
                        objoperadores.insertdriver();
                        if (objoperadores.resultado == 1)
                        {

                            MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                            dgvOperadores.DataSource = null;
                            CargarGrid();
                            limpiarcampos();
                        }
                        else
                        {
                            MessageBox.Show("Error: 510 , Error Al Guardar: Comuniquese con el area de desarrollo ", "Error Fatal");
                        }
                    }

                }
                else if (auxiliar == "update")
                {
                    //  asignar valores a valariables de la clase
                    objoperadores.Idoperador =Convert.ToInt32(idoperador);
                    objoperadores.Noempleado = txtNoEmpleadoOperador.Text;
                    objoperadores.Nombre = txtNombreOperador.Text;
                    objoperadores.Nombre2 = txtNombre2Operador.Text;
                    objoperadores.Apellido = txtApellidoOperador.Text;
                    objoperadores.Apellido2 = txtApellido2Operador.Text;
                    if (cmbTractoOperador.SelectedIndex < 0)
                    {
                        objoperadores.Tracto = 0;
                    }
                    else
                    {
                        objoperadores.Tracto = Convert.ToInt32(cmbTractoOperador.SelectedValue);
                    }
                    objoperadores.Empresa = CmbEmpresaOperador.SelectedItem.ToString();
                    objoperadores.Coordinador = Convert.ToInt32(cmbCoordinador.SelectedValue);
                    objoperadores.Estatus = status;
                    objoperadores.Comentarios = txtComentariosOperador.Text;

                    //manda llamar el metodo de la clase
                    objoperadores.updateDriver();
                    //comprobamos si se realizo con exio
                    if (objoperadores.resultado == 1)
                    {
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvOperadores.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objoperadores.resultado == 2)
                    {
                        MessageBox.Show("Error: Nombre de Operador ya existe", "Coordinador Duplicado");
                        //error = 1;
                    }
                    else if (objoperadores.resultado == 0)
                    {
                        MessageBox.Show("Error Al Actualizar Operador", "Error en Actualizacion");
                        //CargarGrid();
                        //  error = 1;
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 602, Error Al Actualizar: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");

                    }
                }
            }
            CargarComboTrucks();
        }

        private void gbGridOperadores_Enter(object sender, EventArgs e)
        {

        }

        private void pbmodificaciones_MouseHover(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones2;
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarcampos();
        }

        private void cmbTractoOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvOperadores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Font fuente = new Font(dgvOperadores.Font, FontStyle.Bold);
            foreach (DataGridViewRow Myrow in dgvOperadores.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Myrow.Cells["Estatus"].Value.ToString() == "Activo")// Or your condition 
                {
                    Myrow.Cells["Estatus"].Style.ForeColor = Color.Green;

                    dgvOperadores.Columns["Estatus"].DefaultCellStyle.Font = fuente;
                }
                else if (Myrow.Cells["Estatus"].Value.ToString() == "Inactivo")
                {
                    Myrow.DefaultCellStyle.ForeColor = Color.Red;

                    dgvOperadores.Columns["Estatus"].DefaultCellStyle.Font = fuente;
                }

            }
        }

        private void dgvOperadores_SelectionChanged(object sender, EventArgs e)
        {
            dgvOperadores.ReadOnly = true;
            limpiarcampos();
            gbOperadores.Enabled = false;
            if (dgvOperadores.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvOperadores.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvOperadores.Rows[selectedrowindex];

                idoperador = Convert.ToString(selectedRow.Cells["id"].Value);
                numempleado = Convert.ToString(selectedRow.Cells["NoEmpleado"].Value);
                nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                nombre2 = Convert.ToString(selectedRow.Cells["Nombre2"].Value);
                apellido = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                apellido2 = Convert.ToString(selectedRow.Cells["Apellido2"].Value);
                tracto = Convert.ToString(selectedRow.Cells["Tracto"].Value);
                empresa = Convert.ToString(selectedRow.Cells["Empresa"].Value);
                comentarios = Convert.ToString(selectedRow.Cells["comentarios"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                foto = Convert.ToString(selectedRow.Cells["Foto"].Value);
                coordinador = Convert.ToString(selectedRow.Cells["Coordinador"].Value);

                if (foto != "")
                {

                    GetFileFromS3();

                }
                else
                {
                    img = null;
                    pbfotousuario.Image = null;
                }


            }
        }

        private void pbfotousuario_Click(object sender, EventArgs e)
        {
            FrmFotoDialog objmostrar = new FrmFotoDialog(nombre, apellido +" Tracto: "+ tracto, img);
            objmostrar.ShowDialog();
        }

        private void txtNoEmpleadoOperador_TextChanged(object sender, EventArgs e)
        {
           //.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtNombreOperador_TextChanged(object sender, EventArgs e)
        {
            txtNombreOperador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtNombre2Operador_TextChanged(object sender, EventArgs e)
        {
            txtNombre2Operador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtApellidoOperador_TextChanged(object sender, EventArgs e)
        {
            txtApellidoOperador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtApellido2Operador_TextChanged(object sender, EventArgs e)
        {
            txtApellido2Operador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtComentariosOperador_TextChanged(object sender, EventArgs e)
        {
           // txtComentariosOperador.ch = CharacterCasing.Upper;
        }

        private void btnagregarTracto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAjusteTracto objmostrar = new FrmAjusteTracto("","","");
            objmostrar.ShowDialog();
            CargarComboTrucks();

            int index2 = cmbTractoOperador.FindString(tracto);
            cmbTractoOperador.SelectedIndex = index2;
        }

        List<string> ids = new List<string>();
        private void pbbajas_Click(object sender, EventArgs e)
        {
            ids.Clear();
            DataGridViewSelectedRowCollection seleccion = dgvOperadores.SelectedRows;
            foreach (DataGridViewRow item in seleccion)
            {
                ids.Add(item.Cells[0].Value.ToString());
            }
            for (int i = 0; i < ids.Count; i++)
            {
                gbOperadores.Enabled = false;
                label6.Text = "Eliminar Operador";
                // gbUsuarios.Enabled = true;
                limpiarcampos();

                int index = cmbTractoOperador.FindString(tracto);
                cmbTractoOperador.SelectedIndex = index;

                int index2 = CmbEmpresaOperador.FindString(empresa);
                CmbEmpresaOperador.SelectedIndex = index2;

                int index3 = cmbCoordinador.FindString(coordinador);
                cmbCoordinador.SelectedIndex = index3;

                foreach (DataGridViewRow Myrow in dgvOperadores.Rows)
                {
                    if (Convert.ToString(Myrow.Cells[0].Value.ToString()) == ids[i])
                    {
                        txtNoEmpleadoOperador.Text = Convert.ToString(Myrow.Cells[1].Value.ToString());
                        txtNombreOperador.Text = Convert.ToString(Myrow.Cells[2].Value.ToString());;
                        txtNombre2Operador.Text = Convert.ToString(Myrow.Cells[3].Value.ToString());;
                        txtApellidoOperador.Text = Convert.ToString(Myrow.Cells[4].Value.ToString());;
                        txtApellido2Operador.Text = Convert.ToString(Myrow.Cells[5].Value.ToString());;
                        txtComentariosOperador.Text = comentarios;
                        numempleado = Convert.ToString(Myrow.Cells[1].Value.ToString());
                        nombre = Convert.ToString(Myrow.Cells[2].Value.ToString());
                        nombre2 = Convert.ToString(Myrow.Cells[3].Value.ToString());
                        apellido = Convert.ToString(Myrow.Cells[4].Value.ToString());
                        apellido2 = Convert.ToString(Myrow.Cells[5].Value.ToString());
                    }

                }
            
                cmbTractoOperador.Text = tracto;
                tracto = tracto.Replace("ION", "");
                tracto = tracto.Replace("LMA", "");
                tracto = tracto.Replace("TN", "");
                tracto = tracto.Replace("-", "");
                if (tracto == "SinTracto")
                {
                    tracto = "0";
                }




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


                DialogResult res = MessageBox.Show("Esta Seguro Que Desea Eliminar El Operador: " +numempleado +" "+ nombre + " " + apellido, "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    objoperadores.Idoperador = Convert.ToInt32(ids[i]);
                    objoperadores.Tracto = Convert.ToInt32(tracto);
                    objoperadores.deleteDrivers();
                    if (Convert.ToInt32(objoperadores.resultado) == 1)
                    {
                        MessageBox.Show("Operador Eliminado Con Exito", "EXITO");
                        DeleteFileFromS3();
                        CargarGrid();
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 601 , Error al eliminar Operador, enviar captura de pantalla a sistemas@losbucaneros.com", "Error Fatal");

                    }

                    //Some task…  
                }
                if (res == DialogResult.Cancel)
                {
                    gbOperadores.Enabled = false;
                    limpiarcampos();

                }
                CargarComboTrucks();
            }
        }

        private void pbCamara_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Desea Reemplazar la foto del Operador : " + nombre + " " + apellido, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)

            {
                FrmFoto objmostrarfoto = new FrmFoto(txtNombreOperador.Text + "_" + txtApellidoOperador.Text + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgOperadores");
                objmostrarfoto.ShowDialog();
                if (ClsCoordinadores.existe == 1)
                {
                    DeleteFileFromS3();
                    //manda llamar el metodo de la clase
                    objoperadores.Idoperador = Convert.ToInt32(idoperador);
                    objoperadores.Fotonombre = ClsUsuarios.fotoruta;
                    objoperadores.updateDriverimage();
                    if (objoperadores.resultado == 1)
                    {

                        MessageBox.Show("Foto Actualizada Con Exito", "Almacenamiento Exitoso");
                        dgvOperadores.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("No se actualizo la foto");
                        limpiarcampos();
                    }


                }
            }
        }

        private void btnagregarCoordinador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAjusteCoordinador objmostrar = new FrmAjusteCoordinador("","","");
            objmostrar.ShowDialog();
            CargarComboCoordinators();

            int index2 = cmbCoordinador.FindString(coordinador);
            cmbCoordinador.SelectedIndex = index2;
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
                (dgvOperadores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre + Apellido+ Apellido2+ Tracto LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 0)
            {
                (dgvOperadores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre + Apellido+ Apellido2+ Tracto+Estatus LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
           
        }

        private void cmbcriteriobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNoEmpleadoOperador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNoEmpleadoOperador_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnlimpiartext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtBuscaOperadores.Text = "";
        }

        private void gbOperadores_Enter(object sender, EventArgs e)
        {

        }

        private void pbCamara_MouseHover(object sender, EventArgs e)
        {
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara2;

        }

        private void pbaltas_MouseLeave(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
        }

        private void pbbajas_MouseLeave(object sender, EventArgs e)
        {
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
        }

        private void pbmodificaciones_MouseLeave(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
        }

        private void pbCamara_MouseLeave(object sender, EventArgs e)
        {
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
        }

        private void pbmodificaciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo podran realizarlo administradores");
            limpiarcampos();
            pbCamara.Visible = true;
            gbOperadores.Enabled = true;
            auxiliar = "update";
            label6.Text = "Actualizar Operador";

            string truck = tracto;

            truck = truck.Replace("ION", "");
            truck = truck.Replace("LMA", "");
            truck = truck.Replace("TN", "");
            truck = truck.Replace("-", "");

            if (truck == "SinTracto")
            {
                truck = "0";
            }

            objoperadores.Tracto = Convert.ToInt32(truck);
            objoperadores.EditTruckEstatus();
            CargarComboTrucks();

            int index = cmbTractoOperador.FindString(tracto);
            cmbTractoOperador.SelectedIndex = index;

            int index2 = CmbEmpresaOperador.FindString(empresa);
            CmbEmpresaOperador.SelectedIndex = index2;

            coordinador = coordinador.Replace('-', ' ');
            int index3 = cmbCoordinador.FindString(coordinador);
            cmbCoordinador.SelectedIndex = index3;

            txtNoEmpleadoOperador.Text = numempleado;
            txtNombreOperador.Text = nombre;
            txtNombre2Operador.Text = nombre2;
            txtApellidoOperador.Text = apellido;
            txtApellido2Operador.Text = apellido2;
            txtComentariosOperador.Text = comentarios;




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
            
        }





        //metodos 
        public void CargarGrid()
        {
            dgvOperadores.DataSource = null;
            objoperadores.populateGridDrivers();
            dgvOperadores.DataSource = objoperadores.dt;
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            Font fuente = new Font(dgvOperadores.Font, FontStyle.Bold);



            dgvOperadores.Columns["Nombre"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvOperadores.Columns["Nombre"].DefaultCellStyle.Font = fuente;
            dgvOperadores.Columns["Apellido"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvOperadores.Columns["Apellido"].DefaultCellStyle.Font = fuente;
            dgvOperadores.Columns["Tracto"].DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvOperadores.Columns["Tracto"].DefaultCellStyle.Font = fuente;
            dgvOperadores.ClearSelection();


        }

        public void CargarComboTrucks()
        {
            cmbTractoOperador.DataSource = null;
            objoperadores.populatecomboTrucks();

            cmbTractoOperador.ValueMember = "Id";
            cmbTractoOperador.DisplayMember = "Tracto";
            cmbTractoOperador.DataSource = objoperadores.dt;
            cmbTractoOperador.SelectedIndex = -1;

        }
        public void CargarComboCoordinators()
        {
            cmbCoordinador.DataSource = null;
            objoperadores.populatecomboCoordinator();

            cmbCoordinador.ValueMember = "Id";
            cmbCoordinador.DisplayMember = "Coordinador";
            cmbCoordinador.DataSource = objoperadores.dt;
            cmbCoordinador.SelectedIndex = -1;

        }
        public void limpiarcampos()
        {
            gbOperadores.Enabled = false;
            pbCamara.Visible = false;
            txtNombreOperador.Text = "";
            txtNombre2Operador.Text = "";
            txtApellidoOperador.Text = "";
            txtApellido2Operador.Text = "";
            txtNoEmpleadoOperador.Text = "";
            txtComentariosOperador.Text = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            CmbEmpresaOperador.SelectedIndex = -1;
            cmbTractoOperador.SelectedIndex = -1;
            cmbCoordinador.SelectedIndex = -1;
            status = "";
        }

        private void GetFileFromS3()
        {


            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            //  var existingBucketName = "losbucaneros";
            //var subDirectoryInBucket = "imgUsuarios";
            var client = Amazon.AWSClientFactory.CreateAmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);


            try
            {
                GetObjectResponse getObjRespone = client.GetObject("losbucaneros/imgOperadores", foto);
                MemoryStream stream = new MemoryStream();
                getObjRespone.ResponseStream.CopyTo(stream);

                var image = Image.FromStream(stream);
                img = image;
                pbfotousuario.Image = image;
            }
            catch (Exception)
            {

                MessageBox.Show("Error:600 Error al mostrar imagen de operador con id: " + idoperador, "Error Fatal");
            }



        }

        private void DeleteFileFromS3()
        {
            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            var existingBucketName = "losbucaneros/imgOperadores";
            // var subDirectoryInBucket = "imgUsuarios";
            var client = Amazon.AWSClientFactory.CreateAmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);

            if (error == 0)
            {
                // Guarda la foto si no hay error en la base de datos
                DeleteObjectRequest deleteObjectRequest = new DeleteObjectRequest
                {

                    BucketName = existingBucketName,
                    Key = foto
                };
                try
                {
                    client.DeleteObject(deleteObjectRequest);

                }
                catch (AmazonS3Exception s3Exception)
                {

                }
            }
            else if (error == 1)
            {
                //elimina la imagen que se habia guardado, pero marco error al guardar en la base de datos
                DeleteObjectRequest deleteObjectRequest = new DeleteObjectRequest
                {

                    BucketName = existingBucketName,
                    Key = foto2
                };
                try
                {
                    client.DeleteObject(deleteObjectRequest);

                }
                catch (AmazonS3Exception s3Exception)
                {

                }

            }
            foto = "";
            foto2 = "";
            error = 0;





        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvOperadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOperadores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Operadores: " + dgvOperadores.RowCount;
        }
    }
}
