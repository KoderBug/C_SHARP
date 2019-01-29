using System;
using System.Collections.Generic;


namespace CinemaFilms.Models
{
    public class Showing
    {
        public int ID { get; set; }
        public int MovieID { get; set; }
        public int TheaterID { get; set; }
        public string movieTime { get; set; }
        public DateTime movieDate { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Theater Theater { get; set; }
    }
}