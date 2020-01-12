using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayLessPest
{
    public class ContactModel : PageModel
    {

        public string customerEmail;
        public string customerName;
        public string reason;
        public string userMessage;
        public void OnGet()
        {

        }

        public void OnPost()
        {
            customerName = Request.Form["customerName"];
            customerEmail = Request.Form["customerEmail"];
            userMessage = Request.Form["message"];
            reason = Request.Form["subject"];

            if (reason == "na")
                reason = "general inquiry";

            MailMessage message = new MailMessage(customerEmail, "setuprc1@gmail.com",customerName + " " + reason,userMessage);

            SmtpClient client = new SmtpClient();

            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new NetworkCredential("setuprc1@gmail.com", "567A;59AJh");


            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }

    }
}