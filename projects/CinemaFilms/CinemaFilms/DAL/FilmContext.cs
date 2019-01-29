using CinemaFilms.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CinemaFilms.DAL
{
    /* Set up the context file to create the database and communitcate with the database.  
       The connectionstring is defined in the root WebConfig file  
       Specified singular table names in OnModelCreating */
    public class FilmContext : DbContext
    {
        public FilmContext() : base("FilmContext")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showing> Showings { get; set; }
        public DbSet<Theater> Theaters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}