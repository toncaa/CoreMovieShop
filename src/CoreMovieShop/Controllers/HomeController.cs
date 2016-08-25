using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMovieShop.Models;

namespace CoreMovieShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>();
            Movie m;
            m = new Movie();
            m.Title = "Batman:The Dark Knight";
            m.Poster = "/images/b2.jpg";

            for(int i=0;i<10;i++)
            {
                movies.Add(m);
            }

            return View(movies);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
