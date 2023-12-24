using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Sinaq.Areas.Admin.ViewModels.Destination;
using MVC_Sinaq.Contexts;
using MVC_Sinaq.Models;
using MVC_Sinaq.ViewModels.Destination;
using System.Diagnostics;

namespace MVC_Sinaq.Controllers
{
    public class HomeController : Controller
    {
       
       TravelingDBContext _db { get; }

        public HomeController(TravelingDBContext db)
        {
            _db = db;
        }

        public async Task< IActionResult >Index()
        {
            var data = await _db.Destinations.Select(s => new DestinationListItemUserVM
            {
                Image = s.Image,
                Title = s.Title,
                Price = s.Price,
                Rate = s.Rate,
            }).ToListAsync();
            return View(data);
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