using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext;
        public HomeController(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }
        public IActionResult Index()
        {
                CategoryMenu model= new CategoryMenu();
                model.Categories = _movieContext.Categories.ToList();
                model.Movies=_movieContext.Movies.ToList();
            return View(model);
        }
        
        public IActionResult Details(int id)
        {
            CategoryMenu model = new CategoryMenu();
            model.Categories = new List<Category>();
            model.Movie = _movieContext.Movies.Where(p => p.MovieId == id).FirstOrDefault();

            return View(model);
        }

    }
}
