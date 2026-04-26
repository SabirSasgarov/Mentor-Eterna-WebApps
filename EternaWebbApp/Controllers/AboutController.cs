using EternaWebbApp.Data;
using EternaWebbApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaWebbApp.Controllers
{
	public class AboutController : Controller
	{
		private readonly AppDbContext _context;

		public AboutController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			AboutVM aboutVM = new AboutVM
			{
				Users = _context.Users.Include(u=>u.Reviews).ToList()
			};
			return View(aboutVM);
		}
	}
}
