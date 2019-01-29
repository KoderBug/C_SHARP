using System;
using System.Collections.Generic;


namespace CinemaFilms.Models
{
    public class Movie
    {       
        public int ID { get; set; }
        public string movieName { get; set; }
        public string Rating { get; set; }
        public int runTime { get; set; }

        public virtual ICollection<Showing> Showings { get; set; }
    }
}