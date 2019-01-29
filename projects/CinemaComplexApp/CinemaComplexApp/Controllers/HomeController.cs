using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using CinemaComplexApp.Models;
using CinemaComplexApp.ViewModels;

namespace CinemaComplexApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                using (var db = new CinemaContext())
                {
                // Instantiate database objects, assign data and add to database using the Context file to communicate with 
                // the database.  Wrap the statements in a using block so we are sure that resources are freed up when 
                // we are done working with the Context

                    var cinemacomplex = new CinemaComplex();
                    var nowPlaying = new Movie();
                    var viewer1 = new Customer();
                    var viewer2 = new Customer();

                    cinemacomplex.CinemaName = "TinselTown";
                    cinemacomplex.Theater = "A";
                    db.CinemaComplex.Add(cinemacomplex);
                    db.SaveChanges();

                    nowPlaying.CinemaId = cinemacomplex.Id;
                    nowPlaying.movieName = "The Grinch";
                    db.Movie.Add(nowPlaying);
                    db.SaveChanges();

                    viewer1.MovieId = nowPlaying.Id;
                    viewer2.MovieId = nowPlaying.Id;
                    viewer1.LastName = "Jones";
                    viewer1.Seat = "H12";

                
                    viewer2.LastName = "Smith";
                    viewer2.Seat = "H13";
                    db.Customer.Add(viewer1);
                    db.Customer.Add(viewer2);
                    db.SaveChanges();
                }


                using (var db = new CinemaContext())
                {
                    var moviegoers = (from c in db.CinemaComplex
                                                    join m in db.Movie on c.Id equals m.CinemaId
                                                    join v in db.Customer on m.Id equals v.MovieId
                                                      select new
                                                      {
                                                          c.CinemaName,
                                                          c.Theater,
                                                          m.movieName,
                                                          v.LastName,
                                                          v.Seat
                                                      }).ToList();

                    var nowshowingvms = new List<NowShowingVm>();
                    foreach (var moviegoer in moviegoers)
                    {
                        var nowshowingvm = new NowShowingVm();
                        nowshowingvm.CinemaName = moviegoer.CinemaName;
                        nowshowingvm.Theater = moviegoer.Theater;
                        nowshowingvm.movieName = moviegoer.movieName;
                        nowshowingvm.LastName = moviegoer.LastName;
                        nowshowingvm.Seat = moviegoer.Seat;
                        nowshowingvms.Add(nowshowingvm);
                    }
                    return View(nowshowingvms);
                }
            }
        }     
    }
