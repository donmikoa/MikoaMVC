using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MikoaMVC.Models;
using MikoaMVC.ViewModels;

namespace MikoaMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
           
        }

       
       [Route("movies/released/{year}/{month:regex(\\d{4})}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
           
            return Content(year + "/" + month);

        }


    }
}