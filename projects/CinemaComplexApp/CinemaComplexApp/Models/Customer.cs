using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaComplexApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Seat { get; set; }

        public int MovieId { get; set; }
       
    }
}