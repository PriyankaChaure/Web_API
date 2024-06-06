using Microsoft.AspNetCore.Mvc;

namespace CurdDBClientEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
