using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayLessPest.Models
{
    public class Service
    {

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Price { get; set; }

        public List<string> features { get; set; }

        public string innerHTML { get; set; }
        public string headImage { get; set; }


    }
}
