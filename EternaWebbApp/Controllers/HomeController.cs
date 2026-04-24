using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EternaWebbApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

	}
}
