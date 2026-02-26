using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projektuppgift.Data;

namespace Projektuppgift.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Associations()
        {
            var associations = await _context.Associations.ToListAsync();
            return View(associations);
        }

        public async Task<IActionResult> Facilities()
        {
            var facilities = await _context.Facilities.ToListAsync();
            return View(facilities);
        }

        public async Task<IActionResult> Bookings()
        {
            var bookings = await _context.Bookings
                .Include(b => b.Facility)
                .Include(b => b.Association)
                .ToListAsync();

            return View(bookings);
        }
    }
}