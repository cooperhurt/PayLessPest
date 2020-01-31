using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayLessPest.Models;

namespace PayLessPest
{
    public class businessModel : PageModel
    {
        public Service currentService;
        public string customerEmail;
        public string customerName;
        public string customerPhone;
        public string reason;
        public string userMessage;
        public void OnGet()
        {
            currentService = new Service();
            currentService.Title = "Business Pest Control";
            currentService.headImage = "/img/banner/business.jpg";
        }

        public void OnPost()
        {
            customerName = Request.Form["customerName"];
            customerEmail = Request.Form["customerEmail"];
            userMessage = Request.Form["message"];
            reason = Request.Form["subject"];

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