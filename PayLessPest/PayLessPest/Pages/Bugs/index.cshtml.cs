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
        public string customerEmail;
        public string customerName;
        public string customerPhone;
        public string reason;
        public string userMessage;
        public string perferredContact;
        public string metaDesc;
        public string phoneNumber;
        public string bug;
        public List<Bug> bugs;
        public Bug currentBug;

        public void OnGet(string bug)
        {
            bugs = new List<Bug>();

            generateBugList();
            if (bug != null)
            {
                currentBug = bugs.Find(item => item.Name == bug);

                metaDesc = currentBug == null ? metaDesc = "We offer pest control services for all of the common bugs in Utah including Bed Bugs, Box Elder Bugs, Ants, Termites, Rodents, bettles, or anything else you may have. Call, email or chat with us today." : currentBug.meta;
            }
            else
            {
                metaDesc = "We offer pest control services for all of the common bugs in Utah including Bed Bugs, Box Elder Bugs, Ants, Termites, Rodents, bettles, or anything else you may have. Call, email or chat with us today.";
            }
        }

        public IActionResult OnPost()
        {
            customerName = Request.Form["name"];
            customerEmail = Request.Form["email"];
            userMessage = Request.Form["message"];
            reason = Request.Form["subject"];
            perferredContact = Request.Form["perferredContact"];
            phoneNumber = Request.Form["phone"];
            bug = Request.Form["bug"];

            userMessage += "\n\nPerferred Contact: " + perferredContact;


            if (reason == "na")
                reason = "General Inquiry";

            SendEmail emailSend = new SendEmail(customerName, customerEmail, userMessage, reason,"", new DateTime(),phoneNumber);
            try
            {
                emailSend.send();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
            return bug == null ? Redirect("/bugs") : Redirect("/bugs?bug="+bug);
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
            ant.meta = "Utah ants come in many different species, so know which type is important step to elminate your pest control service. Rather it be from carpenter ants, velvety ants paventment ants, or any other kind of ant we cover it. Call, email, or chat with us today.";

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
            bedBug.meta = "Bed bugs are commony in 1 in 5 houses in Utah, yet one of the more difficult things to extermite DYI. Our professional services can help eliminate your bed bug problem. Call, email, or chat with us today.";

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
            spiders.meta = "Utah is home to over 600 species of spiders, and some are dangerous some aren't. Our pest control services can help solve or prevent your spider problem at your home or business. Call, email, or chat today.";

            Bug subSpider = new Bug();

            subSpider.Name = "Yellow Sac Spider";
            subSpider.ImagePath = "/img/yellowSac.jpg";
            subSpider.innerText = "Is it a Yellow Sac or Brown Recluse? More often then not you are dealing with a Yellow Sac since they are more prominent. Commonly found in firewood,  eaves, walls, or window frames. " +
                                    " As with most spiders the light color does mean there is venom. Yellow Sac bites are typically identified with redness, itching, sweeling but can also be accomindated with fever dizziniess, and headaches.";
            spiders.subType.Add(subSpider);

            bugs.Add(spiders);
            #endregion

            #region Termites
            Bug terminite = new Bug();
            terminite.Name = "Termites";
            terminite.Descripition = "";
            terminite.headerImage = "/img/bugs/terminite/header.jpg";
            terminite.ImagePath = "/img/bugs/terminite/terminite.jpg";
            terminite.CommonlyFound.Add("Salt Lake City");
            terminite.CommonlyFound.Add("Ogden");
            terminite.CommonlyFound.Add("Layton");
            terminite.CommonlyFound.Add("Bountiful");
            terminite.CommonlyFound.Add("Salt Lake City");
            terminite.CommonlyFound.Add("Provo");
            terminite.CommonlyFound.Add("West Valley City");
            terminite.meta = "Termites can be very harmful not to you but your house. If you have termites you should not put it off. Our competitive pricing can help solve your termitie pest control problem. Call, email, or chat with ust today!";

            Bug terminite1 = new Bug();
            terminite1.Name = "Termite";
            terminite1.innerText = "These are one of the few pest you cannot put off, the sooner you treat the termites, the smaller damage to your property. It is estimate 1 out of every 5 " +
                                    " houses have termites, and 20% will have them at some point. Treating them yourself is possible, difficult and ";
            terminite1.ImagePath = "/img/bugs/terminite/terminite.jpg";

            terminite.subType.Add(terminite1);

            bugs.Add(terminite);
            #endregion

            #region Rodent
            Bug rodent = new Bug();
            rodent.Name = "Rodent";
            rodent.ImagePath = "/img/bugs/rodents/mouse.jpg";
            rodent.headerImage = "/img/bugs/rodents/header.jpg";
            rodent.Descripition = "";
            rodent.CommonlyFound.Add("Salt Lake City");
            rodent.CommonlyFound.Add("Ogden");
            rodent.CommonlyFound.Add("Layton");
            rodent.CommonlyFound.Add("Bountiful");
            rodent.CommonlyFound.Add("Salt Lake City");
            rodent.CommonlyFound.Add("Provo");
            rodent.CommonlyFound.Add("West Valley City");
            rodent.meta = "Utah mouse and rats can be hard to control or prevent, our professional services can help solve your rodent problem. Call, chat, or email us today.";

            Bug rodent1 = new Bug();
            rodent1.Name = "Rodent/Mous";
            rodent1.ImagePath = "/img/bugs/rodents/mouse.jpg";
            rodent1.innerText = "Probably the most well known pest that people think of when it comes to Pest Control. These creates typically come from dirty areas, or leaving things out. While 1-2 can be handled they can quickly grow out of hand. " +
                                "They can cause damange to just about anything by including couches, chairs, carpet, and anything else.";

            bugs.Add(rodent);
            #endregion

            #region cockroach
            Bug cockroach = new Bug();
            cockroach.Name = "Cockroaches";
            cockroach.Descripition = "";
            cockroach.ImagePath = "/img/bugs/cockroaches.jpg";
            cockroach.headerImage = "/img/bugs/cokroaches.jpg";
            cockroach.CommonlyFound.Add("Salt Lake City");
            cockroach.CommonlyFound.Add("Ogden");
            cockroach.CommonlyFound.Add("Layton");
            cockroach.CommonlyFound.Add("Bountiful");
            cockroach.CommonlyFound.Add("Salt Lake City");
            cockroach.CommonlyFound.Add("Provo");
            cockroach.CommonlyFound.Add("West Valley City");
            cockroach.meta = "Cockroaches are one of those things that typically come from an outside source, and are known for being gross. We specialize in cockraoch pest control, call, email, or chat with us today to learn more.";

            Bug cocroach1 = new Bug();
            cocroach1.Name = "Cockroach";
            cocroach1.ImagePath = "/img/bugs/cockroaches.jpg";
            cocroach1.innerText = "Aruguably one of the most known bugs for getting pest control, these gross creatures typically orginate from hotels, exteriror surrondings, dirty/waste areas. Typically " +
                                    " we recommend getting professoinal treatment ASAP. With commerical grade spray and products it may still take several treatements to get rid of these pests.";
            cockroach.subType.Add(cocroach1);

            bugs.Add(cockroach);
            #endregion

            #region Box Elder
            Bug boxElderBug = new Bug();
            boxElderBug.Name = "Box Elder Bugs";
            boxElderBug.Descripition = "";
            boxElderBug.ImagePath = "/img/bugs/boxElder/box-elder-bugs.jpg";
            boxElderBug.CommonlyFound.Add("Salt Lake City");
            boxElderBug.CommonlyFound.Add("Ogden");
            boxElderBug.CommonlyFound.Add("Layton");
            boxElderBug.CommonlyFound.Add("Bountiful");
            boxElderBug.CommonlyFound.Add("Salt Lake City");
            boxElderBug.CommonlyFound.Add("Provo");
            boxElderBug.CommonlyFound.Add("West Valley City");
            boxElderBug.meta = "Box Elder Bugs in Utah are very common, and typically are harmless. It is possible towrads winter or late summer as they move inside they can become a pest. Our services can help solve that problem, call, email, or chat with us today.";

            Bug boxElder = new Bug();
            boxElder.Name = "Box Elder Bug";
            boxElder.innerText = "These bugs are essentially harmless, but can quickly grow out of hand and require control. Typically these bugs" +
                                " are identified with the birght organe and black body. Typically will see them in the summer, and towards fall/colder weather" +
                                " they move inside and become more of a problem.";
            boxElder.ImagePath =  "/img/bugs/boxElder/box-elder-bugs.jpg";

            boxElderBug.subType.Add(boxElder);
            bugs.Add(boxElderBug);
            #endregion
        }
    }
}