using System.Diagnostics;
using ApplicationCore.Models;
using Infrastructure.Services;
using KenyaFairwayGolf.Models;
using Microsoft.AspNetCore.Mvc;

namespace KenyaFairwayGolf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
            var golfClubCardService = new GolfClubService();

            var golfClubCards = golfClubCardService.GetTop30GolfClubs();

            return View(golfClubCards);
        }

        public IActionResult GolfClubDetails()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TopGolfClubs()
        {
            var golfClubs = new List<string>
            { 
                "Titleist Pro V1",
                "Callaway Chrome Soft",
                "TaylorMade TP5",
                "Bridgestone Tour B XS",
                "Srixon Z-Star",
                "Mizuno RB Tour",
                "Wilson Staff Duo Soft+",
                "Volvik Vivid",
                "Pinnacle Rush",
                "Nike Vapor Fly"
            };
            return View(golfClubs);
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
