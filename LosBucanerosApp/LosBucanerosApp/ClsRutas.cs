using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;



namespace LosBucanerosApp
{
    class ClsRutas
    {
        public string connstring = "Server=losbucaneros.clkm3ykxjjdd.us-east-1.rds.amazonaws.com;Database=DBLosBucaneros;User ID=sa;Password=LosBucaneros2018;";
        public string msj;
        private SqlConnection conn;
      //  private SqlCommand comm;

        public void TestOpenConnect()
        {
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                msj = "1";
                conn.Close();


            }
            catch (Exception ex)
            {

                msj = "0";
            }
           
        
        }

        public void CorreoCancelacion(string Id,string Idresponsiva,string Tipodescuento,string TotalDescuento,string Fecha,string Comentarios)
        {
            MailMessage mail;
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            string htmlBody="";
            mail = new MailMessage();
            mail.From = new MailAddress("losbucanerossistemas@gmail.com");
            mail.To.Add("sistemas@losbucaneros.com");
            mail.IsBodyHtml = true;
            htmlBody = "<html><head><meta charset='utf-8'><title>Untitled Document</title></head><body><img src='http://losbucaneros.com/app/images/Logo.png' width='200' height='150'</p><p><strong>Descuento correspondiente a la baja de una responsiva</strong></p><table width='789' border='1'><tbody><tr><td width='128'>Id</td><tr><td width='128'>Id Responsiva</td><td width='101'>Tipo de Descuento</td><td width='87'>Cantidad de descuento</td><td width='82'>Fecha</td><td width='70'>Comentario</td></tr><tr><td>" + Id + "</td><td>" + Idresponsiva + "</td><td>" + Tipodescuento + "</td><td>" + TotalDescuento + "</td></tr></tbody></table></body></html>";
            mail.Subject = "Descuento por equipo celular";
            mail.Body = htmlBody;
       

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("losbucanerossistemas@gmail.com", "LosBucaneros2018");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }


