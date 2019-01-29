using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CinemaFilms.DAL;
using CinemaFilms.Models;
using CinemaFilms.ViewModels;

namespace CinemaFilms.Controllers
{
    public class ShowtimesController : Controller
    {
        private FilmContext db = new FilmContext();

        // GET: List of Movies playing
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: Showtimes/Details/ Query Db and write movie times to ViewModel to pass to Details page
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            using (db)
            {
                var showtimes = (from m in db.Movies                                
                                 join s in db.Showings on m.ID equals s.MovieID
                                 join t in db.Theaters on s.TheaterID equals t.ID
                                 select new
                                 {                                    
                                     s.MovieID,
                                     m.movieName,
                                     s.movieTime,
                                     t.movieTheater
                                     
                                 })                                
                                 .ToList();

                var moviedetailsvms = new List<MovieDetailsVm>();
                foreach (var showtime in showtimes)
                {
                    if (id == showtime.MovieID)
                    { 
                        var moviedetailsvm = new MovieDetailsVm();
                        moviedetailsvm.movieName = showtime.movieName;
                        moviedetailsvm.movieTime = showtime.movieTime;
                        moviedetailsvm.movieTheater = showtime.movieTheater;
                        moviedetailsvms.Add(moviedetailsvm);
                    }
                }
                return View(moviedetailsvms);
            }
           
        }
       
    }
}
