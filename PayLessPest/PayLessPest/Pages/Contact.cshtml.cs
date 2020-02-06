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
        public string customerPhone;
        public string perferred;
        public void OnGet()
        {

        }

        public void OnPost()
        {
            customerName = Request.Form["name"];
            customerEmail = Request.Form["email"];
            userMessage = Request.Form["message"];
            reason = Request.Form["subject"];
            customerPhone = Request.Form["phone"];
            perferred = Request.Form["perferredContact"];

            if (reason == "na")
                reason = "General Inquiry";

            userMessage += "\n\nPerferred Contact: " + perferred;

            SendEmail emailSend = new SendEmail(customerName, customerEmail, userMessage, reason,"General",new DateTime(), customerPhone);
            try
            {
                emailSend.send();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }

    }
}