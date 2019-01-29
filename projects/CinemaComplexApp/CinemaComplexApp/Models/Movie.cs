using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaComplexApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string movieName { get; set; }

        public int CinemaId { get; set; }
        
    }
}