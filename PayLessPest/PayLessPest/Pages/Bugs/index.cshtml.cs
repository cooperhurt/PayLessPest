using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PayLessPest.Models;

namespace PayLessPest
{
    public class indexModel : PageModel
    {

        public List<Bug> bugs;

        public void OnGet(string bug)
        {
            generateBugList();


        }

        public void generateBugList()
        {
            Bug ant = new Bug();
            ant.Name = "Ant Pest Control";
            ant.

            Bug bedBug = new Bug();
            Bug spiders = new Bug();
            Bug terminite = new Bug();
            Bug rodent = new Bug();
            Bug cockroach = new Bug();
            Bug boxElderBug = new Bug();


        }
    }
}