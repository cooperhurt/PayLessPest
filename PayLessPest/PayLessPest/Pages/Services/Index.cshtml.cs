using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayLessPest
{
    public class IndexModel : PageModel
    {
        public string customerEmail;
        public string customerName;
        public string customerPhone;
        public string reason;
        public string userMessage;
        public string perferrContact;

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
            perferrContact = Request.Form["perferredContact"];

            userMessage += "\n\nPerferred Contact: " + perferrContact;

            if (reason == "na")
                reason = "General Inquiry";

            SendEmail emailSend = new SendEmail(customerName, customerEmail, userMessage, reason,"General", new DateTime(),customerPhone);
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