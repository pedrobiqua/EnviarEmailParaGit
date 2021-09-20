using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace EnviarEmailParaGit
{
    public class EnviaEmail
    {
        public static void EnviarEmail(String mailDestino)
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential("email smtp", "senha");
                        smtp.Port = 587; // porta padrão
                        smtp.EnableSsl = true; // essa opção tem q ser true pois o gmail tem um certificado ssl

                        //Mensagem e remetente e destinatario
                        email.From = new MailAddress("email");
                        email.To.Add(mailDestino);

                        email.Subject = "Estudando C#";
                        email.IsBodyHtml = false;
                        email.Body = "Estudo de c# enviando um e-mail com um codigo meu";

                        //Enviar o email
                        smtp.Send(email);
                    }
                }
                Console.WriteLine("E-mail enviado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}