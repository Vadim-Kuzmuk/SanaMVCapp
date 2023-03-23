using Microsoft.AspNetCore.Mvc;
using MVCapp.Models;
using System.Diagnostics;

namespace MVCapp.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
		{
			return RedirectToAction("Greet");
		}

		public IActionResult Greet()
		{
			return View("GreetGet");
		}

		[HttpPost]
		public IActionResult Greet(GreetHomeViewModel greetHomeViewModel)
		{
			if (!ModelState.IsValid)
			{
				return View("GreetGet", greetHomeViewModel);
			}
			return View("GreetPost", greetHomeViewModel);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}