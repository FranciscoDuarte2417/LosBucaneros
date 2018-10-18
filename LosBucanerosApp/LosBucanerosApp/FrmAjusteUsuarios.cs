using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.S3.Model;
using System.IO;

namespace LosBucanerosApp
{
    public partial class FrmAjusteUsuarios : Form
    {
        string status;
        string auxiliar;
        int error;
        string Nombre, Apellido, Permiso;
        string idusuario, nombreusuario, apellidousuario, usuario, pass, estatus, permiso, foto,foto2;
        ClsUsuarios objusuarios = new ClsUsuarios();
        public FrmAjusteUsuarios(string nombre, string apellido, string permis)
        {
            InitializeComponent();
            Nombre = nombre;
            Apellido = apellido;
            Permiso = permiso;
        }

        private void FrmAjusteUsuarios_Load(object sender, EventArgs e)
        {
            pbaltas.Image = LosBucanerosApp.Properties.Resources.alta;
            pbbajas.Image = LosBucanerosApp.Properties.Resources.baja;
            pbconsultas.Image = LosBucanerosApp.Properties.Resources.consultas;
            pbmodificaciones.Image = LosBucanerosApp.Properties.Resources.modificaciones;
            pbCamara.Image = LosBucanerosApp.Properties.Resources.camara;
            lblusuario.Text = "Bienvenido: " + Nombre + " " + Apellido;
            CargarGrid();
            cmbcriteriobusqueda.SelectedIndex = 0;
            cmbPermisos.SelectedIndex = 1;

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

        private void pbaltas_Click(object sender, EventArgs e)
        {
            auxiliar = "insert";
            gbUsuarios.Enabled = true;
            label6.Text = "Registro de Usuarios";
            txtnombreusuario.Focus();
            cmbPermisos.SelectedIndex = 1;
            rbActivo.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {//revisar si no hay campos nulos
            if (txtnombreusuario.Text==""||txtapellidousuario.Text==""||cmbPermisos.SelectedIndex<0 || status=="")
            {
                MessageBox.Show("No se Aceptan Campos Vacios", "Error de Validacion");
            }
            else
            {
                if (auxiliar=="insert")
                {
                    ClsUsuarios.existe = 0;
                    objusuarios.Nombre = txtnombreusuario.Text;
                    objusuarios.Apellido = txtapellidousuario.Text;
                    objusuarios.Usuario = txtusuario.Text;
                    objusuarios.Pass = txtpassword.Text;
                    objusuarios.Status = status;
                    objusuarios.Permisos = cmbPermisos.SelectedItem.ToString();
                    if (cmbPermisos.SelectedIndex == 0)
                    {
                        objusuarios.Permisos = "Admin";
                    }
                  


                    DialogResult res = MessageBox.Show("Desea tomar una foto al usuario?: ", "Confirmacion de foto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {

                        FrmFoto objmostrarfoto = new FrmFoto(objusuarios.Usuario + "_" + objusuarios.Nombre+"_"+objusuarios.Apellido+"_"+DateTime.Now.Day.ToString()+DateTime.Now.Month.ToString()+DateTime.Now.Year.ToString()+DateTime.Now.Hour.ToString()+DateTime.Now.Minute.ToString(),"imgUsuarios");
                        objmostrarfoto.ShowDialog();
                        if (ClsUsuarios.existe == 1)
                        {
                            //manda llamar el metodo de la clase
                            objusuarios.Fotonombre = ClsUsuarios.fotoruta;
                            objusuarios.insertuser();
                            if (objusuarios.resultado == 1)
                            {

                                MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                dgvUsuarios.DataSource = null;
                                CargarGrid();
                                limpiarcampos();
                            }
                            else if(objusuarios.resultado == 2)
                            {
                                MessageBox.Show("Error: Nombre de Usuario ya existe","Usuario Duplicado");
                                error = 1;
                            }
                            else if (objusuarios.resultado == 0)
                            {
                                MessageBox.Show("Error Al Registrar Usuario", "Error en Registro");
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
                                objusuarios.Fotonombre = "";
                                objusuarios.insertuser();
                                if (objusuarios.resultado == 1)
                                {

                                    MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                                    dgvUsuarios.DataSource = null;
                                    CargarGrid();
                                    limpiarcampos();
                                }
                                else if (objusuarios.resultado == 2)
                                {
                                    MessageBox.Show("Error: Nombre de Usuario ya existe", "Usuario Duplicado");
                                    error = 1;
                                }
                                else if (objusuarios.resultado == 0)
                                {
                                    MessageBox.Show("Error Al Registrar Usuario", "Error en Registro");
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
                    else if (res==DialogResult.No)
                    {
                        objusuarios.Fotonombre = "";
                        objusuarios.insertuser();
                        if (objusuarios.resultado == 1)
                        {

                            MessageBox.Show("Registro Almacenado Con Exito", "Almacenamiento Exitoso");
                            dgvUsuarios.DataSource = null;
                            CargarGrid();
                            limpiarcampos();
                        }
                        else if (objusuarios.resultado == 2)
                        {
                            MessageBox.Show("El usuario esta duplicado");
                        }
                        else
                        {
                            MessageBox.Show("Error: 100 , Error Al Guardar: Comuniquese con el area de desarrollo ", "Error Fatal");
                        }
                    }
   
                }
                else if (auxiliar=="update")
                {
                    //asignar valores a valariables de la clase
                    objusuarios.Idusuario =Convert.ToInt32(idusuario);
                    objusuarios.Nombre = txtnombreusuario.Text;
                    objusuarios.Apellido = txtapellidousuario.Text;
                    objusuarios.Usuario = txtusuario.Text;
                    objusuarios.Pass = txtpassword.Text;
                    objusuarios.Status = status;
                    objusuarios.Permisos = cmbPermisos.SelectedItem.ToString();
                    if (cmbPermisos.SelectedIndex == 0)
                    {
                        objusuarios.Permisos = "Admin";
                    }
                    
                    //manda llamar el metodo de la clase
                    objusuarios.updatetuser();
                    //comprobamos si se realizo con exio
                    if (objusuarios.resultado == 1)
                    {
                        MessageBox.Show("Registro Actualizado Con Exito", "Actualizacion Exitosa");
                        dgvUsuarios.DataSource = null;
                        CargarGrid();
                        limpiarcampos();
                    }
                    else if (objusuarios.resultado == 2)
                    {
                        MessageBox.Show("Error: Nombre de Usuario ya existe", "Usuario Duplicado");
                        //error = 1;
                    }
                    else if (objusuarios.resultado == 0)
                    {
                        MessageBox.Show("Error Al Actualizar Usuario", "Error en Actualizacion");
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

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Activo";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            status = "Inactivo";
        }

        private void pbmodificaciones_Click(object sender, EventArgs e)
        {
            

            auxiliar = "update";
            label6.Text = "Actualizar Usuario";
            gbUsuarios.Enabled = true;
            limpiarcampos();
            pbCamara.Visible = true;
            txtnombreusuario.Text = nombreusuario;
            txtapellidousuario.Text = apellidousuario;
            txtusuario.Text = usuario;
            txtpassword.Text = pass;
            if (estatus=="Activo" || estatus== "Activo")
            {
                rbActivo.Checked = true;
                status = "Activo";
            }
            else
            {
                rbInactivo.Checked = true;
                status = "Inactivo";
            }
            if (permiso=="Admin")
            {
                cmbPermisos.SelectedIndex = 0;
            }
            else if (permiso == "General")
            {
                cmbPermisos.SelectedIndex = 1;
            }
            else if (permiso == "Invitado")
            {
                cmbPermisos.SelectedIndex = 2;
            }
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarcampos();
            gbUsuarios.Enabled = false;
          
        }

        private void pbbajas_Click(object sender, EventArgs e)
        {
            gbUsuarios.Enabled = false;
            label6.Text = "Eliminar Usuario";
           // gbUsuarios.Enabled = true;
            limpiarcampos();
            txtnombreusuario.Text = nombreusuario;
            txtapellidousuario.Text = apellidousuario;
            txtusuario.Text = usuario;
            txtpassword.Text = pass;
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
            if (permiso == "Admin")
            {
                cmbPermisos.SelectedIndex = 0;
            }
            else if (permiso == "General")
            {
                cmbPermisos.SelectedIndex = 1;
            }
            else if (permiso == "Invitado")
            {
                cmbPermisos.SelectedIndex = 2;
            }

            DialogResult res = MessageBox.Show("Esta Seguro Que Desea Eliminar El Usuario: "+ nombreusuario+" " +apellidousuario, "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                objusuarios.Idusuario = Convert.ToInt32(idusuario);
                objusuarios.deleteuser();
                if (Convert.ToInt32(objusuarios.resultado)==1)
                {
                    MessageBox.Show("Usuario Eliminado Con Exito","EXITO");
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
                gbUsuarios.Enabled = false;
                limpiarcampos();
    
            }

        }

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {
            txtnombreusuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtapellidousuario_TextChanged(object sender, EventArgs e)
        {
            txtapellidousuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            txtpassword.Focus();
        }

        public void limpiarcampos()
        {
            pbCamara.Visible = false;
            txtnombreusuario.Text = "";
            txtapellidousuario.Text = "";
            txtusuario.Text = "";
            txtpassword.Text = "";
            rbActivo.Checked = false;
            rbInactivo.Checked = false;
            cmbPermisos.SelectedIndex = -1;
        }

        private void pbfotousuario_Click(object sender, EventArgs e)
        {
            FrmFotoDialog objmostrar = new FrmFotoDialog(nombreusuario,apellidousuario,img);
            objmostrar.ShowDialog();
        }

        public void CargarGrid()
        {
            dgvUsuarios.DataSource = null;
            objusuarios.populateGridUser();
            dgvUsuarios.DataSource = objusuarios.dt;
            DataGridViewCellStyle style = new DataGridViewCellStyle();

            Font fuente = new Font(dgvUsuarios.Font, FontStyle.Bold);



            dgvUsuarios.Columns["Usuario"].DefaultCellStyle.ForeColor = Color.Green;
            dgvUsuarios.Columns["Usuario"].DefaultCellStyle.Font = fuente;
            dgvUsuarios.Columns["Password"].DefaultCellStyle.ForeColor = Color.Red;
            dgvUsuarios.Columns["Password"].DefaultCellStyle.Font = fuente;

        }

        private void pbCamara_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Desea Reemplazar la foto del Usuario : " + nombreusuario + " " + apellidousuario, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)

            {
                FrmFoto objmostrarfoto = new FrmFoto(usuario + "_" + nombreusuario + "_" + apellidousuario + "_" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString(), "imgUsuarios");
                objmostrarfoto.ShowDialog();
                if (ClsUsuarios.existe == 1)
                {
                    DeleteFileFromS3();
                    //manda llamar el metodo de la clase
                    objusuarios.Idusuario =Convert.ToInt32(idusuario);
                    objusuarios.Fotonombre = ClsUsuarios.fotoruta;
                    objusuarios.updatetuserimage();
                    if (objusuarios.resultado == 1)
                    {

                        MessageBox.Show("Foto Actualizada Con Exito", "Almacenamiento Exitoso");
                        dgvUsuarios.DataSource = null;
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
            if (res == DialogResult.No)
                {
                    MessageBox.Show("aqui no hace nada todo se queda igual");
                    gbUsuarios.Enabled = false;
                    limpiarcampos();
                }
           
        }

        private void cmbcriteriobusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbGridOperadores_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscaOperadores_TextChanged(object sender, EventArgs e)
        {
            if (cmbcriteriobusqueda.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccionar un criterio de busqueda valido");
                txtBuscaOperadores.Text = "";
            }
            else if (cmbcriteriobusqueda.SelectedIndex == 0)
            {
                (dgvUsuarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre + Apellido LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
           
            else if (cmbcriteriobusqueda.SelectedIndex == 1)
            {
                (dgvUsuarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Usuario LIKE '%{0}%'", txtBuscaOperadores.Text);
            }
            
           
        }
 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUsuarios.ReadOnly = true;
        }
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            dgvUsuarios.ReadOnly = true;
            limpiarcampos();
            gbUsuarios.Enabled = false;
            if (dgvUsuarios.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvUsuarios.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvUsuarios.Rows[selectedrowindex];

                idusuario = Convert.ToString(selectedRow.Cells["Id"].Value);
                nombreusuario = Convert.ToString(selectedRow.Cells["Nombre"].Value);
                apellidousuario = Convert.ToString(selectedRow.Cells["Apellido"].Value);
                usuario = Convert.ToString(selectedRow.Cells["Usuario"].Value);
                pass = Convert.ToString(selectedRow.Cells["Password"].Value);
                estatus = Convert.ToString(selectedRow.Cells["Estatus"].Value);
                permiso = Convert.ToString(selectedRow.Cells["Permiso"].Value);
                foto = Convert.ToString(selectedRow.Cells["Foto"].Value);

                if (foto!="")
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
        static IAmazonS3 client;
        Image img;
        private void GetFileFromS3()
        {
           

            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            var existingBucketName = "losbucaneros";
            var subDirectoryInBucket = "imgUsuarios";
            var client = Amazon.AWSClientFactory.CreateAmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);


            try
            {
                GetObjectResponse getObjRespone = client.GetObject("losbucaneros/imgUsuarios", foto);
                MemoryStream stream = new MemoryStream();
                getObjRespone.ResponseStream.CopyTo(stream);

               var  image = Image.FromStream(stream);
                img = image;
                pbfotousuario.Image = image;
            }
            catch (Exception)
            {

                MessageBox.Show("Error:200 Error al mostrar imagen de usuario", "Eror Fatal");
            }

           
           
        }
        private void DeleteFileFromS3()
        {
            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            var existingBucketName = "losbucaneros/imgUsuarios";
            // var subDirectoryInBucket = "imgUsuarios";
            var client = Amazon.AWSClientFactory.CreateAmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);

            if (error==0)
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

        private void cmbPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcont.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold);
            lblcont.Text = "Usuarios: " + dgvUsuarios.RowCount;
        }

        }
}
