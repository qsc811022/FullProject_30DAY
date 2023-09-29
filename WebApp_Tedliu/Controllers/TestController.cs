using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tedliu.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			// return View();
			string todayeDates=DateTime.Now.ToShortDateString();
			return Ok(todayeDates);
		}
	}
}
