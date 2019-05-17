using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrangerThingsGallery.Controllers
{
    public class EpisodesController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "Stranger Things";
            ViewBag.EpisodeNumber = 1;
            ViewBag.Description = "<p>On his way home from a friend's house, young Will sees something terrifying. Nearby, a sinister secret lurks in the depths of a government lab.</p>";
            ViewBag.Artists = new string[]
                {
                    "Directors: Matt Duffer, Ross Duffer",
                    "Writers: Matt Duffer, Ross Duffer"
                };

            return View();
            
        }
    }
}