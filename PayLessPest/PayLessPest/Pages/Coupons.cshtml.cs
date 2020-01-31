using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayLessPest.Models;

namespace PayLessPest
{
    public class CouponsModel : PageModel
    {
        public List<Promotion> Promotions = new List<Promotion>();

        public void OnGet()
        {
            Promotions = getPromotion();
        }

        private List<Promotion> getPromotion()
        {
            List<Promotion> list = new List<Promotion>();

            Promotion one = new Promotion();
            one.Title = "$75 Outdoor spray";
            one.Image = "/img/promotions/spray.jpg";
            one.details = "3500 Square feet limit, residental only.";
            list.Add(one);

            Promotion two = new Promotion();
            two.Title = "Free Pest Control Quote";
            two.Image = "/img/promotions/spray.jpg";
            two.details = "Any time, any day! We provide free quotes.";
            list.Add(two);

            return list;
        }
    }
}