using Microsoft.AspNetCore.Mvc;

namespace EternaWebbApp.Controllers
{
	public class PortfolioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
