using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
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
    public partial class FrmAmazonPhoto : Form
    {
        public FrmAmazonPhoto()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Archivo = new OpenFileDialog();
            DialogResult result = Archivo.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtpath.Text = Archivo.FileName;
            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            UploadFileToS3(txtpath.Text,"ResponsivasAdministrativos");
        }
        private void UploadFileToS3(string filePath, string subDirectoryInBucket)
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
    }
}
