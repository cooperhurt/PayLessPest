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
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Descripition { get; set; }

        public List<string> CommonlyFound { get; set; }
        public List<string> tags { get; set; }

        public List<Fact> Facts { get; set; }



    }
}
