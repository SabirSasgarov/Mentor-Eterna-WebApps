using EternaWebbApp.Data;
using EternaWebbApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EternaWebbApp.Data;

namespace EternaWebbApp.Controllers
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
			HomeVM homeVM = new HomeVM
			{
				Sliders = _context.Sliders.ToList(),
				Features = _context.Features.ToList(),
				Services = _context.Services.ToList(),
				Clients = _context.Clients.ToList()
			};
			return View(homeVM);
		}

	}
}
