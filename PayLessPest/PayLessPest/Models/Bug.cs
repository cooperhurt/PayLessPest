using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayLessPest.Models
{
    public class Bug
    {
        public Bug()
        {
            Facts = new List<Fact>();
            tags = new List<string>();
            CommonlyFound = new List<string>();
            subType = new List<Bug>();
            FAQs = new List<FAQ>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string shortDescription { get; set; }
        public string Descripition { get; set; }
        public string ImagePath { get; set; }
        public string headerImage { get; set; }
        public string meta { get; set; }
        public string innerText { get; set; }
        public List<string> CommonlyFound { get; set; }
        public List<string> tags { get; set; }

        public List<Fact> Facts { get; set; }

        public List<Bug> subType { get; set; }

        public List<FAQ> FAQs { get; set; }
    }
}
