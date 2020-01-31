using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayLessPest.Models
{
    public class FAQ
    {

        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Video { get; set; }
        public string Img { get; set; }
    }
}
