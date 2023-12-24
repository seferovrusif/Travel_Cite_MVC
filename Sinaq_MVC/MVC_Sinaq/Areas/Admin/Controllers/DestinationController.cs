using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Sinaq.Areas.Admin.ViewModels.Destination;
using MVC_Sinaq.Contexts;
using MVC_Sinaq.Models;

namespace MVC_Sinaq.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
            TravelingDBContext _db { get; }

        public DestinationController(TravelingDBContext db)
        {
            _db = db;
        }

        public async Task< IActionResult> Index()
        {
            var data = await _db.Destinations.Select(s => new DestinationListItemVM
            {
                Image = s.Image,
                Title = s.Title,
                Id = s.Id,
                Price = s.Price,
                Rate = s.Rate,
            }).ToListAsync();
            return View(data) ;
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DestinationCreateVM vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            Destination destination = new Destination 
            {
                Image = "fff",
                Title = vm.Title,
                Price = vm.Price,
                Rate = vm.Rate,
            };
            await _db.Destinations.AddAsync(destination);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }

}
