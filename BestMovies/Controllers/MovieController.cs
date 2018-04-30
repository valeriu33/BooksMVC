using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestMovies.Models;
using BestMovies.Persistance.Repositories;

namespace BestMovies.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
//            var customers = new List<Movie>()
//            {
//                new Movie()
//                {
//                    Id = 0,
//                    Name = "Game of Thrones",
//                    Author = "George R. Martin"
//                },
//
//                new Movie()
//                {
//                    Id = 1,
//                    Name = "Sherlok Holmes",
//                    Author = "Arthur Conan Doyle"
//                },
//
//                new Movie()
//                {
//                    Id = 2,
//                    Name = "C sharp",
//                    Author = "Anders Hejlsberg"
//                },
//            };

            var DB = new DB_Context();

            return View(DB.Movies.ToList());
        }

        public ActionResult Details(int? id)
        {
            //            var movies = new List<Movie>()
            //            {
            //                new Movie()
            //                {
            //                    Id = 0,
            //                    Name = "Game of Thrones",
            //                    Author = "George R. Martin"
            //                },
            //
            //                new Movie()
            //                {
            //                    Id = 1,
            //                    Name = "Sherlok Holmes",
            //                    Author = "Arthur Conan Doyle"
            //                },
            //
            //                new Movie()
            //                {
            //                    Id = 2,
            //                    Name = "C sharp",
            //                    Author = "Anders Hejlsberg"
            //                },
            //            };
            var DB = new DB_Context();

            Movie movie = null;
            try
            {
                movie = DB.Movies.First(c => c.Id == id);
            }
            catch (Exception e)
            {
                return Content("We dont have this customer");
            }

            return View(movie);
        }
    }
}