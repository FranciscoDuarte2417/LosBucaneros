using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosBucanerosApp
{
    public partial class FrmAmazonPhoto : Form
    {
        string id, tipoempleado, operador, telefono, equipo, tiporesponsiva,total, descuento, descuentosemanal;
        public FrmAmazonPhoto(string Id, string Tipoempleado)
        {
            InitializeComponent();
            id = Id;
            tipoempleado = Tipoempleado;
            
        }
        ClsResponsivas objresponsiva = new ClsResponsivas();

        private SqlConnection conn;
        private SqlCommand comm;
        public DataTable dt;
        public SqlDataAdapter adp;
        ClsRutas objrutas = new ClsRutas();
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Archivo = new OpenFileDialog();
                DialogResult result = Archivo.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtpath.Text = Archivo.FileName;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo problemas con el archivo");
            }
            
        }

        public string preciosim()
        {
            //cuando esta disponible
            string precio = "";
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spPrecioSim]", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;


                //
                adp = new SqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);


            }
            catch (Exception)
            {

                throw;
            }

            foreach (DataRow row in dt.Rows)
            {
                precio = row[0].ToString();
            }

            // dgvReponsivas.Columns.Add(DataGridViewImageCell dat);

            return precio;
        }

        public void DetallesCorreo()
        {
            try
            { //establecer parametros de conexion
                conn = new SqlConnection(objrutas.connstring);
                //abrir conexion con parametros previamente asignados
                conn.Open();
                //asignar comando de sql
                comm = new SqlCommand("[spCorreoResponsiva]", conn);
                //asignar conexion al comando
                comm.Connection = conn;
                //
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@tipoempleado", tipoempleado);


                //
                adp = new SqlDataAdapter(comm);
                dt = new DataTable();
                adp.Fill(dt);


            }
            catch (Exception)
            {

                throw;
            }

            foreach (DataRow row in dt.Rows)
            {
                id = row[0].ToString();
                tipoempleado = row[1].ToString();
                operador = row[2].ToString(); 
                telefono = row[3].ToString();
                equipo = row[4].ToString();
                tiporesponsiva = row[5].ToString();
                total = row[7].ToString();
                if (tiporesponsiva != "PRESTAMO")
                {
                    descuento = row[6].ToString();
                    descuentosemanal = (Convert.ToDouble(row[7].ToString()) / Convert.ToDouble(row[6].ToString())).ToString();
                }
                else
                {
                    descuento = "0";
                    descuentosemanal = "0";
                    
                }
                


            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            if (tipoempleado == "Operador")
            {
                UploadFileToS3(txtpath.Text, "ResponsivasOperadores");
            }
            else
            {
                UploadFileToS3(txtpath.Text, "ResponsivasAdministrativos");
            }
            DetallesCorreo();
            if (tiporesponsiva == "SIM")
            {
                objrutas.EnviarCorreo(id, tipoempleado, operador, telefono, equipo, tiporesponsiva, preciosim(), DateTime.Now.ToShortDateString(), descuento, descuentosemanal, txtpath.Text);
            }
            else
            {
                objrutas.EnviarCorreo(id, tipoempleado, operador, telefono, equipo, tiporesponsiva, total, DateTime.Now.ToShortDateString(), descuento, descuentosemanal, txtpath.Text);
            }
            MessageBox.Show("Archivo enviado con Exito","Finalizado",MessageBoxButtons.OK);

        }
        private void UploadFileToS3(string filePath, string subDirectoryInBucket)
        {
            string nuevaruta = @"C:\Users\Administrador\Desktop\" + id + ".pdf";
            System.IO.File.Copy(txtpath.Text, nuevaruta);
            var awsAccessKey = "AKIAI5KHC3XKCDKYP3NQ";
            var awsSecretKey = "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";
            var existingBucketName = "losbucaneros";
            var client = Amazon.AWSClientFactory.CreateAmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);

            var uploadRequest = new TransferUtilityUploadRequest
            {
                FilePath = filePath,
                BucketName = existingBucketName,
                CannedACL = S3CannedACL.PublicRead
            };

            var fileTransferUtility = new TransferUtility(client);
            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
            if (subDirectoryInBucket == "" || subDirectoryInBucket == null)
            {
                request.BucketName = existingBucketName; //no subdirectory just bucket name
            }
            else
            {   // subdirectory and bucket name
                request.BucketName = existingBucketName + @"/" + subDirectoryInBucket;
            }
            //request.Key = fileNameInS3; //file name up in S3
            request.FilePath = nuevaruta; //local file name
            fileTransferUtility.Upload(request); //commensing the transfer
            System.IO.File.Delete(nuevaruta);
            //  fileTransferUtility.Upload(uploadRequest);
        }
    }
}
