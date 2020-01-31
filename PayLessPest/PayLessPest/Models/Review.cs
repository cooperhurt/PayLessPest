using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayLessPest.Models
{
    public class Review
    {
        public int id { get; set; }

        public string Source { get; set; }

        public string Name { get; set; }
        public string ReviewText { get; set; }
        public string Image { get; set; }
    }
}
