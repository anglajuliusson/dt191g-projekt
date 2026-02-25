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
    }
}