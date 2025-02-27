﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thor.Models;
using Thor.ViewModels;

namespace Thor.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 1" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

        }


    }
}
















//Different Types of Returning Actions

//public ActionResult Random()
//{
//    var movie = new Movie()
//    {
//        Name = "Shrek!"
//    };
//    var customers = new List<Customer>
//            {
//                new Customer { Name = "Customer 1" },
//                new Customer { Name = "Customer 1" }
//            };

//    var viewModel = new RandomMovieViewModel
//    {
//        Movie = movie,
//        Customers = customers
//    };

//    //ViewData["Movie"] = movie;

//    //ViewBag.RandomMovie = movie;

//    //var viewResult = new ViewResult();


//    return View(viewModel);

//    //return View(movie);
//    //return new ViewResult();
//    //return Content("Hello Thor!");
//    //return HttpNotFound();
//    //return new EmptyResult();
//    //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
//    //return RedirectToAction("Action", "Controller", anonymous object for redirect to one or another page });
//    // url:  https://localhost:44395/?page=1&sortBy=name
//}


//public ActionResult Edit(int id)
//{
//    return Content("id=" + id);
//}

////movies
//public ActionResult Index(int? pageIndex, string sortBy)
//{
//    if (!pageIndex.HasValue)
//    {
//        pageIndex = 1;
//    }

//    if (String.IsNullOrWhiteSpace(sortBy))
//    {
//        sortBy = "Name";
//    }

//    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
//}

//[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
//public ActionResult ByReleaseDate(int year, int month)
//{
//    return Content(year + "/" + month);
//}