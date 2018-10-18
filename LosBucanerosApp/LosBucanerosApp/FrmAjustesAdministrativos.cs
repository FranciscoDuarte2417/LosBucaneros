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
    public partial class FrmAjustesAdministrativos : Form
    {
        string status = "";
        string auxiliar;
        int error;
        string Nombre, Apellido, Permiso;
        string foto, foto2, idadministrativo, nombre, nombre2, apellido, apellido2, empresa, estatus,numempleado,puesto,uce;
        Image img;
        ClsAdministrativos objadministrativos = new ClsAdministrativos();

        public FrmAjustesAdministrativos(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }

        private void FrmAjustesAdministrativos_Load(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
            pbconsultas.Image = LosBucanerosApp.Properties.Resources.consultas;
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
            lblusuario.Text = "Bienvenido: " + Nombre + " " + Apellido;
            CargarGrid();
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

        private void pbmodificaciones_MouseHover(object sender, EventArgs e)
        {
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones2;
        }

        private void pbCamara_MouseHover(object sender, EventArgs e)
        {
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara2;

        }

        private void pbaltas_Click(object sender, EventArgs e)
        {
            auxiliar = "insert";
            gbAdministrativos.Enabled = true;
            label6.Text = "Registro de Administrativos";
            txtnoempleado.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == " " || txtapellido.Text == " " || cmbempresa.SelectedIndex < 0 || cmbUce.SelectedIndex < 0 || status == "")
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                if (auxiliar == "insert")
                {
                    ClsAdministrativos.existe = 0;

                    objadministrativos.NoEmpleado = txtnoempleado.Text;
                    objadministrativos.Nombre = txtnombre.Text;
                    objadministrativos.Nombre2 = txtnombre2.Text;
                    objadministrativos.Apellido = txtapellido.Text;
                    objadministrativos.Apellido2 = txtapellido2.Text;
                    objadministrativos.Empresa = cmbempresa.SelectedItem.ToString();
                    objadministrativos.Puesto = txtpuesto.Text;
                    objadministrativos.Uce= cmbUce.SelectedItem.ToString();


                    objadministrativos.Estatus = status;
                  



                    DialogResult res = MessageBox.Show("Desea tomar una foto al Administrativo?: ", "Confirmacion de foto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {

                        FrmFoto objmostrarfoto = new FrmFoto(nombre + "_" + apellido + "_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgAdministrativos");
                        objmostrarfoto.ShowDialog();
                        if (ClsAdministrativos.existe == 1)
                        {
                            //manda llamar el metodo de la clase
                            objadministrativos.Fotonombre = ClsCoordinadores.fotoruta;
                            objadministrativos.insertAdministrative();
                            if (objadministrativos.resultado == 1)
                            {

                                MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                dgvAdministrativos.DataSource = null;
                                CargarGrid();
                                limpiarcampos();
                            }
                            else if (objadministrativos.resultado == 2)
                            {
                                MessageBox.Show("Error: Nombre de Administrativo ya existe", "Usuario Duplicado");
                                error = 1;
                            }
                            else if (objadministrativos.resultado == 0)
                            {
                                MessageBox.Show("Error Al Registrar Administrativo", "Error en Registro");
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
                                objadministrativos.Fotonombre = "";
                                objadministrativos.insertAdministrative();
                                if (objadministrativos.resultado == 1)
                                {

                                    MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                    dgvAdministrativos.DataSource = null;
                                    CargarGrid();
                                    limpiarcampos();
                                }
                                else if (objadministrativos.resultado == 2)
                                {
                                    MessageBox.Show("Error: Nombre de Operador ya existe", "Usuario Duplicado");
                                    error = 1;
                                }
                                else if (objadministrativos.resultado == 0)
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
                        objadministrativos.Fotonombre = "";
                        objadministrativos.insertAdministrative();
                        if (objadministrativos.resultado == 1)
                        {

                            MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                            dgvAdministrativos.DataSource = null;
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
                    objadministrativos.Idadministrativo =Convert.ToInt32(idadministrativo);
                    objadministrativos.NoEmpleado = txtnoempleado.Text;
                    objadministrativos.Nombre = txtnombre.Text;
                    objadministrativos.Nombre2 = txtnombre2.Text;
                    objadministrativos.Apellido = txtapellido.Text;
                    objadministrativos.Apellido2 = txtapellido2.Text;
                    objadministrativos.Empresa = cmbempresa.SelectedItem.ToString();
                    objadministrativos.Puesto = txtpuesto.Text;
                    objadministrativos.Uce = cmbUce.SelectedItem.ToString();
                    objadministrativos.Estatus = status;

                    //manda llamar el metodo de la clase
                    objadministrativos.updateAdministrative();
                    //comprobamos si se realizo con exio
                    if (objadministrativos.resultado == 1)
                    {
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvAdministrativos.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objadministrativos.resultado == 2)
                    {
                        MessageBox.Show("Error: Nombre de Administrativo ya existe", "Coordinador Duplicado");
                        //error = 1;
                    }
                    else if (objadministrativos.resultado == 0)
                    {
                        MessageBox.Show("Error Al Actualizar Administrativo", "Error en Actualizacion");
                        //CargarGrid();
                        //  error = 1;
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 02, Error Al Actualizar Administrativo: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");

                    }
                }
            }
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Activo";
        }

        private void dgvAdministrativos_SelectionChanged(object sender, EventArgs e)
        {
            dgvAdministrativos.ReadOnly = true;
            limpiarcampos();
            gbAdministrativos.Enabled = false;
            if (dgvAdministrativos.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAdministrativos.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvAdministrativos.Rows[selectedrowindex];

                idadministrativo = Convert.ToString(selectedRow.Cells["id"].Value);
                numempleado = Convert.ToString(selectedRow.Cells["NoEmpleado"].Value);
                nombre = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                nombre2 = Convert.ToString(selectedRow.Cells["Nombre2"].Value);
                apellido = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                apellido2 = Convert.ToString(selectedRow.Cells["Apellido2"].Value);
                empresa = Convert.ToString(selectedRow.Cells["Empresa"].Value);
                puesto = Convert.ToString(selectedRow.Cells["Puesto"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                foto = Convert.ToString(selectedRow.Cells["Foto"].Value);
                uce = Convert.ToString(selectedRow.Cells["Uce"].Value);

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

        private void pbmodificaciones_Click(object sender, EventArgs e)
        {
            limpiarcampos();
            pbCamara.Visible = true;
            gbAdministrativos.Enabled = true;
            auxiliar = "update";
            label6.Text = "Actualizar Administrativo";
            int index = cmbempresa.FindString(empresa);
            cmbempresa.SelectedIndex = index;
            int index2 = cmbUce.FindString(uce);
            cmbUce.SelectedIndex = index;


            txtnoempleado.Text = numempleado;
            txtnombre.Text = nombre;
            txtnombre2.Text = nombre2;
            txtapellido.Text = apellido;
            txtapellido2.Text = apellido2;
            txtpuesto.Text = puesto;

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

        private void pbCamara_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Desea Reemplazar la foto del Operador : " + nombre + " " + apellido, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)

            {
                FrmFoto objmostrarfoto = new FrmFoto(nombre + "_" + apellido + "_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgAdministrativos");
                objmostrarfoto.ShowDialog();
                if (ClsCoordinadores.existe == 1)
                {
                    DeleteFileFromS3();
                    //manda llamar el metodo de la clase
                    objadministrativos.Idadministrativo = Convert.ToInt32(idadministrativo);
                    objadministrativos.Fotonombre = ClsUsuarios.fotoruta;
                    objadministrativos.updateAdministrativeimage();
                    if (objadministrativos.resultado == 1)
                    {

                        MessageBox.Show("Foto Actualizada Con Exito", "Almacenamiento Exitoso");
                        dgvAdministrativos.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: No se actualizo la foto");
                        limpiarcampos();
                    }


                }
            }
        }

        private void gbGridOperadores_Enter(object sender, EventArgs e)
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
                (dgvAdministrativos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre + Apellido+ Apellido2 LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvAdministrativos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Puesto LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
        }

        private void txtnoempleado_TextChanged(object sender, EventArgs e)
        {
            txtnoempleado.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtnombre2_TextChanged(object sender, EventArgs e)
        {
            txtnombre2.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            txtapellido.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtnoempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtapellido2_TextChanged(object sender, EventArgs e)
        {
            txtapellido2.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtpuesto_TextChanged(object sender, EventArgs e)
        {
            txtpuesto.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnlimpiartext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtBuscaOperadores.Text = "";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Inactivo";
        }
        List<string> ids = new List<string>();
        private void pbbajas_Click(object sender, EventArgs e)
        {
            ids.Clear();
            DataGridViewSelectedRowCollection seleccion = dgvAdministrativos.SelectedRows;
            foreach (DataGridViewRow item in seleccion)
            {
                ids.Add(item.Cells[0].Value.ToString());
            }
            for (int i = 0; i < ids.Count; i++)
            {
                gbAdministrativos.Enabled = false;
         //   label6.Text = "Eliminar Administrativo";
            // gbUsuarios.Enabled = true;
            limpiarcampos();

            int index = cmbempresa.FindString(empresa);
            cmbempresa.SelectedIndex = index;


            int index2 = cmbUce.FindString(uce);
            cmbUce.SelectedIndex = index;

            foreach (DataGridViewRow Myrow in dgvAdministrativos.Rows)
            {
                if (Myrow.Cells[0].Value.ToString() == ids[i])
                {
                    txtnoempleado.Text = Myrow.Cells[1].Value.ToString();
                    txtnombre.Text = Myrow.Cells[2].Value.ToString();
                    txtnombre2.Text = Myrow.Cells[3].Value.ToString();
                    txtapellido.Text = Myrow.Cells[4].Value.ToString();
                    txtapellido2.Text = Myrow.Cells[5].Value.ToString();
                    numempleado = Myrow.Cells[1].Value.ToString();
                    nombre = Myrow.Cells[2].Value.ToString();
                    nombre2 = Myrow.Cells[3].Value.ToString();
                    apellido = Myrow.Cells[4].Value.ToString();
                    apellido2 = Myrow.Cells[5].Value.ToString();
                }
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


            DialogResult res = MessageBox.Show("Esta Seguro Que Desea Eliminar El Administrativo: " + numempleado + " " + nombre + " " + apellido, "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                objadministrativos.Idadministrativo = Convert.ToInt32(ids[i]);
                DialogResult X = MessageBox.Show("¿El administrativo tiene un telefono asignado?","Equipos asignados",MessageBoxButtons.YesNo);
                if (X == System.Windows.Forms.DialogResult.Yes)
                {
                    X = MessageBox.Show("¿El telefono fue regresado?","Equipos Asignados",MessageBoxButtons.YesNo);
                    if (X == System.Windows.Forms.DialogResult.Yes)
                    {
                        objadministrativos.TelefonoAdministratives("Disponible");
                    }
                    else if (X == System.Windows.Forms.DialogResult.No)
                    {
                        objadministrativos.TelefonoAdministratives("Baja");
                    }
                }
                objadministrativos.deleteAdministratives();
                if (Convert.ToInt32(objadministrativos.resultado) == 1)
                {
                    MessageBox.Show("Administrativo Eliminado Con Exito", "EXITO");
                    DeleteFileFromS3();
                    CargarGrid();
                    limpiarcampos();
                }
                else
                {
                    MessageBox.Show("Error: 701 , Error al eliminar Administrativo, enviar captura de pantalla a sistemas@losbucaneros.com", "Error Fatal");

                }

                //Some task…  
            }
            if (res == DialogResult.Cancel)
            {
                gbAdministrativos.Enabled = false;
                limpiarcampos();

            }
            }
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


        public void CargarGrid()
        {
            dgvAdministrativos.DataSource = null;
            objadministrativos.populateGridAdministratives();
            dgvAdministrativos.DataSource = objadministrativos.dt;
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            Font fuente = new Font(dgvAdministrativos.Font, FontStyle.Bold);



            dgvAdministrativos.Columns["Nombre"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvAdministrativos.Columns["Nombre"].DefaultCellStyle.Font = fuente;
            dgvAdministrativos.Columns["Apellido"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvAdministrativos.Columns["Apellido"].DefaultCellStyle.Font = fuente;
            dgvAdministrativos.ClearSelection();

        }
        public void limpiarcampos()
        {
            gbAdministrativos.Enabled = false;
            pbCamara.Visible = false;
            txtnoempleado.Text = "";
            txtnombre.Text = "";
            txtnombre2.Text = "";
            txtapellido.Text = "";
            txtapellido2.Text = "";
            txtpuesto.Text = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            cmbempresa.SelectedIndex = -1;
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
                GetObjectResponse getObjRespone = client.GetObject("losbucaneros/imgAdministrativos", foto);
                MemoryStream stream = new MemoryStream();
                getObjRespone.ResponseStream.CopyTo(stream);

                var image = Image.FromStream(stream);
                img = image;
                pbfotousuario.Image = image;
            }
            catch (Exception)
            {

                MessageBox.Show("Error:500 Error al mostrar imagen de coordinador con id: " + idadministrativo, "Error Fatal");
            }



        }

        private void DeleteFileFromS3()
        {
            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            var existingBucketName = "losbucaneros/imgUsuarios";
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

        private void dgvAdministrativos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Administrativos: " + dgvAdministrativos.RowCount;
        }
    }
}
