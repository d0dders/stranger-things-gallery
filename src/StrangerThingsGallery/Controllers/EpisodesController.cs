using StrangerThingsGallery.Data;
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
        private EpisodeRepository _episodeRepository = null;

        public EpisodesController()
        {
            _episodeRepository = new EpisodeRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var episode = _episodeRepository.GetEpisode(id.Value);


            return View(episode);
            
        }
    }
}