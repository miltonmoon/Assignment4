using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                restList.Add($"#{r.RestRank}: {r.RestName}, Fav Dish: {r.FavDish}, Address: {r.RestAddy}, Phone: {r.RestPhone}, Website: {r.WebLink}");
            }

            return View(restList);
        }

        [HttpGet]
        public IActionResult NewSuggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Suggestion appResponse)
        {
            TempStorage.AddSuggestion(appResponse);
            return View("Confirmation", appResponse);
        }

        public IActionResult DisplaySuggestions()
        {
            return View(TempStorage.Suggestions);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
