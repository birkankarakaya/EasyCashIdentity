using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		[HttpGet]
		public IActionResult Index(int id)
		{
			var value = TempData["Mail"];
			ViewBag.v = value + " asd";
			return View();
		}

		[HttpPost]
		public IActionResult Index(ConfirmMailViewModel confirmMailViewModel)
		{
			return View();
		}
	}
}
