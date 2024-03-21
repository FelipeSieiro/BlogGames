using Microsoft.AspNetCore.Mvc;

namespace CP1GAMES.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
