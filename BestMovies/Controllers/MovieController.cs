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
            var DB = new DB_Context();

            return View(DB.Movies.ToList());
        }

        public ActionResult Details(int? id)
        {

            var DB = new DB_Context();

            Movie movie = null;
            try
            {
                movie = DB.Movies.Include("Genre").First(c => c.Id == id);
            }
            catch (Exception e)
            {
                return Content("We dont have this customer");
            }

            return View(movie);
        }
    }
}