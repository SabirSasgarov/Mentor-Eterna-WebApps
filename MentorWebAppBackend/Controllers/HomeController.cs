using System.Diagnostics;
using MentorWebAppBackend.Data.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace MentorWebAppBackend.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

		public IActionResult Index()
        {
            var features = _context.Features.ToList();
			return View(features);
        }

    }
}
