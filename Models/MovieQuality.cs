using System;
using System.Collections.Generic;
using System.Text;
using MediaBrowser.Controller.Entities.Movies;
using EmbyStatistics.Enum;

namespace EmbyStatistics.Models
{
    public class MovieQuality
    {
        public List<Movie> Movies { get; set; }
        public VideoQuality Quality { get; set; }
    }
}
