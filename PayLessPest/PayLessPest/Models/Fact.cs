using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayLessPest.Models
{
    public class Fact
    {
        [Key]
        public int id { get; set; }

        public string Title { get; set; }

        public string Info { get; set; }

        public string ImagePath { get; set; }
    }
}
