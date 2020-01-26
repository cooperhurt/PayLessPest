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
        public string reason;
        public string userMessage;

        public void OnGet()
        {

        }
    }
}