using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Biblioteca.Util
{
    class Email
    {
        public static bool Enviar(String email, String assunto, String texto)
        {
            try
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com", 25); 
                   
                NetworkCredential cred = new NetworkCredential("darkreadbiblioteca2022@gmail.com", "obaferisstwbljhe");

                MailMessage Msg = new MailMessage();


                Msg.From = new MailAddress("darkreadbiblioteca2022@gmail.com");
                Msg.To.Add(email);
                Msg.Subject = assunto;
                Msg.Body = texto;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
