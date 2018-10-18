using System;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.S3.Model;
using System.IO;

namespace LosBucanerosApp
{
    public partial class FrmFoto : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        //Amazon
       

        private void UploadFileToS3(string filePath,string subDirectoryInBucket)
        {
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
            request.FilePath = filePath; //local file name
            fileTransferUtility.Upload(request); //commensing the transfer

            //  fileTransferUtility.Upload(uploadRequest);
        }


        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                comboBox1.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);
                }
                comboBox1.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                comboBox1.Items.Add("No se encontraron Camaras Web");
            }
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            //do processing here
            //pictureBox1.Image = img;
            pictureBox1.BackgroundImage = img;

        }
        private void CloseVideoSource()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }
        string NombreFoto;
        string RutaFotoAmazom;
        public FrmFoto(string nombrefoto, string rutafotoamazon)
        {
            InitializeComponent();
            NombreFoto = nombrefoto;
            RutaFotoAmazom = rutafotoamazon;
        }

        private void FrmFoto_Load(object sender, EventArgs e)
        {
            ClsUsuarios.existe = 0;
            ClsCoordinadores.existe = 0;
            getCamList();
        }

        private void btnRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            getCamList();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeviceExist)
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                CloseVideoSource();
                videoSource.DesiredFrameSize = new Size(160, 120);
                videoSource.DesiredFrameRate = 10;
                videoSource.Start();
                
            }
            else
            {
               MessageBox.Show("Conecte una WebCam e intente de nuevo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsUsuarios.existe = 0;
            ClsCoordinadores.existe = 0;
            ClsOperadores.existe = 0;
            ClsAdministrativos.existe = 0;
            ClsAlmacenEquipos.existe = 0;

            CloseVideoSource();
            DialogResult res = MessageBox.Show("Desea guardar la imagen?: ", "Confirmacion de foto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {

                string ruta = "C:\\Temporal\\Operadores";
                string rutafoto = "C:\\Temporal\\Operadores\\" + NombreFoto + ".jpg";

                if (Directory.Exists(ruta))
                {
                    pictureBox1.BackgroundImage.Save(rutafoto, ImageFormat.Jpeg);
                    UploadFileToS3(rutafoto, RutaFotoAmazom);
                    ClsUsuarios.existe = 1;
                    ClsCoordinadores.existe = 1;
                    ClsOperadores.existe = 1;
                    ClsAdministrativos.existe = 1;
                    ClsAlmacenEquipos.existe = 1;
                    ClsUsuarios.fotoruta = NombreFoto + ".jpg";
                    ClsCoordinadores.fotoruta = NombreFoto + ".jpg";
                    ClsOperadores.fotoruta = NombreFoto + ".jpg";
                    ClsAdministrativos.fotoruta = NombreFoto + ".jpg";
                    ClsAlmacenEquipos.fotoruta = NombreFoto + ".jpg";
                    this.Close();
                }
                else
                {
                    Directory.CreateDirectory(ruta);

                    pictureBox1.BackgroundImage.Save(rutafoto, ImageFormat.Jpeg);
                    UploadFileToS3(rutafoto, RutaFotoAmazom);

                    ClsUsuarios.existe = 1;
                    ClsCoordinadores.existe = 1;
                    ClsOperadores.existe = 1;
                    ClsAdministrativos.existe = 1;
                    ClsAlmacenEquipos.existe = 1;

                   

                    ClsUsuarios.fotoruta = ruta;
                    ClsCoordinadores.fotoruta = ruta;
                    ClsOperadores.fotoruta = ruta;
                    ClsAdministrativos.fotoruta = ruta;
                    ClsAlmacenEquipos.fotoruta = ruta;
                    this.Close();

                }

                          
            }
            if (res == DialogResult.Cancel)
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    CloseVideoSource();
                    videoSource.DesiredFrameSize = new Size(1000, 750);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                }
                else
                {
                    MessageBox.Show("Conecte una WebCam e intente de nuevo");
                }
            }
        }
    }
}
