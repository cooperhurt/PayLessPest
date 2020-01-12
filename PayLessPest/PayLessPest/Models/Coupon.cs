using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayLessPest.Models
{
    public class Coupon
    {

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public double discountPercent { get; set; }
        public double amountOff { get; set; }
    }
}
