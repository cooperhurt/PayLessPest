using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PayLessPest
{
    public class AreaModel : PageModel
    {
        public string customerEmail;
        public string customerName;
        public string customerPhone;
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
                reason = "General Inquiry";

            SendEmail emailSend = new SendEmail(customerName, customerEmail, userMessage, reason,"",new DateTime(),"");
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