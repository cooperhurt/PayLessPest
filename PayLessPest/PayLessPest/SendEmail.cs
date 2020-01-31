using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PayLessPest
{
    public class SendEmail
    {
        public string customerName;
        public string customerEmail;
        public string userMessage;
        public string emailTitle;
        public string serviceType;
        public DateTime serviceDate;

        public SendEmail(string customerName,string customerEmail,string userMessage,string emailTitle,string serviceType = "", DateTime? serviceDate= null)
        {

            string sendTitle = serviceType == "" ? customerName + " " + emailTitle : customerName + " " + serviceType + " " + serviceDate + " " + emailTitle;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.userMessage = userMessage;
            this.emailTitle = sendTitle;
            this.serviceType = serviceType;
            this.serviceDate = serviceDate ?? DateTime.MinValue;
        }

        public void send()
        {
            MailMessage message = new MailMessage(customerEmail, "setuprc1@gmail.com", emailTitle, userMessage);

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
