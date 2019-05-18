using StrangerThingsGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrangerThingsGallery.Data
{
    public class EpisodeRepository
    {
        private static Episode[] _episodes = new Episode[]
        {
            new Episode()
            {
                SeriesTitle = "Stranger Things",
                EpisodeNumber = 1,
                DescriptionHtml = "<p>On his way home from a friend's house, young Will sees something terrifying. Nearby, a sinister secret lurks in the depths of a government lab.</p>",
                Artists = new Artist[]
               {
                    new Artist() {Role = "Director", Name = "Matt Duffer, Ross Duffer"},
                    new Artist() {Role = "Writor", Name = "Matt Duffer, Ross Duffer"}
               }
            },
            new Episode()
            {
                SeriesTitle = "Stranger Things",
                EpisodeNumber = 2,
                DescriptionHtml = "<p>Lucas, Mike and Dustin try to talk to the girl they found in the woods. Hopper questions an anxious Joyce about an unsettling phone call.</p>",
                Artists = new Artist[]
               {
                    new Artist() {Role = "Director", Name = "Matt Duffer, Ross Duffer"},
                    new Artist() {Role = "Writor", Name = "Matt Duffer, Ross Duffer"}
               }
            },
            new Episode()
            {
                SeriesTitle = "Stranger Things",
                EpisodeNumber = 9,
                DescriptionHtml = "<p>Eleven makes plans to finish what she started while the survivors turn up the heat on the monstrous force that's holding Will hostage.</p>",
                Artists = new Artist[]
               {
                    new Artist() {Role = "Director", Name = "Matt Duffer, Ross Duffer"},
                    new Artist() {Role = "Writor", Name = "Matt Duffer, Ross Duffer"}
               }
            }
    };

        public Episode GetEpisode(int id)
        {
            Episode episodeToReturn = null;
            foreach (var episode in _episodes)
            {
                if (episode.Id == id)
                {
                    episodeToReturn = episode;
                    break;
                }
            }
            return episodeToReturn;
        }
    }
}