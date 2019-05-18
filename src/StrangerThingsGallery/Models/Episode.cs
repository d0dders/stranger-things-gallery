using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrangerThingsGallery.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int EpisodeNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favourite { get; set; }

    }
}