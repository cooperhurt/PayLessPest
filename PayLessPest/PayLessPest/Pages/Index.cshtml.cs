using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PayLessPest.Models;

namespace PayLessPest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Review> Reviews { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            generateReviews();
        }

        public void generateReviews()
        {
            Reviews = new List<Review>();

            Review one = new Review();
            one.Name = "Starla Fitzgerald";
            one.Image = "/img/testmonial/1.png";
            one.ReviewText = "This company is great, travis ( the owner)always took all my calls( and there were a few  more then a few 😂) and answer all my question with confidence! Scheduling  with him was always easy and he seemed pretty flexible . Pricing was very affordable which is always a plus!"
                + "Thanks travis for fixing my 'issue' in my house and being so great.I hope I don't ever have a need for pest control again but if I do you will be the one I call !!!";
            one.Source = "Google";

            Reviews.Add(one);

            Review two = new Review();
            two.Name = "Stonebridge Apartments";
            two.Source = "Google";
            two.Image = "/img/testmonial/2.png";
            two.ReviewText = "Great vendor, on call so whenever there is an issue they schedule with in 24-72 hours. Depending on the issue they will show up the day of!";
            Reviews.Add(two);

            Review three = new Review();
            three.Name = "Virginia M. Erickson";
            three.Image = "/img/testmonial/1.png";
            three.ReviewText = "Travis came out and treated for termites in the soil and also spiders in our house. He was very knowledgeable about his job, easy to talk to and very professional. I would recommend him to anyone";
            three.Source = "Facebook";
            Reviews.Add(three);
        }
    }
}
