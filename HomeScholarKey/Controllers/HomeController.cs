using Microsoft.AspNetCore.Mvc;

namespace HomeScholarKey.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
