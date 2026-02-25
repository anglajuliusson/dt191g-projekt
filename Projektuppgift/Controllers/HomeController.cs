using Microsoft.AspNetCore.Mvc;

namespace Projektuppgift.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Associations()
        {
            return View();
        }
        public IActionResult Facilities()
        {
            return View();
        }
        public IActionResult Bookings()
        {
            return View();
        }
    }
}