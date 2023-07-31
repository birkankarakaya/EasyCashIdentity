using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		[HttpGet]
		public IActionResult Index(int id)
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(ConfirmMailViewModel confirmMailViewModel)
		{

		}
	}
}
