using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaFilms.Models
{
    public class Theater
    {
        public int ID { get; set; }
        public string movieTheater { get; set; }
        public int capacity { get; set; }

        public ICollection<Showing> Showings { get; set; }
    }
}