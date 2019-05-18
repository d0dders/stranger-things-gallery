using StrangerThingsGallery.Models;
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
            var episode = new Episode()
            {
                SeriesTitle = "Stranger Things",
                EpisodeNumber = 1,
                DescriptionHtml = "<p>On his way home from a friend's house, young Will sees something terrifying. Nearby, a sinister secret lurks in the depths of a government lab.</p>",
                Artists = new Artist[]
                {
                    new Artist() {Role = "Director", Name = "Matt Duffer, Ross Duffer"},
                    new Artist() {Role = "Writor", Name = "Matt Duffer, Ross Duffer"}
                }
            };


            return View(episode);
            
        }
    }
}