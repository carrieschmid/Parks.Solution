using Microsoft.AspNetCore.Mvc;
using ParksApp.Models;

namespace ParksApp.Controllers
{
    public class ParkController : Controller
    {
        public IActionResult Index()
        {
            var allParks = Park.GetParks();
            return View(allParks);
        }
    }
}