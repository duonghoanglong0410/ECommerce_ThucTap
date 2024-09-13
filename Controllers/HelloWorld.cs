using Microsoft.AspNetCore.Mvc;

namespace ECommerce_ThucTap.Controllers
{
	public class HelloWorld : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