        public void EnviarCorreo(string idresponsiva, string tipoempleado, string nombre, string linea, string equipo, string tiporesponsiva, string total, string fecha,string descuento,string descuentosemanal,string pathdocument)
        {
            try
            {
                MailMessage mail;
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                string htmlBody;


                if (tiporesponsiva == "PRESTAMO")
                {
                    mail = new MailMessage();
                    mail.From = new MailAddress("losbucanerossistemas@gmail.com");
                    mail.To.Add("responsivasprestamos@stratorgroup.com");
                    mail.IsBodyHtml = true;
                    htmlBody = "<html><head><meta charset='utf-8'><title>Untitled Document</title></head><body><img src='http://losbucaneros.com/app/images/Logo.png' width='200' height='150'</p><p><strong>Responsiva por equipo celular</strong></p><table width='789' border='1'><tbody><tr><td width='128'>Id Responsiva</td><td width='101'>Tipo Empleado</td><td width='87'>Nombre</td><td width='82'>Linea</td><td width='70'>Equipo</td><td width='145'>Tipo Responsiva</td><td width='53'>Total</td><td width='71'>Fecha</td></tr><tr><td>" + idresponsiva + "</td><td>" + tipoempleado + "</td><td>" + nombre + "</td><td>" + linea + "</td><td>" + equipo + "</td><td>" + tiporesponsiva + "</td><td>" + total + "</td><td>" + fecha + "</td></tr></tbody></table></body></html>";
                    mail.Subject = "Responsiva por equipo celular";
                    mail.Body = htmlBody;
                    System.Net.Mail.Attachment adjunto;
                    adjunto = new System.Net.Mail.Attachment(pathdocument);
                    mail.Attachments.Add(adjunto);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("losbucanerossistemas@gmail.com", "LosBucaneros2018");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                else if (tiporesponsiva == "DESCUENTO")
                {
                    mail = new MailMessage();
                    mail.From = new MailAddress("losbucanerossistemas@gmail.com");
                    mail.To.Add("responsivasdescuentos@stratorgroup.com");
                    mail.IsBodyHtml = true;
                    htmlBody = "<html><head><meta charset='utf-8'><title>Untitled Document</title></head><body><img src='http://losbucaneros.com/app/images/Logo.png' width='200' height='150'</p><p><strong>Responsiva por equipo celular</strong></p><table width='789' border='1'><tbody><tr><td width='128'>Id Responsiva</td><td width='101'>Tipo Empleado</td><td width='87'>Nombre</td><td width='82'>Linea</td><td width='70'>Equipo</td><td width='145'>Tipo Responsiva</td><td width='53'>Total</td><td width='101'>Descuento</td><td width='101'>Descuento Semanal</td><td width='71'>Fecha</td></tr><tr><td>" + idresponsiva + "</td><td>" + tipoempleado + "</td><td>" + nombre + "</td><td>" + linea + "</td><td>" + equipo + "</td><td>" + tiporesponsiva + "</td><td>" + total + "</td><td>" + descuento + "</td><td>" + descuentosemanal + "</td><td>" + fecha + "</td></tr></tbody></table></body></html>";
                    mail.Subject = "Responsiva por equipo celular";
                    mail.Body = htmlBody;
                    System.Net.Mail.Attachment adjunto;
                    adjunto = new System.Net.Mail.Attachment(pathdocument);
                    mail.Attachments.Add(adjunto);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("losbucanerossistemas@gmail.com", "LosBucaneros2018");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                else
                {
                    mail = new MailMessage();
                    mail.From = new MailAddress("losbucanerossistemas@gmail.com");
                    mail.To.Add("responsivasprestamos@stratorgroup.com");
                    mail.IsBodyHtml = true;
                    htmlBody = "<html><head><meta charset='utf-8'><title>Untitled Document</title></head><body><img src='http://losbucaneros.com/app/images/Logo.png' width='200' height='150'</p><p><strong>Responsiva por tarjeta sim</strong></p><table width='789' border='1'><tbody><tr><td width='128'>Id Responsiva</td><td width='101'>Tipo Empleado</td><td width='87'>Nombre</td><td width='82'>Linea</td><td width='145'>Tipo Responsiva</td><td width='53'>Total</td><td width='71'>Fecha</td></tr><tr><td>" + idresponsiva + "</td><td>" + tipoempleado + "</td><td>" + nombre + "</td><td>" + linea + "</td><td>" + tiporesponsiva + "</td><td>" + total + "</td><td>" + fecha + "</td></tr></tbody></table></body></html>";
                    mail.Subject = "Responsiva por tarjeta SIM";
                    mail.Body = htmlBody;
                    System.Net.Mail.Attachment adjunto;
                    adjunto = new System.Net.Mail.Attachment(pathdocument);
                    mail.Attachments.Add(adjunto);

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("losbucanerossistemas@gmail.com", "LosBucaneros2018");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }

                if (tipoempleado == "Operador")
                {
                    mail = new MailMessage();
                    mail.From = new MailAddress("losbucanerossistemas@gmail.com");
                    mail.To.Add("monitoreo1@losbucaneros.com");
                    mail.IsBodyHtml = true;
                    htmlBody = "<html><head><meta charset='utf-8'><title>Untitled Document</title></head><body><img src='http://losbucaneros.com/app/images/Logo.png' width='200' height='150'</p><p><strong>Responsiva por tarjeta sim</strong></p><table width='789' border='1'><tbody><tr><td width='128'>Id Responsiva</td><td width='101'>Tipo Empleado</td><td width='87'>Nombre</td><td width='82'>Linea</td></tr><tr><td>" + idresponsiva + "</td><td>" + tipoempleado + "</td><td>" + nombre + "</td><td>" + linea + "</td></tr></tbody></table></body></html>";
                    mail.Subject = "Responsiva por tarjeta SIM";
                    mail.Body = htmlBody;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("losbucanerossistemas@gmail.com", "LosBucaneros2018");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}