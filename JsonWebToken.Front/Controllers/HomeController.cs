using Microsoft.AspNetCore.Mvc;

namespace JsonWebToken.Front.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
