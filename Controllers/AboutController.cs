using Microsoft.AspNetCore.Mvc;

namespace CP1GAMES.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
