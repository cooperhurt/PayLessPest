using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayLessPest
{
    public class residentalModel : PageModel
    {
        public string customerEmail;
        public string customerName;
        public string customerPhone;
        public string reason;
        public string userMessage;
        public string perferredContact;

        public void OnGet()
        {

        }

        public void OnPost()
        {
            customerName = Request.Form["customerName"];
            customerEmail = Request.Form["customerEmail"];
            userMessage = Request.Form["message"];
            reason = Request.Form["subject"];
            perferredContact = Request.Form["perferredContact"];

            userMessage += "\n" + perferredContact;

            if (reason == "na")
                reason = "General Inquiry";

            SendEmail emailSend = new SendEmail(customerName, customerEmail, userMessage, reason);
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