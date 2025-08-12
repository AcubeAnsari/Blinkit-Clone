using Microsoft.AspNetCore.Mvc;
using Temp.Data;

namespace Temp.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
