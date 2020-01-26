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
            ant.ImagePath = "/img/bugs/ants/red-ant.jpg";
            Fact factAnt1 = new Fact();
            factAnt1.Title = "testf Title";
            ant.Facts.Add(factAnt1);
            ant.CommonlyFound.Add("Salt Lake City");
            bugs.Add(ant);

            Bug bedBug = new Bug();
            bedBug.Name = "Bed Bugs";
            bedBug.Descripition = "";
            bedBug.ImagePath = "/img/bugs/bedBugs/bedBug.jpg";
            bedBug.CommonlyFound.Add("Salt Lake City");
            bugs.Add(bedBug);

            Bug spiders = new Bug();
            spiders.Name = "Spiders";
            spiders.Descripition = "";
            spiders.ImagePath = "/img/bugs/spiders.jpg";
            spiders.CommonlyFound.Add("Salt Lake City");
            bugs.Add(spiders);

            Bug terminite = new Bug();
            terminite.Name = "Terminite";
            terminite.Descripition = "";
            terminite.ImagePath = "/img/bugs/terminite/terminite.jpg";
            terminite.CommonlyFound.Add("Salt Lake City");
            bugs.Add(terminite);

            Bug rodent = new Bug();
            rodent.Name = "Rodent";
            rodent.ImagePath = "/img/bugs/rodents/mouse.jpg";
            rodent.Descripition = "";
            rodent.CommonlyFound.Add("Salt Lake City");
            bugs.Add(rodent);

            Bug cockroach = new Bug();
            cockroach.Name = "Cockroaches";
            cockroach.Descripition = "";
            cockroach.ImagePath = "/img/bugs/cockroaches.jpg";
            cockroach.CommonlyFound.Add("Salt Lake City");
            bugs.Add(cockroach);

            Bug boxElderBug = new Bug();
            boxElderBug.Name = "Box Elder Bugs";
            boxElderBug.Descripition = "";
            boxElderBug.ImagePath = "/img/bugs/boxElder/box-elder-bugs.jpg";
            boxElderBug.CommonlyFound.Add("Salt Lake City");
            bugs.Add(boxElderBug);
        }
    }
}