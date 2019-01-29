using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaFilms.ViewModels
{
    public class MovieDetailsVm
    {
        public string movieName { get; set; }
        public string Rating { get; set; }
        public string runTime { get; set; }
        public string movieTheater { get; set; }
        public int MovieID { get; set; } 
        public string movieTime { get; set; }
    }
}