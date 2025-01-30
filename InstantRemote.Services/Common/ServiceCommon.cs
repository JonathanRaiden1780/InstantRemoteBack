using AutoMapper;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Services;
using InstantRemote.Core.Dtos.Common.Request;
using InstantRemote.Core.Dtos.Common.Response;
using System.Net.Mail;
using System.Net;

namespace InstantRemote.Services.Common
{
    public class ServiceCommon : BaseService, IServiceCommon
    {
        public ServiceCommon(IUnitOfWork UnitOfWork, Func<string, IServiceFactory> serviceFactory, IMapper mapper) : base(UnitOfWork, serviceFactory, mapper)
        {
        }

        public void SendMail(string toEmail, string subject, string htmlBody)
        {
            string smtpServer = "smtp.gmail.com"; 
            int smtpPort = 587; 
            string fromEmail = "jhuertavads@gmail.com"; 
            string fromPassword = "vhfz wzxq lbbl wcbs";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = htmlBody;
                mail.IsBodyHtml = true; 

                SmtpClient smtpClient = new SmtpClient(smtpServer)
                {
                    Port = smtpPort,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true 
                };

                smtpClient.Send(mail);
                Console.WriteLine("Correo enviado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al enviar correo: {ex.Message}");
            }
        }

    }
}
