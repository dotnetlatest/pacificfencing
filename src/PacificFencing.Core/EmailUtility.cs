using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PacificFencing.Core
{
    public class EmailUtility
    {
        public static MailMessage CreateRequestAQuoteHtmlEmailMessage(RequestAQuoteModel model)
        {

            return new MailMessage
            {
                Body = new RequestAQuoteHtmlEmail(model).TransformText(),
                From = new MailAddress("info@pacificcleaning.com", "John Pacific", Encoding.UTF8),
                To = { new MailAddress(model.Email, model.ContactName) },
                BodyEncoding = Encoding.UTF8,
                Subject = "Pacific Cleaning Services",
                IsBodyHtml = true
            };
        }

        public static void SendEmail(RequestAQuoteModel model)
        {
            var message = CreateRequestAQuoteHtmlEmailMessage(model);
            SmtpClient client = new SmtpClient("localhost");
            client.Send(message);
        }
    }
}
