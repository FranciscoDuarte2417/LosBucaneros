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
    public partial class FrmAjusteCoordinador : Form
    {
        public FrmAjusteCoordinador(string nombre, string apellido, string permiso)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }
        string status;
        string auxiliar;
        int error;
        string Nombre, Apellido, Permiso;
        string foto, foto2, idcoordinador, nombre, nombre2, apellido, apellido2, uce, estatus;
        Image img;
        ClsCoordinadores objcoordinador = new ClsCoordinadores();
        private void FrmAjusteCoordinador_Load(object sender, EventArgs e)
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
            limpiarcampos();
            pbCamara.Visible = true;
            gbCoordinadores.Enabled = true;
            auxiliar = "update";
            label6.Text = "Actualizar Coordinador";

            int index = cmbUce.FindString(uce);
            cmbUce.SelectedIndex = index;

           

            txtNombreCoordinador.Text = nombre;
            txtNombre2Coordinador.Text = nombre2;
            txtApellidoCoordinador.Text = apellido;
            txtApellido2Coordinador.Text = apellido2;


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

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Activo";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Inactivo";
        }

        private void dgvCoordinador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Font fuente = new Font(dgvCoordinador.Font, FontStyle.Bold);
            foreach (DataGridViewRow Myrow in dgvCoordinador.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Myrow.Cells[6].Value.ToString() == "Activo")// Or your condition 
                {
                    Myrow.Cells[6].Style.ForeColor = Color.Green;

                    dgvCoordinador.Columns["Estatus"].DefaultCellStyle.Font = fuente;
                }
                else if (Myrow.Cells[6].Value.ToString() == "Inactivo")
                {
                    Myrow.Cells[6].Style.ForeColor = Color.Red;

                    dgvCoordinador.Columns["Estatus"].DefaultCellStyle.Font = fuente;
                }

            }
        }
        List<string> ids = new List<string>();
        private void pbbajas_Click(object sender, EventArgs e)
        {
            ids.Clear();
            DataGridViewSelectedRowCollection seleccion = dgvCoordinador.SelectedRows;
            foreach (DataGridViewRow item in seleccion)
            {
                ids.Add(item.Cells[0].Value.ToString());
            }

            for (int i = 0; i < ids.Count; i++)
            {
                gbCoordinadores.Enabled = false;
                label6.Text = "Eliminar Usuario";
                // gbUsuarios.Enabled = true;
                limpiarcampos();
                int index = cmbUce.FindString(uce);
                cmbUce.SelectedIndex = index;


                foreach (DataGridViewRow Myrow in dgvCoordinador.Rows)
                {
                    if (Myrow.Cells[0].Value.ToString() == ids[i])
                    {
                        txtNombreCoordinador.Text = Myrow.Cells[1].Value.ToString();
                        txtNombre2Coordinador.Text = Myrow.Cells[2].Value.ToString();
                        txtApellidoCoordinador.Text = Myrow.Cells[3].Value.ToString();
                        txtApellido2Coordinador.Text = Myrow.Cells[4].Value.ToString();
                        nombre = Myrow.Cells[1].Value.ToString();
                        nombre2 = Myrow.Cells[2].Value.ToString();
                        apellido = Myrow.Cells[3].Value.ToString();
                        apellido2 = Myrow.Cells[4].Value.ToString();
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


                DialogResult res = MessageBox.Show("Esta Seguro Que Desea Eliminar El Coordinador: " + nombre + " " + apellido, "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    objcoordinador.Idcoordinador = Convert.ToInt32(ids[i]);
                    objcoordinador.deleteCoordinators();
                    if (Convert.ToInt32(objcoordinador.resultado) == 1)
                    {
                        MessageBox.Show("Coordinador Eliminado Con Exito", "EXITO");
                        DeleteFileFromS3();
                        CargarGrid();
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 101 , Error al eliminar usuario, enviar captura de pantalla a sistemas@losbucaneros.com", "Error Fatal");

                    }

                    //Some task…  
                }
                if (res == DialogResult.Cancel)
                {
                    gbCoordinadores.Enabled = false;
                    limpiarcampos();

                }
            }
            
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarcampos();
        }

        private void pbfotousuario_Click(object sender, EventArgs e)
        {
            FrmFotoDialog objmostrar = new FrmFotoDialog(nombre, apellido, img);
            objmostrar.ShowDialog();
        }

        private void pbCamara_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Desea Reemplazar la foto del Coordinador : " + nombre + " " + apellido, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)

            {
                FrmFoto objmostrarfoto = new FrmFoto(nombre + "_" + apellido + "_" + uce + "_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgCoordinadores");
                objmostrarfoto.ShowDialog();
                if (ClsCoordinadores.existe == 1)
                {
                    DeleteFileFromS3();
                    //manda llamar el metodo de la clase
                    objcoordinador.Idcoordinador = Convert.ToInt32(idcoordinador);
                    objcoordinador.Fotonombre = ClsUsuarios.fotoruta;
                    objcoordinador.updateCoordinatorimage();
                    if (objcoordinador.resultado == 1)
                    {

                        MessageBox.Show("Foto Actualizada Con Exito", "Almacenamiento Exitoso");
                        dgvCoordinador.DataSource = null;
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

        private void txtBuscaOperadores_TextChanged(object sender, EventArgs e)
        {
            if (cmbcriteriobusqueda.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar un criterio de busqueda valido");
                txtBuscaOperadores.Text = "";
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 0)
            {
                (dgvCoordinador.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre + Apellido LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvCoordinador.DataSource as DataTable).DefaultView.RowFilter = string.Format("Uce LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
              
            
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvCoordinador.DataSource as DataTable).DefaultView.RowFilter = string.Format("Uce LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
        }

        private void btnlimpiartext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtBuscaOperadores.Text = "";
        }

        private void txtNombreCoordinador_TextChanged(object sender, EventArgs e)
        {
            txtNombreCoordinador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtNombre2Coordinador_TextChanged(object sender, EventArgs e)
        {
            txtNombre2Coordinador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtApellidoCoordinador_TextChanged(object sender, EventArgs e)
        {
            txtApellidoCoordinador.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtApellido2Coordinador_TextChanged(object sender, EventArgs e)
        {
            txtApellido2Coordinador.CharacterCasing = CharacterCasing.Upper;
        }

        public void CargarGrid()
        {
            dgvCoordinador.DataSource = null;
            objcoordinador.populateGridCoordinator();
            dgvCoordinador.DataSource = objcoordinador.dt;
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            Font fuente = new Font(dgvCoordinador.Font, FontStyle.Bold);



            dgvCoordinador.Columns["Nombre"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvCoordinador.Columns["Nombre"].DefaultCellStyle.Font = fuente;
            dgvCoordinador.Columns["Apellido"].DefaultCellStyle.ForeColor = Color.Blue;
            dgvCoordinador.Columns["Apellido"].DefaultCellStyle.Font = fuente;
            dgvCoordinador.ClearSelection();

        }
        public void limpiarcampos()
        {
            gbCoordinadores.Enabled = false;
            pbCamara.Visible = false;
            txtNombreCoordinador.Text = "";
            txtNombre2Coordinador.Text = "";
            txtApellidoCoordinador.Text = "";
            txtApellido2Coordinador.Text = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            cmbUce.SelectedIndex = -1;
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
                GetObjectResponse getObjRespone = client.GetObject("losbucaneros/imgCoordinadores", foto);
                MemoryStream stream = new MemoryStream();
                getObjRespone.ResponseStream.CopyTo(stream);

                var image = Image.FromStream(stream);
                img = image;
                pbfotousuario.Image = image;
            }
            catch (Exception)
            {

                MessageBox.Show("Error:500 Error al mostrar imagen de coordinador con id: "+idcoordinador, "Error Fatal");
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

        private void pbaltas_Click(object sender, EventArgs e)
        {
            auxiliar = "insert";
            gbCoordinadores.Enabled = true;
            label6.Text = "Registro de Usuarios";
            txtNombreCoordinador.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreCoordinador.Text == "" || txtApellidoCoordinador.Text == "" || cmbUce.SelectedIndex < 0 || status == "")
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                if (auxiliar == "insert")
                {
                    ClsCoordinadores.existe = 0;
                    objcoordinador.Nombre = txtNombreCoordinador.Text;
                    objcoordinador.Nombre2 = txtNombre2Coordinador.Text;
                    objcoordinador.Apellido = txtApellidoCoordinador.Text;
                    objcoordinador.Apellido2 = txtApellido2Coordinador.Text;
                    objcoordinador.Uce = cmbUce.SelectedItem.ToString();
                    objcoordinador.Estatus = status;



                    DialogResult res = MessageBox.Show("Desea tomar una foto al coordinador?: ", "Confirmacion de foto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {

                        FrmFoto objmostrarfoto = new FrmFoto(objcoordinador.Nombre + "_" + objcoordinador.Apellido + "_" + objcoordinador.Uce + "_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgCoordinadores");
                        objmostrarfoto.ShowDialog();
                        if (ClsCoordinadores.existe == 1)
                        {
                            //manda llamar el metodo de la clase
                            objcoordinador.Fotonombre = ClsCoordinadores.fotoruta;
                            objcoordinador.insertcoordinator();
                            if (objcoordinador.resultado == 1)
                            {

                                MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                dgvCoordinador.DataSource = null;
                                CargarGrid();
                                limpiarcampos();
                            }
                            else if (objcoordinador.resultado == 2)
                            {
                                MessageBox.Show("Error: Nombre de Coordinador ya existe", "Usuario Duplicado");
                                error = 1;
                            }
                            else if (objcoordinador.resultado == 0)
                            {
                                MessageBox.Show("Error Al Registrar Coordinador", "Error en Registro");
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
                                objcoordinador.Fotonombre = "";
                                objcoordinador.insertcoordinator();
                                if (objcoordinador.resultado == 1)
                                {

                                    MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                    dgvCoordinador.DataSource = null;
                                    CargarGrid();
                                    limpiarcampos();
                                }
                                else if (objcoordinador.resultado == 2)
                                {
                                    MessageBox.Show("Error: Nombre de coordinador ya existe", "Usuario Duplicado");
                                    error = 1;
                                }
                                else if (objcoordinador.resultado == 0)
                                {
                                    MessageBox.Show("Error Al Registrar Coordinador", "Error en Registro");
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
                        objcoordinador.Fotonombre = "";
                        objcoordinador.insertcoordinator();
                        if (objcoordinador.resultado == 1)
                        {

                            MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                            dgvCoordinador.DataSource = null;
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
                    //asignar valores a valariables de la clase
                    objcoordinador.Idcoordinador = Convert.ToInt32(idcoordinador);
                    objcoordinador.Nombre = txtNombreCoordinador.Text;
                    objcoordinador.Nombre2 = txtNombre2Coordinador.Text;
                    objcoordinador.Apellido = txtApellidoCoordinador.Text;
                    objcoordinador.Apellido2 = txtApellido2Coordinador.Text;
                    objcoordinador.Uce = cmbUce.SelectedItem.ToString();
                    objcoordinador.Estatus = status;

                    //manda llamar el metodo de la clase
                    objcoordinador.updateCoordinator();
                    //comprobamos si se realizo con exio
                    if (objcoordinador.resultado == 1)
                    {
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvCoordinador.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objcoordinador.resultado == 2)
                    {
                        MessageBox.Show("Error: Nombre de Coordinador ya existe", "Coordinador Duplicado");
                        //error = 1;
                    }
                    else if (objcoordinador.resultado == 0)
                    {
                        MessageBox.Show("Error Al Actualizar Coordinador", "Error en Actualizacion");
                        //CargarGrid();
                        //  error = 1;
                        limpiarcampos();
                    }
                    else
                    {
                        MessageBox.Show("Error: 102, Error Al Actualizar: Enviar Captura de pantalla al correo: sistemas@losbucaneros.com ", "Error Fatal");
                    }
                }
            }
        }

        private void dgvCoordinador_SelectionChanged(object sender, EventArgs e)
        {
            dgvCoordinador.ReadOnly = true;
            limpiarcampos();
            gbCoordinadores.Enabled = false;
            if (dgvCoordinador.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCoordinador.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvCoordinador.Rows[selectedrowindex];

                idcoordinador = Convert.ToString(selectedRow.Cells["id"].Value);
                nombre = Convert.ToString(selectedRow.Cells["nombre"].Value);
                nombre2 = Convert.ToString(selectedRow.Cells["nombre2"].Value);
                apellido = Convert.ToString(selectedRow.Cells["apellido"].Value);
                apellido2 = Convert.ToString(selectedRow.Cells["apellido2"].Value);
                uce = Convert.ToString(selectedRow.Cells["uce"].Value);
                estatus = Convert.ToString(selectedRow.Cells["estatus"].Value);
                foto = Convert.ToString(selectedRow.Cells["foto"].Value);

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

        private void gbUsuarios_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCoordinador_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Coordinadores: " + dgvCoordinador.RowCount;
        }
    }
}
