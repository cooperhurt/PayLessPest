using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayLessPest
{
    public class DomesticModel : PageModel
    {
        public string customerEmail;
        public string customerName;
        public string customerPhone;
        public string perferred;
        public string reason;
        public string userMessage;

        public void OnGet()
        {

        }

        public void OnPost()
        {
            customerName = Request.Form["customerName"];
            customerEmail = Request.Form["customerEmail"];
            customerPhone = Request.Form["phone"];
            userMessage = Request.Form["message"];
            reason = Request.Form["subject"];
            perferred = Request.Form["perferredContact"];

            userMessage += "\nPerferred Contact: " + perferred;

            if (reason == "na")
                reason = "General Inquiry";

            SendEmail emailSend = new SendEmail(customerName, customerEmail, userMessage, reason,"Domestic", new DateTime(),customerPhone);
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