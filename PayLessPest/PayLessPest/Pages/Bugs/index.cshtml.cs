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
        public Bug currentBug;

        public void OnGet(string bug)
        {
            bugs = new List<Bug>();

            generateBugList();
            if(bug != null)
            {
                currentBug = bugs.Find(item => item.Name == bug);
            }
        }

        public void generateBugList()
        {
            Bug ant = new Bug();
            ant.Name = "Ant";
            ant.Descripition = "";
            Fact factAnt1 = new Fact();
            factAnt1.Title = "testf Title";
            ant.Facts.Add(factAnt1);
            ant.CommonlyFound.Add("Salt Lake City");
            bugs.Add(ant);

            Bug bedBug = new Bug();
            bedBug.Name = "Bed Bugs";
            bedBug.Descripition = "";
            bedBug.CommonlyFound.Add("Salt Lake City");

            Bug spiders = new Bug();
            spiders.Name = "Spiders";
            spiders.Descripition = "";
            spiders.CommonlyFound.Add("Salt Lake City");

            Bug terminite = new Bug();
            terminite.Name = "Terminite";
            terminite.Descripition = "";
            terminite.CommonlyFound.Add("Salt Lake City");

            Bug rodent = new Bug();
            rodent.Name = "Rodent";
            rodent.Descripition = "";
            rodent.CommonlyFound.Add("Salt Lake City");

            Bug cockroach = new Bug();
            cockroach.Name = "Cockroaches";
            cockroach.Descripition = "";
            cockroach.CommonlyFound.Add("Salt Lake City");

            Bug boxElderBug = new Bug();
            boxElderBug.Name = "Box Elder Bugs";
            boxElderBug.Descripition = "";
            boxElderBug.CommonlyFound.Add("Salt Lake City");


        }
    }
}