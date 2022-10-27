using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OcaGameLogic
{
    public class SendEmail
    {

        public int send(string receiver)
        {

            Random random = new Random();
            int number = random.Next(1000, 100000);
            MailMessage message = new MailMessage();
            message.To.Add(receiver);
            message.Subject = "Correo de verificacion";
            message.SubjectEncoding = Encoding.UTF8;
            message.Body = "El codigo de verificacion para el cambio de contraseña es: " + number + " regrese al juego e ingreselo";
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            message.From = new MailAddress("OcaGameServices@hotmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("OcaGameServices@hotmail.com", "Ocagameadmin$");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Host = "smtp.office365.com";
            try
            {
                smtp.Send(message);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede enviar el correo de verificacion, revise el correo ingresado");
                number = 0;
            }

            return number;
        }
    }
}
