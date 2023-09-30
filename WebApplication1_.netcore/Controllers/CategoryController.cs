using Microsoft.AspNetCore.Mvc;

namespace WebApplication1_.netcore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
