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

            #region Ant Region
            Bug ant = new Bug();
            ant.Name = "Ant";
            ant.shortDescription = "There are many types of ants in Utah including carpeneter, pavement, and many more. Click to read more.";
            ant.Descripition = "Found throughout Utah.";
            ant.ImagePath = "/img/bugs/ants/red-ant.jpg";
            ant.CommonlyFound.Add("Ogden");
            ant.CommonlyFound.Add("Layton");
            ant.CommonlyFound.Add("Bountiful");
            ant.CommonlyFound.Add("Salt Lake City");
            ant.CommonlyFound.Add("Provo");
            ant.CommonlyFound.Add("West Valley City");
            ant.headerImage = "/img/bugs/ants/header.jpg";

            Bug carpenter = new Bug();
            carpenter.Name = "Carpeneter Ants";
            carpenter.ImagePath = "/img/bugs/ants/carpenter.jpg";
            carpenter.innerText = "Arguablly one the most commony type of ants in utah, and can reach up to 1'' in length. These ants are easily identified by the black or redish skin color. " +
                                  "The queen also has the ability to grow wings and fly. Typically these are feed off sugar or protein, making these ants found indoors and outdoors. These are easily" +
                                  " treatable, contact us below and we can come out and evulate your situation.";
            ant.subType.Add(carpenter);

            Bug harvester = new Bug();
            harvester.Name = "Velvety Tree Ants";
            harvester.ImagePath = "/img/bugs/ants/velvety.jpg";
            harvester.innerText = "Arguablly one the most commony type of ants in utah, and can reach up to 1'' in length. These ants are easily identified by the black or redish skin color. " +
                                  "The queen also has the ability to grow wings and fly. Typically these are feed off sugar or protein, making these ants found indoors and outdoors. These are easily" +
                                  " treatable, contact us below and we can come out and evulate your situation.";
            ant.subType.Add(harvester);

            Bug pavement = new Bug();
            pavement.Name = "Pavement Ants";
            pavement.ImagePath = "/img/bugs/ants/pavement.jpg";
            pavement.innerText = "Arguablly one the most commony type of ants in utah, and can reach up to 1'' in length. These ants are easily identified by the black or redish skin color. " +
                                  "The queen also has the ability to grow wings and fly. Typically these are feed off sugar or protein, making these ants found indoors and outdoors. These are easily" +
                                  " treatable, contact us below and we can come out and evulate your situation.";
            ant.subType.Add(pavement);

            bugs.Add(ant);
            #endregion

            #region Bed Bug
            Bug bedBug = new Bug();
            bedBug.Name = "Bed Bugs";
            bedBug.Descripition = "Not many preventable measures, but possible to remove.";
            bedBug.headerImage = "/img/bugs/bedBugs/header.jpg";
            bedBug.ImagePath = "/img/bugs/bedBugs/bedBug.jpg";
            bedBug.CommonlyFound.Add("Ogden");
            bedBug.CommonlyFound.Add("Layton");
            bedBug.CommonlyFound.Add("Bountiful");
            bedBug.CommonlyFound.Add("Salt Lake City");
            bedBug.CommonlyFound.Add("Provo");
            bedBug.CommonlyFound.Add("West Valley City");
            bedBug.CommonlyFound.Add("Throughout Utah");

            Bug bedBugI = new Bug();
            bedBugI.Name = "Bed Bug";
            bedBugI.ImagePath = "/img/bugs/bedBugs/bedBug.jpg";
            bedBugI.innerText = "Bed bugs typically aren't just introduced randomly. Typically the cause of bed bugs is typically through a medium like hotel, or a guest from their house." +
                                " Bed bugs are very difficult to be removed, while many may try themselves they typically end up calling a professional like ourselves. Smoke bombs do not typically " +
                                "work because they spread throughout the whole house.";

            bedBug.subType.Add(bedBugI);

            bugs.Add(bedBug);
            #endregion


            #region Spiders
            Bug spiders = new Bug();
            spiders.Name = "Spiders";
            spiders.Descripition = "";
            spiders.headerImage = "/img/bugs/spiderHeader.jpg";
            spiders.ImagePath = "/img/bugs/spiders.jpg";
            spiders.CommonlyFound.Add("Salt Lake City");
            spiders.CommonlyFound.Add("Ogden");
            spiders.CommonlyFound.Add("Layton");
            spiders.CommonlyFound.Add("Bountiful");
            spiders.CommonlyFound.Add("Salt Lake City");
            spiders.CommonlyFound.Add("Provo");
            spiders.CommonlyFound.Add("West Valley City");

            Bug subSpider = new Bug();

            subSpider.Name = "Yellow Sac Spider";
            subSpider.ImagePath = "/img/yellowSac.jpg";
            subSpider.innerText = "Is it a Yellow Sac or Brown Recluse? More often then not you are dealing with a Yellow Sac since they are more prominent. Commonly found in firewood,  eaves, walls, or window frames. " +
                                    " As with most spiders the light color does mean there is venom. Yellow Sac bites are typically identified with redness, itching, sweeling but can also be accomindated with fever dizziniess, and headaches.";
            spiders.subType.Add(subSpider);

            bugs.Add(spiders);
            #endregion

            #region termite
            Bug terminite = new Bug();
            terminite.Name = "Terminite";
            terminite.Descripition = "";
            terminite.ImagePath = "/img/bugs/terminite/terminite.jpg";
            terminite.CommonlyFound.Add("Salt Lake City");
            bugs.Add(terminite);
            #endregion

            #region Rodent
            Bug rodent = new Bug();
            rodent.Name = "Rodent";
            rodent.ImagePath = "/img/bugs/rodents/mouse.jpg";
            rodent.Descripition = "";
            rodent.CommonlyFound.Add("Salt Lake City");
            bugs.Add(rodent);
            #endregion

            #region cockroach
            Bug cockroach = new Bug();
            cockroach.Name = "Cockroaches";
            cockroach.Descripition = "";
            cockroach.ImagePath = "/img/bugs/cockroaches.jpg";
            cockroach.CommonlyFound.Add("Salt Lake City");
            bugs.Add(cockroach);

            #endregion

            #region
            Bug boxElderBug = new Bug();
            boxElderBug.Name = "Box Elder Bugs";
            boxElderBug.Descripition = "";
            boxElderBug.ImagePath = "/img/bugs/boxElder/box-elder-bugs.jpg";
            boxElderBug.CommonlyFound.Add("Salt Lake City");
            bugs.Add(boxElderBug);
            #endregion
        }
    }
}