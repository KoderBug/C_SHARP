using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CinemaFilms.Models;

namespace CinemaFilms.DAL
{
    // Initialize Db with test data, currently dropping Db each time application runs
    public class FilmInitializer : System.Data.Entity. DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            var movies = new List<Movie>
            {
                new Movie{movieName="The Grinch",Rating="G",runTime=86},
                new Movie{movieName="Spider-man", Rating="PG",runTime=117},
                new Movie{movieName="Mary Poppins Returns",Rating="PG",runTime=130},
                new Movie{movieName="Bumblebee",Rating="PG-13",runTime=114},
                new Movie{movieName="Mary Queen of Scots",Rating="R",runTime=124}

            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
            var theaters = new List<Theater>
            {
                new Theater{movieTheater="A",capacity=120},
                new Theater{movieTheater="B",capacity=75},
                new Theater{movieTheater="C",capacity=150},
                new Theater{movieTheater="D",capacity=200}
            };

            theaters.ForEach(s => context.Theaters.Add(s));
            context.SaveChanges();
            var showings = new List<Showing>
            {
                new Showing{MovieID=1,TheaterID=3,movieTime=("9:20am"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=1,TheaterID=3,movieTime=("11:40am"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=1,TheaterID=1,movieTime=("1:55pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=1,TheaterID=3,movieTime=("6:45pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=2,TheaterID=2,movieTime=("10:20am"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=2,TheaterID=2,movieTime=("12:25pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=2,TheaterID=1,movieTime=("4:15pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=2,TheaterID=4,movieTime=("8:50pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=2,TheaterID=3,movieTime=("10:50pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=3,TheaterID=4,movieTime=("9:35am"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=3,TheaterID=4,movieTime=("11:10am"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=3,TheaterID=3,movieTime=("2:15pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=3,TheaterID=2,movieTime=("5:25pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=3,TheaterID=4,movieTime=("7:00pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=3,TheaterID=1,movieTime=("8:30pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=4,TheaterID=3,movieTime=("1:20pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=4,TheaterID=2,movieTime=("4:20pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=4,TheaterID=2,movieTime=("8:40pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=5,TheaterID=1,movieTime=("7:30pm"),movieDate=DateTime.Parse("2019-01-08")},
                new Showing{MovieID=5,TheaterID=2,movieTime=("10:30pm"),movieDate=DateTime.Parse("2019-01-08")}
            };

            showings.ForEach(s => context.Showings.Add(s));
            context.SaveChanges();
        }
    }
}