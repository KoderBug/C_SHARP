using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CinemaComplexApp.Models
{
    public class CinemaContext : DbContext
    { 
        //Set up the context file to create the database and communitcate with the database.  
        // The connectionstring is defined in the root Web.config file.
        // The database will be created each time the application is run.

        public CinemaContext()     
                 :base("CinemaContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CinemaContext>());
        }

        //DbSet is defined for every type in the model which allows us to query and save instances of those types.
        public DbSet<CinemaComplex> CinemaComplex { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}